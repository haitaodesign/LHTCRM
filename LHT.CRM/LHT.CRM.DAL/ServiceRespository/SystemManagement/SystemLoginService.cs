using LHT.CRM.DAL.IServiceRespository.ISystemManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHT.CRM.Model;

namespace LHT.CRM.DAL.ServiceRespository.SystemManagement
{
    public class SystemLoginService : LHTCRMBaseRespository<LHTCRMEntities>, ISystemLogin
    {
        public SystemLoginService(LHTCRMEntities context) : base(context)
        {
        }

        public SystemLoginService() : base(new LHTCRMEntities())
        {
        }

        public List<Model.SystemLogin> GetAll()
        {
            return _dbContext.SystemLogins.ToList();
        }

        public void Add(Model.SystemLogin login)
        {
            if (login != null)
            {
                _dbContext.SystemLogins.Add(login);
            }
        }

        public void Delete(int loginId)
        {
            var login = _dbContext.SystemLogins.Find(loginId);
            if (login != null)
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

        public SystemLogin GetModel(string loginName)
        {
            SystemLogin sl = new SystemLogin();
            try
            {
                sl = _dbContext.SystemLogins.Single(l => l.LoginName == loginName);
                return sl;
            }
            catch
            {
                return null;
            }
            
        }


    }
}
