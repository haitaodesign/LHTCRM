namespace LHT.CRM.App.CRM
{
    partial class frmCreateCustomer
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
            this.metrotabcontrol = new DMSkin.Metro.Controls.MetroTabControl();
            this.tpAddCusMainInfo = new DMSkin.Metro.Controls.MetroTabPage();
            this.cbUserName = new DMSkin.Metro.Controls.MetroComboBox();
            this.tbCusCode = new DMSkin.Controls.MetroTextBox();
            this.tbPhoneNum = new DMSkin.Controls.MetroTextBox();
            this.metroLabel9 = new DMSkin.Metro.Controls.MetroLabel();
            this.tbCusName = new DMSkin.Controls.MetroTextBox();
            this.metroLabel3 = new DMSkin.Metro.Controls.MetroLabel();
            this.metroLabel1 = new DMSkin.Metro.Controls.MetroLabel();
            this.metroLabel2 = new DMSkin.Metro.Controls.MetroLabel();
            this.tpAddCusBaseInfo = new DMSkin.Metro.Controls.MetroTabPage();
            this.tbProvince = new DMSkin.Controls.MetroTextBox();
            this.tbAddress = new DMSkin.Controls.MetroTextBox();
            this.metroLabel11 = new DMSkin.Metro.Controls.MetroLabel();
            this.tbHomePage = new DMSkin.Controls.MetroTextBox();
            this.metroLabel10 = new DMSkin.Metro.Controls.MetroLabel();
            this.cbScale = new DMSkin.Metro.Controls.MetroComboBox();
            this.cbBussinessType = new DMSkin.Metro.Controls.MetroComboBox();
            this.cbCusType = new DMSkin.Metro.Controls.MetroComboBox();
            this.tbCity = new DMSkin.Controls.MetroTextBox();
            this.metroLabel8 = new DMSkin.Metro.Controls.MetroLabel();
            this.metroLabel7 = new DMSkin.Metro.Controls.MetroLabel();
            this.metroLabel6 = new DMSkin.Metro.Controls.MetroLabel();
            this.metroLabel5 = new DMSkin.Metro.Controls.MetroLabel();
            this.metroLabel4 = new DMSkin.Metro.Controls.MetroLabel();
            this.btnCancel = new DMSkin.Controls.DMButton();
            this.btnEnter = new DMSkin.Controls.DMButton();
            this.metrotabcontrol.SuspendLayout();
            this.tpAddCusMainInfo.SuspendLayout();
            this.tpAddCusBaseInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // metrotabcontrol
            // 
            this.metrotabcontrol.Controls.Add(this.tpAddCusMainInfo);
            this.metrotabcontrol.Controls.Add(this.tpAddCusBaseInfo);
            this.metrotabcontrol.DM_UseSelectable = true;
            this.metrotabcontrol.Dock = System.Windows.Forms.DockStyle.Top;
            this.metrotabcontrol.Location = new System.Drawing.Point(8, 39);
            this.metrotabcontrol.Name = "metrotabcontrol";
            this.metrotabcontrol.SelectedIndex = 1;
            this.metrotabcontrol.Size = new System.Drawing.Size(662, 468);
            this.metrotabcontrol.TabIndex = 0;
            // 
            // tpAddCusMainInfo
            // 
            this.tpAddCusMainInfo.Controls.Add(this.cbUserName);
            this.tpAddCusMainInfo.Controls.Add(this.tbCusCode);
            this.tpAddCusMainInfo.Controls.Add(this.tbPhoneNum);
            this.tpAddCusMainInfo.Controls.Add(this.metroLabel9);
            this.tpAddCusMainInfo.Controls.Add(this.tbCusName);
            this.tpAddCusMainInfo.Controls.Add(this.metroLabel3);
            this.tpAddCusMainInfo.Controls.Add(this.metroLabel1);
            this.tpAddCusMainInfo.Controls.Add(this.metroLabel2);
            this.tpAddCusMainInfo.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tpAddCusMainInfo.HorizontalScrollbarBarColor = true;
            this.tpAddCusMainInfo.HorizontalScrollbarDM_HighlightOnWheel = false;
            this.tpAddCusMainInfo.HorizontalScrollbarSize = 10;
            this.tpAddCusMainInfo.Location = new System.Drawing.Point(4, 39);
            this.tpAddCusMainInfo.Name = "tpAddCusMainInfo";
            this.tpAddCusMainInfo.Size = new System.Drawing.Size(654, 425);
            this.tpAddCusMainInfo.TabIndex = 0;
            this.tpAddCusMainInfo.Text = "主要信息";
            this.tpAddCusMainInfo.VerticalScrollbarBarColor = true;
            this.tpAddCusMainInfo.VerticalScrollbarDM_HighlightOnWheel = false;
            this.tpAddCusMainInfo.VerticalScrollbarSize = 10;
            // 
            // cbUserName
            // 
            this.cbUserName.DM_UseSelectable = true;
            this.cbUserName.FormattingEnabled = true;
            this.cbUserName.ItemHeight = 24;
            this.cbUserName.Items.AddRange(new object[] {
            "李四",
            "张三"});
            this.cbUserName.Location = new System.Drawing.Point(217, 307);
            this.cbUserName.Name = "cbUserName";
            this.cbUserName.Size = new System.Drawing.Size(260, 30);
            this.cbUserName.TabIndex = 22;
            // 
            // tbCusCode
            // 
            this.tbCusCode.BackColor = System.Drawing.Color.Transparent;
            this.tbCusCode.IsPassWord = false;
            this.tbCusCode.Location = new System.Drawing.Point(217, 59);
            this.tbCusCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCusCode.MaximumSize = new System.Drawing.Size(260, 38);
            this.tbCusCode.MinimumSize = new System.Drawing.Size(260, 38);
            this.tbCusCode.Name = "tbCusCode";
            this.tbCusCode.Size = new System.Drawing.Size(260, 38);
            this.tbCusCode.TabIndex = 13;
            this.tbCusCode.WaterText = "请输入客户编码";
            // 
            // tbPhoneNum
            // 
            this.tbPhoneNum.BackColor = System.Drawing.Color.Transparent;
            this.tbPhoneNum.IsPassWord = false;
            this.tbPhoneNum.Location = new System.Drawing.Point(217, 229);
            this.tbPhoneNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPhoneNum.MaximumSize = new System.Drawing.Size(260, 38);
            this.tbPhoneNum.MinimumSize = new System.Drawing.Size(260, 38);
            this.tbPhoneNum.Name = "tbPhoneNum";
            this.tbPhoneNum.Size = new System.Drawing.Size(260, 38);
            this.tbPhoneNum.TabIndex = 12;
            this.tbPhoneNum.WaterText = "请输入客户电话";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.DM_FontSize = DMSkin.Metro.MetroLabelSize.Tall;
            this.metroLabel9.Location = new System.Drawing.Point(86, 242);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(50, 25);
            this.metroLabel9.TabIndex = 11;
            this.metroLabel9.Text = "电话";
            // 
            // tbCusName
            // 
            this.tbCusName.BackColor = System.Drawing.Color.Transparent;
            this.tbCusName.IsPassWord = false;
            this.tbCusName.Location = new System.Drawing.Point(217, 146);
            this.tbCusName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCusName.MaximumSize = new System.Drawing.Size(260, 38);
            this.tbCusName.MinimumSize = new System.Drawing.Size(260, 38);
            this.tbCusName.Name = "tbCusName";
            this.tbCusName.Size = new System.Drawing.Size(260, 38);
            this.tbCusName.TabIndex = 8;
            this.tbCusName.WaterText = "请输入全称";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.DM_FontSize = DMSkin.Metro.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(86, 159);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(88, 25);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "客户名称";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.DM_FontSize = DMSkin.Metro.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(86, 307);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 25);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "业务员";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.DM_FontSize = DMSkin.Metro.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(86, 72);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(88, 25);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "客户编码";
            // 
            // tpAddCusBaseInfo
            // 
            this.tpAddCusBaseInfo.Controls.Add(this.tbProvince);
            this.tpAddCusBaseInfo.Controls.Add(this.tbAddress);
            this.tpAddCusBaseInfo.Controls.Add(this.metroLabel11);
            this.tpAddCusBaseInfo.Controls.Add(this.tbHomePage);
            this.tpAddCusBaseInfo.Controls.Add(this.metroLabel10);
            this.tpAddCusBaseInfo.Controls.Add(this.cbScale);
            this.tpAddCusBaseInfo.Controls.Add(this.cbBussinessType);
            this.tpAddCusBaseInfo.Controls.Add(this.cbCusType);
            this.tpAddCusBaseInfo.Controls.Add(this.tbCity);
            this.tpAddCusBaseInfo.Controls.Add(this.metroLabel8);
            this.tpAddCusBaseInfo.Controls.Add(this.metroLabel7);
            this.tpAddCusBaseInfo.Controls.Add(this.metroLabel6);
            this.tpAddCusBaseInfo.Controls.Add(this.metroLabel5);
            this.tpAddCusBaseInfo.Controls.Add(this.metroLabel4);
            this.tpAddCusBaseInfo.HorizontalScrollbarBarColor = true;
            this.tpAddCusBaseInfo.HorizontalScrollbarDM_HighlightOnWheel = false;
            this.tpAddCusBaseInfo.HorizontalScrollbarSize = 10;
            this.tpAddCusBaseInfo.Location = new System.Drawing.Point(4, 39);
            this.tpAddCusBaseInfo.Name = "tpAddCusBaseInfo";
            this.tpAddCusBaseInfo.Size = new System.Drawing.Size(654, 425);
            this.tpAddCusBaseInfo.TabIndex = 1;
            this.tpAddCusBaseInfo.Text = "基本信息";
            this.tpAddCusBaseInfo.VerticalScrollbarBarColor = true;
            this.tpAddCusBaseInfo.VerticalScrollbarDM_HighlightOnWheel = false;
            this.tpAddCusBaseInfo.VerticalScrollbarSize = 10;
            // 
            // tbProvince
            // 
            this.tbProvince.BackColor = System.Drawing.Color.Transparent;
            this.tbProvince.IsPassWord = false;
            this.tbProvince.Location = new System.Drawing.Point(235, 22);
            this.tbProvince.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbProvince.MaximumSize = new System.Drawing.Size(260, 38);
            this.tbProvince.MinimumSize = new System.Drawing.Size(260, 38);
            this.tbProvince.Name = "tbProvince";
            this.tbProvince.Size = new System.Drawing.Size(260, 38);
            this.tbProvince.TabIndex = 28;
            this.tbProvince.WaterText = "请输入客户省份";
            // 
            // tbAddress
            // 
            this.tbAddress.BackColor = System.Drawing.Color.Transparent;
            this.tbAddress.IsPassWord = false;
            this.tbAddress.Location = new System.Drawing.Point(235, 365);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAddress.MaximumSize = new System.Drawing.Size(260, 38);
            this.tbAddress.MinimumSize = new System.Drawing.Size(260, 38);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(260, 38);
            this.tbAddress.TabIndex = 27;
            this.tbAddress.WaterText = "请输入详细地址";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.DM_FontSize = DMSkin.Metro.MetroLabelSize.Tall;
            this.metroLabel11.Location = new System.Drawing.Point(86, 378);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(50, 25);
            this.metroLabel11.TabIndex = 26;
            this.metroLabel11.Text = "地址";
            // 
            // tbHomePage
            // 
            this.tbHomePage.BackColor = System.Drawing.Color.Transparent;
            this.tbHomePage.IsPassWord = false;
            this.tbHomePage.Location = new System.Drawing.Point(235, 314);
            this.tbHomePage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbHomePage.MaximumSize = new System.Drawing.Size(260, 38);
            this.tbHomePage.MinimumSize = new System.Drawing.Size(260, 38);
            this.tbHomePage.Name = "tbHomePage";
            this.tbHomePage.Size = new System.Drawing.Size(260, 38);
            this.tbHomePage.TabIndex = 25;
            this.tbHomePage.WaterText = "请输入公司网址";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.DM_FontSize = DMSkin.Metro.MetroLabelSize.Tall;
            this.metroLabel10.Location = new System.Drawing.Point(86, 327);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(50, 25);
            this.metroLabel10.TabIndex = 24;
            this.metroLabel10.Text = "网址";
            // 
            // cbScale
            // 
            this.cbScale.DM_UseSelectable = true;
            this.cbScale.FormattingEnabled = true;
            this.cbScale.ItemHeight = 24;
            this.cbScale.Items.AddRange(new object[] {
            "10人以上",
            "50人以上",
            "100人以上"});
            this.cbScale.Location = new System.Drawing.Point(235, 265);
            this.cbScale.Name = "cbScale";
            this.cbScale.Size = new System.Drawing.Size(260, 30);
            this.cbScale.TabIndex = 23;
            // 
            // cbBussinessType
            // 
            this.cbBussinessType.DM_UseSelectable = true;
            this.cbBussinessType.FormattingEnabled = true;
            this.cbBussinessType.ItemHeight = 24;
            this.cbBussinessType.Items.AddRange(new object[] {
            "制造业",
            "金融",
            "房地产"});
            this.cbBussinessType.Location = new System.Drawing.Point(235, 148);
            this.cbBussinessType.Name = "cbBussinessType";
            this.cbBussinessType.Size = new System.Drawing.Size(260, 30);
            this.cbBussinessType.TabIndex = 22;
            // 
            // cbCusType
            // 
            this.cbCusType.DM_UseSelectable = true;
            this.cbCusType.FormattingEnabled = true;
            this.cbCusType.ItemHeight = 24;
            this.cbCusType.Items.AddRange(new object[] {
            "国企",
            "合资",
            "私有"});
            this.cbCusType.Location = new System.Drawing.Point(235, 211);
            this.cbCusType.Name = "cbCusType";
            this.cbCusType.Size = new System.Drawing.Size(260, 30);
            this.cbCusType.TabIndex = 21;
            // 
            // tbCity
            // 
            this.tbCity.BackColor = System.Drawing.Color.Transparent;
            this.tbCity.IsPassWord = false;
            this.tbCity.Location = new System.Drawing.Point(235, 81);
            this.tbCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCity.MaximumSize = new System.Drawing.Size(260, 38);
            this.tbCity.MinimumSize = new System.Drawing.Size(260, 38);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(260, 38);
            this.tbCity.TabIndex = 20;
            this.tbCity.WaterText = "请输入客户城市";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.DM_FontSize = DMSkin.Metro.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(86, 270);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(50, 25);
            this.metroLabel8.TabIndex = 17;
            this.metroLabel8.Text = "规模";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.DM_FontSize = DMSkin.Metro.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(86, 216);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(50, 25);
            this.metroLabel7.TabIndex = 15;
            this.metroLabel7.Text = "类型";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.DM_FontSize = DMSkin.Metro.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(86, 153);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(50, 25);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "行业";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.DM_FontSize = DMSkin.Metro.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(86, 94);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(50, 25);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "城市";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.DM_FontSize = DMSkin.Metro.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(86, 35);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(50, 25);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "省份";
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
            this.btnCancel.Location = new System.Drawing.Point(478, 527);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 45);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
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
            this.btnEnter.Location = new System.Drawing.Point(247, 527);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(125, 45);
            this.btnEnter.TabIndex = 20;
            this.btnEnter.Text = "确定";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // frmCreateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.White;
            this.CaptionBackColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(117)))), ((int)(((byte)(180)))));
            this.CaptionBackColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(117)))), ((int)(((byte)(180)))));
            this.CaptionFont = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClientSize = new System.Drawing.Size(678, 583);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.metrotabcontrol);
            this.Name = "frmCreateCustomer";
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.Text = "添加客户信息";
            this.TitleColor = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.frmCreateCustomer_Load);
            this.metrotabcontrol.ResumeLayout(false);
            this.tpAddCusMainInfo.ResumeLayout(false);
            this.tpAddCusMainInfo.PerformLayout();
            this.tpAddCusBaseInfo.ResumeLayout(false);
            this.tpAddCusBaseInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DMSkin.Metro.Controls.MetroTabControl metrotabcontrol;
        private DMSkin.Metro.Controls.MetroTabPage tpAddCusMainInfo;
        private DMSkin.Metro.Controls.MetroTabPage tpAddCusBaseInfo;
        private DMSkin.Controls.DMButton btnCancel;
        private DMSkin.Controls.DMButton btnEnter;
        private DMSkin.Metro.Controls.MetroLabel metroLabel3;
        private DMSkin.Metro.Controls.MetroLabel metroLabel1;
        private DMSkin.Metro.Controls.MetroLabel metroLabel2;
        private DMSkin.Controls.MetroTextBox tbCusName;
        private DMSkin.Metro.Controls.MetroLabel metroLabel8;
        private DMSkin.Metro.Controls.MetroLabel metroLabel7;
        private DMSkin.Metro.Controls.MetroLabel metroLabel6;
        private DMSkin.Metro.Controls.MetroLabel metroLabel5;
        private DMSkin.Metro.Controls.MetroLabel metroLabel4;
        private DMSkin.Controls.MetroTextBox tbPhoneNum;
        private DMSkin.Metro.Controls.MetroLabel metroLabel9;
        private DMSkin.Controls.MetroTextBox tbAddress;
        private DMSkin.Metro.Controls.MetroLabel metroLabel11;
        private DMSkin.Controls.MetroTextBox tbHomePage;
        private DMSkin.Metro.Controls.MetroLabel metroLabel10;
        private DMSkin.Metro.Controls.MetroComboBox cbScale;
        private DMSkin.Metro.Controls.MetroComboBox cbBussinessType;
        private DMSkin.Metro.Controls.MetroComboBox cbCusType;
        private DMSkin.Controls.MetroTextBox tbCity;
        private DMSkin.Controls.MetroTextBox tbCusCode;
        private DMSkin.Controls.MetroTextBox tbProvince;
        private DMSkin.Metro.Controls.MetroComboBox cbUserName;
    }
}