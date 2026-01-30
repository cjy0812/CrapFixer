namespace CrapFixer
{
    partial class MainForm
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Windows = new System.Windows.Forms.TabPage();
            this.treeFeatures = new System.Windows.Forms.TreeView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.analyzeMarkedFeatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixMarkedFeatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreMarkedFeatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seperatorToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.helpMarkedFeatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Apps = new System.Windows.Forms.TabPage();
            this.checkedListBoxApps = new System.Windows.Forms.CheckedListBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.comboLogActions = new System.Windows.Forms.ComboBox();
            this.rtbLogger = new System.Windows.Forms.RichTextBox();
            this.btnFix = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnGitHub = new System.Windows.Forms.Button();
            this.lblOSInfo = new System.Windows.Forms.Label();
            this.lblVersionInfo = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pictureHeader = new System.Windows.Forms.PictureBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.linkUpdateCheck = new System.Windows.Forms.LinkLabel();
            this.btnTools = new System.Windows.Forms.Button();
            this.btnFixer = new System.Windows.Forms.Button();
            this.linkSelection = new System.Windows.Forms.LinkLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelContainer.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.Windows.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.Apps.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.BackColor = System.Drawing.SystemColors.Control;
            this.panelContainer.Controls.Add(this.panelContent);
            this.panelContainer.Location = new System.Drawing.Point(90, 69);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(613, 375);
            this.panelContainer.TabIndex = 198;
            // 
            // panelContent
            // 
            this.panelContent.AutoScroll = true;
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Controls.Add(this.btnAnalyze);
            this.panelContent.Controls.Add(this.tabControl);
            this.panelContent.Controls.Add(this.groupBox);
            this.panelContent.Controls.Add(this.btnFix);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(613, 375);
            this.panelContent.TabIndex = 205;
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAnalyze.AutoEllipsis = true;
            this.btnAnalyze.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAnalyze.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalyze.Location = new System.Drawing.Point(268, 339);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(121, 29);
            this.btnAnalyze.TabIndex = 1;
            this.btnAnalyze.Text = Properties.Resources.ResourceManager.GetString("MainForm.btnAnalyze.Text");
            this.btnAnalyze.UseVisualStyleBackColor = false;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl.Controls.Add(this.Windows);
            this.tabControl.Controls.Add(this.Apps);
            this.tabControl.ItemSize = new System.Drawing.Size(68, 21);
            this.tabControl.Location = new System.Drawing.Point(7, 5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.ShowToolTips = true;
            this.tabControl.Size = new System.Drawing.Size(255, 363);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl.TabIndex = 199;
            // 
            // Windows
            // 
            this.Windows.AutoScroll = true;
            this.Windows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Windows.Controls.Add(this.treeFeatures);
            this.Windows.Location = new System.Drawing.Point(4, 25);
            this.Windows.Name = "Windows";
            this.Windows.Size = new System.Drawing.Size(247, 334);
            this.Windows.TabIndex = 0;
            this.Windows.Text = Properties.Resources.ResourceManager.GetString("MainForm.Windows.Text");
            // 
            // treeFeatures
            // 
            this.treeFeatures.BackColor = System.Drawing.Color.White;
            this.treeFeatures.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeFeatures.CheckBoxes = true;
            this.treeFeatures.ContextMenuStrip = this.contextMenuStrip;
            this.treeFeatures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeFeatures.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeFeatures.Location = new System.Drawing.Point(0, 0);
            this.treeFeatures.Name = "treeFeatures";
            this.treeFeatures.ShowLines = false;
            this.treeFeatures.ShowNodeToolTips = true;
            this.treeFeatures.ShowPlusMinus = false;
            this.treeFeatures.ShowRootLines = false;
            this.treeFeatures.Size = new System.Drawing.Size(247, 334);
            this.treeFeatures.TabIndex = 0;
            this.treeFeatures.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeFeatures_AfterCheck);
            this.treeFeatures.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeFeatures_MouseDown);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.analyzeMarkedFeatureToolStripMenuItem,
            this.fixMarkedFeatureToolStripMenuItem,
            this.restoreMarkedFeatureToolStripMenuItem,
            this.seperatorToolStripMenuItem,
            this.helpMarkedFeatureToolStripMenuItem});
            this.contextMenuStrip.Name = "contextManualMenu";
            this.contextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip.Size = new System.Drawing.Size(119, 98);
            // 
            // analyzeMarkedFeatureToolStripMenuItem
            // 
            this.analyzeMarkedFeatureToolStripMenuItem.Name = "analyzeMarkedFeatureToolStripMenuItem";
            this.analyzeMarkedFeatureToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.analyzeMarkedFeatureToolStripMenuItem.Text = Properties.Resources.ResourceManager.GetString("MainForm.analyzeMarkedFeatureToolStripMenuItem.Text");
            this.analyzeMarkedFeatureToolStripMenuItem.Click += new System.EventHandler(this.analyzeMarkedFeatureToolStripMenuItem_Click);
            // 
            // fixMarkedFeatureToolStripMenuItem
            // 
            this.fixMarkedFeatureToolStripMenuItem.Name = "fixMarkedFeatureToolStripMenuItem";
            this.fixMarkedFeatureToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.fixMarkedFeatureToolStripMenuItem.Text = Properties.Resources.ResourceManager.GetString("MainForm.fixMarkedFeatureToolStripMenuItem.Text");
            this.fixMarkedFeatureToolStripMenuItem.Click += new System.EventHandler(this.fixMarkedFeatureToolStripMenuItem_Click);
            // 
            // restoreMarkedFeatureToolStripMenuItem
            // 
            this.restoreMarkedFeatureToolStripMenuItem.Name = "restoreMarkedFeatureToolStripMenuItem";
            this.restoreMarkedFeatureToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.restoreMarkedFeatureToolStripMenuItem.Text = Properties.Resources.ResourceManager.GetString("MainForm.restoreMarkedFeatureToolStripMenuItem.Text");
            this.restoreMarkedFeatureToolStripMenuItem.Click += new System.EventHandler(this.restoreMarkedFeatureToolStripMenuItem_Click);
            // 
            // seperatorToolStripMenuItem
            // 
            this.seperatorToolStripMenuItem.Name = "seperatorToolStripMenuItem";
            this.seperatorToolStripMenuItem.Size = new System.Drawing.Size(115, 6);
            // 
            // helpMarkedFeatureToolStripMenuItem
            // 
            this.helpMarkedFeatureToolStripMenuItem.Name = "helpMarkedFeatureToolStripMenuItem";
            this.helpMarkedFeatureToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.helpMarkedFeatureToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.helpMarkedFeatureToolStripMenuItem.Text = Properties.Resources.ResourceManager.GetString("MainForm.helpMarkedFeatureToolStripMenuItem.Text");
            this.helpMarkedFeatureToolStripMenuItem.Click += new System.EventHandler(this.helpMarkedFeatureToolStripMenuItem_Click);
            // 
            // Apps
            // 
            this.Apps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Apps.Controls.Add(this.checkedListBoxApps);
            this.Apps.Location = new System.Drawing.Point(4, 25);
            this.Apps.Name = "Apps";
            this.Apps.Size = new System.Drawing.Size(247, 334);
            this.Apps.TabIndex = 1;
            this.Apps.Text = Properties.Resources.ResourceManager.GetString("MainForm.Apps.Text");
            // 
            // checkedListBoxApps
            // 
            this.checkedListBoxApps.BackColor = System.Drawing.Color.White;
            this.checkedListBoxApps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxApps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxApps.Font = new System.Drawing.Font("Tahoma", 8F);
            this.checkedListBoxApps.FormattingEnabled = true;
            this.checkedListBoxApps.Items.AddRange(new object[] {
            Properties.Resources.ResourceManager.GetString("MainForm.checkedListBoxApps.NoAnalysisYet")});
            this.checkedListBoxApps.Location = new System.Drawing.Point(0, 0);
            this.checkedListBoxApps.Name = "checkedListBoxApps";
            this.checkedListBoxApps.Size = new System.Drawing.Size(247, 334);
            this.checkedListBoxApps.Sorted = true;
            this.checkedListBoxApps.TabIndex = 336;
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.groupBox.Controls.Add(this.comboLogActions);
            this.groupBox.Controls.Add(this.rtbLogger);
            this.groupBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox.Location = new System.Drawing.Point(268, 21);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(334, 310);
            this.groupBox.TabIndex = 200;
            this.groupBox.TabStop = false;
            // 
            // comboLogActions
            // 
            this.comboLogActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboLogActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.comboLogActions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLogActions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboLogActions.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.comboLogActions.FormattingEnabled = true;
            this.comboLogActions.Location = new System.Drawing.Point(7, 285);
            this.comboLogActions.Name = "comboLogActions";
            this.comboLogActions.Size = new System.Drawing.Size(319, 21);
            this.comboLogActions.TabIndex = 210;
            this.comboLogActions.Visible = false;
            // 
            // rtbLogger
            // 
            this.rtbLogger.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLogger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.rtbLogger.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLogger.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbLogger.Location = new System.Drawing.Point(7, 19);
            this.rtbLogger.Name = "rtbLogger";
            this.rtbLogger.Size = new System.Drawing.Size(319, 263);
            this.rtbLogger.TabIndex = 195;
            this.rtbLogger.Text = "";
            this.rtbLogger.WordWrap = false;
            // 
            // btnFix
            // 
            this.btnFix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFix.AutoEllipsis = true;
            this.btnFix.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFix.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFix.Location = new System.Drawing.Point(482, 339);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(121, 29);
            this.btnFix.TabIndex = 2;
            this.btnFix.Text = Properties.Resources.ResourceManager.GetString("MainForm.btnFix.Text");
            this.btnFix.UseVisualStyleBackColor = false;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.panelHeader.Controls.Add(this.btnGitHub);
            this.panelHeader.Controls.Add(this.lblOSInfo);
            this.panelHeader.Controls.Add(this.lblVersionInfo);
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Controls.Add(this.pictureHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(710, 61);
            this.panelHeader.TabIndex = 204;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // btnGitHub
            // 
            this.btnGitHub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGitHub.AutoSize = true;
            this.btnGitHub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGitHub.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(210)))));
            this.btnGitHub.FlatAppearance.BorderSize = 0;
            this.btnGitHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGitHub.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnGitHub.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGitHub.Location = new System.Drawing.Point(657, 7);
            this.btnGitHub.Name = "btnGitHub";
            this.btnGitHub.Size = new System.Drawing.Size(40, 40);
            this.btnGitHub.TabIndex = 201;
            this.btnGitHub.TabStop = false;
            this.toolTip.SetToolTip(this.btnGitHub, "Love CrapFixer? It’s open source — but your support keeps it alive! 💖");
            this.btnGitHub.UseVisualStyleBackColor = true;
            this.btnGitHub.Click += new System.EventHandler(this.btnGitHub_Click);
            // 
            // lblOSInfo
            // 
            this.lblOSInfo.AutoSize = true;
            this.lblOSInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblOSInfo.Font = new System.Drawing.Font("Tahoma", 7.6F);
            this.lblOSInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblOSInfo.Location = new System.Drawing.Point(90, 37);
            this.lblOSInfo.Name = "lblOSInfo";
            this.lblOSInfo.Size = new System.Drawing.Size(120, 13);
            this.lblOSInfo.TabIndex = 200;
            this.lblOSInfo.Text = Properties.Resources.ResourceManager.GetString("MainForm.lblOSInfo.Text");
            // 
            // lblVersionInfo
            // 
            this.lblVersionInfo.AutoSize = true;
            this.lblVersionInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblVersionInfo.Font = new System.Drawing.Font("Tahoma", 7.6F);
            this.lblVersionInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblVersionInfo.Location = new System.Drawing.Point(198, 15);
            this.lblVersionInfo.Name = "lblVersionInfo";
            this.lblVersionInfo.Size = new System.Drawing.Size(13, 13);
            this.lblVersionInfo.TabIndex = 2;
            this.lblVersionInfo.Text = Properties.Resources.ResourceManager.GetString("MainForm.lblVersionInfo.Text");
            // 
            // lblHeader
            // 
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHeader.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(89, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(117, 25);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = Properties.Resources.ResourceManager.GetString("MainForm.lblHeader.Text");
            this.toolTip.SetToolTip(this.lblHeader, "Click here to visit the CrapFixer website at github.com/builtbybel/crapfixer");
            this.lblHeader.UseCompatibleTextRendering = true;
            // 
            // pictureHeader
            // 
            this.pictureHeader.BackColor = System.Drawing.Color.Transparent;
            this.pictureHeader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureHeader.Image = global::CFixer.Properties.Resources.AppIcon;
            this.pictureHeader.InitialImage = null;
            this.pictureHeader.Location = new System.Drawing.Point(30, 9);
            this.pictureHeader.Name = "pictureHeader";
            this.pictureHeader.Size = new System.Drawing.Size(44, 41);
            this.pictureHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureHeader.TabIndex = 0;
            this.pictureHeader.TabStop = false;
            this.toolTip.SetToolTip(this.pictureHeader, "Click here to visit the CrapFixer website at github.com/builtbybel/crapfixer");
            // 
            // btnRestore
            // 
            this.btnRestore.AutoEllipsis = true;
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRestore.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(210)))));
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnRestore.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRestore.Location = new System.Drawing.Point(10, 142);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(80, 60);
            this.btnRestore.TabIndex = 198;
            this.btnRestore.TabStop = false;
            this.btnRestore.Text = Properties.Resources.ResourceManager.GetString("MainForm.btnRestore.Text");
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // linkUpdateCheck
            // 
            this.linkUpdateCheck.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkUpdateCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkUpdateCheck.AutoEllipsis = true;
            this.linkUpdateCheck.AutoSize = true;
            this.linkUpdateCheck.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkUpdateCheck.LinkColor = System.Drawing.Color.White;
            this.linkUpdateCheck.Location = new System.Drawing.Point(590, 447);
            this.linkUpdateCheck.Name = "linkUpdateCheck";
            this.linkUpdateCheck.Size = new System.Drawing.Size(107, 13);
            this.linkUpdateCheck.TabIndex = 203;
            this.linkUpdateCheck.TabStop = true;
            this.linkUpdateCheck.Text = Properties.Resources.ResourceManager.GetString("MainForm.linkUpdateCheck.Text");
            this.linkUpdateCheck.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkUpdateCheck.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkUpdateCheck_LinkClicked);
            // 
            // btnTools
            // 
            this.btnTools.AutoEllipsis = true;
            this.btnTools.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnTools.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(210)))));
            this.btnTools.FlatAppearance.BorderSize = 0;
            this.btnTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTools.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnTools.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTools.Location = new System.Drawing.Point(10, 210);
            this.btnTools.Name = "btnTools";
            this.btnTools.Size = new System.Drawing.Size(80, 60);
            this.btnTools.TabIndex = 205;
            this.btnTools.TabStop = false;
            this.btnTools.Text = Properties.Resources.ResourceManager.GetString("MainForm.btnTools.Text");
            this.btnTools.UseVisualStyleBackColor = true;
            // 
            // btnFixer
            // 
            this.btnFixer.AutoEllipsis = true;
            this.btnFixer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(240)))));
            this.btnFixer.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFixer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(170)))), ((int)(((byte)(210)))));
            this.btnFixer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFixer.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnFixer.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFixer.Location = new System.Drawing.Point(10, 74);
            this.btnFixer.Name = "btnFixer";
            this.btnFixer.Size = new System.Drawing.Size(80, 60);
            this.btnFixer.TabIndex = 206;
            this.btnFixer.TabStop = false;
            this.btnFixer.Text = Properties.Resources.ResourceManager.GetString("MainForm.btnFixer.Text");
            this.btnFixer.UseVisualStyleBackColor = false;
            // 
            // linkSelection
            // 
            this.linkSelection.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkSelection.AutoEllipsis = true;
            this.linkSelection.AutoSize = true;
            this.linkSelection.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSelection.LinkColor = System.Drawing.Color.White;
            this.linkSelection.Location = new System.Drawing.Point(10, 447);
            this.linkSelection.Name = "linkSelection";
            this.linkSelection.Size = new System.Drawing.Size(49, 13);
            this.linkSelection.TabIndex = 207;
            this.linkSelection.TabStop = true;
            this.linkSelection.Text = Properties.Resources.ResourceManager.GetString("MainForm.linkSelection.Text");
            this.linkSelection.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkSelection.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSelection_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(710, 466);
            this.Controls.Add(this.linkSelection);
            this.Controls.Add(this.btnFixer);
            this.Controls.Add(this.btnTools);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.linkUpdateCheck);
            this.Controls.Add(this.panelContainer);
            this.MinimumSize = new System.Drawing.Size(642, 337);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = Properties.Resources.ResourceManager.GetString("MainForm.Text");
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.panelContainer.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.Windows.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.Apps.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fixMarkedFeatureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analyzeMarkedFeatureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreMarkedFeatureToolStripMenuItem;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Windows;
        private System.Windows.Forms.TabPage Apps;
        private System.Windows.Forms.GroupBox groupBox;
        public System.Windows.Forms.RichTextBox rtbLogger;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureHeader;
        private System.Windows.Forms.Label lblVersionInfo;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.CheckedListBox checkedListBoxApps;
        private System.Windows.Forms.ToolStripSeparator seperatorToolStripMenuItem;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.LinkLabel linkUpdateCheck;
        private System.Windows.Forms.ToolStripMenuItem helpMarkedFeatureToolStripMenuItem;
        private System.Windows.Forms.Label lblOSInfo;
        private System.Windows.Forms.Button btnTools;
        private System.Windows.Forms.Button btnFixer;
        private System.Windows.Forms.LinkLabel linkSelection;
        private System.Windows.Forms.ComboBox comboLogActions;
        private System.Windows.Forms.TreeView treeFeatures;
        private System.Windows.Forms.Button btnGitHub;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

