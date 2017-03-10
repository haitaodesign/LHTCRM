using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHT.CRM.DAL.ServiceRespository.CRM;
using LHT.CRM.DAL.ServiceRespository.SystemManagement;

namespace LHT.CRM.DALUnitTestProject
{
    [TestClass]
    public class UnitTestVisitDAL
    {
        CRM_VisitService cvs = new CRM_VisitService();
        SystemUserService sus = new SystemUserService();
        CRM_CustomerService ccs = new CRM_CustomerService();
        CRM_ContactService ccons = new CRM_ContactService();
        /// <summary>
        /// 返回拜访管理的字段
        /// </summary>
        [TestMethod]
        public void GetVistList()
        {

            var query = from c in cvs.GetAll()
                        join s in sus.GetAll()
                        on c.VSuperiorId equals s.Id into cs
                        from css in cs.DefaultIfEmpty()
                        select new
                        {
                            Id = c.VSuperiorId,
                            Name = css.UserName
                        };
            


            Assert.IsNotNull(query);
            foreach (var item in query)
            {
                Console.WriteLine(item.Name);
            }
           
        }

        [TestMethod]
        public void MyTestMethod()
        {

            var query2 = from c in cvs.GetAll()
                         join customer in ccs.GetAll()
                         on c.CusId equals customer.Id into cvcs
                         from vcs in cvcs.DefaultIfEmpty()
                         select new
                         {
                             CusId = c.CusId,
                             CusCode = vcs.CusCode,
                             CusName = vcs.CusName,
                         };

            Assert.IsNotNull(query2);

            //构造一个显示列表的类


            foreach (var item in query2)
            {
                Console.WriteLine(item.CusId+item.CusCode+item.CusName);
            }
          
        }

        [TestMethod]
        public void ThreeTableJoin()
        {
            var query3 = from visit in cvs.GetAll()
                         join customer in ccs.GetAll()
                         on visit.CusId equals customer.Id
                         join user in sus.GetAll()
                         on visit.VSuperiorId equals user.Id
                         join contact in ccons.GetAll()
                         on visit.ConId equals contact.Id
                         select new
                         {
                             CusCode = customer.CusCode,
                             CusName = customer.CusName,
                             UserName = user.UserName,
                             ContactName=contact.Name,
                             VTitle=visit.VTitle,
                             VContent=visit.VContent,
                             VType=visit.VType,
                             VPlanDate=visit.VPlanDate,
                             VCompleteDate=visit.VCompleteDate,
                             VSuperiorDate=visit.VSuperiorDate,
                             VSuperiorSuggestion=visit.VSuperiorSuggestion,
                             VStatus=visit.VStatus

                         };
            Assert.IsNotNull(query3);
            foreach (var item in query3)
            {
                Console.WriteLine(item.CusCode+"-"+item.CusName+"-"+item.UserName+" "+item.VContent);
            }
        }
    }
}
