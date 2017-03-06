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
using LHT.CRM.BLL.CRM;

namespace LHT.CRM.App.CRM
{
    public partial class frmCreateCustomer : Skin_VS
    {
        CRM_Customer cc = new CRM_Customer();
        SystemUserLogic suc = new SystemUserLogic();
        CRM_CustomerLogic ccl = new CRM_CustomerLogic();
        public frmCreateCustomer()
        {
            InitializeComponent();
        }

        private void frmCreateCustomer_Load(object sender, EventArgs e)
        {
            //填充输入表单的基本数据

            //新建三个表，行业表，客户类型表，公司规模表

            //联系人选择使用联系人添加

            //通过业务员返回业务员Id




        }



        #region "方法"

        /// <summary>
        /// 获取输入的客户信息
        /// </summary>
        /// <returns></returns>
        public CRM_Customer GetCustomerModel()
        {
            cc.CId = frmFuncLib.userId;
            cc.CDate = DateTime.Now;
            //客户编码不能重复
            cc.CusCode = tbCusCode.Text;
            cc.CusName = tbCusName.Text;
            cc.SaleId = GetSaleId(cbUserName.Text);
            cc.Province = tbProvince.Text;
            cc.City = tbCity.Text;
            cc.BussinessType = cbBussinessType.Text;
            cc.Scale = cbScale.Text;
            cc.CusType = cbCusType.Text;
            cc.PhoneNum = tbPhoneNum.Text;
            cc.HomePage = tbHomePage.Text;
            cc.Address = tbAddress.Text;
            if (cbUserName.Text == string.Empty)
            {
                cc.IsPublisCus = 0;
            }
            else
            {
                cc.IsPublisCus = 1;
            }

            return cc;
        }
        


        /// <summary>
        /// 根据业务员名字返回id
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public int GetSaleId(string userName)
        {
            return suc.GetSaleId(userName);
        }

        #endregion

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if(tbCusCode.Text!=string.Empty && tbCusName.Text != string.Empty)
            {
                ccl.AddCustomer(GetCustomerModel());
                MessageBox.Show("添加成功！");
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }
    }
}
