namespace LHT.CRM.App.Settings
{
    partial class frmCreateUser
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
            this.metroLabel1 = new DMSkin.Metro.Controls.MetroLabel();
            this.metroLabel2 = new DMSkin.Metro.Controls.MetroLabel();
            this.cbSex = new DMSkin.Metro.Controls.MetroComboBox();
            this.tbAge = new DMSkin.Controls.MetroTextBox();
            this.metroLabel3 = new DMSkin.Metro.Controls.MetroLabel();
            this.tbPhone = new DMSkin.Controls.MetroTextBox();
            this.metroLabel4 = new DMSkin.Metro.Controls.MetroLabel();
            this.tbEmail = new DMSkin.Controls.MetroTextBox();
            this.metroLabel5 = new DMSkin.Metro.Controls.MetroLabel();
            this.tbQQ = new DMSkin.Controls.MetroTextBox();
            this.metroLabel6 = new DMSkin.Metro.Controls.MetroLabel();
            this.metroLabel7 = new DMSkin.Metro.Controls.MetroLabel();
            this.cbRoleName = new DMSkin.Metro.Controls.MetroComboBox();
            this.btnCancel = new DMSkin.Controls.DMButton();
            this.btnEnter = new DMSkin.Controls.DMButton();
            this.tbUserName = new DMSkin.Controls.MetroTextBox();
            this.tbLoginName = new DMSkin.Controls.MetroTextBox();
            this.metroLabel8 = new DMSkin.Metro.Controls.MetroLabel();
            this.titlePromptInfo = new DMSkin.Metro.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.DM_FontSize = DMSkin.Metro.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(76, 108);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "姓名";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.DM_FontSize = DMSkin.Metro.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(76, 176);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 25);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "性别";
            // 
            // cbSex
            // 
            this.cbSex.DM_UseSelectable = true;
            this.cbSex.FormattingEnabled = true;
            this.cbSex.ItemHeight = 24;
            this.cbSex.Items.AddRange(new object[] {
            "请选择性别",
            "男",
            "女"});
            this.cbSex.Location = new System.Drawing.Point(253, 173);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(260, 30);
            this.cbSex.TabIndex = 1;
            // 
            // tbAge
            // 
            this.tbAge.BackColor = System.Drawing.Color.Transparent;
            this.tbAge.IsPassWord = false;
            this.tbAge.Location = new System.Drawing.Point(253, 237);
            this.tbAge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAge.MaximumSize = new System.Drawing.Size(260, 38);
            this.tbAge.MinimumSize = new System.Drawing.Size(260, 38);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(260, 38);
            this.tbAge.TabIndex = 2;
            this.tbAge.WaterText = "请输入年龄";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.DM_FontSize = DMSkin.Metro.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(76, 244);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(50, 25);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "年龄";
            // 
            // tbPhone
            // 
            this.tbPhone.BackColor = System.Drawing.Color.Transparent;
            this.tbPhone.IsPassWord = false;
            this.tbPhone.Location = new System.Drawing.Point(253, 309);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPhone.MaximumSize = new System.Drawing.Size(260, 38);
            this.tbPhone.MinimumSize = new System.Drawing.Size(260, 38);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(260, 38);
            this.tbPhone.TabIndex = 3;
            this.tbPhone.WaterText = "请输入电话号码";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.DM_FontSize = DMSkin.Metro.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(76, 316);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(88, 25);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "电话号码";
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.Transparent;
            this.tbEmail.IsPassWord = false;
            this.tbEmail.Location = new System.Drawing.Point(253, 381);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEmail.MaximumSize = new System.Drawing.Size(260, 38);
            this.tbEmail.MinimumSize = new System.Drawing.Size(260, 38);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(260, 38);
            this.tbEmail.TabIndex = 4;
            this.tbEmail.WaterText = "请输入电子邮件";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.DM_FontSize = DMSkin.Metro.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(76, 388);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(88, 25);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "电子邮件";
            // 
            // tbQQ
            // 
            this.tbQQ.BackColor = System.Drawing.Color.Transparent;
            this.tbQQ.IsPassWord = false;
            this.tbQQ.Location = new System.Drawing.Point(253, 453);
            this.tbQQ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbQQ.MaximumSize = new System.Drawing.Size(260, 38);
            this.tbQQ.MinimumSize = new System.Drawing.Size(260, 38);
            this.tbQQ.Name = "tbQQ";
            this.tbQQ.Size = new System.Drawing.Size(260, 38);
            this.tbQQ.TabIndex = 5;
            this.tbQQ.WaterText = "请输入QQ号码";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.DM_FontSize = DMSkin.Metro.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(76, 460);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(42, 25);
            this.metroLabel6.TabIndex = 14;
            this.metroLabel6.Text = "QQ";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.DM_FontSize = DMSkin.Metro.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(76, 532);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(50, 25);
            this.metroLabel7.TabIndex = 16;
            this.metroLabel7.Text = "角色";
            // 
            // cbRoleName
            // 
            this.cbRoleName.DM_UseSelectable = true;
            this.cbRoleName.FormattingEnabled = true;
            this.cbRoleName.ItemHeight = 24;
            this.cbRoleName.Items.AddRange(new object[] {
            "请选择用户角色",
            "达到"});
            this.cbRoleName.Location = new System.Drawing.Point(253, 529);
            this.cbRoleName.Name = "cbRoleName";
            this.cbRoleName.Size = new System.Drawing.Size(260, 30);
            this.cbRoleName.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.DM_DisabledColor = System.Drawing.Color.Empty;
            this.btnCancel.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(140)))), ((int)(((byte)(188)))));
            this.btnCancel.DM_MoveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.btnCancel.DM_NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnCancel.DM_Radius = 5;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = null;
            this.btnCancel.Location = new System.Drawing.Point(388, 678);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 45);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Transparent;
            this.btnEnter.DM_DisabledColor = System.Drawing.Color.Empty;
            this.btnEnter.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(140)))), ((int)(((byte)(188)))));
            this.btnEnter.DM_MoveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.btnEnter.DM_NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnEnter.DM_Radius = 5;
            this.btnEnter.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.Image = null;
            this.btnEnter.Location = new System.Drawing.Point(157, 678);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(125, 45);
            this.btnEnter.TabIndex = 18;
            this.btnEnter.Text = "确定";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // tbUserName
            // 
            this.tbUserName.BackColor = System.Drawing.Color.Transparent;
            this.tbUserName.IsPassWord = false;
            this.tbUserName.Location = new System.Drawing.Point(253, 102);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbUserName.MaximumSize = new System.Drawing.Size(260, 38);
            this.tbUserName.MinimumSize = new System.Drawing.Size(260, 38);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(260, 38);
            this.tbUserName.TabIndex = 0;
            this.tbUserName.WaterText = "请输入姓名";
            // 
            // tbLoginName
            // 
            this.tbLoginName.BackColor = System.Drawing.Color.Transparent;
            this.tbLoginName.IsPassWord = false;
            this.tbLoginName.Location = new System.Drawing.Point(253, 583);
            this.tbLoginName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLoginName.MaximumSize = new System.Drawing.Size(260, 38);
            this.tbLoginName.MinimumSize = new System.Drawing.Size(260, 38);
            this.tbLoginName.Name = "tbLoginName";
            this.tbLoginName.Size = new System.Drawing.Size(260, 38);
            this.tbLoginName.TabIndex = 7;
            this.tbLoginName.WaterText = "请输入登录账号";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.DM_FontSize = DMSkin.Metro.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(76, 590);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(50, 25);
            this.metroLabel8.TabIndex = 22;
            this.metroLabel8.Text = "账号";
            // 
            // titlePromptInfo
            // 
            this.titlePromptInfo.ActiveControl = null;
            this.titlePromptInfo.DM_UseSelectable = true;
            this.titlePromptInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePromptInfo.Location = new System.Drawing.Point(8, 39);
            this.titlePromptInfo.Name = "titlePromptInfo";
            this.titlePromptInfo.Size = new System.Drawing.Size(626, 39);
            this.titlePromptInfo.TabIndex = 23;
            this.titlePromptInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titlePromptInfo.Visible = false;
            // 
            // frmCreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.White;
            this.CaptionBackColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(117)))), ((int)(((byte)(180)))));
            this.CaptionBackColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(117)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(642, 751);
            this.Controls.Add(this.titlePromptInfo);
            this.Controls.Add(this.tbLoginName);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.cbRoleName);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.tbQQ);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCreateUser";
            this.ShowDrawIcon = false;
            this.Text = "添加用户信息";
            this.TitleColor = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.frmCreateUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DMSkin.Metro.Controls.MetroLabel metroLabel1;
        private DMSkin.Metro.Controls.MetroLabel metroLabel2;
        private DMSkin.Metro.Controls.MetroComboBox cbSex;
        private DMSkin.Controls.MetroTextBox tbAge;
        private DMSkin.Metro.Controls.MetroLabel metroLabel3;
        private DMSkin.Controls.MetroTextBox tbPhone;
        private DMSkin.Metro.Controls.MetroLabel metroLabel4;
        private DMSkin.Controls.MetroTextBox tbEmail;
        private DMSkin.Metro.Controls.MetroLabel metroLabel5;
        private DMSkin.Controls.MetroTextBox tbQQ;
        private DMSkin.Metro.Controls.MetroLabel metroLabel6;
        private DMSkin.Metro.Controls.MetroLabel metroLabel7;
        private DMSkin.Metro.Controls.MetroComboBox cbRoleName;
        private DMSkin.Controls.DMButton btnCancel;
        private DMSkin.Controls.DMButton btnEnter;
        private DMSkin.Controls.MetroTextBox tbUserName;
        private DMSkin.Controls.MetroTextBox tbLoginName;
        private DMSkin.Metro.Controls.MetroLabel metroLabel8;
        private DMSkin.Metro.Controls.MetroTile titlePromptInfo;
    }
}