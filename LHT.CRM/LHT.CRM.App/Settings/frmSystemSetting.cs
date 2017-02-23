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

namespace LHT.CRM.App.Settings
{
    public partial class frmSystemSetting : Form
    {
        #region 公共变量
        public int currentRoleId;
        SystemRole sr = new SystemRole();
        SystemRoleLogic srl = new SystemRoleLogic();
        SystemUserLogic sul = new SystemUserLogic();
        #endregion
        public frmSystemSetting()
        {
            InitializeComponent();
            this.dgvRoleSetting.AutoGenerateColumns = false;
            this.dgvUserSetting.AutoGenerateColumns = false;
        }
        private void frmSystemSetting_Load(object sender, EventArgs e)
        {
            DisplayRoleList();
            DisplayUserList();
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
        #endregion

        #endregion

        
    }
}
