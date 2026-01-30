namespace CFixer.Views
{
    partial class OptionsView
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
            this.panelSettings = new System.Windows.Forms.Panel();
            this.btnViveMenu = new System.Windows.Forms.Button();
            this.btnPluginsMenu = new System.Windows.Forms.Button();
            this.panelSubContent = new System.Windows.Forms.Panel();
            this.btnAboutMenu = new System.Windows.Forms.Button();
            this.btnSettingsMenu = new System.Windows.Forms.Button();
            this.panelSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panelSettings.Controls.Add(this.btnViveMenu);
            this.panelSettings.Controls.Add(this.btnPluginsMenu);
            this.panelSettings.Controls.Add(this.panelSubContent);
            this.panelSettings.Controls.Add(this.btnAboutMenu);
            this.panelSettings.Controls.Add(this.btnSettingsMenu);
            this.panelSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSettings.Location = new System.Drawing.Point(0, 0);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(625, 395);
            this.panelSettings.TabIndex = 243;
            // 
            // btnViveMenu
            // 
            this.btnViveMenu.BackColor = System.Drawing.Color.White;
            this.btnViveMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnViveMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.btnViveMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViveMenu.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnViveMenu.Location = new System.Drawing.Point(14, 88);
            this.btnViveMenu.Name = "btnViveMenu";
            this.btnViveMenu.Size = new System.Drawing.Size(100, 32);
            this.btnViveMenu.TabIndex = 248;
            this.btnViveMenu.Text = Properties.Resources.ResourceManager.GetString("OptionsView.btnViveMenu.Text");
            this.btnViveMenu.UseVisualStyleBackColor = false;
            this.btnViveMenu.Click += new System.EventHandler(this.btnViveMenu_Click);
            // 
            // btnPluginsMenu
            // 
            this.btnPluginsMenu.BackColor = System.Drawing.Color.White;
            this.btnPluginsMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnPluginsMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.btnPluginsMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPluginsMenu.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnPluginsMenu.Location = new System.Drawing.Point(14, 48);
            this.btnPluginsMenu.Name = "btnPluginsMenu";
            this.btnPluginsMenu.Size = new System.Drawing.Size(100, 32);
            this.btnPluginsMenu.TabIndex = 247;
            this.btnPluginsMenu.Text = Properties.Resources.ResourceManager.GetString("OptionsView.btnPluginsMenu.Text");
            this.btnPluginsMenu.UseVisualStyleBackColor = false;
            this.btnPluginsMenu.Click += new System.EventHandler(this.btnPluginsMenu_Click);
            // 
            // panelSubContent
            // 
            this.panelSubContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSubContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.panelSubContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSubContent.Location = new System.Drawing.Point(129, 8);
            this.panelSubContent.Name = "panelSubContent";
            this.panelSubContent.Size = new System.Drawing.Size(487, 378);
            this.panelSubContent.TabIndex = 246;
            // 
            // btnAboutMenu
            // 
            this.btnAboutMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAboutMenu.BackColor = System.Drawing.Color.White;
            this.btnAboutMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnAboutMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.btnAboutMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutMenu.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnAboutMenu.Location = new System.Drawing.Point(14, 354);
            this.btnAboutMenu.Name = "btnAboutMenu";
            this.btnAboutMenu.Size = new System.Drawing.Size(100, 32);
            this.btnAboutMenu.TabIndex = 242;
            this.btnAboutMenu.Text = Properties.Resources.ResourceManager.GetString("OptionsView.btnAboutMenu.Text");
            this.btnAboutMenu.UseVisualStyleBackColor = false;
            this.btnAboutMenu.Click += new System.EventHandler(this.btnAboutMenu_Click);
            // 
            // btnSettingsMenu
            // 
            this.btnSettingsMenu.BackColor = System.Drawing.Color.White;
            this.btnSettingsMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnSettingsMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.btnSettingsMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingsMenu.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnSettingsMenu.Location = new System.Drawing.Point(14, 8);
            this.btnSettingsMenu.Name = "btnSettingsMenu";
            this.btnSettingsMenu.Size = new System.Drawing.Size(100, 32);
            this.btnSettingsMenu.TabIndex = 241;
            this.btnSettingsMenu.Text = Properties.Resources.ResourceManager.GetString("OptionsView.btnSettingsMenu.Text");
            this.btnSettingsMenu.UseVisualStyleBackColor = false;
            this.btnSettingsMenu.Click += new System.EventHandler(this.btnSettingsMenu_Click);
            // 
            // OptionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelSettings);
            this.Name = "OptionsView";
            this.Size = new System.Drawing.Size(625, 395);
            this.panelSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Button btnSettingsMenu;
        private System.Windows.Forms.Button btnAboutMenu;
        private System.Windows.Forms.Panel panelSubContent;
        private System.Windows.Forms.Button btnPluginsMenu;
        private System.Windows.Forms.Button btnViveMenu;
    }
}
