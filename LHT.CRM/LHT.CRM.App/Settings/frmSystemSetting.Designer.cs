namespace LHT.CRM.App.Settings
{
    partial class frmSystemSetting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new DMSkin.Metro.Controls.MetroTabControl();
            this.tpRoleSetting = new DMSkin.Metro.Controls.MetroTabPage();
            this.btnAuthority = new DMSkin.Controls.DMButton();
            this.btnDeleteRole = new DMSkin.Controls.DMButton();
            this.btnUpdateRole = new DMSkin.Controls.DMButton();
            this.btnCreateRole = new DMSkin.Controls.DMButton();
            this.dgvRoleSetting = new DMSkin.Metro.Controls.MetroGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabControl1.SuspendLayout();
            this.tpRoleSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoleSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tpRoleSetting);
            this.metroTabControl1.DM_UseSelectable = true;
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Multiline = true;
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(801, 701);
            this.metroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.metroTabControl1.TabIndex = 0;
            // 
            // tpRoleSetting
            // 
            this.tpRoleSetting.Controls.Add(this.btnAuthority);
            this.tpRoleSetting.Controls.Add(this.btnDeleteRole);
            this.tpRoleSetting.Controls.Add(this.btnUpdateRole);
            this.tpRoleSetting.Controls.Add(this.btnCreateRole);
            this.tpRoleSetting.Controls.Add(this.dgvRoleSetting);
            this.tpRoleSetting.HorizontalScrollbarBarColor = true;
            this.tpRoleSetting.HorizontalScrollbarDM_HighlightOnWheel = false;
            this.tpRoleSetting.HorizontalScrollbarSize = 2;
            this.tpRoleSetting.Location = new System.Drawing.Point(4, 39);
            this.tpRoleSetting.Name = "tpRoleSetting";
            this.tpRoleSetting.Size = new System.Drawing.Size(793, 658);
            this.tpRoleSetting.TabIndex = 0;
            this.tpRoleSetting.Text = "角色设置";
            this.tpRoleSetting.VerticalScrollbarBarColor = true;
            this.tpRoleSetting.VerticalScrollbarDM_HighlightOnWheel = false;
            this.tpRoleSetting.VerticalScrollbarSize = 10;
            // 
            // btnAuthority
            // 
            this.btnAuthority.BackColor = System.Drawing.Color.Transparent;
            this.btnAuthority.DM_DisabledColor = System.Drawing.Color.Empty;
            this.btnAuthority.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(140)))), ((int)(((byte)(188)))));
            this.btnAuthority.DM_MoveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.btnAuthority.DM_NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnAuthority.DM_Radius = 5;
            this.btnAuthority.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAuthority.ForeColor = System.Drawing.Color.White;
            this.btnAuthority.Image = null;
            this.btnAuthority.Location = new System.Drawing.Point(462, 22);
            this.btnAuthority.Name = "btnAuthority";
            this.btnAuthority.Size = new System.Drawing.Size(125, 45);
            this.btnAuthority.TabIndex = 6;
            this.btnAuthority.Text = "权限";
            this.btnAuthority.UseVisualStyleBackColor = false;
            this.btnAuthority.Click += new System.EventHandler(this.btnAuthority_Click);
            // 
            // btnDeleteRole
            // 
            this.btnDeleteRole.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteRole.DM_DisabledColor = System.Drawing.Color.Empty;
            this.btnDeleteRole.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(140)))), ((int)(((byte)(188)))));
            this.btnDeleteRole.DM_MoveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.btnDeleteRole.DM_NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnDeleteRole.DM_Radius = 5;
            this.btnDeleteRole.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDeleteRole.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRole.Image = null;
            this.btnDeleteRole.Location = new System.Drawing.Point(307, 23);
            this.btnDeleteRole.Name = "btnDeleteRole";
            this.btnDeleteRole.Size = new System.Drawing.Size(125, 45);
            this.btnDeleteRole.TabIndex = 5;
            this.btnDeleteRole.Text = "删除";
            this.btnDeleteRole.UseVisualStyleBackColor = false;
            this.btnDeleteRole.Click += new System.EventHandler(this.btnDeleteRole_Click);
            // 
            // btnUpdateRole
            // 
            this.btnUpdateRole.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateRole.DM_DisabledColor = System.Drawing.Color.Empty;
            this.btnUpdateRole.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(140)))), ((int)(((byte)(188)))));
            this.btnUpdateRole.DM_MoveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.btnUpdateRole.DM_NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnUpdateRole.DM_Radius = 5;
            this.btnUpdateRole.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdateRole.ForeColor = System.Drawing.Color.White;
            this.btnUpdateRole.Image = null;
            this.btnUpdateRole.Location = new System.Drawing.Point(152, 22);
            this.btnUpdateRole.Name = "btnUpdateRole";
            this.btnUpdateRole.Size = new System.Drawing.Size(125, 45);
            this.btnUpdateRole.TabIndex = 4;
            this.btnUpdateRole.Text = "修改";
            this.btnUpdateRole.UseVisualStyleBackColor = false;
            this.btnUpdateRole.Click += new System.EventHandler(this.btnUpdateRole_Click);
            // 
            // btnCreateRole
            // 
            this.btnCreateRole.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateRole.DM_DisabledColor = System.Drawing.Color.Empty;
            this.btnCreateRole.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(140)))), ((int)(((byte)(188)))));
            this.btnCreateRole.DM_MoveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.btnCreateRole.DM_NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnCreateRole.DM_Radius = 5;
            this.btnCreateRole.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCreateRole.ForeColor = System.Drawing.Color.White;
            this.btnCreateRole.Image = null;
            this.btnCreateRole.Location = new System.Drawing.Point(-3, 23);
            this.btnCreateRole.Name = "btnCreateRole";
            this.btnCreateRole.Size = new System.Drawing.Size(125, 45);
            this.btnCreateRole.TabIndex = 3;
            this.btnCreateRole.Text = "新建";
            this.btnCreateRole.UseVisualStyleBackColor = false;
            this.btnCreateRole.Click += new System.EventHandler(this.btnCreateRole_Click);
            // 
            // dgvRoleSetting
            // 
            this.dgvRoleSetting.AllowUserToAddRows = false;
            this.dgvRoleSetting.AllowUserToDeleteRows = false;
            this.dgvRoleSetting.AllowUserToResizeRows = false;
            this.dgvRoleSetting.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoleSetting.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvRoleSetting.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRoleSetting.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRoleSetting.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoleSetting.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRoleSetting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRoleSetting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.RoleName,
            this.RoleDescription});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoleSetting.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRoleSetting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvRoleSetting.EnableHeadersVisualStyles = false;
            this.dgvRoleSetting.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvRoleSetting.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvRoleSetting.Location = new System.Drawing.Point(0, 88);
            this.dgvRoleSetting.Name = "dgvRoleSetting";
            this.dgvRoleSetting.ReadOnly = true;
            this.dgvRoleSetting.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoleSetting.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRoleSetting.RowHeadersVisible = false;
            this.dgvRoleSetting.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvRoleSetting.RowTemplate.Height = 27;
            this.dgvRoleSetting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoleSetting.Size = new System.Drawing.Size(793, 570);
            this.dgvRoleSetting.TabIndex = 2;
            this.dgvRoleSetting.Click += new System.EventHandler(this.dgvRoleSetting_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "编号";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // RoleName
            // 
            this.RoleName.DataPropertyName = "RoleName";
            this.RoleName.HeaderText = "角色名称";
            this.RoleName.Name = "RoleName";
            this.RoleName.ReadOnly = true;
            // 
            // RoleDescription
            // 
            this.RoleDescription.DataPropertyName = "RoleDescription";
            this.RoleDescription.HeaderText = "角色描述";
            this.RoleDescription.Name = "RoleDescription";
            this.RoleDescription.ReadOnly = true;
            // 
            // frmSystemSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(801, 701);
            this.Controls.Add(this.metroTabControl1);
            this.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSystemSetting";
            this.Text = "frmSystemSetting";
            this.Load += new System.EventHandler(this.frmSystemSetting_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.tpRoleSetting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoleSetting)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DMSkin.Metro.Controls.MetroTabControl metroTabControl1;
        private DMSkin.Metro.Controls.MetroTabPage tpRoleSetting;
        private DMSkin.Metro.Controls.MetroGrid dgvRoleSetting;
        private DMSkin.Controls.DMButton btnCreateRole;
        private DMSkin.Controls.DMButton btnAuthority;
        private DMSkin.Controls.DMButton btnDeleteRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleDescription;
        private DMSkin.Controls.DMButton btnUpdateRole;
    }
}