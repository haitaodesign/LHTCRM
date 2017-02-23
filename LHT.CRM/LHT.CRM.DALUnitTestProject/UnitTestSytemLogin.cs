using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHT.CRM.Model;
using LHT.CRM.DAL.ServiceRespository.SystemManagement;

namespace LHT.CRM.DALUnitTestProject
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class UnitTestSytemLogin
    {
        [TestMethod]
        public void TestAddLogin()
        {
            SystemLogin sl = new SystemLogin();
            SystemLoginService sls = new SystemLoginService();
            sl.LoginName = "aaaaa";
            sl.Password = "3333333";
            sl.IsLock = 1;
            sls.Add(sl);
            int result = sls.SaveChanges();
            Assert.IsTrue(result==1);
        }
    }
 
}
