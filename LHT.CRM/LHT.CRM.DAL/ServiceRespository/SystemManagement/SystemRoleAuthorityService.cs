using LHT.CRM.DAL.IServiceRespository.ISystemManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHT.CRM.Model;

namespace LHT.CRM.DAL.ServiceRespository.SystemManagement
{
    public class SystemRoleAuthorityService : LHTCRMBaseRespository<LHTCRMEntities>, ISystemRoleAuthority
    {
        public SystemRoleAuthorityService(LHTCRMEntities context) : base(context)
        {
        }
        public SystemRoleAuthorityService():base(new LHTCRMEntities())
        {
        }

        public List<SystemRoleAuthority> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<SystemRoleAuthority> GetAll(int roleId)
        {
            return _dbContext.SystemRoleAuthorities.Where(r => r.RoleId == roleId && r.IsLock==1).ToList();
        }

        public void Add(SystemRoleAuthority roleAuth)
        {
            throw new NotImplementedException();
        }

        public void Delete(int roleAuthId)
        {
            throw new NotImplementedException();
        }

        public void Update(SystemRoleAuthority roleAuth)
        {
            var role = _dbContext.SystemRoleAuthorities.Find(roleAuth.Id);
            if (role != null)
            {
                role.RoleId = roleAuth.RoleId;
                role.ModuleName = roleAuth.ModuleName;
                role.IsLock = roleAuth.IsLock;
            }
        }

        public List<SystemRoleAuthority> GetAllToRoleId(int roleId)
        {
            return _dbContext.SystemRoleAuthorities.Where(r => r.RoleId == roleId).ToList();
        }

        public SystemRoleAuthority GetRoleAuth(int Id)
        {
            return _dbContext.SystemRoleAuthorities.Single(r => r.Id == Id);
        }

        public SystemRoleAuthority GetRoleIdAndModule(int roleId,string moduleName)
        {
            return _dbContext.SystemRoleAuthorities.Single(r => r.RoleId == roleId && r.ModuleName == moduleName);
        }
    }
}
