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
using System.IO;
using System.Windows.Forms;

using KeePass.Resources;
using KeePass.UI;
using System.Reflection;

namespace PronouncePwGen
{
    public partial class PronounceablePwOptsForm : Form
    {
        public PronounceablePwOptsForm()
        {
            this.Text = PronouncePwGenRes.FormTitle;
            InitializeComponent();
        }

        private void PronounceablePwOptsForm_Load(object sender, EventArgs e)
        {
            GlobalWindowManager.AddWindow(this);
            pbBannerImage.Image = BannerFactory.CreateBanner(pbBannerImage.Width, pbBannerImage.Height, BannerStyle.Default, Properties.Resource.B48x48_KGPG_Info, PronouncePwGenRes.HeaderText, PronouncePwGenRes.HeaderText2);
        }

        public ProunouncePwGenProfile GetOptions(ProunouncePwGenProfile defaults)
        {
            cbMoreProunounceable.Checked = defaults.MorePronounceable;
            cmbMode.SelectedIndex = (int)defaults.CaseMode;
            cbDigits.Checked = defaults.UseDigits;
            tbSymbols.Text = defaults.UseSymbols;
            nudLength.Value = defaults.MinimumLength;
            cmbSubsMode.SelectedIndex = (int)defaults.SubstitutionMode;
            cmbSubsScheme.Items.Clear();
            cmbSubsScheme.Items.Add("No substitution");
            cmbSubsScheme.SelectedIndex = 0;
            DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\ppgsub");
            FileInfo[] fis = di.GetFiles("*.ppgsub", SearchOption.AllDirectories);
            foreach (FileInfo fi in fis)
            {
                string subfile = Path.GetFileNameWithoutExtension(fi.FullName);
                int i = cmbSubsScheme.Items.Add(subfile);
                if (subfile == defaults.SubstitutionScheme) cmbSubsScheme.SelectedIndex = i;
            }
            if (this.ShowDialog() != DialogResult.OK) return defaults;

            ProunouncePwGenProfile profile = new ProunouncePwGenProfile();
            profile.MorePronounceable = cbMoreProunounceable.Checked;
            profile.CaseMode = (CaseMode)cmbMode.SelectedIndex;
            profile.SubstitutionMode = (CharacterSubstitutionMode)cmbSubsMode.SelectedIndex;
            profile.UseDigits = cbDigits.Checked;
            profile.UseSymbols = tbSymbols.Text;
            profile.MinimumLength = (int)nudLength.Value;
            profile.SubstitutionScheme = cmbSubsScheme.SelectedIndex > 0 ? (string)cmbSubsScheme.SelectedItem.ToString() : "";
            if (profile.SubstitutionScheme.Length == 0) profile.SubstitutionMode = CharacterSubstitutionMode.NoSubstitution;

            return profile;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void PronounceablePwOptsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalWindowManager.RemoveWindow(this);
        }
    }
}
