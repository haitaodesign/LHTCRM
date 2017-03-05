using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LHT.CRM.App.CRM
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            //客户信息加载时判断账号信息是主管还是业务员，主管加载全部信息，显示全部按钮可见
            //业务员只加载本人信息，不加载其他人的信息，
            //而且业务员没有删除客户信息的功能，只有新增和修改


            //获取所有的客户信息




            //根据SaleId返回客户信息，SaleId==UserId




        }






        #region “事件”

        #endregion


        #region "方法"
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

        public void LoadCusInfo()
        {
            if (IsRole())
            {
                //获得所有客户列表
                

            }
            else
            {
                //根据userId返回客户信息列表
            }
        }




        #endregion


    }
}
