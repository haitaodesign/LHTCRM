using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHT.CRM.DAL.ServiceRespository.SystemManagement;

namespace LHT.CRM.DALUnitTestProject
{
    [TestClass]
    public class UintTestRoleAuthority
    {
        [TestMethod]
        public void GetRoleAuthToRoleId()
        {
            SystemRoleAuthorityService sras = new SystemRoleAuthorityService();
            var id = 1;
            Assert.IsTrue(sras.GetAll(id) != null);
            foreach (var item in sras.GetAll(id))
            {
                Console.WriteLine(item.ModuleName);
            }
            
        }
    }
}
