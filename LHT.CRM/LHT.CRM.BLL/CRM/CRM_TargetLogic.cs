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


        public int Add(CRM_Target target)
        {
            cts.Add(target);
            int result = cts.SaveChanges();
            if (result > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }


        public int Delete(int targetId)
        {
            cts.Delete(targetId);
            int result = cts.SaveChanges();
            if (result > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int Update(CRM_Target target)
        {
            cts.Update(target);
            int result = cts.SaveChanges();
            if (result > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

    }
}
