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
    public partial class frmContact : Form
    {
        CRM_ContactLogic ccl = new CRM_ContactLogic();
        public frmContact()
        {
            InitializeComponent();
        }

        private void frmContact_Load(object sender, EventArgs e)
        {
            this.dgvContactInfo.AutoGenerateColumns = false;
            LoadContactList();
        }

        #region "事件"

        #endregion

        #region "方法"

        public void LoadContactList()
        {
            dgvContactInfo.DataSource = ccl.GetAll();
        }




        #endregion

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }
    }
}
