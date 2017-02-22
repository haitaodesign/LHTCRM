using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHT.CRM.DAL.ServiceRespository.SystemManagement;
using LHT.CRM.Model;

namespace LHT.CRM.DALUnitTestProject
{
    [TestClass]
    public class UnitTestUser
    {
        [TestMethod]
        public void TestUserList()
        {
            SystemUserService sus = new SystemUserService();
            List<SystemUser> list=  sus.GetAll();
            Assert.IsNotNull(list);
            foreach (var item in list)
            {
                Console.WriteLine(item.UserName);
            }
        }
    }
}
