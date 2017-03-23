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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new DMSkin.Metro.Controls.MetroTabControl();
            this.tpUserSetting = new DMSkin.Metro.Controls.MetroTabPage();
            this.dgvUserSetting = new DMSkin.Metro.Controls.MetroGrid();
            this.btnaddrole = new DMSkin.Controls.DMButton();
            this.btndeleteuser = new DMSkin.Controls.DMButton();
            this.btnupdateuser = new DMSkin.Controls.DMButton();
            this.btnadduser = new DMSkin.Controls.DMButton();
            this.tbAccountSetting = new DMSkin.Metro.Controls.MetroTabPage();
            this.dgvAccountSetting = new DMSkin.Metro.Controls.MetroGrid();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLockedAccount = new DMSkin.Controls.DMButton();
            this.btnResetPassword = new DMSkin.Controls.DMButton();
            this.tpRoleSetting = new DMSkin.Metro.Controls.MetroTabPage();
            this.btnAuthority = new DMSkin.Controls.DMButton();
            this.btnDeleteRole = new DMSkin.Controls.DMButton();
            this.btnUpdateRole = new DMSkin.Controls.DMButton();
            this.btnCreateRole = new DMSkin.Controls.DMButton();
            this.dgvRoleSetting = new DMSkin.Metro.Controls.MetroGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabControl1.SuspendLayout();
            this.tpUserSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserSetting)).BeginInit();
            this.tbAccountSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountSetting)).BeginInit();
            this.tpRoleSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoleSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tpUserSetting);
            this.metroTabControl1.Controls.Add(this.tbAccountSetting);
            this.metroTabControl1.Controls.Add(this.tpRoleSetting);
            this.metroTabControl1.DM_UseSelectable = true;
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(795, 636);
            this.metroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.metroTabControl1.TabIndex = 0;
            // 
            // tpUserSetting
            // 
            this.tpUserSetting.Controls.Add(this.dgvUserSetting);
            this.tpUserSetting.Controls.Add(this.btnaddrole);
            this.tpUserSetting.Controls.Add(this.btndeleteuser);
            this.tpUserSetting.Controls.Add(this.btnupdateuser);
            this.tpUserSetting.Controls.Add(this.btnadduser);
            this.tpUserSetting.HorizontalScrollbarBarColor = true;
            this.tpUserSetting.HorizontalScrollbarDM_HighlightOnWheel = false;
            this.tpUserSetting.HorizontalScrollbarSize = 2;
            this.tpUserSetting.Location = new System.Drawing.Point(4, 39);
            this.tpUserSetting.Name = "tpUserSetting";
            this.tpUserSetting.Size = new System.Drawing.Size(787, 593);
            this.tpUserSetting.TabIndex = 1;
            this.tpUserSetting.Text = "用户设置";
            this.tpUserSetting.VerticalScrollbarBarColor = true;
            this.tpUserSetting.VerticalScrollbarDM_HighlightOnWheel = false;
            this.tpUserSetting.VerticalScrollbarSize = 10;
            // 
            // dgvUserSetting
            // 
            this.dgvUserSetting.AllowUserToAddRows = false;
            this.dgvUserSetting.AllowUserToDeleteRows = false;
            this.dgvUserSetting.AllowUserToResizeRows = false;
            this.dgvUserSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUserSetting.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserSetting.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvUserSetting.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUserSetting.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUserSetting.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserSetting.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserSetting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUserSetting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column9,
            this.Column10});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserSetting.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUserSetting.EnableHeadersVisualStyles = false;
            this.dgvUserSetting.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvUserSetting.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvUserSetting.Location = new System.Drawing.Point(0, 74);
            this.dgvUserSetting.Name = "dgvUserSetting";
            this.dgvUserSetting.ReadOnly = true;
            this.dgvUserSetting.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserSetting.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUserSetting.RowHeadersVisible = false;
            this.dgvUserSetting.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvUserSetting.RowTemplate.Height = 27;
            this.dgvUserSetting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserSetting.Size = new System.Drawing.Size(791, 519);
            this.dgvUserSetting.TabIndex = 11;
            // 
            // btnaddrole
            // 
            this.btnaddrole.BackColor = System.Drawing.Color.Transparent;
            this.btnaddrole.DM_DisabledColor = System.Drawing.Color.Empty;
            this.btnaddrole.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(140)))), ((int)(((byte)(188)))));
            this.btnaddrole.DM_MoveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.btnaddrole.DM_NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnaddrole.DM_Radius = 5;
            this.btnaddrole.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnaddrole.ForeColor = System.Drawing.Color.White;
            this.btnaddrole.Image = null;
            this.btnaddrole.Location = new System.Drawing.Point(462, 23);
            this.btnaddrole.Name = "btnaddrole";
            this.btnaddrole.Size = new System.Drawing.Size(125, 45);
            this.btnaddrole.TabIndex = 10;
            this.btnaddrole.Text = "角色";
            this.btnaddrole.UseVisualStyleBackColor = false;
            // 
            // btndeleteuser
            // 
            this.btndeleteuser.BackColor = System.Drawing.Color.Transparent;
            this.btndeleteuser.DM_DisabledColor = System.Drawing.Color.Empty;
            this.btndeleteuser.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(140)))), ((int)(((byte)(188)))));
            this.btndeleteuser.DM_MoveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.btndeleteuser.DM_NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btndeleteuser.DM_Radius = 5;
            this.btndeleteuser.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btndeleteuser.ForeColor = System.Drawing.Color.White;
            this.btndeleteuser.Image = null;
            this.btndeleteuser.Location = new System.Drawing.Point(307, 23);
            this.btndeleteuser.Name = "btndeleteuser";
            this.btndeleteuser.Size = new System.Drawing.Size(125, 45);
            this.btndeleteuser.TabIndex = 9;
            this.btndeleteuser.Text = "删除";
            this.btndeleteuser.UseVisualStyleBackColor = false;
            // 
            // btnupdateuser
            // 
            this.btnupdateuser.BackColor = System.Drawing.Color.Transparent;
            this.btnupdateuser.DM_DisabledColor = System.Drawing.Color.Empty;
            this.btnupdateuser.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(140)))), ((int)(((byte)(188)))));
            this.btnupdateuser.DM_MoveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.btnupdateuser.DM_NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnupdateuser.DM_Radius = 5;
            this.btnupdateuser.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnupdateuser.ForeColor = System.Drawing.Color.White;
            this.btnupdateuser.Image = null;
            this.btnupdateuser.Location = new System.Drawing.Point(152, 23);
            this.btnupdateuser.Name = "btnupdateuser";
            this.btnupdateuser.Size = new System.Drawing.Size(125, 45);
            this.btnupdateuser.TabIndex = 8;
            this.btnupdateuser.Text = "修改";
            this.btnupdateuser.UseVisualStyleBackColor = false;
            this.btnupdateuser.Click += new System.EventHandler(this.btnupdateuser_Click);
            // 
            // btnadduser
            // 
            this.btnadduser.BackColor = System.Drawing.Color.Transparent;
            this.btnadduser.DM_DisabledColor = System.Drawing.Color.Empty;
            this.btnadduser.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(140)))), ((int)(((byte)(188)))));
            this.btnadduser.DM_MoveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.btnadduser.DM_NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnadduser.DM_Radius = 5;
            this.btnadduser.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnadduser.ForeColor = System.Drawing.Color.White;
            this.btnadduser.Image = null;
            this.btnadduser.Location = new System.Drawing.Point(-3, 23);
            this.btnadduser.Name = "btnadduser";
            this.btnadduser.Size = new System.Drawing.Size(125, 45);
            this.btnadduser.TabIndex = 7;
            this.btnadduser.Text = "新建";
            this.btnadduser.UseVisualStyleBackColor = false;
            this.btnadduser.Click += new System.EventHandler(this.btnadduser_Click);
            // 
            // tbAccountSetting
            // 
            this.tbAccountSetting.Controls.Add(this.dgvAccountSetting);
            this.tbAccountSetting.Controls.Add(this.btnLockedAccount);
            this.tbAccountSetting.Controls.Add(this.btnResetPassword);
            this.tbAccountSetting.HorizontalScrollbarBarColor = true;
            this.tbAccountSetting.HorizontalScrollbarDM_HighlightOnWheel = false;
            this.tbAccountSetting.HorizontalScrollbarSize = 2;
            this.tbAccountSetting.Location = new System.Drawing.Point(4, 39);
            this.tbAccountSetting.Name = "tbAccountSetting";
            this.tbAccountSetting.Size = new System.Drawing.Size(787, 593);
            this.tbAccountSetting.TabIndex = 2;
            this.tbAccountSetting.Text = "账号设置";
            this.tbAccountSetting.VerticalScrollbarBarColor = true;
            this.tbAccountSetting.VerticalScrollbarDM_HighlightOnWheel = false;
            this.tbAccountSetting.VerticalScrollbarSize = 10;
            // 
            // dgvAccountSetting
            // 
            this.dgvAccountSetting.AllowUserToAddRows = false;
            this.dgvAccountSetting.AllowUserToDeleteRows = false;
            this.dgvAccountSetting.AllowUserToResizeRows = false;
            this.dgvAccountSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAccountSetting.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccountSetting.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAccountSetting.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAccountSetting.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAccountSetting.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccountSetting.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAccountSetting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAccountSetting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccountSetting.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAccountSetting.EnableHeadersVisualStyles = false;
            this.dgvAccountSetting.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvAccountSetting.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAccountSetting.Location = new System.Drawing.Point(0, 74);
            this.dgvAccountSetting.Name = "dgvAccountSetting";
            this.dgvAccountSetting.ReadOnly = true;
            this.dgvAccountSetting.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccountSetting.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAccountSetting.RowHeadersVisible = false;
            this.dgvAccountSetting.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAccountSetting.RowTemplate.Height = 27;
            this.dgvAccountSetting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccountSetting.Size = new System.Drawing.Size(791, 519);
            this.dgvAccountSetting.TabIndex = 11;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Id";
            this.Column6.HeaderText = "编号";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "LoginName";
            this.Column7.HeaderText = "账号";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "IsLock";
            this.Column8.HeaderText = "是否启用";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // btnLockedAccount
            // 
            this.btnLockedAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnLockedAccount.DM_DisabledColor = System.Drawing.Color.Empty;
            this.btnLockedAccount.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(140)))), ((int)(((byte)(188)))));
            this.btnLockedAccount.DM_MoveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.btnLockedAccount.DM_NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnLockedAccount.DM_Radius = 5;
            this.btnLockedAccount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLockedAccount.ForeColor = System.Drawing.Color.White;
            this.btnLockedAccount.Image = null;
            this.btnLockedAccount.Location = new System.Drawing.Point(152, 23);
            this.btnLockedAccount.Name = "btnLockedAccount";
            this.btnLockedAccount.Size = new System.Drawing.Size(125, 45);
            this.btnLockedAccount.TabIndex = 8;
            this.btnLockedAccount.Text = "账号锁定";
            this.btnLockedAccount.UseVisualStyleBackColor = false;
            this.btnLockedAccount.Click += new System.EventHandler(this.btnLockedAccount_Click);
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnResetPassword.DM_DisabledColor = System.Drawing.Color.Empty;
            this.btnResetPassword.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(140)))), ((int)(((byte)(188)))));
            this.btnResetPassword.DM_MoveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.btnResetPassword.DM_NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnResetPassword.DM_Radius = 5;
            this.btnResetPassword.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnResetPassword.ForeColor = System.Drawing.Color.White;
            this.btnResetPassword.Image = null;
            this.btnResetPassword.Location = new System.Drawing.Point(-3, 23);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(125, 45);
            this.btnResetPassword.TabIndex = 7;
            this.btnResetPassword.Text = "重置密码";
            this.btnResetPassword.UseVisualStyleBackColor = false;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
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
            this.tpRoleSetting.Size = new System.Drawing.Size(787, 593);
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
            this.btnAuthority.Location = new System.Drawing.Point(462, 23);
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
            this.btnUpdateRole.Location = new System.Drawing.Point(152, 23);
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
            this.dgvRoleSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRoleSetting.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoleSetting.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvRoleSetting.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRoleSetting.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRoleSetting.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoleSetting.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRoleSetting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRoleSetting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.RoleName,
            this.RoleDescription});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoleSetting.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvRoleSetting.EnableHeadersVisualStyles = false;
            this.dgvRoleSetting.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvRoleSetting.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvRoleSetting.Location = new System.Drawing.Point(0, 74);
            this.dgvRoleSetting.Name = "dgvRoleSetting";
            this.dgvRoleSetting.ReadOnly = true;
            this.dgvRoleSetting.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoleSetting.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvRoleSetting.RowHeadersVisible = false;
            this.dgvRoleSetting.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvRoleSetting.RowTemplate.Height = 27;
            this.dgvRoleSetting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoleSetting.Size = new System.Drawing.Size(793, 519);
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "编号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "UserName";
            this.dataGridViewTextBoxColumn2.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Sex";
            this.dataGridViewTextBoxColumn3.HeaderText = "性别";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Age";
            this.Column1.HeaderText = "年龄";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Phone";
            this.Column2.HeaderText = "电话";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Email";
            this.Column3.HeaderText = "电子邮件";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "QQ";
            this.Column4.HeaderText = "QQ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "RoleName";
            this.Column5.HeaderText = "角色";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "RoleId";
            this.Column9.HeaderText = "RoleId";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "LoginName";
            this.Column10.HeaderText = "LoginName";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            // 
            // frmSystemSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(795, 636);
            this.Controls.Add(this.metroTabControl1);
            this.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSystemSetting";
            this.Text = "frmSystemSetting";
            this.Load += new System.EventHandler(this.frmSystemSetting_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.tpUserSetting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserSetting)).EndInit();
            this.tbAccountSetting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountSetting)).EndInit();
            this.tpRoleSetting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoleSetting)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DMSkin.Metro.Controls.MetroTabControl metroTabControl1;
        private DMSkin.Metro.Controls.MetroTabPage tpRoleSetting;
        private DMSkin.Controls.DMButton btnCreateRole;
        private DMSkin.Controls.DMButton btnAuthority;
        private DMSkin.Controls.DMButton btnDeleteRole;
        private DMSkin.Controls.DMButton btnUpdateRole;
        private DMSkin.Metro.Controls.MetroTabPage tpUserSetting;
        private DMSkin.Metro.Controls.MetroGrid dgvUserSetting;
        private DMSkin.Controls.DMButton btnaddrole;
        private DMSkin.Controls.DMButton btndeleteuser;
        private DMSkin.Controls.DMButton btnupdateuser;
        private DMSkin.Controls.DMButton btnadduser;
        private DMSkin.Metro.Controls.MetroTabPage tbAccountSetting;
        private DMSkin.Metro.Controls.MetroGrid dgvRoleSetting;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleDescription;
        private DMSkin.Controls.DMButton btnLockedAccount;
        public DMSkin.Controls.DMButton btnResetPassword;
        private DMSkin.Metro.Controls.MetroGrid dgvAccountSetting;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}