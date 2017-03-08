using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHT.CRM.Model;
using LHT.CRM.DAL.ServiceRespository.CRM;

namespace LHT.CRM.BLL.CRM
{
    public class CRM_ContactLogic
    {
        CRM_ContactService ccs = new CRM_ContactService();
        public List<CRM_Contact> GetAll()
        {
            return ccs.GetAll();
        }
    }
}
