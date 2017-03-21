using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHT.CRM.DAL.ServiceRespository.CRM;
using LHT.CRM.Model;

namespace LHT.CRM.BLL.CRM
{
    public class CRM_TargetLogic
    {
        CRM_TargetService cts = new CRM_TargetService();
        public List<CRM_Target> GetAll()
        {
            return cts.GetAll();
        }
           
    }
}
