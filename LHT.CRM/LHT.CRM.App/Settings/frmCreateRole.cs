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
        SystemModuleLogic sml = new SystemModuleLogic();
        SystemRoleAuthorityLogic sral = new SystemRoleAuthorityLogic();
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
                    //返回最后一行记录


                    //循环写入权限模块表，并将其属性IsLock设置为0
                    //查询模块列表
                    //写入数据库
                    foreach (var item in sml.GetAllModule())
                    {
                        SystemRoleAuthority sra = new SystemRoleAuthority()
                        {
                            RoleId =srl.RoleId(),
                            ModuleName = item.TopName,
                            IsLock = 0
                        };
                        sral.AddRoleAuthority(sra);
                    }





                    this.Close();
                    //刷新数据列表
                    frmSystemSetting fss;
                    fss = (frmSystemSetting)this.Owner;
                    fss.RefreshMethod();
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
