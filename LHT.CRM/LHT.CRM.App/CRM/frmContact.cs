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
    public partial class frmContact : Form
    {
        CRM_ContactLogic ccl = new CRM_ContactLogic();
        CRM_Contact cct = new CRM_Contact();
        CRM_CustomerLogic cusl = new CRM_CustomerLogic();
        public frmContact()
        {
            InitializeComponent();
        }

        private void frmContact_Load(object sender, EventArgs e)
        {
            this.dgvContactInfo.AutoGenerateColumns = false;
            LoadContactList();
        }

        #region "事件"
        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateContact fcc = new frmCreateContact();
            fcc.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmCreateContact fcc = new frmCreateContact();
            fcc.Owner = this;
            fcc.Text = "修改联系人信息";
            fcc.ShowDialog();
        }
        #endregion

        #region "方法"

        /// <summary>
        /// 显示联系人列表
        /// </summary>
        public void LoadContactList()
        {
            dgvContactInfo.DataSource = null;
            var querylist = from contact in ccl.GetAll()
                            join customer in cusl.GetAll()
                            on contact.CusId equals customer.Id
                            select new
                            {
                                Id = contact.Id,
                                CusName = customer.CusName,
                                Name = contact.Name,
                                Gender = contact.Gender,
                                JiGuan=contact.JiGuan,
                                DeptName= contact.DeptName,
                                Position = contact.Position,
                                Mobile = contact.Mobile,
                                WX= contact.WX,
                                Email = contact.Email
                            };
            dgvContactInfo.DataSource = querylist.ToList();
        }


        /// <summary>
        /// 修改的联系人信息写入修改表单
        /// </summary>
        public CRM_Contact GetCRM_ContactModel()
        {
            //获取当前行的联系人信息
            cct.Id = Convert.ToInt32(this.dgvContactInfo.CurrentRow.Cells[0].Value);
            cct.MId = frmFuncLib.userId;
            cct.MDate = DateTime.Now;
            cct.Name = this.dgvContactInfo.CurrentRow.Cells[1].Value.ToString();
            cct.Gender= this.dgvContactInfo.CurrentRow.Cells[2].Value.ToString();
            cct.JiGuan= this.dgvContactInfo.CurrentRow.Cells[3].Value.ToString();
            cct.DeptName = this.dgvContactInfo.CurrentRow.Cells[4].Value.ToString();
            cct.Position= this.dgvContactInfo.CurrentRow.Cells[5].Value.ToString();
            cct.Mobile= this.dgvContactInfo.CurrentRow.Cells[6].Value.ToString();
            cct.WX= this.dgvContactInfo.CurrentRow.Cells[7].Value.ToString();
            cct.Email= this.dgvContactInfo.CurrentRow.Cells[8].Value.ToString();
            string cusname = this.dgvContactInfo.CurrentRow.Cells[9].Value.ToString();
            if (cusname != null)
            {
                cct.CusId = cusl.GetCusId(cusname);
            }
            return cct;
        }





        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {
        }
    }
}
