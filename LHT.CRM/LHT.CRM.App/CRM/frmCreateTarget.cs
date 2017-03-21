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
    public partial class frmCreateTarget : Skin_VS
    {
        CRM_Target ct = new CRM_Target();
        CRM_TargetLogic ctl = new CRM_TargetLogic();
        public frmCreateTarget()
        {
            InitializeComponent();
        }

        private void frmCreateTarget_Load(object sender, EventArgs e)
        {
            if (this.Text == "修改销售目标")
            {
                frmTarget ft;
                ft = (frmTarget)this.Owner;
                ct = ft.GetCRM_TargetModel();
                LoadUpdateTarget();
            }
        }
        #region "事件"
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (this.Text == "添加销售目标")
            {
                AddTarget();
            }else if (this.Text == "修改销售目标")
            {
                UpdateTarget();
            }
        }
        #endregion

        #region "方法"
        /// <summary>
        /// 获取输入的目标信息
        /// </summary>
        /// <returns></returns>
        public CRM_Target GetCRM_TargetModel()
        {
            ct.CId = frmFuncLib.userId;
            ct.CDate = DateTime.Now;
            ct.Period = dtPeriod.Text;
            ct.Target1 =Convert.ToDecimal(tbTarget1.Text);
            ct.Target2 =Convert.ToDecimal(tbTarget2.Text);
            ct.Target3= Convert.ToDecimal(tbTarget3.Text);
            ct.Target4= Convert.ToDecimal(tbTarget4.Text);
            ct.UserName = frmFuncLib.userName;
            return ct;

        }
        public CRM_Target GetUpdateCRM_TargetModel()
        {
            ct.MId = frmFuncLib.userId;
            ct.MDate = DateTime.Now;
            ct.Period = dtPeriod.Text;
            ct.Target1 = Convert.ToDecimal(tbTarget1.Text);
            ct.Target2 = Convert.ToDecimal(tbTarget2.Text);
            ct.Target3 = Convert.ToDecimal(tbTarget3.Text);
            ct.Target4 = Convert.ToDecimal(tbTarget4.Text);
            ct.UserName = frmFuncLib.userName;
            return ct;

        }
        /// <summary>
        /// 加载修改销售目标信息
        /// </summary>
        public void LoadUpdateTarget()
        {
            dtPeriod.Text = ct.Period;
            tbTarget1.Text = ct.Target1.ToString();
            tbTarget2.Text = ct.Target2.ToString();
            tbTarget3.Text = ct.Target3.ToString();
            tbTarget4.Text = ct.Target4.ToString();
        }

        /// <summary>
        /// 添加销售目标
        /// </summary>
        public void AddTarget()
        {
            GetCRM_TargetModel();
            if (ct != null)
            {
                ctl.Add(ct);
                MessageBox.Show("添加成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }

        public void UpdateTarget()
        {
            GetUpdateCRM_TargetModel();
            if (ct != null)
            {
                ctl.Update(ct);
                MessageBox.Show("修改成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }

        #endregion

        


       
    }
}
