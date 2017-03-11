using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LHT.CRM.BLL.SystemManagement;
using LHT.CRM.Model;
using LHT.CRM.Common.Encrypt;

namespace LHT.CRM.App.Settings
{
    public partial class frmSystemSetting : Form
    {
        #region 公共变量
        public int currentRoleId;
        SystemRole sr = new SystemRole();
        SystemRoleLogic srl = new SystemRoleLogic();
        SystemUserLogic sul = new SystemUserLogic();
        SystemLoginLogic sll = new SystemLoginLogic();
        SystemLogin sl = new SystemLogin();
        #endregion
        public frmSystemSetting()
        {
            InitializeComponent();
            this.dgvRoleSetting.AutoGenerateColumns = false;
            this.dgvUserSetting.AutoGenerateColumns = false;
            this.dgvAccountSetting.AutoGenerateColumns = false;
        }
        private void frmSystemSetting_Load(object sender, EventArgs e)
        {
            DisplayRoleList();
            DisplayUserList();
            DisplayLoginNameList();
        }
        #region 角色设置

        #region 事件


        private void btnCreateRole_Click(object sender, EventArgs e)
        {
            //弹出新建角色窗体
            frmCreateRole fcr = new frmCreateRole();
            fcr.Owner = this;
            fcr.ShowDialog();
        }
        private void btnAuthority_Click(object sender, EventArgs e)
        {
            frmCreateAuthority fca = new frmCreateAuthority();
            fca.Owner = this;
            fca.ShowDialog();
        }

        private void dgvRoleSetting_Click(object sender, EventArgs e)
        {
            currentRoleId = Convert.ToInt32(dgvRoleSetting.CurrentRow.Cells[0].Value.ToString());
        }

        private void btnUpdateRole_Click(object sender, EventArgs e)
        {
            //将当前行的数据保存到一个临时对象中
            sr.Id = Convert.ToInt32(dgvRoleSetting.CurrentRow.Cells[0].Value.ToString());
            sr.RoleName = dgvRoleSetting.CurrentRow.Cells[1].Value.ToString();
            sr.RoleDescription = dgvRoleSetting.CurrentRow.Cells[2].Value.ToString();
            frmCreateRole fcr = new frmCreateRole();
            fcr.Owner = this;
            fcr.Text = "修改角色";
            fcr.ShowDialog();
        }

        private void btnDeleteRole_Click(object sender, EventArgs e)
        {
            //获取当前角色Id，并根据Id删除模块权限表（使用数据库级联删除）
            if (srl.Delete(currentRoleId) == 1)
            {
                RefreshMethod();
            }
            else
            {
                MessageBox.Show("删除失败", "提示", MessageBoxButtons.OK);
            }

        }
        #endregion
        #region 方法调用
        //显示角色列表
        public void DisplayRoleList()
        {
            //显示角色信息
            dgvRoleSetting.DataSource = srl.GetAll();
        }

        public SystemRole GetRole()
        {
            return sr;
        }

        //刷新列表数据的方法
        public void RefreshMethod()
        {
            //清除数据
            dgvRoleSetting.DataSource = null;
            //重新加载
            DisplayRoleList();
        }








        #endregion

        #endregion

        #region “用户设置”

        #region 事件
        private void btnadduser_Click(object sender, EventArgs e)
        {
            CreateUserWindow();
        }
        #endregion


        #region 方法调用
        /// <summary>
        /// 初始化用户列表显示
        /// </summary>
        public void DisplayUserList()
        {
            //设置属性对应的字段

            //填充数据
            dgvUserSetting.DataSource = sul.GetAllUsers();
        }

        /// <summary>
        /// 刷新用户列表
        /// </summary>
        public void RefreshUserList()
        {
            dgvUserSetting.DataSource = null;
            DisplayUserList();
        }

        /// <summary>
        /// 创建用户添加窗体
        /// </summary>
        public void CreateUserWindow()
        {
            frmCreateUser fcu = new frmCreateUser();
            fcu.Owner = this;
            fcu.ShowDialog();
        }

        /// <summary>
        /// 显示账号列表
        /// </summary>
        public void DisplayLoginNameList()
        {
            dgvAccountSetting.DataSource = null;
            dgvAccountSetting.DataSource = sll.GetAllLogin();
        }


        #endregion

        #endregion

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            //将密码重置为123456
            string resetpassword = MD5Encrypt.GetMD5Hash("admin123456");
            sl.Id = Convert.ToInt32(dgvAccountSetting.CurrentRow.Cells[0].Value.ToString());
            sl.LoginName = dgvAccountSetting.CurrentRow.Cells[1].Value.ToString();
            sl.Password = resetpassword;
            sl.IsLock =Convert.ToInt32(dgvAccountSetting.CurrentRow.Cells[2].Value.ToString());

            if (sll.Update(sl)==1)
            {
                MessageBox.Show("重置成功!", "提示", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("重置失败!", "提示", MessageBoxButtons.OK);
            }

        }

        private void btnLockedAccount_Click(object sender, EventArgs e)
        {
            //判断当前账号是否启用，若启用，则提示是否禁用账户，如未启用，则提示是否启用
            //获取当前选择的数据
            string loginname= dgvAccountSetting.CurrentRow.Cells[1].Value.ToString();
            sl = sll.GetLoginModel(loginname);
            if (sl.IsLock == 1)
            {
                sl.IsLock = 0;
                sll.Update(sl);
                MessageBox.Show("账号已被禁用！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //刷新数据
                DisplayLoginNameList();

            }
            else
            {
                sl.IsLock = 1;
                sll.Update(sl);
                MessageBox.Show("账号已启用！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayLoginNameList();
            }


        }

        
    }
}
