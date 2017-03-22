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
    public partial class frmVisit : Form
    {
        CRM_VisitLogic cvs = new CRM_VisitLogic();
        SystemUserLogic sul = new SystemUserLogic();
        CRM_CustomerLogic ccusl = new CRM_CustomerLogic();
        CRM_ContactLogic cconl = new CRM_ContactLogic();
        public frmVisit()
        {
            InitializeComponent();
        }

        private void frmVisit_Load(object sender, EventArgs e)
        {
            this.dgvVisitInfo.AutoGenerateColumns = false;

            LoadVistList();

        }

        #region "方法"

        /// <summary>
        /// 加载拜访记录列表
        /// </summary>
        public void LoadVistList()
        {
            var showvisitlist = from visit in cvs.GetAll()
                                join customer in ccusl.GetAll()
                                on visit.CusId equals customer.Id
                                join user in sul.GetAllUsers()
                                on visit.VSuperiorId equals user.Id
                                join contact in cconl.GetAll()
                                on visit.ConId equals contact.Id
                                select new
                                {
                                    Id = visit.Id,
                                    CusCode = customer.CusCode,
                                    CusName = customer.CusName,
                                    UserName = user.UserName,
                                    ContactName = contact.Name,
                                    VTitle = visit.VTitle,
                                    VContent = visit.VContent,
                                    VType = visit.VType,
                                    VPlanDate = visit.VPlanDate,
                                    VCompleteDate = visit.VCompleteDate,
                                    VSuperiorDate = visit.VSuperiorDate,
                                    VSuperiorSuggestion = visit.VSuperiorSuggestion,
                                    VStatus = visit.VStatus

                                };
            this.dgvVisitInfo.DataSource = showvisitlist.ToList();
        }

        /// <summary>
        /// 获得修改拜访记录的Id
        /// </summary>
        /// <returns></returns>
        public int GetCRM_VisitId()
        {
            return Convert.ToInt32(this.dgvVisitInfo.CurrentRow.Cells[0].Value);
        }

        public void RefreshVisitList()
        {
            CRM_VisitLogic cvs = new CRM_VisitLogic();
            SystemUserLogic sul = new SystemUserLogic();
            CRM_CustomerLogic ccusl = new CRM_CustomerLogic();
            CRM_ContactLogic cconl = new CRM_ContactLogic();
            var showvisitlist = from visit in cvs.GetAll()
                                join customer in ccusl.GetAll()
                                on visit.CusId equals customer.Id
                                join user in sul.GetAllUsers()
                                on visit.VSuperiorId equals user.Id
                                join contact in cconl.GetAll()
                                on visit.ConId equals contact.Id
                                select new
                                {
                                    Id = visit.Id,
                                    CusCode = customer.CusCode,
                                    CusName = customer.CusName,
                                    UserName = user.UserName,
                                    ContactName = contact.Name,
                                    VTitle = visit.VTitle,
                                    VContent = visit.VContent,
                                    VType = visit.VType,
                                    VPlanDate = visit.VPlanDate,
                                    VCompleteDate = visit.VCompleteDate,
                                    VSuperiorDate = visit.VSuperiorDate,
                                    VSuperiorSuggestion = visit.VSuperiorSuggestion,
                                    VStatus = visit.VStatus

                                };
            this.dgvVisitInfo.DataSource = showvisitlist.ToList();
        }
        #endregion

        #region "事件"
        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateVisit fcv = new frmCreateVisit();
            fcv.ShowDialog();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmCreateVisit fcv = new frmCreateVisit();
            fcv.Owner = this;
            fcv.Text = "修改拜访记录";
            fcv.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //如果当前状态为已审核，则业务员不能删除，只能由主管删除

            //获取Id和记录状态

            string status = this.dgvVisitInfo.CurrentRow.Cells[12].Value.ToString();
            if (status == "False")
            {
                int Id = Convert.ToInt32(this.dgvVisitInfo.CurrentRow.Cells[0].Value);
                cvs.Delete(Id);
                MessageBox.Show("删除成功！");
                LoadVistList();
            }
            else
            {
                MessageBox.Show("已审核记录不能删除！");
            }



        }
        #endregion


    }
}
