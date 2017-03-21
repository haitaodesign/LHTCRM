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
using LHT.CRM.Model;

namespace LHT.CRM.App.CRM
{
    public partial class frmTarget : Form
    {
        CRM_TargetLogic ctl = new CRM_TargetLogic();
        CRM_Target ct = new CRM_Target();
        public frmTarget()
        {
            InitializeComponent();
        }
        private void frmTarget_Load(object sender, EventArgs e)
        {

            this.dgvTargetInfo.AutoGenerateColumns = false;
            LoadTargetList();
        }


        #region "事件"
        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateTarget fct = new frmCreateTarget();
            fct.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmCreateTarget fctar = new frmCreateTarget();
            fctar.Owner = this;
            fctar.Text = "修改销售目标";
            fctar.ShowDialog();
        }
        #endregion

        #region "方法"

        //获取目标列表，通过UserId获取业务员姓名，一个拥业务员有多个目标

        public void LoadTargetList()
        {
            this.dgvTargetInfo.DataSource = ctl.GetAll();
        }


        public CRM_Target GetCRM_TargetModel()
        {
            ct.Id = Convert.ToInt32(this.dgvTargetInfo.CurrentRow.Cells[0].Value);
            ct.Period = this.dgvTargetInfo.CurrentRow.Cells[1].Value.ToString();
            ct.Target1 =Convert.ToInt32(this.dgvTargetInfo.CurrentRow.Cells[2].Value);
            ct.Target2 = Convert.ToUInt32(this.dgvTargetInfo.CurrentRow.Cells[3].Value);
            ct.Target3 = Convert.ToUInt32(this.dgvTargetInfo.CurrentRow.Cells[4].Value);
            ct.Target4 = Convert.ToUInt32(this.dgvTargetInfo.CurrentRow.Cells[5].Value);
            return ct;
        }


        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            int tarId =Convert.ToInt32(this.dgvTargetInfo.CurrentRow.Cells[0].Value);
            if (tarId.ToString()!=null)
            {
                ctl.Delete(tarId);
                MessageBox.Show("删除成功！");
                LoadTargetList();
            }
            else
            {
                MessageBox.Show("删除失败！");
            }
        }
    }
}
