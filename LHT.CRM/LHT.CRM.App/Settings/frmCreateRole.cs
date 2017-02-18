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

namespace LHT.CRM.App.Settings
{
    public partial class frmCreateRole : Skin_VS
    {
        public frmCreateRole()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //插入一条角色记录
            if(tbRoleName.Text != string.Empty && tbRoleDescription.Text != string.Empty)
            {
                SystemRole sr = new SystemRole();
                sr.RoleName = tbRoleName.Text.Trim();
                sr.RoleDescription = tbRoleDescription.Text.Trim();
                SystemRoleLogic srl = new SystemRoleLogic();
                if (srl.Add(sr) == 1)
                {
                    this.Close();
                    //刷新数据列表
                }
            }
            else
            {
                MessageBox.Show("请填写完整的角色信息","提示",MessageBoxButtons.OK);
            }
            

            //插入默认权限模块的记录
        }
    }
}
