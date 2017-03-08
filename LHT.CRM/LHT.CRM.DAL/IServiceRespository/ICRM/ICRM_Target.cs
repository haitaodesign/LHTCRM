using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHT.CRM.Model;

namespace LHT.CRM.DAL.IServiceRespository.ICRM
{
    interface ICRM_Target
    {
        List<CRM_Target> GetAll();

        void Add(CRM_Target target);

        void Delete(int targetId);

        void Update(CRM_Target target);
    }
}
