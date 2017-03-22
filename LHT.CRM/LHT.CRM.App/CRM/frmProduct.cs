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
    public partial class frmProduct : Form
    {
        CRM_ProductLogic cpl = new CRM_ProductLogic();
        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            this.dgvProductInfo.AutoGenerateColumns = false;
            LoadProductList();
        }


        #region "事件"

        #endregion


        #region "方法"

        public void LoadProductList()
        {
            this.dgvProductInfo.DataSource = null;
            this.dgvProductInfo.DataSource = cpl.GetAll();
        }

        #endregion

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateProduct fcp = new frmCreateProduct();
            fcp.Owner = this;
            fcp.ShowDialog();
        }
    }
}
