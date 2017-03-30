using System;
using System.Drawing;
using System.Windows.Forms;
using CCWin;
using LHT.CRM.App.Settings;
using LHT.CRM.App.CRM;

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
            lblUserName.Text = frmFuncLib.userName;


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
            //向splitContainer1.Panel2添加系统设置窗体
            if (frmFuncLib.IsOpenModules("系统设置"))
            {
                frmSystemSetting fss = new frmSystemSetting();
                AddForm(fss, "系统设置");
            }
            else
            {
                MessageBox.Show("您没有权限操作此模块，请联系管理员开通！");
            }

        }


        /// <summary>
        /// 导航菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbNav_MouseClick(object sender, MouseEventArgs e)
        {
            //获取当前点击的获得的值

            var selectNavTxt = lbNav.SelectedItem.ToString();
            bool isopen = frmFuncLib.IsOpenModules(selectNavTxt);

            if (selectNavTxt == "客户" && isopen)
            {
                frmCustomer fc = new frmCustomer();
                AddForm(fc, "客户管理");
            }
            else if (selectNavTxt == "联系人" && isopen)
            {
                frmContact fcc = new frmContact();
                AddForm(fcc, "联系人管理");
            }
            else if (selectNavTxt == "拜访" && isopen)
            {
                frmVisit fv = new frmVisit();
                AddForm(fv, "拜访管理");
            }
            else if (selectNavTxt == "销售" && isopen)
            {
                frmTarget ft = new frmTarget();
                AddForm(ft, "销售管理");
            }
            else if (selectNavTxt == "产品" && isopen)
            {
                frmProduct fp = new frmProduct();
                AddForm(fp, "产品管理");
            }
            else if (selectNavTxt == "个人桌面")
            {
                lblMenuTitle.Text = "个人桌面";
                panel3.Controls.Clear();
                //个人桌面待定
            }
            else
            {
                MessageBox.Show("您没有权限操作此模块，请联系管理员开通！");
            }


        }

        #endregion


        #region "方法"
        public void AddForm(Form frm, string title)
        {
            lblMenuTitle.Text = title;
            panel3.Controls.Clear();
            //向splitContainer1.Panel2添加系统设置窗体
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panel3.Controls.Add(frm);
            frm.Show();
        }
        #endregion


    }
}
