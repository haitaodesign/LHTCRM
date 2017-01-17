using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LHT.CRM.Model;
using LHT.CRM.DAL.ServiceRespository.SystemManagement;

namespace LHT.CRM.DALUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SystemLogin s = new SystemLogin();
            SystemLoginService sl = new SystemLoginService();
            s = sl.GetModel("admin");
            Assert.IsTrue(s != null);
            Console.WriteLine(s.LoginName);
        }
        [TestMethod]
        public void testLoginNameisnull()
        {
            SystemLogin s = new SystemLogin();
            SystemLoginService sl = new SystemLoginService();
            s = sl.GetModel("ad");
            Assert.IsTrue(s == null);
        }
    }
}
