using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHT.CRM.DAL.IServiceRespository.ICRM;
using LHT.CRM.Model;

namespace LHT.CRM.DAL.ServiceRespository.CRM
{
    public class CRM_TargetService : LHTCRMBaseRespository<LHTCRMEntities>, ICRM_Target
    {
        public CRM_TargetService(LHTCRMEntities context) : base(context) { }

        public CRM_TargetService():base(new LHTCRMEntities()) { }

        public void Add(CRM_Target target)
        {
            throw new NotImplementedException();
        }

        public void Delete(int targetId)
        {
            throw new NotImplementedException();
        }

        public List<CRM_Target> GetAll()
        {
            return _dbContext.CRM_Target.ToList();
        }

        public void Update(CRM_Target target)
        {
            throw new NotImplementedException();
        }
    }
}
