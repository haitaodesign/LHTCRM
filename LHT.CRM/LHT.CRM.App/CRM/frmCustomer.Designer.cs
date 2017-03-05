namespace LHT.CRM.App.CRM
{
    partial class frmCustomer
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
            this.dmButton1 = new DMSkin.Controls.DMButton();
            this.SuspendLayout();
            // 
            // dmButton1
            // 
            this.dmButton1.BackColor = System.Drawing.Color.Transparent;
            this.dmButton1.DM_DisabledColor = System.Drawing.Color.Empty;
            this.dmButton1.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(140)))), ((int)(((byte)(188)))));
            this.dmButton1.DM_MoveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.dmButton1.DM_NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.dmButton1.DM_Radius = 5;
            this.dmButton1.Image = null;
            this.dmButton1.Location = new System.Drawing.Point(155, 218);
            this.dmButton1.Name = "dmButton1";
            this.dmButton1.Size = new System.Drawing.Size(125, 45);
            this.dmButton1.TabIndex = 0;
            this.dmButton1.Text = "dmButton1";
            this.dmButton1.UseVisualStyleBackColor = false;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 541);
            this.Controls.Add(this.dmButton1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCustomer";
            this.Text = "frmCustomer";
            this.ResumeLayout(false);

        }

        #endregion

        private DMSkin.Controls.DMButton dmButton1;
    }
}