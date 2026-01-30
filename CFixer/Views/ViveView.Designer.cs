namespace CFixer.Views
{
    partial class ViveView
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.EnabledColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfoColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnDescription = new System.Windows.Forms.Button();
            this.linkPluginUsage = new System.Windows.Forms.LinkLabel();
            this.txtCustomIds = new System.Windows.Forms.TextBox();
            this.lblCustomIds = new System.Windows.Forms.Label();
            this.btnApplyCustom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EnabledColumn,
            this.NameColumn,
            this.IdColumn,
            this.StatusColumn,
            this.InfoColumn});
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView.Location = new System.Drawing.Point(15, 46);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(470, 305);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // EnabledColumn
            // 
            this.EnabledColumn.FillWeight = 57.38248F;
            this.EnabledColumn.HeaderText = "";
            this.EnabledColumn.Name = "EnabledColumn";
            this.EnabledColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EnabledColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // NameColumn
            // 
            this.NameColumn.FillWeight = 203.0457F;
            this.NameColumn.HeaderText = "Feature";
            this.NameColumn.Name = "NameColumn";
            // 
            // IdColumn
            // 
            this.IdColumn.FillWeight = 79.85728F;
            this.IdColumn.HeaderText = "ID";
            this.IdColumn.Name = "IdColumn";
            // 
            // StatusColumn
            // 
            this.StatusColumn.FillWeight = 79.85728F;
            this.StatusColumn.HeaderText = "Status";
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.ReadOnly = true;
            // 
            // InfoColumn
            // 
            this.InfoColumn.FillWeight = 79.85728F;
            this.InfoColumn.HeaderText = "Info";
            this.InfoColumn.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.InfoColumn.Name = "InfoColumn";
            this.InfoColumn.ReadOnly = true;
            this.InfoColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.InfoColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Location = new System.Drawing.Point(500, 47);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(109, 29);
            this.btnApply.TabIndex = 8;
            this.btnApply.Text = Properties.Resources.ResourceManager.GetString("ViveView.btnApply.Text");
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnViveApply_Click);
            // 
            // btnDescription
            // 
            this.btnDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDescription.AutoEllipsis = true;
            this.btnDescription.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDescription.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescription.Location = new System.Drawing.Point(15, 10);
            this.btnDescription.Name = "btnDescription";
            this.btnDescription.Padding = new System.Windows.Forms.Padding(20, 0, 100, 0);
            this.btnDescription.Size = new System.Drawing.Size(594, 25);
            this.btnDescription.TabIndex = 9;
            this.btnDescription.Text = Properties.Resources.ResourceManager.GetString("ViveView.btnDescription.Text");
            this.btnDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDescription.UseVisualStyleBackColor = true;
            // 
            // linkPluginUsage
            // 
            this.linkPluginUsage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkPluginUsage.AutoSize = true;
            this.linkPluginUsage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.linkPluginUsage.Location = new System.Drawing.Point(535, 16);
            this.linkPluginUsage.Name = "linkPluginUsage";
            this.linkPluginUsage.Size = new System.Drawing.Size(56, 13);
            this.linkPluginUsage.TabIndex = 247;
            this.linkPluginUsage.TabStop = true;
            this.linkPluginUsage.Text = Properties.Resources.ResourceManager.GetString("ViveView.linkPluginUsage.Text");
            this.linkPluginUsage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPluginUsage_LinkClicked);
            // 
            // txtCustomIds
            // 
            this.txtCustomIds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomIds.Location = new System.Drawing.Point(77, 357);
            this.txtCustomIds.Multiline = true;
            this.txtCustomIds.Name = "txtCustomIds";
            this.txtCustomIds.Size = new System.Drawing.Size(408, 24);
            this.txtCustomIds.TabIndex = 248;
            // 
            // lblCustomIds
            // 
            this.lblCustomIds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCustomIds.AutoSize = true;
            this.lblCustomIds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomIds.Location = new System.Drawing.Point(12, 363);
            this.lblCustomIds.Name = "lblCustomIds";
            this.lblCustomIds.Size = new System.Drawing.Size(59, 13);
            this.lblCustomIds.TabIndex = 249;
            this.lblCustomIds.Text = Properties.Resources.ResourceManager.GetString("ViveView.lblCustomIds.Text");
            // 
            // btnApplyCustom
            // 
            this.btnApplyCustom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApplyCustom.Location = new System.Drawing.Point(500, 355);
            this.btnApplyCustom.Name = "btnApplyCustom";
            this.btnApplyCustom.Size = new System.Drawing.Size(109, 29);
            this.btnApplyCustom.TabIndex = 250;
            this.btnApplyCustom.Text = Properties.Resources.ResourceManager.GetString("ViveView.btnApplyCustom.Text");
            this.btnApplyCustom.UseVisualStyleBackColor = true;
            this.btnApplyCustom.Click += new System.EventHandler(this.btnApplyCustom_Click);
            // 
            // ViveView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.btnApplyCustom);
            this.Controls.Add(this.lblCustomIds);
            this.Controls.Add(this.txtCustomIds);
            this.Controls.Add(this.linkPluginUsage);
            this.Controls.Add(this.btnDescription);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.dataGridView);
            this.Name = "ViveView";
            this.Size = new System.Drawing.Size(625, 395);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnDescription;
        private System.Windows.Forms.LinkLabel linkPluginUsage;
        private System.Windows.Forms.TextBox txtCustomIds;
        private System.Windows.Forms.Label lblCustomIds;
        private System.Windows.Forms.Button btnApplyCustom;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EnabledColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
        private System.Windows.Forms.DataGridViewLinkColumn InfoColumn;
    }
}
