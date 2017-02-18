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

namespace LHT.CRM.App.Settings
{
    public partial class frmSystemSetting : Form
    {
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
            SystemRoleLogic srl = new SystemRoleLogic();
            dgvRoleSetting.DataSource = srl.GetAll();
            dgvRoleSetting.Columns["SystemUsers"].Visible = false;
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
    }
}
