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
            var user = _dbContext.SystemUsers.Find(userId);
            if (user != null)
            {
                _dbContext.SystemUsers.Remove(user);
            }
        }

        public void Update(SystemUser user)
        {
            var updateuser = _dbContext.SystemUsers.Find(user.Id);
            if (updateuser != null)
            {
                updateuser.UserName = user.UserName;
                updateuser.Sex = user.Sex;
                updateuser.Age = user.Age;
                updateuser.Phone = user.Phone;
                updateuser.Email = user.Email;
                updateuser.QQ = user.QQ;
                updateuser.RoleId = user.RoleId;
                updateuser.RoleName = user.RoleName;
                updateuser.LoginName = user.LoginName;
            }
        }
    }
}
