﻿namespace LHT.CRM.App.CRM
{
    partial class frmCreateContact
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
            this.metroTabControl1 = new DMSkin.Metro.Controls.MetroTabControl();
            this.metroTabPage1 = new DMSkin.Metro.Controls.MetroTabPage();
            this.tbMobile = new DMSkin.Controls.MetroTextBox();
            this.tbCusName = new DMSkin.Controls.MetroTextBox();
            this.metroLabel8 = new DMSkin.Metro.Controls.MetroLabel();
            this.tbName = new DMSkin.Controls.MetroTextBox();
            this.tbPosition = new DMSkin.Controls.MetroTextBox();
            this.tbDeptName = new DMSkin.Controls.MetroTextBox();
            this.metroLabel9 = new DMSkin.Metro.Controls.MetroLabel();
            this.metroLabel3 = new DMSkin.Metro.Controls.MetroLabel();
            this.metroLabel1 = new DMSkin.Metro.Controls.MetroLabel();
            this.metroLabel2 = new DMSkin.Metro.Controls.MetroLabel();
            this.metroTabPage2 = new DMSkin.Metro.Controls.MetroTabPage();
            this.tbWX = new DMSkin.Controls.MetroTextBox();
            this.tbJiGuan = new DMSkin.Controls.MetroTextBox();
            this.cbGender = new DMSkin.Metro.Controls.MetroComboBox();
            this.tbEmail = new DMSkin.Controls.MetroTextBox();
            this.metroLabel4 = new DMSkin.Metro.Controls.MetroLabel();
            this.metroLabel5 = new DMSkin.Metro.Controls.MetroLabel();
            this.metroLabel6 = new DMSkin.Metro.Controls.MetroLabel();
            this.metroLabel7 = new DMSkin.Metro.Controls.MetroLabel();
            this.btnCancel = new DMSkin.Controls.DMButton();
            this.btnEnter = new DMSkin.Controls.DMButton();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.DM_UseSelectable = true;
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroTabControl1.Location = new System.Drawing.Point(8, 39);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(662, 443);
            this.metroTabControl1.TabIndex = 0;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.tbMobile);
            this.metroTabPage1.Controls.Add(this.tbCusName);
            this.metroTabPage1.Controls.Add(this.metroLabel8);
            this.metroTabPage1.Controls.Add(this.tbName);
            this.metroTabPage1.Controls.Add(this.tbPosition);
            this.metroTabPage1.Controls.Add(this.tbDeptName);
            this.metroTabPage1.Controls.Add(this.metroLabel9);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarDM_HighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(654, 400);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "主要信息";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarDM_HighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // tbMobile
            // 
            this.tbMobile.BackColor = System.Drawing.Color.Transparent;
            this.tbMobile.IsPassWord = false;
            this.tbMobile.Location = new System.Drawing.Point(198, 277);
            this.tbMobile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMobile.MaximumSize = new System.Drawing.Size(260, 38);
            this.tbMobile.MinimumSize = new System.Drawing.Size(260, 38);
            this.tbMobile.Name = "tbMobile";
            this.tbMobile.Size = new System.Drawing.Size(260, 38);
            this.tbMobile.TabIndex = 36;
            this.tbMobile.WaterText = "请输入联系人电话";
            // 
            // tbCusName
            // 
            this.tbCusName.BackColor = System.Drawing.Color.Transparent;
            this.tbCusName.IsPassWord = false;
            this.tbCusName.Location = new System.Drawing.Point(198, 347);
            this.tbCusName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCusName.MaximumSize = new System.Drawing.Size(260, 38);
            this.tbCusName.MinimumSize = new System.Drawing.Size(260, 38);
            this.tbCusName.Name = "tbCusName";
            this.tbCusName.Size = new System.Drawing.Size(260, 38);
            this.tbCusName.TabIndex = 35;
            this.tbCusName.WaterText = "请输入客户名称";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.DM_FontSize = DMSkin.Metro.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(76, 350);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(88, 25);
            this.metroLabel8.TabIndex = 34;
            this.metroLabel8.Text = "客户名称";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.Transparent;
            this.tbName.IsPassWord = false;
            this.tbName.Location = new System.Drawing.Point(198, 51);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbName.MaximumSize = new System.Drawing.Size(260, 38);
            this.tbName.MinimumSize = new System.Drawing.Size(260, 38);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(260, 38);
            this.tbName.TabIndex = 33;
            this.tbName.WaterText = "请输入联系人姓名";
            // 
            // tbPosition
            // 
            this.tbPosition.BackColor = System.Drawing.Color.Transparent;
            this.tbPosition.IsPassWord = false;
            this.tbPosition.Location = new System.Drawing.Point(198, 199);
            this.tbPosition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPosition.MaximumSize = new System.Drawing.Size(260, 38);
            this.tbPosition.MinimumSize = new System.Drawing.Size(260, 38);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(260, 38);
            this.tbPosition.TabIndex = 32;
            this.tbPosition.WaterText = "请输入联系人职位";
            // 
            // tbDeptName
            // 
            this.tbDeptName.BackColor = System.Drawing.Color.Transparent;
            this.tbDeptName.IsPassWord = false;
            this.tbDeptName.Location = new System.Drawing.Point(198, 123);
            this.tbDeptName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDeptName.MaximumSize = new System.Drawing.Size(260, 38);
            this.tbDeptName.MinimumSize = new System.Drawing.Size(260, 38);
            this.tbDeptName.Name = "tbDeptName";
            this.tbDeptName.Size = new System.Drawing.Size(260, 38);
            this.tbDeptName.TabIndex = 31;
            this.tbDeptName.WaterText = "请输入联系人部门";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.DM_FontSize = DMSkin.Metro.MetroLabelSize.Tall;
            this.metroLabel9.Location = new System.Drawing.Point(76, 212);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(50, 25);
            this.metroLabel9.TabIndex = 27;
            this.metroLabel9.Text = "职位";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.DM_FontSize = DMSkin.Metro.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(76, 134);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(50, 25);
            this.metroLabel3.TabIndex = 25;
            this.metroLabel3.Text = "部门";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.DM_FontSize = DMSkin.Metro.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(76, 290);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 25);
            this.metroLabel1.TabIndex = 24;
            this.metroLabel1.Text = "手机";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.DM_FontSize = DMSkin.Metro.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(76, 56);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 25);
            this.metroLabel2.TabIndex = 23;
            this.metroLabel2.Text = "姓名";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.tbWX);
            this.metroTabPage2.Controls.Add(this.tbJiGuan);
            this.metroTabPage2.Controls.Add(this.cbGender);
            this.metroTabPage2.Controls.Add(this.tbEmail);
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.Controls.Add(this.metroLabel5);
            this.metroTabPage2.Controls.Add(this.metroLabel6);
            this.metroTabPage2.Controls.Add(this.metroLabel7);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarDM_HighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(654, 400);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "基本信息";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarDM_HighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // tbWX
            // 
            this.tbWX.BackColor = System.Drawing.Color.Transparent;
            this.tbWX.IsPassWord = false;
            this.tbWX.Location = new System.Drawing.Point(197, 211);
            this.tbWX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbWX.MaximumSize = new System.Drawing.Size(260, 38);
            this.tbWX.MinimumSize = new System.Drawing.Size(260, 38);
            this.tbWX.Name = "tbWX";
            this.tbWX.Size = new System.Drawing.Size(260, 38);
            this.tbWX.TabIndex = 40;
            this.tbWX.WaterText = "请输入联系人微信";
            // 
            // tbJiGuan
            // 
            this.tbJiGuan.BackColor = System.Drawing.Color.Transparent;
            this.tbJiGuan.IsPassWord = false;
            this.tbJiGuan.Location = new System.Drawing.Point(197, 128);
            this.tbJiGuan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbJiGuan.MaximumSize = new System.Drawing.Size(260, 38);
            this.tbJiGuan.MinimumSize = new System.Drawing.Size(260, 38);
            this.tbJiGuan.Name = "tbJiGuan";
            this.tbJiGuan.Size = new System.Drawing.Size(260, 38);
            this.tbJiGuan.TabIndex = 39;
            this.tbJiGuan.WaterText = "请输入联系人籍贯";
            // 
            // cbGender
            // 
            this.cbGender.DM_UseSelectable = true;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.ItemHeight = 24;
            this.cbGender.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbGender.Location = new System.Drawing.Point(197, 47);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(260, 30);
            this.cbGender.TabIndex = 38;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.Transparent;
            this.tbEmail.IsPassWord = false;
            this.tbEmail.Location = new System.Drawing.Point(197, 306);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEmail.MaximumSize = new System.Drawing.Size(260, 38);
            this.tbEmail.MinimumSize = new System.Drawing.Size(260, 38);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(260, 38);
            this.tbEmail.TabIndex = 37;
            this.tbEmail.WaterText = "请输入联系人电子邮件";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.DM_FontSize = DMSkin.Metro.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(76, 222);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(50, 25);
            this.metroLabel4.TabIndex = 35;
            this.metroLabel4.Text = "微信";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.DM_FontSize = DMSkin.Metro.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(76, 137);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(50, 25);
            this.metroLabel5.TabIndex = 33;
            this.metroLabel5.Text = "籍贯";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.DM_FontSize = DMSkin.Metro.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(76, 307);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(50, 25);
            this.metroLabel6.TabIndex = 32;
            this.metroLabel6.Text = "邮箱";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.DM_FontSize = DMSkin.Metro.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(76, 52);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(50, 25);
            this.metroLabel7.TabIndex = 31;
            this.metroLabel7.Text = "性别";
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
            this.btnCancel.Location = new System.Drawing.Point(506, 509);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 45);
            this.btnCancel.TabIndex = 23;
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
            this.btnEnter.Location = new System.Drawing.Point(275, 509);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(125, 45);
            this.btnEnter.TabIndex = 22;
            this.btnEnter.Text = "确定";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // frmCreateContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.White;
            this.CaptionBackColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(117)))), ((int)(((byte)(180)))));
            this.CaptionBackColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(117)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(678, 583);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.metroTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCreateContact";
            this.ShowDrawIcon = false;
            this.Text = "添加联系人";
            this.TitleColor = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.frmCreateContact_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DMSkin.Metro.Controls.MetroTabControl metroTabControl1;
        private DMSkin.Metro.Controls.MetroTabPage metroTabPage1;
        private DMSkin.Metro.Controls.MetroTabPage metroTabPage2;
        private DMSkin.Metro.Controls.MetroLabel metroLabel9;
        private DMSkin.Metro.Controls.MetroLabel metroLabel3;
        private DMSkin.Metro.Controls.MetroLabel metroLabel1;
        private DMSkin.Metro.Controls.MetroLabel metroLabel2;
        private DMSkin.Metro.Controls.MetroComboBox cbGender;
        private DMSkin.Controls.MetroTextBox tbEmail;
        private DMSkin.Metro.Controls.MetroLabel metroLabel4;
        private DMSkin.Metro.Controls.MetroLabel metroLabel5;
        private DMSkin.Metro.Controls.MetroLabel metroLabel6;
        private DMSkin.Metro.Controls.MetroLabel metroLabel7;
        private DMSkin.Controls.MetroTextBox tbDeptName;
        private DMSkin.Controls.MetroTextBox tbJiGuan;
        private DMSkin.Controls.MetroTextBox tbPosition;
        private DMSkin.Controls.DMButton btnCancel;
        private DMSkin.Controls.DMButton btnEnter;
        private DMSkin.Controls.MetroTextBox tbName;
        private DMSkin.Controls.MetroTextBox tbWX;
        private DMSkin.Controls.MetroTextBox tbMobile;
        private DMSkin.Controls.MetroTextBox tbCusName;
        private DMSkin.Metro.Controls.MetroLabel metroLabel8;
    }
}