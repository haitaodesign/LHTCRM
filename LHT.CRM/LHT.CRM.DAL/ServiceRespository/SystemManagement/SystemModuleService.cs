using LHT.CRM.DAL.IServiceRespository.ISystemManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHT.CRM.Model;

namespace LHT.CRM.DAL.ServiceRespository.SystemManagement
{
    public class SystemModuleService : LHTCRMBaseRespository<LHTCRMEntities>, ISystemModule
    {
        public SystemModuleService(LHTCRMEntities context) : base(context)
        {
        }
        public SystemModuleService():base(new LHTCRMEntities())
        {
        }

        public List<SystemModule> GetAll()
        {
            return _dbContext.SystemModules.ToList();
        }

        public void Add(SystemModule sm)
        {
            throw new NotImplementedException();
        }

        public void Delete(int smId)
        {
            throw new NotImplementedException();
        }

        public void Update(SystemModule sm)
        {
            throw new NotImplementedException();
        }
    }
}
