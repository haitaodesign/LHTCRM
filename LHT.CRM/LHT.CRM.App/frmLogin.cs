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
using LHT.CRM.Model;

namespace LHT.CRM.App
{
    public partial class frmLogin : Skin_VS
    {
        SystemLoginLogic sll = new SystemLoginLogic();
        SystemUserLogic sul = new SystemUserLogic();
        public frmLogin()
        {
            InitializeComponent();
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        #region "事件"
        /// <summary>
        /// 登录验证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dmButton1_Click(object sender, EventArgs e)
        {
            if (!IsConnection())
            {
                return;
            }
            //验证
            //获取密码和账号值
            string loginname = tbLoginName.Text.Trim();
            string password = tbPassword.Text.Trim();
            //首先判断账号是否为空
            if (loginname == string.Empty)
            {
                MessageBox.Show("账号不能为空", "提示", MessageBoxButtons.OK);
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
                            GetUserInfo(loginname);
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
        private void dmButtonCloseLight2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dmButtonMinLight2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        #endregion


        #region "方法"
        /// <summary>
        /// 登录成功后获取用户信息，赋值到公共变量
        /// </summary>
        public void GetUserInfo(string loginname)
        {
            frmFuncLib.userId = sll.GetLoginModel(loginname).Id;
            SystemUser su = sul.GetUserModel(frmFuncLib.userId);
            frmFuncLib.userName = su.UserName;
            frmFuncLib.roleId = (int)su.RoleId;
            frmFuncLib.roleName = su.RoleName;
        }



        public bool IsConnection()
        {
            if (!sll.IsConnection())
            {
                MessageBox.Show("请检查网络是否正常或联系管理员数据库是否开启！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion





    }
}
