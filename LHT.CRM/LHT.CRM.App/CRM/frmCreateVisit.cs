using System;
using CCWin;
using LHT.CRM.Model;
using LHT.CRM.BLL.CRM;
using System.Windows.Forms;

namespace LHT.CRM.App.CRM
{
    public partial class frmCreateVisit : Skin_VS
    {
        CRM_Visit cv = new CRM_Visit();
        CRM_VisitLogic cvl = new CRM_VisitLogic();
        CRM_CustomerLogic ccl = new CRM_CustomerLogic();
        CRM_ContactLogic conl = new CRM_ContactLogic();
        public frmCreateVisit()
        {
            InitializeComponent();
        }
        private void frmCreateVisit_Load(object sender, EventArgs e)
        {
            IsSugg();
        }


        #region "事件"
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            GetCRM_VisitModel();
            if (cv != null)
            {
                cvl.Add(cv);
                MessageBox.Show("添加成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }
        #endregion

        #region "方法"

        /// <summary>
        /// 获得输入的拜访信息
        /// </summary>
        public void GetCRM_VisitModel()
        {
            cv.CId = frmFuncLib.userId;
            cv.CDate = DateTime.Now;
            cv.CusId = ccl.GetCusId(tbCusName.Text);
            cv.ConId = conl.GetConId(tbContactName.Text);
            cv.VTitle = tbVTitle.Text;
            cv.VContent = tbContent.Text;
            cv.VType = cbVType.Text;
            cv.VPlanDate =Convert.ToDateTime(dtVPlanDate.Text);
            cv.VCompleteDate = Convert.ToDateTime(dtVCompleteDate.Text);
            cv.VStatus = false;
        }


        /// <summary>
        /// 批示权限
        /// </summary>
        public void IsSugg()
        {
            if (frmFuncLib.roleName == "业务员")
            {
                tbVSuperiorSuggestion.Text = "您没有批示权限，请联系管理员开通！";
                tbVSuperiorSuggestion.ReadOnly = false;
            }
        }


        #endregion

       
    }
}
