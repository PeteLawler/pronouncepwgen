using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
