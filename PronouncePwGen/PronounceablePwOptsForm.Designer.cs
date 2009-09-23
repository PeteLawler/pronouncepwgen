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
            this.tpPwCase = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tpPwOptions = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBannerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).BeginInit();
            this.tcOptions.SuspendLayout();
            this.tpPwCase.SuspendLayout();
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
            "Randomize case"});
            this.cmbMode.Location = new System.Drawing.Point(6, 6);
            this.cmbMode.Name = "cmbMode";
            this.cmbMode.Size = new System.Drawing.Size(211, 21);
            this.cmbMode.TabIndex = 3;
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.Location = new System.Drawing.Point(87, 286);
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
            this.btnCancel.Location = new System.Drawing.Point(168, 286);
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
            this.pbBannerImage.Size = new System.Drawing.Size(255, 60);
            this.pbBannerImage.TabIndex = 11;
            this.pbBannerImage.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Use Digits:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minimum Length:";
            // 
            // nudLength
            // 
            this.nudLength.Location = new System.Drawing.Point(99, 26);
            this.nudLength.Name = "nudLength";
            this.nudLength.Size = new System.Drawing.Size(56, 20);
            this.nudLength.TabIndex = 1;
            this.nudLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbDigits
            // 
            this.cbDigits.AutoSize = true;
            this.cbDigits.Location = new System.Drawing.Point(99, 6);
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
            this.tcOptions.Controls.Add(this.tpPwCase);
            this.tcOptions.Controls.Add(this.tpPwOptions);
            this.tcOptions.Location = new System.Drawing.Point(12, 66);
            this.tcOptions.Name = "tcOptions";
            this.tcOptions.SelectedIndex = 0;
            this.tcOptions.Size = new System.Drawing.Size(231, 214);
            this.tcOptions.TabIndex = 14;
            // 
            // tpPwCase
            // 
            this.tpPwCase.Controls.Add(this.textBox1);
            this.tpPwCase.Controls.Add(this.cmbMode);
            this.tpPwCase.Location = new System.Drawing.Point(4, 22);
            this.tpPwCase.Name = "tpPwCase";
            this.tpPwCase.Padding = new System.Windows.Forms.Padding(3);
            this.tpPwCase.Size = new System.Drawing.Size(223, 188);
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
            this.textBox1.Size = new System.Drawing.Size(211, 149);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // tpPwOptions
            // 
            this.tpPwOptions.Controls.Add(this.textBox2);
            this.tpPwOptions.Controls.Add(this.cbDigits);
            this.tpPwOptions.Controls.Add(this.label2);
            this.tpPwOptions.Controls.Add(this.label1);
            this.tpPwOptions.Controls.Add(this.nudLength);
            this.tpPwOptions.Location = new System.Drawing.Point(4, 22);
            this.tpPwOptions.Name = "tpPwOptions";
            this.tpPwOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tpPwOptions.Size = new System.Drawing.Size(223, 188);
            this.tpPwOptions.TabIndex = 1;
            this.tpPwOptions.Text = "Other Options";
            this.tpPwOptions.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(6, 52);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(211, 130);
            this.textBox2.TabIndex = 16;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // PronounceablePwOptsForm
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(255, 321);
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
            this.Text = "Pronounceable Password Options";
            this.Load += new System.EventHandler(this.PronounceablePwOptsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBannerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).EndInit();
            this.tcOptions.ResumeLayout(false);
            this.tpPwCase.ResumeLayout(false);
            this.tpPwCase.PerformLayout();
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
    }
}