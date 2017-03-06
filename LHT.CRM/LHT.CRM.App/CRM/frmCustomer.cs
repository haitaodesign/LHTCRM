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
    public partial class frmCustomer : Form
    {
        CRM_CustomerLogic ccl = new CRM_CustomerLogic();
        int saleid = frmFuncLib.userId;

        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            //客户信息加载时判断账号信息是主管还是业务员，主管加载全部信息，显示全部按钮可见
            //业务员只加载本人信息，不加载其他人的信息，
            //而且业务员没有删除客户信息的功能，只有新增和修改
            this.dgvCusInfo.AutoGenerateColumns = false;
            if (!IsRole())
            {
                btnShowAll.Visible = false;
            }

            //获取所有的客户信息
            //根据SaleId返回客户信息，SaleId==UserId
            LoadCusInfo();



        }






        #region “事件”
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            if (btnShowAll.Text == "显示全部")
            {
                ShowAllCusInfo();
                btnShowAll.Text = "显示本人";
            }
            else if (btnShowAll.Text == "显示本人")
            {
                LoadCusInfo();
                btnShowAll.Text = "显示全部";
            }
        }
        #endregion


        #region "方法"
        /// <summary>
        /// 判断角色？
        /// </summary>
        /// <returns></returns>
        public bool IsRole()
        {
            if (frmFuncLib.roleName == "业务员")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 根据销售员id显示客户信息
        /// </summary>
        public void LoadCusInfo()
        {
            dgvCusInfo.DataSource = ccl.GetAll(saleid);
        }

        /// <summary>
        /// 如果不是业务员，可以显示所有客户信息
        /// </summary>
        public void ShowAllCusInfo()
        {
            if (IsRole())
            {
                dgvCusInfo.DataSource = ccl.GetAll();
            }
        }






        #endregion

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateCustomer fcc = new frmCreateCustomer();
            fcc.Show();
        }
    }
}
