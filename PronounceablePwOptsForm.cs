/*
    KeePass Pronounceable Password Generator Plugin
    Copyright (C) 2009 Jan Benjamin Engracia <jaybz.e@gmail.com>
    Based on FIPS-181 <http://www.itl.nist.gov/fipspubs/fip181.htm>

    This file is part of KeePass Pronounceable Password Generator Plugin. 
 
    KeePass Pronounceable Password Generator Plugin is free software:
    you can redistribute it and/or modify it under the terms of the GNU
    Lesser General Public License as published by the Free Software
    Foundation, either version 3 of the License, or (at your option) any
    later version.

    KeePass Pronounceable Password Generator Plugin is distributed in
    the hope that it will be useful, but WITHOUT ANY WARRANTY; without
    even the implied warranty of MERCHANTABILITY or FITNESS FOR A
    PARTICULAR PURPOSE.  See the GNU Leser General Public License for
    more details.

    You should have received a copy of the GNU Lesser General Public
    License along with KeePass Pronounceable Password Generator Plugin.
    If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Windows.Forms;

namespace PronouncePwGen
{
    public partial class PronounceablePwOptsForm : Form
    {
        public PronounceablePwOptsForm()
        {
            InitializeComponent();
        }

        public ProunouncePwGenProfile GetOptions(ProunouncePwGenProfile defaults)
        {
            nudLength.Value = 0;
            cbDigits.Checked = false;
            cmbMode.SelectedIndex = 0;
            nudLength.Value = defaults.MinimumLength;
            cbDigits.Checked = defaults.UseDigits;
            cmbMode.SelectedIndex = (int)defaults.CaseMode;
            if (this.ShowDialog() != DialogResult.OK) return defaults;

            ProunouncePwGenProfile profile = new ProunouncePwGenProfile();
            profile.CaseMode = (CaseMode)cmbMode.SelectedIndex;
            profile.UseDigits = cbDigits.Checked;
            profile.MinimumLength = (int)nudLength.Value;
            return profile;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
