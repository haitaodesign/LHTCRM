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

namespace LHT.CRM.App.Settings
{
    public partial class frmCreateUser : Skin_VS
    {
        public frmCreateUser()
        {
            InitializeComponent();
        }

        private void frmCreateUser_Load(object sender, EventArgs e)
        {
            //初始化表单数据
            InitSexData();
            InitRoleData();
        }

        #region 添加用户

        public void InitSexData()
        {
            cbSex.SelectedIndex = 0;

            
        }
        public void InitRoleData()
        {
            cbRoleName.SelectedIndex = 0;
            //获取角色列表并填充，保存角色Id和角色名称


        }

        #endregion
    }
}
