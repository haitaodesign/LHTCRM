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
using LHT.CRM.Model;

namespace LHT.CRM.App.CRM
{
    public partial class frmProduct : Form
    {
        CRM_ProductLogic cpl = new CRM_ProductLogic();
        CRM_Product cp = new CRM_Product();
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
        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateProduct fcp = new frmCreateProduct();
            fcp.Owner = this;
            fcp.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmCreateProduct fcp = new frmCreateProduct();
            fcp.Owner = this;
            fcp.Text = "修改产品信息";
            fcp.ShowDialog();
        }
        #endregion


        #region "方法"

        public void LoadProductList()
        {
            this.dgvProductInfo.DataSource = cpl.GetAll();
        }

        public void RefreshProductList()
        {
            this.dgvProductInfo.DataSource = null;
            CRM_ProductLogic cpl2 = new CRM_ProductLogic();
            this.dgvProductInfo.DataSource = cpl2.GetAll();
        }

        /// <summary>
        /// 获得需要修改的产品信息
        /// </summary>
        /// <returns></returns>
        public int GetUpdateCRM_ProductId()
        {
            return Convert.ToInt32(this.dgvProductInfo.CurrentRow.Cells[0].Value);
        }

        #endregion


    }
}
