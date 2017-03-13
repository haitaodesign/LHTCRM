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
        CRM_Customer updatecc = new CRM_Customer();
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
            if (this.Text == "修改客户信息")
            {
                //将得到的信息填充到输入框
                frmCustomer fc;
                fc = (frmCustomer)this.Owner;
                cc = fc.GetCRM_CustomerModel();
                LoadUpdateInfo();
            }
            

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
                cc.SaleId = GetSaleId(cbUserName.Text.ToString());
            }

            return cc;
        }
        

        public CRM_Customer GetUpdateModel()
        {
            updatecc.Id = cc.Id;
            updatecc.MId = frmFuncLib.userId;
            updatecc.MDate = DateTime.Now;
            //客户编码不能重复
            updatecc.CusCode = tbCusCode.Text;
            updatecc.CusName = tbCusName.Text;
            updatecc.Province = tbProvince.Text;
            updatecc.City = tbCity.Text;
            updatecc.BussinessType = cbBussinessType.Text;
            updatecc.Scale = cbScale.Text;
            updatecc.CusType = cbCusType.Text;
            updatecc.PhoneNum = tbPhoneNum.Text;
            updatecc.HomePage = tbHomePage.Text;
            updatecc.Address = tbAddress.Text;
            if (cbUserName.Text == string.Empty)
            {
                updatecc.IsPublisCus = 0;
            }
            else
            {
                updatecc.IsPublisCus = 1;
                updatecc.SaleId = GetSaleId(cbUserName.Text.ToString());
            }
            return updatecc;
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

        /// <summary>
        /// 加载修改客户信息
        /// </summary>
        public void LoadUpdateInfo()
        {
            tbCusCode.Text = cc.CusCode.ToString();
            tbCusName.Text = cc.CusName.ToString();
            tbPhoneNum.Text = cc.PhoneNum.ToString();
            int id =(int)cc.SaleId;
            string username = GetUserName(id);
            cbUserName.Text = username;
            tbProvince.Text = cc.Province.ToString();
            tbCity.Text = cc.City.ToString();
            cbBussinessType.Text = cc.BussinessType.ToString();
            cbCusType.Text = cc.CusType.ToString();
            cbScale.Text = cc.Scale.ToString();
            tbHomePage.Text = cc.HomePage.ToString();
            tbAddress.Text = cc.Address.ToString();
        }


        public string GetUserName(int saleid)
        {
            return suc.GetUserModel(saleid).UserName;
        }

        #endregion

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //判断是修改客户信息，还是新添加客户信息
            if (this.Text == "添加客户信息")
            {
                if (tbCusCode.Text != string.Empty && tbCusName.Text != string.Empty)
                {
                    ccl.AddCustomer(GetCustomerModel());
                    MessageBox.Show("添加成功！");
                }
                else
                {
                    MessageBox.Show("添加失败！");
                }
            }else if (this.Text == "修改客户信息")
            {
                if (tbCusCode.Text != string.Empty && tbCusName.Text != string.Empty)
                {
                    ccl.UpdateCustomer(GetCustomerModel());
                    MessageBox.Show("修改成功！");
                }
                else
                {
                    MessageBox.Show("修改失败！");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
