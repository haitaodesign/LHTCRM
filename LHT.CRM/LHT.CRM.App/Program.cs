using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LHT.CRM.App.Settings;
using LHT.CRM.App.CRM;

namespace LHT.CRM.App
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
            //Application.Run(new frmLogin());
            //Application.Run(new frmSystemSetting());
            //Application.Run(new frmCreateRole());
            //Application.Run(new frmCreateAuthority());
            //Application.Run(new frmCustomer());
        }
    }
}
