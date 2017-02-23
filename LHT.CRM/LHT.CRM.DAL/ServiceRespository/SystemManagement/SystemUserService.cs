using LHT.CRM.DAL.IServiceRespository.ISystemManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHT.CRM.Model;

namespace LHT.CRM.DAL.ServiceRespository.SystemManagement
{
    public class SystemUserService : LHTCRMBaseRespository<LHTCRMEntities>, ISystemUser
    {
        public SystemUserService(LHTCRMEntities context) : base(context)
        {
        }
        public SystemUserService():base(new LHTCRMEntities())
        {
        }

        public List<SystemUser> GetAll()
        {
            return _dbContext.SystemUsers.ToList();
        }

        public void Add(SystemUser user)
        {
            if (user != null)
            {
                _dbContext.SystemUsers.Add(user);
            }
        }

        public void Delete(int userId)
        {
            throw new NotImplementedException();
        }

        public void Update(SystemUser user)
        {
            throw new NotImplementedException();
        }
    }
}
