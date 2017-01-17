using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;

namespace LHT.CRM.App
{
    public partial class frmLogin : Skin_VS
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void dmButtonCloseLight2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dmButtonMinLight2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void dmButton1_Click(object sender, EventArgs e)
        {
            //验证
            MessageBox.Show("登陆成功！");



            //显示主界面
            frmMain main = new frmMain();
            main.Show();
            //隐藏登陆窗体
            this.Hide();
        }
    }
}
