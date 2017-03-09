using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHT.CRM.DAL.IServiceRespository.ICRM;
using LHT.CRM.Model;

namespace LHT.CRM.DAL.ServiceRespository.CRM
{
    public class CRM_VisitService : LHTCRMBaseRespository<LHTCRMEntities>, ICRM_Visit
    {
        public CRM_VisitService(LHTCRMEntities context) : base(context)
        {
        }
        public CRM_VisitService():base(new LHTCRMEntities()) { }

        public List<CRM_Visit> GetAll()
        {
            return _dbContext.CRM_Visit.ToList();
        }

        public void Add(CRM_Visit visit)
        {
            throw new NotImplementedException();
        }

        public void Delete(int visitId)
        {
            throw new NotImplementedException();
        }

        public void Update(CRM_Visit visit)
        {
            throw new NotImplementedException();
        }
    }
}
