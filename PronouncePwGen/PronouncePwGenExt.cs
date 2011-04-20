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
using System.Collections;
using System.IO;

namespace PronouncePwGen
{
    public class ProunouncePwGenProfile
    {
        private static string version = "2";
        private static string separator = "|";

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

        private bool morepronounceable = false;
        public bool MorePronounceable
        {
            get { return morepronounceable; }
            set { morepronounceable = value; }
        }

        private string symbols = "!@#$%^&*()_+[]{}~`;:,./?<>'\"\\|"; // all typeable characters on a standard 101-key keyboard
        public string UseSymbols
        {
            get { return symbols; }
            set { symbols = value; }
        }

        private CharacterSubstitutionMode submode = CharacterSubstitutionMode.NoSubstitution;
        public CharacterSubstitutionMode SubstitutionMode
        {
            get { return submode; }
            set { submode = value; }
        }

        private string subscheme = "";
        public string SubstitutionScheme
        {
            get { return subscheme; }
            set { subscheme = value; }
        }

        public ProunouncePwGenProfile() { }

        public ProunouncePwGenProfile(string optionstr)
        {
            if (optionstr.Length > 2)
            {
                try
                {
                    string modestr = "";
                    string digitstr = "";
                    string lenstr = "";

                    string morestr = "";
                    string symbolstr = "";
                    string substr = "";

                    if (optionstr.IndexOf(separator) == -1 && optionstr.Length >= 3) // v1 option format
                    {
                        modestr = optionstr.Substring(0, 1);
                        digitstr = optionstr.Substring(1, 1);
                        lenstr = optionstr.Substring(2);
                    }
                    else // new format
                    {
                        int optioncount;
                        if (optionstr.Split(separator.ToCharArray(), 2)[0] == "2") // v2 option format, 
                        {
                            optioncount = optionstr.Split(separator.ToCharArray()).Length;
                            if (optioncount >= 8) optioncount = 8; // number of options for v2 format
                            else throw new ApplicationException();
                        }
                        else throw new ApplicationException();

                        string[] opts = optionstr.Split(separator.ToCharArray(), optioncount);

                        if (optioncount >= 8) // at least 8 (not including version number) available options for v2 format and above
                        {
                            modestr = opts[1];
                            digitstr = opts[2];
                            lenstr = opts[3];
                            morestr = opts[4];
                            substr = opts[5];
                            subscheme = opts[6];
                        }

                        if (opts[optioncount - 1].Length > 0) symbolstr = opts[optioncount - 1];
                    }

                    if (lenstr.Length > 0) minlength = int.Parse(lenstr);

                    switch (modestr)
                    {
                        case "": // leave as default
                            break;
                        case "0":
                            mode = CaseMode.LowerCase;
                            break;
                        case "1":
                            mode = CaseMode.UpperCase;
                            break;
                        case "2":
                            mode = CaseMode.MixedCase;
                            break;
                        case "3":
                            mode = CaseMode.RandomCase;
                            break;
                        case "4":
                            mode = CaseMode.RandomMixedCase;
                            break;
                        default:
                            throw new ApplicationException();
                    }

                    switch (digitstr)
                    {
                        case "": // leave as default
                            break;
                        case "0":
                            digits = false;
                            break;
                        case "1":
                            digits = true;
                            break;
                        default:
                            throw new ApplicationException();
                    }

                    switch (morestr)
                    {
                        case "": // leave as default
                            break;
                        case "0":
                            morepronounceable = false;
                            break;
                        case "1":
                            morepronounceable = true;
                            break;
                        default:
                            throw new ApplicationException();
                    }

                    switch (substr)
                    {
                        case "": // leave as default
                            break;
                        case "0":
                            submode = CharacterSubstitutionMode.NoSubstitution;
                            break;
                        case "1":
                            submode = CharacterSubstitutionMode.RandomSubstitution;
                            break;
                        case "2":
                            submode = CharacterSubstitutionMode.SubstituteAll;
                            break;
                        default:
                            throw new ApplicationException();
                    }

                    symbols = symbolstr;
                }
                catch (ApplicationException) { }
                catch (ArgumentOutOfRangeException) { }
                catch (ArgumentNullException) { }
                catch (FormatException) { }
                catch (OverflowException) { }
            }
        }

        public override string ToString()
        { // v2 format now implemented in ToString()
            return version + separator
                 + ((int)CaseMode).ToString() + separator
                 + (UseDigits ? "1" : "0") + separator
                 + MinimumLength.ToString() + separator
                 + (MorePronounceable ? "1" : "0") + separator
                 + ((int)SubstitutionMode).ToString() + separator
                 + SubstitutionScheme + separator
                 + UseSymbols;
        }
    }

    public class PronounceablePwGenerator : CustomPwGenerator
    {
        private string m_strUuid = PronouncePwGenRes.UUID;
        private string m_strName = PronouncePwGenRes.PluginName;

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

            //return ((int)profile.CaseMode).ToString() + (profile.UseDigits ? "1" : "0") + profile.MinimumLength.ToString(); // v1 format
            return profile.ToString(); // v2 format
        }

        public override KeePassLib.Security.ProtectedString Generate(PwProfile prf, KeePassLib.Cryptography.CryptoRandomStream crsRandomSource)
        {
            ProunouncePwGenProfile profile = new ProunouncePwGenProfile(prf.CustomAlgorithmOptions);
            string gen = "";
            try
            {
                gen = PronounceablePassword.Generate(crsRandomSource, profile.MinimumLength, profile.UseDigits, profile.UseSymbols, profile.CaseMode, profile.MorePronounceable);

                // substitutions - implemented outside of the core generation engine
                if (profile.SubstitutionMode != CharacterSubstitutionMode.NoSubstitution && profile.SubstitutionScheme.Length > 0)
                {
                    string profilepath = Directory.GetCurrentDirectory() + "\\ppgsub\\" + profile.SubstitutionScheme + ".ppgsub";
                    if (File.Exists(profilepath))
                    {
                        PronouncePwGenSubstitutionProfile subprofile = new PronouncePwGenSubstitutionProfile(profilepath);
                        gen = subprofile.Substitute(gen, profile.SubstitutionMode == CharacterSubstitutionMode.RandomSubstitution ? crsRandomSource : null);
                    }
                }
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
