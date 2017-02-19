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
using LHT.CRM.Model;

namespace LHT.CRM.App.Settings
{
    public partial class frmCreateAuthority : Skin_VS
    {
        SystemRoleAuthorityLogic sral = new SystemRoleAuthorityLogic();
        SystemModuleLogic sml = new SystemModuleLogic();
        int roleId;
        List<SystemRoleAuthority> getRoleModule;
        List<SystemRoleAuthority> getAllAuthList;

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
            foreach (var module in sml.GetAllModule())
            {
                lbModuleList.Items.Add(module.TopName);
            }
        }

        public void DislplayRoleModules()
        {
            getRoleModule = sral.GetAuthList(roleId);
            foreach (var item in getRoleModule)
            {
                lbSelModuleList.Items.Add(item.ModuleName);
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {


            //获取角色权限列表，循坏更改信息
            int count = lbSelModuleList.Items.Count;
            getAllAuthList = sral.GetAllAuthList(roleId);
            int countAuthList = getAllAuthList.Count;
            SystemRoleAuthority sra = new SystemRoleAuthority();
            if (count > 0)
            {
                for (int j = 0; j < countAuthList; j++)
                {
                    sra = getAllAuthList[j];
                    sra.IsLock = 0;
                    sral.UpdateRoleAuth(sra);
                }
                for (int i = 0; i < count; i++)
                {
                    string moduleName = lbSelModuleList.Items[i].ToString();
                    //查询roleId和moduleName相同的对象，修改IsLock为1
                    sra = sral.GetRoleIdAndModule(roleId, moduleName);
                    sra.IsLock = 1;
                    sral.UpdateRoleAuth(sra);
                }
            }
            



        }
    }
}
