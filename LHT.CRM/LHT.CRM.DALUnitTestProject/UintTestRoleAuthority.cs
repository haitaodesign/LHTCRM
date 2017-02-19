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
        [TestMethod]
        public void testUpdate()
        {
            SystemRoleAuthorityService sras = new SystemRoleAuthorityService();
            SystemRoleAuthority sra = new SystemRoleAuthority();
            sra.Id = 1;
            sra.ModuleName = "客户";
            sra.RoleId = 1;
            sra.IsLock = 0;
            sras.Update(sra);
            sras.SaveChanges();
            Assert.IsTrue(sra.IsLock == sras.GetRoleAuth(1).IsLock);
            Console.WriteLine(sras.GetRoleAuth(1).IsLock);

        }
    }
}
