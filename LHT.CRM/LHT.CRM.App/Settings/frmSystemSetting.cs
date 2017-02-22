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
        public int currentRoleId;
        SystemRole sr = new SystemRole();
        SystemRoleLogic srl = new SystemRoleLogic();


        public frmSystemSetting()
        {
            InitializeComponent();
        }

        private void frmSystemSetting_Load(object sender, EventArgs e)
        {
            DisplayRoleList();
        }

        private void btnCreateRole_Click(object sender, EventArgs e)
        {
            //弹出新建角色窗体
            frmCreateRole fcr = new frmCreateRole();
            fcr.Owner = this;
            fcr.ShowDialog();
        }


        //显示角色列表
        public void DisplayRoleList()
        {
            //显示角色信息
            dgvRoleSetting.DataSource = srl.GetAll();
            dgvRoleSetting.Columns["SystemRoleAuthorities"].Visible = false;
        }


        //每个角色对应不同的权限

        //用户设置

        //显示用户信息

        //添加用户时设置默认的角色

        //修改用户信息可以更改角色设置


        //刷新列表数据的方法
        public void RefreshMethod()
        {
            //清除数据
            dgvRoleSetting.DataSource = null;
            //重新加载
            DisplayRoleList();
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

        public SystemRole GetRole()
        {
            return sr;
        }

        private void btnDeleteRole_Click(object sender, EventArgs e)
        {
            //获取当前角色Id，并根据Id删除模块权限表（使用数据库级联删除）
            if (srl.Delete(currentRoleId)==1)
            {
                RefreshMethod();
            }
            else
            {
                MessageBox.Show("删除失败", "提示", MessageBoxButtons.OK);
            }

        }
    }
}
