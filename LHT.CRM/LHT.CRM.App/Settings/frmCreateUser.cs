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
using LHT.CRM.Model;
using LHT.CRM.BLL.SystemManagement;
using LHT.CRM.Common.Encrypt;

namespace LHT.CRM.App.Settings
{
    public partial class frmCreateUser : Skin_VS
    {
        List<SystemRole> sRole;
        SystemRoleLogic srl = new SystemRoleLogic();
        SystemUserLogic sul = new SystemUserLogic();
        SystemLogin sl = new SystemLogin();
        SystemLoginLogic sll = new SystemLoginLogic();
        SystemUser su = new SystemUser();
        int currupdateroleId;
        public frmCreateUser()
        {
            InitializeComponent();
        }

        private void frmCreateUser_Load(object sender, EventArgs e)
        {
            if (this.Text == "添加用户信息")
            {
                //初始化表单数据
                InitSexData();
                InitRoleData();
            }else if (this.Text == "修改用户信息")
            {
                //加载需要修改的用户信息
                InitRoleData();
                LoadUpdateUserInfo();
            }
            
        }

        #region “添加用户”
        #region 事件
        /// <summary>
        /// 点击确认插入数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnter_Click(object sender, EventArgs e)
        {
            string loginname = tbLoginName.Text.Trim();
            //查询已有账号数据，不可重复
            //判断姓名，性别，角色不为空，或者匹配正确的数据
            if (this.Text == "添加用户信息")
            {
                AddUserInfo(loginname);
            }else if (this.Text == "修改用户信息")
            {
                UpdateUserInfo(loginname);
            }
        }
        #endregion
        #region 方法

        /// <summary>
        /// 性别初始化
        /// </summary>
        public void InitSexData()
        {
            cbSex.SelectedIndex = 0;
        }
        /// <summary>
        /// 角色下拉框数据初始化
        /// </summary>
        public void InitRoleData()
        {
            cbRoleName.SelectedIndex = 0;
            //获取角色列表并填充，保存角色Id和角色名称
            sRole = srl.GetAll();
            foreach (var item in sRole)
            {
                cbRoleName.Items.Add(item.RoleName);
            }
        }

        /// <summary>
        /// 将输入框中的数据存入一个对象并返回该对象
        /// </summary>
        /// <returns></returns>
        public SystemUser GetInputData()
        {
            SystemUser su = new SystemUser();
            su.UserName = tbUserName.Text.Trim();
            su.Sex = cbSex.Text.Trim();
            su.Age =Convert.ToInt32(tbAge.Text);
            su.Phone = tbPhone.Text;
            su.Email = tbEmail.Text;
            su.QQ = tbQQ.Text;
            su.RoleName = cbRoleName.Text.Trim();
            su.RoleId = GetRoleId(cbRoleName.Text.Trim());
            su.LoginName = tbLoginName.Text.Trim();
            return su;
        }

        //public SystemLogin GetSysLogin()
        //{

        //}


        public int GetRoleId(string rolename)
        {
            int roleId = sRole.Find(s => s.RoleName == rolename).Id;
            return roleId;
        }

        public void LoadUpdateUserInfo()
        {
            frmSystemSetting fss;
            fss = (frmSystemSetting)this.Owner;
            su=fss.GetSystemUserModel();
            currupdateroleId = su.Id;
            tbUserName.Text = su.UserName;
            cbSex.Text = su.Sex;
            tbAge.Text = su.Age.ToString();
            tbPhone.Text = su.Phone;
            tbEmail.Text = su.Email;
            tbQQ.Text = su.QQ;
            LoadRoleName(su.RoleName);
            tbLoginName.Text = su.LoginName;
        }

        public void LoadRoleName(string rolename)
        {
            int roleindex= cbRoleName.Items.IndexOf(rolename);
            if (roleindex != -1)
            {
                cbRoleName.SelectedIndex = roleindex;
            }
        }

        /// <summary>
        /// 添加一个用户
        /// </summary>
        /// <param name="loginname"></param>
        public void AddUserInfo(string loginname)
        {
            if (tbUserName.Text.Trim() != null && cbSex.Text != null
                && cbRoleName.Text != null && tbAge.Text != null && loginname != null)
            {
                //将用户信息写入数据库
                int result = sul.AddUser(GetInputData());
                //添加账号信息，使用默认指定密码，

                if (result != 0)
                {
                    //查询指定账号的用户Id
                    int uid = sul.GetId(loginname);
                    sl.LoginName = loginname;
                    sl.IsLock = 1;
                    //对初始密码加密
                    string pass = MD5Encrypt.GetMD5Hash("123456admin");
                    sl.Password = pass;
                    sl.UserId = uid;
                    if (sl != null)
                    {
                        sll.AddLogin(sl);
                        MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("添加失败！", "提示", MessageBoxButtons.OK);
                }
            }
            else
            {
                titlePromptInfo.Text = "姓名、性别、角色、账号是必填项，不能为空！";
                titlePromptInfo.Visible = true;
            }
        }

        public void UpdateUserInfo(string loginname)
        {
            if (tbUserName.Text != null && cbSex.Text != null
                && cbRoleName.Text != null && tbAge.Text != null && loginname != null)
            {
                //修改
                int result = sul.Update(GetUpdateUserInfo());
                //添加账号信息，使用默认指定密码，

                if (result != 0)
                {
                    //查询指定账号的用户Id
                    int uid = sul.GetId(loginname);
                    sl.LoginName = loginname;
                    sl.IsLock = 1;
                    //对初始密码加密
                    string pass = MD5Encrypt.GetMD5Hash("123456admin");
                    sl.Password = pass;
                    sl.UserId = uid;
                    if (sl != null)
                    {
                        sll.Update(sl);
                        MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK);
                }
            }
            else
            {
                titlePromptInfo.Text = "姓名、性别、角色、账号是必填项，不能为空！";
                titlePromptInfo.Visible = true;
            }
        }


        public SystemUser GetUpdateUserInfo()
        {
            SystemUser su = new SystemUser();
            su.Id = currupdateroleId;
            su.UserName = tbUserName.Text.Trim();
            su.Sex = cbSex.Text.Trim();
            su.Age = Convert.ToInt32(tbAge.Text);
            su.Phone = tbPhone.Text;
            su.Email = tbEmail.Text;
            su.QQ = tbQQ.Text;
            su.RoleName = cbRoleName.Text.Trim();
            su.RoleId = GetRoleId(cbRoleName.Text.Trim());
            su.LoginName = tbLoginName.Text.Trim();
            return su;
        }
        #endregion

        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
