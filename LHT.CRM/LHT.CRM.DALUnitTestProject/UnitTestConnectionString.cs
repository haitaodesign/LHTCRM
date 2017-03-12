using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHT.CRM.DAL;

namespace LHT.CRM.DALUnitTestProject
{
    [TestClass]
    public class UnitTestConnectionString
    {
        [TestMethod]
        public void TestOpenDB()
        {
            bool result = DBConnection.OpenDB();
            Assert.IsTrue(result);
        }
    }
}
