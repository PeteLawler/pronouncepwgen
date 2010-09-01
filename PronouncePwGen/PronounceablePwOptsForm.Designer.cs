namespace PronouncePwGen
{
    partial class PronounceablePwOptsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PronounceablePwOptsForm));
            this.cmbMode = new System.Windows.Forms.ComboBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pbBannerImage = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudLength = new System.Windows.Forms.NumericUpDown();
            this.cbDigits = new System.Windows.Forms.CheckBox();
            this.tcOptions = new System.Windows.Forms.TabControl();
            this.tpPwPronounceability = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cbMoreProunounceable = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tpPwCase = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tpSubstitutions = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSubsScheme = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.cmbSubsMode = new System.Windows.Forms.ComboBox();
            this.tpPwOptions = new System.Windows.Forms.TabPage();
            this.tbSymbols = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBannerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).BeginInit();
            this.tcOptions.SuspendLayout();
            this.tpPwPronounceability.SuspendLayout();
            this.tpPwCase.SuspendLayout();
            this.tpSubstitutions.SuspendLayout();
            this.tpPwOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbMode
            // 
            this.cmbMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMode.FormattingEnabled = true;
            this.cmbMode.Items.AddRange(new object[] {
            "All lower case",
            "All upper case",
            "Capitalize first letter of each syllable",
            "Randomize case",
            "Capitalize first letter of random syllables"});
            this.cmbMode.Location = new System.Drawing.Point(6, 6);
            this.cmbMode.Name = "cmbMode";
            this.cmbMode.Size = new System.Drawing.Size(308, 21);
            this.cmbMode.TabIndex = 3;
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.Location = new System.Drawing.Point(184, 296);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(265, 296);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // pbBannerImage
            // 
            this.pbBannerImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbBannerImage.Location = new System.Drawing.Point(0, 0);
            this.pbBannerImage.Name = "pbBannerImage";
            this.pbBannerImage.Size = new System.Drawing.Size(352, 60);
            this.pbBannerImage.TabIndex = 11;
            this.pbBannerImage.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Use Digits:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minimum Length:";
            // 
            // nudLength
            // 
            this.nudLength.Location = new System.Drawing.Point(106, 49);
            this.nudLength.Name = "nudLength";
            this.nudLength.Size = new System.Drawing.Size(56, 20);
            this.nudLength.TabIndex = 1;
            this.nudLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbDigits
            // 
            this.cbDigits.AutoSize = true;
            this.cbDigits.Location = new System.Drawing.Point(106, 6);
            this.cbDigits.Name = "cbDigits";
            this.cbDigits.Size = new System.Drawing.Size(15, 14);
            this.cbDigits.TabIndex = 2;
            this.cbDigits.UseVisualStyleBackColor = true;
            // 
            // tcOptions
            // 
            this.tcOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tcOptions.Controls.Add(this.tpPwPronounceability);
            this.tcOptions.Controls.Add(this.tpPwCase);
            this.tcOptions.Controls.Add(this.tpSubstitutions);
            this.tcOptions.Controls.Add(this.tpPwOptions);
            this.tcOptions.Location = new System.Drawing.Point(12, 66);
            this.tcOptions.Name = "tcOptions";
            this.tcOptions.SelectedIndex = 0;
            this.tcOptions.Size = new System.Drawing.Size(328, 224);
            this.tcOptions.TabIndex = 14;
            // 
            // tpPwPronounceability
            // 
            this.tpPwPronounceability.Controls.Add(this.textBox3);
            this.tpPwPronounceability.Controls.Add(this.cbMoreProunounceable);
            this.tpPwPronounceability.Controls.Add(this.label4);
            this.tpPwPronounceability.Location = new System.Drawing.Point(4, 22);
            this.tpPwPronounceability.Name = "tpPwPronounceability";
            this.tpPwPronounceability.Padding = new System.Windows.Forms.Padding(3);
            this.tpPwPronounceability.Size = new System.Drawing.Size(320, 198);
            this.tpPwPronounceability.TabIndex = 2;
            this.tpPwPronounceability.Text = "Pronounceability";
            this.tpPwPronounceability.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(6, 29);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(308, 163);
            this.textBox3.TabIndex = 17;
            this.textBox3.Text = "Use this option to generate more pronounceable passwords. Take note that enabling" +
                " this option reduces the security of generated passwords.";
            // 
            // cbMoreProunounceable
            // 
            this.cbMoreProunounceable.AutoSize = true;
            this.cbMoreProunounceable.Location = new System.Drawing.Point(6, 9);
            this.cbMoreProunounceable.Name = "cbMoreProunounceable";
            this.cbMoreProunounceable.Size = new System.Drawing.Size(15, 14);
            this.cbMoreProunounceable.TabIndex = 4;
            this.cbMoreProunounceable.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Generate more pronouceable passwords";
            // 
            // tpPwCase
            // 
            this.tpPwCase.Controls.Add(this.textBox1);
            this.tpPwCase.Controls.Add(this.cmbMode);
            this.tpPwCase.Location = new System.Drawing.Point(4, 22);
            this.tpPwCase.Name = "tpPwCase";
            this.tpPwCase.Padding = new System.Windows.Forms.Padding(3);
            this.tpPwCase.Size = new System.Drawing.Size(320, 198);
            this.tpPwCase.TabIndex = 0;
            this.tpPwCase.Text = "Password Case";
            this.tpPwCase.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(6, 33);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(308, 159);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // tpSubstitutions
            // 
            this.tpSubstitutions.Controls.Add(this.label7);
            this.tpSubstitutions.Controls.Add(this.cmbSubsScheme);
            this.tpSubstitutions.Controls.Add(this.label5);
            this.tpSubstitutions.Controls.Add(this.textBox4);
            this.tpSubstitutions.Controls.Add(this.cmbSubsMode);
            this.tpSubstitutions.Location = new System.Drawing.Point(4, 22);
            this.tpSubstitutions.Name = "tpSubstitutions";
            this.tpSubstitutions.Padding = new System.Windows.Forms.Padding(3);
            this.tpSubstitutions.Size = new System.Drawing.Size(320, 198);
            this.tpSubstitutions.TabIndex = 3;
            this.tpSubstitutions.Text = "Substitutions";
            this.tpSubstitutions.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Substitution Scheme:";
            // 
            // cmbSubsScheme
            // 
            this.cmbSubsScheme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSubsScheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubsScheme.FormattingEnabled = true;
            this.cmbSubsScheme.Items.AddRange(new object[] {
            "No Substitution",
            "Random substitution of substitutable characters",
            "Substitute all substitutable characters"});
            this.cmbSubsScheme.Location = new System.Drawing.Point(119, 33);
            this.cmbSubsScheme.Name = "cmbSubsScheme";
            this.cmbSubsScheme.Size = new System.Drawing.Size(195, 21);
            this.cmbSubsScheme.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Substitution Type:";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(6, 60);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(308, 132);
            this.textBox4.TabIndex = 16;
            this.textBox4.Text = resources.GetString("textBox4.Text");
            // 
            // cmbSubsMode
            // 
            this.cmbSubsMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSubsMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubsMode.FormattingEnabled = true;
            this.cmbSubsMode.Items.AddRange(new object[] {
            "No Substitution",
            "Random substitution of substitutable characters",
            "Substitute all substitutable characters"});
            this.cmbSubsMode.Location = new System.Drawing.Point(119, 6);
            this.cmbSubsMode.Name = "cmbSubsMode";
            this.cmbSubsMode.Size = new System.Drawing.Size(195, 21);
            this.cmbSubsMode.TabIndex = 4;
            // 
            // tpPwOptions
            // 
            this.tpPwOptions.Controls.Add(this.tbSymbols);
            this.tpPwOptions.Controls.Add(this.label3);
            this.tpPwOptions.Controls.Add(this.textBox2);
            this.tpPwOptions.Controls.Add(this.cbDigits);
            this.tpPwOptions.Controls.Add(this.label2);
            this.tpPwOptions.Controls.Add(this.label1);
            this.tpPwOptions.Controls.Add(this.nudLength);
            this.tpPwOptions.Location = new System.Drawing.Point(4, 22);
            this.tpPwOptions.Name = "tpPwOptions";
            this.tpPwOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tpPwOptions.Size = new System.Drawing.Size(320, 198);
            this.tpPwOptions.TabIndex = 1;
            this.tpPwOptions.Text = "Other Options";
            this.tpPwOptions.UseVisualStyleBackColor = true;
            // 
            // tbSymbols
            // 
            this.tbSymbols.Location = new System.Drawing.Point(106, 25);
            this.tbSymbols.Name = "tbSymbols";
            this.tbSymbols.Size = new System.Drawing.Size(122, 20);
            this.tbSymbols.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Use Symbols:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(6, 75);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(308, 117);
            this.textBox2.TabIndex = 16;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "No Substitution",
            "Random substitution of substitutable characters",
            "Substitute all substitutable characters"});
            this.comboBox1.Location = new System.Drawing.Point(119, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Substitution Type:";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(6, 91);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(350, 127);
            this.textBox5.TabIndex = 16;
            this.textBox5.Text = resources.GetString("textBox5.Text");
            // 
            // PronounceablePwOptsForm
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(352, 331);
            this.ControlBox = false;
            this.Controls.Add(this.tcOptions);
            this.Controls.Add(this.pbBannerImage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PronounceablePwOptsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.PronounceablePwOptsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBannerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).EndInit();
            this.tcOptions.ResumeLayout(false);
            this.tpPwPronounceability.ResumeLayout(false);
            this.tpPwPronounceability.PerformLayout();
            this.tpPwCase.ResumeLayout(false);
            this.tpPwCase.PerformLayout();
            this.tpSubstitutions.ResumeLayout(false);
            this.tpSubstitutions.PerformLayout();
            this.tpPwOptions.ResumeLayout(false);
            this.tpPwOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMode;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pbBannerImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudLength;
        private System.Windows.Forms.CheckBox cbDigits;
        private System.Windows.Forms.TabControl tcOptions;
        private System.Windows.Forms.TabPage tpPwCase;
        private System.Windows.Forms.TabPage tpPwOptions;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tpPwPronounceability;
        private System.Windows.Forms.CheckBox cbMoreProunounceable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox tbSymbols;
        private System.Windows.Forms.TabPage tpSubstitutions;
        private System.Windows.Forms.ComboBox cmbSubsMode;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSubsScheme;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
    }
}