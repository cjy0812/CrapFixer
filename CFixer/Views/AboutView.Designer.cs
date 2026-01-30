namespace Views
{
    partial class AboutView
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblVersionInfo = new System.Windows.Forms.Label();
            this.linkGitHub = new System.Windows.Forms.LinkLabel();
            this.btnDonate = new System.Windows.Forms.Button();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.comboBoxCurrency = new System.Windows.Forms.ComboBox();
            this.comboBoxAmount = new System.Windows.Forms.ComboBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(61, 19);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(71, 21);
            this.lblHeader.TabIndex = 235;
            this.lblHeader.Text = Properties.Resources.ResourceManager.GetString("AboutView.lblHeader.Text");
            this.lblHeader.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoEllipsis = true;
            this.label1.Location = new System.Drawing.Point(15, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 26);
            this.label1.TabIndex = 236;
            this.label1.Text = Properties.Resources.ResourceManager.GetString("AboutView.label1.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CFixer.Properties.Resources.AppIcon32;
            this.pictureBox1.Location = new System.Drawing.Point(18, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 34);
            this.pictureBox1.TabIndex = 237;
            this.pictureBox1.TabStop = false;
            // 
            // lblVersionInfo
            // 
            this.lblVersionInfo.AutoSize = true;
            this.lblVersionInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblVersionInfo.ForeColor = System.Drawing.Color.Black;
            this.lblVersionInfo.Location = new System.Drawing.Point(61, 40);
            this.lblVersionInfo.Name = "lblVersionInfo";
            this.lblVersionInfo.Size = new System.Drawing.Size(13, 13);
            this.lblVersionInfo.TabIndex = 238;
            this.lblVersionInfo.Text = Properties.Resources.ResourceManager.GetString("AboutView.lblVersionInfo.Text");
            // 
            // linkGitHub
            // 
            this.linkGitHub.AutoSize = true;
            this.linkGitHub.Location = new System.Drawing.Point(34, 162);
            this.linkGitHub.Name = "linkGitHub";
            this.linkGitHub.Size = new System.Drawing.Size(189, 13);
            this.linkGitHub.TabIndex = 239;
            this.linkGitHub.TabStop = true;
            this.linkGitHub.Text = Properties.Resources.ResourceManager.GetString("AboutView.linkGitHub.Text");
            this.linkGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGitHub_LinkClicked);
            // 
            // btnDonate
            // 
            this.btnDonate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(131)))), ((int)(((byte)(222)))));
            this.btnDonate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDonate.FlatAppearance.BorderSize = 0;
            this.btnDonate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonate.ForeColor = System.Drawing.Color.White;
            this.btnDonate.Location = new System.Drawing.Point(226, 91);
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Size = new System.Drawing.Size(101, 22);
            this.btnDonate.TabIndex = 240;
            this.btnDonate.Text = Properties.Resources.ResourceManager.GetString("AboutView.btnDonate.Text");
            this.btnDonate.UseVisualStyleBackColor = false;
            this.btnDonate.Click += new System.EventHandler(this.btnDonate_Click);
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.panelSettings.Controls.Add(this.comboBoxCurrency);
            this.panelSettings.Controls.Add(this.comboBoxAmount);
            this.panelSettings.Controls.Add(this.lblCopyright);
            this.panelSettings.Controls.Add(this.btnDonate);
            this.panelSettings.Controls.Add(this.lblHeader);
            this.panelSettings.Controls.Add(this.linkGitHub);
            this.panelSettings.Controls.Add(this.label1);
            this.panelSettings.Controls.Add(this.lblVersionInfo);
            this.panelSettings.Controls.Add(this.pictureBox1);
            this.panelSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSettings.Location = new System.Drawing.Point(0, 0);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(625, 395);
            this.panelSettings.TabIndex = 242;
            // 
            // comboBoxCurrency
            // 
            this.comboBoxCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCurrency.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.comboBoxCurrency.FormattingEnabled = true;
            this.comboBoxCurrency.Location = new System.Drawing.Point(157, 91);
            this.comboBoxCurrency.Name = "comboBoxCurrency";
            this.comboBoxCurrency.Size = new System.Drawing.Size(63, 22);
            this.comboBoxCurrency.TabIndex = 243;
            // 
            // comboBoxAmount
            // 
            this.comboBoxAmount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAmount.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.comboBoxAmount.FormattingEnabled = true;
            this.comboBoxAmount.Location = new System.Drawing.Point(64, 91);
            this.comboBoxAmount.Name = "comboBoxAmount";
            this.comboBoxAmount.Size = new System.Drawing.Size(90, 22);
            this.comboBoxAmount.TabIndex = 242;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblCopyright.ForeColor = System.Drawing.Color.Black;
            this.lblCopyright.Location = new System.Drawing.Point(61, 58);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(193, 13);
            this.lblCopyright.TabIndex = 241;
            this.lblCopyright.Text = Properties.Resources.ResourceManager.GetString("AboutView.lblCopyright.Text");
            // 
            // AboutView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelSettings);
            this.Name = "AboutView";
            this.Size = new System.Drawing.Size(625, 395);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblVersionInfo;
        private System.Windows.Forms.LinkLabel linkGitHub;
        private System.Windows.Forms.Button btnDonate;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.ComboBox comboBoxAmount;
        private System.Windows.Forms.ComboBox comboBoxCurrency;
    }
}
