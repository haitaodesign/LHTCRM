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
using LHT.CRM.BLL.SystemManagement;
using LHT.CRM.Common.Encrypt;

namespace LHT.CRM.App
{
    public partial class frmLogin : Skin_VS
    {
        SystemLoginLogic sll = new SystemLoginLogic();
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
            //检查网络连接是否正常
            

        }

        private void dmButton1_Click(object sender, EventArgs e)
        {
            //验证
            //获取密码和账号值
            string loginname = tbLoginName.Text.Trim();
            string password = tbPassword.Text.Trim();
            //首先判断账号是否为空
            if (loginname == string.Empty)
            {
                MessageBox.Show("账号不能为空","提示",MessageBoxButtons.OK);
            }
            else
            {
                //判断账号是否存在,根据账号查询数据
                if (!sll.IsExist(loginname))
                {
                    MessageBox.Show("账号不存在，请重新输入", "提示", MessageBoxButtons.OK);
                }
                else
                {
                    //验证密码
                    ErrorInfo error = frmFuncLib.IsValidPassword(password);
                    if (error.HasError)
                    {
                        MessageBox.Show(error.ErrorMessage, "提示", MessageBoxButtons.OK);
                    }
                    else
                    {
                        //匹配账号和密码，应对密码进行加密之后再匹配
                        bool isMatch = sll.LoginNameAndPasswordIsMatch(loginname, MD5Encrypt.GetMD5Hash(password));
                        if (isMatch)
                        {
                            //显示主界面
                            frmMain main = new frmMain();
                            main.Show();
                            //隐藏登陆窗体
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("密码不正确，请重新输入");
                            tbPassword.Clear();
                        }
                    }
                }
            }
        }
    }
}
