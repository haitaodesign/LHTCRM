using LHT.CRM.DAL.IServiceRespository.ISystemManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHT.CRM.DAL.ServiceRespository.SystemManagement
{
    public class SystemLogin : LHTCRMBaseRespository<LHTCRMEntities>, ISystemLogin
    {
        public SystemLogin(LHTCRMEntities context) : base(context)
        {
        }

        public SystemLogin():base(new LHTCRMEntities())
        {
        }



        public void Add(DAL.SystemLogin login)
        {
            throw new NotImplementedException();
        }

        public void Delete(int loginId)
        {
            throw new NotImplementedException();
        }

        public List<DAL.SystemLogin> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(DAL.SystemLogin login)
        {
            throw new NotImplementedException();
        }
    }
}
