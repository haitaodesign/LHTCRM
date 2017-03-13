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
using LHT.CRM.BLL.SystemManagement;
using LHT.CRM.Model;



namespace LHT.CRM.App.CRM
{
    public partial class frmCustomer : Form
    {
        CRM_CustomerLogic ccl = new CRM_CustomerLogic();
        SystemUserLogic sul = new SystemUserLogic();
        int saleid = frmFuncLib.userId;

        CRM_Customer cc = new CRM_Customer();

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


        /// <summary>
        /// 主管切换客户列表显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// 新建客户窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateCustomer fcc = new frmCreateCustomer();
            fcc.Show();
        }




        #endregion
        /// <summary>
        /// 修改客户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //获取选中的客户信息，新建修改信息窗体，填充修改数据，点击确认修改数据
            //GetCRM_CustomerModel();
            frmCreateCustomer fcc = new frmCreateCustomer();
            fcc.Owner = this;
            fcc.Text = "修改客户信息";
            fcc.ShowDialog();
        }

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
            var showCusList = from customer in ccl.GetAll(saleid)
                              join user in sul.GetAllUsers()
                              on customer.SaleId equals user.Id
                              select new
                              {
                                  Id=customer.Id,
                                  CusCode=customer.CusCode,
                                  CusName=customer.CusName,
                                  Province=customer.Province,
                                  City=customer.City,
                                  BussinessType = customer.BussinessType,
                                  Scale=customer.Scale,
                                  CusType=customer.CusType,
                                  PhoneNum=customer.PhoneNum,
                                  HomePage=customer.HomePage,
                                  Address=customer.Address,
                                  UserName=user.UserName,
                                  SaleId=customer.SaleId
                              };
            dgvCusInfo.DataSource = showCusList.ToList();
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

        /// <summary>
        /// 返回一个客户对象实体，供修改页面使用
        /// </summary>
        /// <returns></returns>
        public CRM_Customer GetCRM_CustomerModel()
        {
            cc.Id = Convert.ToInt32(this.dgvCusInfo.CurrentRow.Cells[0].Value.ToString());
            cc.CusCode = this.dgvCusInfo.CurrentRow.Cells[1].Value.ToString();
            cc.CusName = this.dgvCusInfo.CurrentRow.Cells[2].Value.ToString();
            cc.Province = this.dgvCusInfo.CurrentRow.Cells[3].Value.ToString();
            cc.City = this.dgvCusInfo.CurrentRow.Cells[4].Value.ToString();
            cc.BussinessType = this.dgvCusInfo.CurrentRow.Cells[5].Value.ToString();
            cc.Scale = this.dgvCusInfo.CurrentRow.Cells[6].Value.ToString();
            cc.CusType = this.dgvCusInfo.CurrentRow.Cells[7].Value.ToString();
            cc.PhoneNum = this.dgvCusInfo.CurrentRow.Cells[8].Value.ToString();
            cc.HomePage = this.dgvCusInfo.CurrentRow.Cells[9].Value.ToString();
            cc.Address = this.dgvCusInfo.CurrentRow.Cells[10].Value.ToString();
            cc.SaleId = sul.GetSaleId(this.dgvCusInfo.CurrentRow.Cells[11].Value.ToString());
            return cc;
        }



        //查询返回有业务员名称的列表填充客户列表
        //客户表和用户表联查









        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int currselectedid= Convert.ToInt32(this.dgvCusInfo.CurrentRow.Cells[0].Value.ToString());
            int result=ccl.DeleteCustomer(currselectedid);
            if (result == 1)
            {
                MessageBox.Show("删除成功！","提示",MessageBoxButtons.OK);
                //刷新页面
                if (btnShowAll.Text == "显示全部")
                {
                    ShowAllCusInfo();
                }
                else if (btnShowAll.Text == "显示本人")
                {
                    LoadCusInfo();
                }
            }
            else
            {
                MessageBox.Show("删除失败！", "提示", MessageBoxButtons.OK);
            }

        }
    }
}
