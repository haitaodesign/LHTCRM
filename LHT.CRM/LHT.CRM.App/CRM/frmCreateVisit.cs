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
    public partial class frmCreateVisit : Skin_VS
    {
        CRM_Visit cv = new CRM_Visit();
        CRM_VisitLogic cvl = new CRM_VisitLogic();
        public frmCreateVisit()
        {
            InitializeComponent();
        }



        #region "事件"

        #endregion

        #region "方法"

        /// <summary>
        /// 获得输入的拜访信息
        /// </summary>
        public void GetCRM_VisitModel()
        {

        }

        #endregion
    }
}
