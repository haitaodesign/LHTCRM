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
    public partial class frmCreateContact : Skin_VS
    {
        CRM_Contact cct = new CRM_Contact();
        CRM_ContactLogic ccl = new CRM_ContactLogic();
        CRM_CustomerLogic cusl = new CRM_CustomerLogic();

        public frmCreateContact()
        {
            InitializeComponent();
        }



        #region "事件"
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (this.Text == "添加联系人信息")
            {
                AddContact();
            }
            else if (this.Text == "修改联系人信息")
            {
                UpdateContact();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frmCreateContact_Load(object sender, EventArgs e)
        {
            frmContact fc;
            fc = (frmContact)this.Owner;
            //加载时，默认显示第一个tab
            metroTabControl1.TabPages[0].Select();
            if (this.Text == "修改联系人信息")
            {
                cct = fc.GetCRM_ContactModel();
                //加载到修改表单
                LoadUpdateContact();
            }
        }
        #endregion

        #region "方法"
        /// <summary>
        /// 获取输入的联系人信息
        /// </summary>
        /// <returns></returns>
        public CRM_Contact GetCRM_ContactModel()
        {
            cct.CId = frmFuncLib.userId;
            cct.CDate = DateTime.Now;

            string cusname = tbCusName.Text;
            if (cusname != null)
            {
                cct.CusId = GetCusId(cusname);
            }
            cct.Name = tbName.Text;
            cct.Gender = cbGender.Text;
            cct.JiGuan = tbJiGuan.Text;
            cct.DeptName = tbDeptName.Text;
            cct.Position = tbPosition.Text;
            cct.Mobile = tbMobile.Text;
            cct.WX = tbWX.Text;
            cct.Email = tbEmail.Text;
            return cct;
        }


        /// <summary>
        /// 通过客户名称获取客户Id
        /// </summary>
        /// <param name="cusname"></param>
        /// <returns></returns>
        public int GetCusId(string cusname)
        {
            return cusl.GetCusId(cusname);

        }


        /// <summary>
        /// 记载修改表单联系人信息
        /// </summary>
        public void LoadUpdateContact()
        {
            tbName.Text = cct.Name;
            tbDeptName.Text = cct.DeptName;
            tbPosition.Text = cct.Position;
            tbMobile.Text = cct.Mobile;
            int cusid =Convert.ToInt32(cct.CusId);
            if(cusid > 0)
            {
                tbCusName.Text = cusl.GetCusName(cusid);
            }
            cbGender.Text = cct.Gender;
            tbJiGuan.Text = cct.JiGuan;
            tbWX.Text = cct.WX;
            tbEmail.Text = cct.Email;
        }

        /// <summary>
        /// 点击确定后添加联系人信息
        /// </summary>
        public void AddContact()
        {
            if (GetCRM_ContactModel() != null)
            {
                ccl.Add(GetCRM_ContactModel());
                MessageBox.Show("添加成功！");
                RefreshContactList();
                this.Close();
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }

        /// <summary>
        /// 修改联系人信息
        /// </summary>
        public void UpdateContact()
        {
            if (GetCRM_ContactModel() != null)
            {
                ccl.Update(GetCRM_ContactModel());
                MessageBox.Show("修改成功！");
                RefreshContactList();
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }

        /// <summary>
        /// 刷新联系人列表
        /// </summary>
        public void RefreshContactList()
        {
            frmContact fc;
            fc = (frmContact)this.Owner;
            fc.LoadContactList();
        }
        #endregion

       
    }
}
