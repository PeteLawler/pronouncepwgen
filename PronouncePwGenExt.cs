/*
    KeePass Pronounceable Password Generator Plugin
    Copyright (C) 2009 Jan Benjamin Engracia <jaybz.e@gmail.com>
    Based on FIPS-181 <http://www.itl.nist.gov/fipspubs/fip181.htm>

    This file is part of KeePass Pronounceable Password Generator Plugin. 
 
    KeePass Pronounceable Password Generator Plugin is free software:
    you can redistribute it and/or modify it under the terms of the GNU
    General Public License as published by the Free Software Foundation,
    either version 3 of the License, or (at your option) any later
    version.

    KeePass Pronounceable Password Generator Plugin is distributed in
    the hope that it will be useful, but WITHOUT ANY WARRANTY; without
    even the implied warranty of MERCHANTABILITY or FITNESS FOR A
    PARTICULAR PURPOSE.  See the GNU Leser General Public License for
    more details.

    You should have received a copy of the GNU General Public License
    along with KeePass Pronounceable Password Generator Plugin.  If not,
    see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Diagnostics;

using KeePass.Plugins;

using KeePassLib;
using KeePassLib.Cryptography.PasswordGenerator;

namespace PronouncePwGen
{
    public class ProunouncePwGenProfile
    {
        private bool digits = true;
        public bool UseDigits
        {
            get { return digits; }
            set { digits = value; }
        }

        private int minlength = 16;
        public int MinimumLength
        {
            get { return minlength; }
            set { minlength = value; }
        }

        private CaseMode mode = CaseMode.MixedCase;
        public CaseMode CaseMode
        {
            get { return mode; }
            set { mode = value; }
        }

        public ProunouncePwGenProfile() { }

        public ProunouncePwGenProfile(string optionstr)
        {
            if (optionstr.Length > 2)
            {
                bool newdigits;
                int newlen;
                CaseMode newmode;

                try
                {
                    string modestr = optionstr.Substring(0, 1);
                    string digitstr = optionstr.Substring(1, 1);
                    string lenstr = optionstr.Substring(2);

                    newlen = int.Parse(lenstr);
                    switch (modestr)
                    {
                        case "0":
                            newmode = CaseMode.LowerCase;
                            break;
                        case "1":
                            newmode = CaseMode.UpperCase;
                            break;
                        case "2":
                            newmode = CaseMode.MixedCase;
                            break;
                        case "3":
                            newmode = CaseMode.RandomCase;
                            break;
                        default:
                            throw new ApplicationException();
                    }

                    switch (digitstr)
                    {
                        case "0":
                            newdigits = false;
                            break;
                        case "1":
                            newdigits = true;
                            break;
                        default:
                            throw new ApplicationException();
                    }

                    digits = newdigits;
                    mode = newmode;
                    minlength = newlen;
                }
                catch (ApplicationException) { }
                catch (ArgumentOutOfRangeException) { }
                catch (ArgumentNullException) { }
                catch (FormatException) { }
                catch (OverflowException) { }
            }
        }
    }

    public class PronounceablePwGenerator : CustomPwGenerator
    {
        private string m_strUuid = "075898AA-36E4-4BAE-BF74-3EF30C0AD446";
        private string m_strName = "Pronounceable Password Generator (FIPS181 based)";

        public override PwUuid Uuid
        {
            get { return new PwUuid(new Guid(m_strUuid).ToByteArray()); }
        }

        public override string Name
        {
            get { return m_strName; }
        }

        public override bool SupportsOptions
        {
            get { return true; }
        }

        public override string GetOptions(string strCurrentOptions)
        {
            ProunouncePwGenProfile profile = new ProunouncePwGenProfile(strCurrentOptions);

            PronounceablePwOptsForm optsform = new PronounceablePwOptsForm();
            profile = optsform.GetOptions(profile);
            optsform.Dispose();

            return ((int)profile.CaseMode).ToString() + (profile.UseDigits ? "1" : "0") + profile.MinimumLength.ToString();
        }

        public override KeePassLib.Security.ProtectedString Generate(PwProfile prf, KeePassLib.Cryptography.CryptoRandomStream crsRandomSource)
        {
            ProunouncePwGenProfile profile = new ProunouncePwGenProfile(prf.CustomAlgorithmOptions);
            string gen = "";
            try
            {
                gen = PronounceablePassword.Generate(crsRandomSource, profile.MinimumLength, profile.UseDigits, profile.CaseMode);
            }
            catch (DivideByZeroException) { }
            return new KeePassLib.Security.ProtectedString(false, gen);
        }
    }

    public class PronouncePwGenExt : Plugin
    {
        private IPluginHost m_host = null;
        private PronounceablePwGenerator m_ppgGenerator = null;

        public override bool Initialize(IPluginHost host)
        {
            Debug.Assert(host != null);
            if (host == null) return false;
            m_host = host;

            m_ppgGenerator = new PronounceablePwGenerator();
            m_host.PwGeneratorPool.Add(m_ppgGenerator);

            return true;
        }

        public override void Terminate()
        {
            m_host.PwGeneratorPool.Remove(m_ppgGenerator.Uuid);
            m_ppgGenerator = null;
        }

        public override System.Drawing.Image SmallIcon
        {
            get
            {
                return Properties.Resource.B16x16_KGPG_Gen;
            }
        }
    }
}
