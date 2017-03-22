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
using LHT.CRM.BLL.CRM;

namespace LHT.CRM.App.CRM
{
    public partial class frmCreateProduct : Skin_VS
    {
        CRM_Product cp = new CRM_Product();
        CRM_ProductLogic cpl = new CRM_ProductLogic();

        public frmCreateProduct()
        {
            InitializeComponent();
        }


        #region "事件"
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (this.Text == "添加产品信息")
            {
                AddProduct();
            }else if (this.Text == "修改产品信息")
            {

            }
        }
        #endregion

        #region "方法"
        /// <summary>
        /// 获取需要添加的产品信息
        /// </summary>
        public void GetCRM_ProductModel()
        {
            cp.CId = frmFuncLib.userId;
            cp.CDate = DateTime.Now;
            cp.Name = tbProductName.Text;
            cp.Category = tbCateGory.Text;
            cp.Unit = tbUnit.Text;
            cp.Quantity =Convert.ToInt32(tbQuantity.Text);
            cp.Introduction = tbIntroduction.Text;
        }

        public void AddProduct()
        {
            if (tbProductName.Text != null)
            {
                GetCRM_ProductModel();
                cpl.Add(cp);
                MessageBox.Show("添加成功！");
                LoadProductList();
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }

        /// <summary>
        /// 刷新产品信息列表
        /// </summary>
        public void LoadProductList()
        {
            frmProduct fp = new frmProduct();
            fp = (frmProduct)this.Owner;
            fp.LoadProductList();
            this.Close();
        }

        #endregion

        
    }
}
