using LHT.CRM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHT.CRM.DAL.IServiceRespository.ICRM
{
    interface ICRM_Visit
    {
        List<CRM_Visit> GetAll();

        CRM_Visit GetModel(int id);

        void Add(CRM_Visit visit);

        void Delete(int id);

        void Update(CRM_Visit visit);
    }
}
