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
    }
}
