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
            metroTabControl1.TabPages[0].Select();
            IsSugg();
            if (this.Text == "修改拜访记录")
            {
                frmVisit fcv;
                fcv = (frmVisit)this.Owner;
                int visitId = fcv.GetCRM_VisitId();
                cv = cvl.GetCRM_VisitModel(visitId);
                LoadUpdateCRM_Visit();
            }

        }


        #region "事件"
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (this.Text == "拜访记录")
            {
                GetCRM_VisitModel();
                if (cv != null)
                {
                    cvl.Add(cv);
                    MessageBox.Show("添加成功！");
                    RefreshVisitList();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("添加失败！");
                }
            }
            else if(this.Text=="修改拜访记录")
            {
                if (cv != null)
                {
                    GetUpdateCRM_VisitModel();
                    if (cv != null)
                    {
                        cvl.Update(cv);
                        MessageBox.Show("修改成功！");
                        RefreshVisitList();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("修改失败！");
                    }
                }
            }
            
        }
        #endregion

        #region "方法"

        /// <summary>
        /// 添加拜访记录时获得输入的拜访信息
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

        /// <summary>
        /// 加载拜访记录修改信息
        /// </summary>
        public void LoadUpdateCRM_Visit()
        {
            tbCusCode.Text = cv.CusId.ToString();
            tbCusName.Text = ccl.GetCusName((Int32)cv.CusId);
            tbContactName.Text = conl.GetConName((Int32)cv.ConId);
            tbVTitle.Text = cv.VTitle;
            tbContent.Text = cv.VContent;
            cbVType.Text = cv.VType;
            dtVPlanDate.Text = cv.VPlanDate.ToString();
            dtVCompleteDate.Text = cv.VCompleteDate.ToString();
        }

        /// <summary>
        /// 获得修改拜访记录的信息实体
        /// </summary>
        public void GetUpdateCRM_VisitModel()
        {

            cv.MId = frmFuncLib.userId;
            cv.MDate = DateTime.Now;
            cv.CusId = ccl.GetCusId(tbCusName.Text);
            cv.ConId = conl.GetConId(tbContactName.Text);
            cv.VTitle = tbVTitle.Text;
            cv.VContent = tbContent.Text;
            cv.VType = cbVType.Text;
            cv.VPlanDate = Convert.ToDateTime(dtVPlanDate.Text);
            cv.VCompleteDate = Convert.ToDateTime(dtVCompleteDate.Text);
        }

        public void RefreshVisitList()
        {
            frmVisit fv = new frmVisit();
            fv = (frmVisit)this.Owner;
            fv.RefreshVisitList();
        }

        #endregion

       
    }
}
