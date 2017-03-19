namespace LHT.CRM.App.CRM
{
    partial class frmCreateVisit
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
            this.tbContent = new System.Windows.Forms.TextBox();
            this.metroLabel8 = new DMSkin.Metro.Controls.MetroLabel();
            this.metroLabel7 = new DMSkin.Metro.Controls.MetroLabel();
            this.dtVCompleteDate = new DMSkin.Metro.Controls.MetroDateTime();
            this.dtVPlanDate = new DMSkin.Metro.Controls.MetroDateTime();
            this.metroLabel6 = new DMSkin.Metro.Controls.MetroLabel();
            this.metroLabel5 = new DMSkin.Metro.Controls.MetroLabel();
            this.tbVTitle = new System.Windows.Forms.TextBox();
            this.metroLabel4 = new DMSkin.Metro.Controls.MetroLabel();
            this.metroTabPage2 = new DMSkin.Metro.Controls.MetroTabPage();
            this.metroLabel2 = new DMSkin.Metro.Controls.MetroLabel();
            this.tbCusCode = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new DMSkin.Metro.Controls.MetroLabel();
            this.tbCusName = new System.Windows.Forms.TextBox();
            this.metroLabel3 = new DMSkin.Metro.Controls.MetroLabel();
            this.tbContactName = new System.Windows.Forms.TextBox();
            this.btnSelectCustomer = new System.Windows.Forms.Button();
            this.btnSelectContact = new System.Windows.Forms.Button();
            this.btnCancel = new DMSkin.Controls.DMButton();
            this.btnEnter = new DMSkin.Controls.DMButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cbVType = new System.Windows.Forms.ComboBox();
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
            this.metroTabControl1.Location = new System.Drawing.Point(8, 160);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(707, 299);
            this.metroTabControl1.TabIndex = 0;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.cbVType);
            this.metroTabPage1.Controls.Add(this.tbContent);
            this.metroTabPage1.Controls.Add(this.metroLabel8);
            this.metroTabPage1.Controls.Add(this.metroLabel7);
            this.metroTabPage1.Controls.Add(this.dtVCompleteDate);
            this.metroTabPage1.Controls.Add(this.dtVPlanDate);
            this.metroTabPage1.Controls.Add(this.metroLabel6);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.tbVTitle);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarDM_HighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(699, 256);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "基本信息";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarDM_HighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(146, 151);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(534, 84);
            this.tbContent.TabIndex = 40;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.DM_FontSize = DMSkin.Metro.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(3, 154);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(88, 25);
            this.metroLabel8.TabIndex = 39;
            this.metroLabel8.Text = "拜访内容";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.DM_FontSize = DMSkin.Metro.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(365, 64);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(88, 25);
            this.metroLabel7.TabIndex = 37;
            this.metroLabel7.Text = "拜访方式";
            // 
            // dtVCompleteDate
            // 
            this.dtVCompleteDate.Location = new System.Drawing.Point(146, 105);
            this.dtVCompleteDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtVCompleteDate.Name = "dtVCompleteDate";
            this.dtVCompleteDate.Size = new System.Drawing.Size(200, 30);
            this.dtVCompleteDate.TabIndex = 36;
            // 
            // dtVPlanDate
            // 
            this.dtVPlanDate.Location = new System.Drawing.Point(146, 63);
            this.dtVPlanDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtVPlanDate.Name = "dtVPlanDate";
            this.dtVPlanDate.Size = new System.Drawing.Size(200, 30);
            this.dtVPlanDate.TabIndex = 35;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.DM_FontSize = DMSkin.Metro.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(3, 109);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(88, 25);
            this.metroLabel6.TabIndex = 34;
            this.metroLabel6.Text = "完成日期";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.DM_FontSize = DMSkin.Metro.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(0, 67);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(88, 25);
            this.metroLabel5.TabIndex = 33;
            this.metroLabel5.Text = "计划日期";
            // 
            // tbVTitle
            // 
            this.tbVTitle.Location = new System.Drawing.Point(146, 19);
            this.tbVTitle.Name = "tbVTitle";
            this.tbVTitle.Size = new System.Drawing.Size(534, 25);
            this.tbVTitle.TabIndex = 32;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.DM_FontSize = DMSkin.Metro.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(0, 23);
            this.metroLabel4.MinimumSize = new System.Drawing.Size(50, 25);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(88, 25);
            this.metroLabel4.TabIndex = 31;
            this.metroLabel4.Text = "拜访目的";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.textBox3);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarDM_HighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(636, 256);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "批示内容";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarDM_HighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.DM_FontSize = DMSkin.Metro.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(12, 67);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(88, 25);
            this.metroLabel2.TabIndex = 30;
            this.metroLabel2.Text = "客户编码";
            // 
            // tbCusCode
            // 
            this.tbCusCode.Location = new System.Drawing.Point(120, 67);
            this.tbCusCode.Multiline = true;
            this.tbCusCode.Name = "tbCusCode";
            this.tbCusCode.Size = new System.Drawing.Size(104, 25);
            this.tbCusCode.TabIndex = 31;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.DM_FontSize = DMSkin.Metro.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(311, 67);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 25);
            this.metroLabel1.TabIndex = 32;
            this.metroLabel1.Text = "客户名称";
            // 
            // tbCusName
            // 
            this.tbCusName.Location = new System.Drawing.Point(451, 67);
            this.tbCusName.Multiline = true;
            this.tbCusName.Name = "tbCusName";
            this.tbCusName.Size = new System.Drawing.Size(241, 25);
            this.tbCusName.TabIndex = 33;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.DM_FontSize = DMSkin.Metro.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(12, 117);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(69, 25);
            this.metroLabel3.TabIndex = 34;
            this.metroLabel3.Text = "联系人";
            // 
            // tbContactName
            // 
            this.tbContactName.Location = new System.Drawing.Point(120, 117);
            this.tbContactName.Name = "tbContactName";
            this.tbContactName.Size = new System.Drawing.Size(104, 25);
            this.tbContactName.TabIndex = 35;
            // 
            // btnSelectCustomer
            // 
            this.btnSelectCustomer.Location = new System.Drawing.Point(256, 67);
            this.btnSelectCustomer.Name = "btnSelectCustomer";
            this.btnSelectCustomer.Size = new System.Drawing.Size(49, 25);
            this.btnSelectCustomer.TabIndex = 36;
            this.btnSelectCustomer.Text = "...";
            this.btnSelectCustomer.UseVisualStyleBackColor = true;
            // 
            // btnSelectContact
            // 
            this.btnSelectContact.Location = new System.Drawing.Point(256, 117);
            this.btnSelectContact.Name = "btnSelectContact";
            this.btnSelectContact.Size = new System.Drawing.Size(49, 25);
            this.btnSelectContact.TabIndex = 37;
            this.btnSelectContact.Text = "...";
            this.btnSelectContact.UseVisualStyleBackColor = true;
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
            this.btnCancel.Location = new System.Drawing.Point(567, 465);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 45);
            this.btnCancel.TabIndex = 39;
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
            this.btnEnter.Location = new System.Drawing.Point(336, 465);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(125, 45);
            this.btnEnter.TabIndex = 38;
            this.btnEnter.Text = "确定";
            this.btnEnter.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(0, 0);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(636, 256);
            this.textBox3.TabIndex = 2;
            // 
            // cbVType
            // 
            this.cbVType.FormattingEnabled = true;
            this.cbVType.Location = new System.Drawing.Point(475, 69);
            this.cbVType.Name = "cbVType";
            this.cbVType.Size = new System.Drawing.Size(205, 23);
            this.cbVType.TabIndex = 41;
            // 
            // frmCreateVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.White;
            this.CaptionBackColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(117)))), ((int)(((byte)(180)))));
            this.CaptionBackColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(117)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(718, 544);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnSelectContact);
            this.Controls.Add(this.btnSelectCustomer);
            this.Controls.Add(this.tbContactName);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.tbCusName);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tbCusCode);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCreateVisit";
            this.ShowDrawIcon = false;
            this.Text = "拜访记录";
            this.TitleColor = System.Drawing.Color.White;
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DMSkin.Metro.Controls.MetroTabControl metroTabControl1;
        private DMSkin.Metro.Controls.MetroTabPage metroTabPage1;
        private DMSkin.Metro.Controls.MetroTabPage metroTabPage2;
        private DMSkin.Metro.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TextBox tbCusCode;
        private DMSkin.Metro.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox tbCusName;
        private DMSkin.Metro.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.TextBox tbContactName;
        private System.Windows.Forms.Button btnSelectCustomer;
        private System.Windows.Forms.Button btnSelectContact;
        private System.Windows.Forms.TextBox tbContent;
        private DMSkin.Metro.Controls.MetroLabel metroLabel8;
        private DMSkin.Metro.Controls.MetroLabel metroLabel7;
        private DMSkin.Metro.Controls.MetroDateTime dtVCompleteDate;
        private DMSkin.Metro.Controls.MetroDateTime dtVPlanDate;
        private DMSkin.Metro.Controls.MetroLabel metroLabel6;
        private DMSkin.Metro.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.TextBox tbVTitle;
        private DMSkin.Metro.Controls.MetroLabel metroLabel4;
        private DMSkin.Controls.DMButton btnCancel;
        private DMSkin.Controls.DMButton btnEnter;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox cbVType;
    }
}