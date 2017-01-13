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

        public List<Model.SystemLogin> GetAll()
        {
            return _dbContext.SystemLogins.ToList();
        }

        public void Add(Model.SystemLogin login)
        {
            if(login != null)
            {
                _dbContext.SystemLogins.Add(login);
            }
        }

        public void Delete(int loginId)
        {
            var login = _dbContext.SystemLogins.Find(loginId);
            if (login!=null)
            {
                _dbContext.SystemLogins.Remove(login);
            }
        }

        public void Update(Model.SystemLogin login)
        {
            var updatelogin = _dbContext.SystemLogins.Find(login.Id);
            if (updatelogin != null)
            {
                updatelogin.LoginName = login.LoginName;
                updatelogin.Password = login.Password;
                updatelogin.IsLock = login.IsLock;
                updatelogin.UserId = login.UserId;
            }
        }
    }
}
