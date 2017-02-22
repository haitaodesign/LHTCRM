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
    [TestClass]
    public class UnitTestRole
    {
        [TestMethod]
        public async Task testAddRole()
        {
            SystemRole sr = new SystemRole{ RoleName = "普通用户",RoleDescription = "拥有查看基本模块的权限" };
            SystemRoleService srs = new SystemRoleService();
            srs.Add(sr);
            int result = await srs.SaveChangesAsync();
            Assert.IsTrue(result==1);
        }

        [TestMethod]
        public void testLastRole()
        {
            SystemRoleService srs1 = new SystemRoleService();
            SystemRole sr = new SystemRole();
            sr=srs1.LastSystemRole();
            Assert.IsTrue(sr != null);
            Console.WriteLine(sr.RoleName+" "+sr.Id);
        }


        [TestMethod]
        public void DeleteRole()
        {
            SystemRoleService srsl = new SystemRoleService();
            srsl.Delete(1);
            int result = srsl.SaveChanges();
            Assert.IsTrue(result == 1);
        }
    }
}
