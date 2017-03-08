using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LHT.CRM.BLL.CRM;

namespace LHT.CRM.App.CRM
{
    public partial class frmTarget : Form
    {
        CRM_TargetLogic ctl = new CRM_TargetLogic();
        public frmTarget()
        {
            InitializeComponent();
        }
        private void frmTarget_Load(object sender, EventArgs e)
        {

            this.dgvTargetInfo.AutoGenerateColumns = false;
            LoadTargetList();
        }


        #region "事件"

        #endregion

        #region "方法"

        //获取目标列表，通过UserId获取业务员姓名，一个拥业务员有多个目标

        public void LoadTargetList()
        {
            this.dgvTargetInfo.DataSource = ctl.GetAll();
        }

        #endregion

       
    }
}
