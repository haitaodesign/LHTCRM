namespace LHT.CRM.App
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.dmButton1 = new DMSkin.Controls.DMButton();
            this.dmButtonCloseLight1 = new DMSkin.Controls.DMButtonCloseLight();
            this.dmButtonMinLight1 = new DMSkin.Controls.DMButtonMinLight();
            this.dmTextBox1 = new DMSkin.Controls.DMTextBox();
            this.dmTextBox2 = new DMSkin.Controls.DMTextBox();
            this.dmButtonCloseLight2 = new DMSkin.Controls.DMButtonCloseLight();
            this.dmButtonMinLight2 = new DMSkin.Controls.DMButtonMinLight();
            this.SuspendLayout();
            // 
            // dmButton1
            // 
            this.dmButton1.BackColor = System.Drawing.Color.Transparent;
            this.dmButton1.DM_DisabledColor = System.Drawing.Color.Empty;
            this.dmButton1.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(160)))), ((int)(((byte)(230)))));
            this.dmButton1.DM_MoveColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.dmButton1.DM_NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(117)))), ((int)(((byte)(180)))));
            this.dmButton1.DM_Radius = 1;
            this.dmButton1.Image = null;
            this.dmButton1.Location = new System.Drawing.Point(113, 243);
            this.dmButton1.Name = "dmButton1";
            this.dmButton1.Size = new System.Drawing.Size(266, 27);
            this.dmButton1.TabIndex = 0;
            this.dmButton1.Text = "登录";
            this.dmButton1.UseVisualStyleBackColor = false;
            // 
            // dmButtonCloseLight1
            // 
            this.dmButtonCloseLight1.BackColor = System.Drawing.Color.Transparent;
            this.dmButtonCloseLight1.Location = new System.Drawing.Point(803, 8);
            this.dmButtonCloseLight1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.dmButtonCloseLight1.MaximumSize = new System.Drawing.Size(70, 68);
            this.dmButtonCloseLight1.MinimumSize = new System.Drawing.Size(70, 68);
            this.dmButtonCloseLight1.Name = "dmButtonCloseLight1";
            this.dmButtonCloseLight1.Size = new System.Drawing.Size(70, 68);
            this.dmButtonCloseLight1.TabIndex = 3;
            // 
            // dmButtonMinLight1
            // 
            this.dmButtonMinLight1.BackColor = System.Drawing.Color.Transparent;
            this.dmButtonMinLight1.Location = new System.Drawing.Point(732, 4);
            this.dmButtonMinLight1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.dmButtonMinLight1.Name = "dmButtonMinLight1";
            this.dmButtonMinLight1.Size = new System.Drawing.Size(70, 68);
            this.dmButtonMinLight1.TabIndex = 4;
            // 
            // dmTextBox1
            // 
            this.dmTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dmTextBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dmTextBox1.Location = new System.Drawing.Point(116, 147);
            this.dmTextBox1.Name = "dmTextBox1";
            this.dmTextBox1.Size = new System.Drawing.Size(260, 27);
            this.dmTextBox1.TabIndex = 1;
            this.dmTextBox1.WaterText = "请输入账号";
            // 
            // dmTextBox2
            // 
            this.dmTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dmTextBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dmTextBox2.Location = new System.Drawing.Point(116, 195);
            this.dmTextBox2.Name = "dmTextBox2";
            this.dmTextBox2.Size = new System.Drawing.Size(260, 27);
            this.dmTextBox2.TabIndex = 2;
            this.dmTextBox2.UseSystemPasswordChar = true;
            this.dmTextBox2.WaterText = "请输入密码";
            // 
            // dmButtonCloseLight2
            // 
            this.dmButtonCloseLight2.BackColor = System.Drawing.Color.Transparent;
            this.dmButtonCloseLight2.Location = new System.Drawing.Point(460, 1);
            this.dmButtonCloseLight2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dmButtonCloseLight2.MaximumSize = new System.Drawing.Size(40, 34);
            this.dmButtonCloseLight2.MinimumSize = new System.Drawing.Size(40, 34);
            this.dmButtonCloseLight2.Name = "dmButtonCloseLight2";
            this.dmButtonCloseLight2.Size = new System.Drawing.Size(40, 34);
            this.dmButtonCloseLight2.TabIndex = 5;
            this.dmButtonCloseLight2.Click += new System.EventHandler(this.dmButtonCloseLight2_Click);
            // 
            // dmButtonMinLight2
            // 
            this.dmButtonMinLight2.BackColor = System.Drawing.Color.Transparent;
            this.dmButtonMinLight2.Location = new System.Drawing.Point(413, 2);
            this.dmButtonMinLight2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dmButtonMinLight2.Name = "dmButtonMinLight2";
            this.dmButtonMinLight2.Size = new System.Drawing.Size(40, 34);
            this.dmButtonMinLight2.TabIndex = 6;
            this.dmButtonMinLight2.Click += new System.EventHandler(this.dmButtonMinLight2_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CaptionBackColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(117)))), ((int)(((byte)(180)))));
            this.CaptionBackColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(117)))), ((int)(((byte)(180)))));
            this.CaptionFont = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CaptionHeight = 80;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.ControlBox = false;
            this.Controls.Add(this.dmButtonMinLight2);
            this.Controls.Add(this.dmButtonCloseLight2);
            this.Controls.Add(this.dmTextBox2);
            this.Controls.Add(this.dmTextBox1);
            this.Controls.Add(this.dmButtonMinLight1);
            this.Controls.Add(this.dmButtonCloseLight1);
            this.Controls.Add(this.dmButton1);
            this.EffectWidth = 4;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(500, 300);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "frmLogin";
            this.Radius = 0;
            this.ShadowColor = System.Drawing.Color.LightGray;
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.Text = "欢迎登录LHTCRM";
            this.TitleCenter = true;
            this.TitleColor = System.Drawing.Color.White;
            this.TitleOffset = new System.Drawing.Point(50, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DMSkin.Controls.DMButton dmButton1;
        private DMSkin.Controls.DMButtonCloseLight dmButtonCloseLight1;
        private DMSkin.Controls.DMButtonMinLight dmButtonMinLight1;
        private DMSkin.Controls.DMTextBox dmTextBox1;
        private DMSkin.Controls.DMTextBox dmTextBox2;
        private DMSkin.Controls.DMButtonCloseLight dmButtonCloseLight2;
        private DMSkin.Controls.DMButtonMinLight dmButtonMinLight2;
    }
}