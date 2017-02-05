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
            this.metroTabControl1 = new DMSkin.Metro.Controls.MetroTabControl();
            this.tpRoleSetting = new DMSkin.Metro.Controls.MetroTabPage();
            this.RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRoleSetting = new DMSkin.Metro.Controls.MetroGrid();
            this.metroTabControl1.SuspendLayout();
            this.tpRoleSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoleSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tpRoleSetting);
            this.metroTabControl1.DM_UseSelectable = true;
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
            // RoleName
            // 
            this.RoleName.DataPropertyName = "RoleName";
            this.RoleName.HeaderText = "角色名称";
            this.RoleName.Name = "RoleName";
            this.RoleName.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "序号";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoleSetting.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRoleSetting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRoleSetting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.RoleName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoleSetting.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRoleSetting.EnableHeadersVisualStyles = false;
            this.dgvRoleSetting.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvRoleSetting.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvRoleSetting.Location = new System.Drawing.Point(10, 10);
            this.dgvRoleSetting.Name = "dgvRoleSetting";
            this.dgvRoleSetting.ReadOnly = true;
            this.dgvRoleSetting.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoleSetting.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRoleSetting.RowHeadersVisible = false;
            this.dgvRoleSetting.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvRoleSetting.RowTemplate.Height = 27;
            this.dgvRoleSetting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoleSetting.Size = new System.Drawing.Size(487, 621);
            this.dgvRoleSetting.TabIndex = 2;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;
    }
}