﻿using System;
using System.Drawing;
using System.Windows.Forms;
using CCWin;
using LHT.CRM.App.Settings;

namespace LHT.CRM.App
{
    public partial class frmMain : Skin_VS
    {


        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            //首先加载个人桌面

        }
        



        #region "主界面事件"

        /// <summary>
        /// 鼠标悬停显示此图标的提示信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinPictureBox3_MouseHover(object sender, EventArgs e)
        {
            tpSettings.Show("设置", this.pbSettings);
        }



        /// <summary>
        /// 点击主界面右上角关闭按钮时退出界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //先询问是否关闭,根据选择结果执行相应的代码
            
            Application.Exit();
        }



        /// <summary>
        /// 单击设置图标，显示设置快捷菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbSettings_Click(object sender, EventArgs e)
        {
            cmSettings.Show(this.splitContainer1.Panel1, new Point(50, 600));
        }

        /// <summary>
        /// 单击系统设置，向splitContainer1.Panel2添加系统设置窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiSystemSettings_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            //向splitContainer1.Panel2添加系统设置窗体
            frmSystemSetting fss = new frmSystemSetting();
            fss.TopLevel = false;
            fss.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(fss);
            fss.Show();
        }

        #endregion

        
    }
}
