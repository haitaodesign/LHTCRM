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

namespace LHT.CRM.App
{
    public partial class frmMain : Skin_VS
    {
        #region “定义系统全局字段”
        public static string loginName;
        public static int userId;
        #endregion


        public frmMain()
        {
            InitializeComponent();
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            Button btn = new Button();
            btn.Text = "添加一个按钮";
            skinTabControl1.TabPages[this.skinTabControl1.TabPages.Count - 1].Controls.Add(btn);
        }

        private void skinListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //窗体初始化时，通过UserId查找角色，找到角色对应的子模块权限，动态加载到顶级模块的下面





    }
}
