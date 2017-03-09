using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHT.CRM.Model;

namespace LHT.CRM.DAL.IServiceRespository.ICRM
{
    interface ICRM_Visit
    {
        List<CRM_Visit> GetAll();

        void Add(CRM_Visit visit);

        void Delete(int visitId);

        void Update(CRM_Visit visit);
    }
}
