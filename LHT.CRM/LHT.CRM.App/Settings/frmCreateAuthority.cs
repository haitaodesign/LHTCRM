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

namespace LHT.CRM.App.Settings
{
    public partial class frmCreateAuthority : Skin_VS
    {
        int roleId;
        public frmCreateAuthority()
        {
            InitializeComponent();
        }

        private void frmCreateAuthority_Load(object sender, EventArgs e)
        {
            DisplayAllModules();
            //显示某一角色拥有的模块列表
            frmSystemSetting fss;
            fss = (frmSystemSetting)this.Owner;
            roleId=fss.currentRoleId;
            DislplayRoleModules();


        }

        private void btnAddModule_Click(object sender, EventArgs e)
        {
            //获取当前listbox选中项的值
            //添加到右边listbox,添加之前先判断是否已有此项，如果有则提示已经添加

            var curItemValueLeft = lbModuleList.SelectedItem.ToString();

            //判断当前lbSelModuleList中是否包含选中项的值，返回bool值
            bool result = lbSelModuleList.Items.Contains(curItemValueLeft);

            if (!result)
            {
                lbSelModuleList.Items.Add(curItemValueLeft);
            }
            else
            {
                MessageBox.Show("请不要添加重复的项！", "提示", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        private void btnDeleteModule_Click(object sender, EventArgs e)
        {
            var currentItemValueRight = lbSelModuleList.SelectedItem.ToString();
            lbSelModuleList.Items.Remove(currentItemValueRight);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 显示所有功能模块的名称列表
        /// </summary>
        public void DisplayAllModules()
        {
            SystemModuleLogic sml = new SystemModuleLogic();
            foreach (var module in sml.GetAllModule())
            {
                lbModuleList.Items.Add(module.TopName);
            }
        }

        public void DislplayRoleModules()
        {
            SystemRoleAuthorityLogic sral = new SystemRoleAuthorityLogic();
            foreach (var item in sral.GetAuthList(roleId))
            {
                lbSelModuleList.Items.Add(item.ModuleName);
            }
        }
    }
}
