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

        #endregion


    }
}
