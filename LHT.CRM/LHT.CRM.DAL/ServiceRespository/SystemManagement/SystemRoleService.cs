using LHT.CRM.DAL.IServiceRespository.ISystemManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHT.CRM.Model;

namespace LHT.CRM.DAL.ServiceRespository.SystemManagement
{
    public class SystemRoleService : LHTCRMBaseRespository<LHTCRMEntities>, ISystemRole
    {
        public SystemRoleService(LHTCRMEntities context) : base(context)
        {
        }
        
        public SystemRoleService():base(new LHTCRMEntities())
        {

        }

        public SystemRole LastSystemRole()
        {
            return _dbContext.SystemRoles.ToList().LastOrDefault();
        }

        public void Add(SystemRole role)
        {
            if (role != null)
            {
                _dbContext.SystemRoles.Add(role);
            }
        }

        public void Delete(int roleId)
        {
            var role = _dbContext.SystemRoles.Find(roleId);
            if (role != null)
            {
                _dbContext.SystemRoles.Remove(role);
            }
        }

        public List<SystemRole> GetAll()
        {
            return _dbContext.SystemRoles.ToList();
        }

        public void Update(SystemRole role)
        {
            var sRole = _dbContext.SystemRoles.Find(role.Id);
            if (role != null)
            {
                sRole.RoleName = role.RoleName;
                sRole.RoleDescription = role.RoleDescription;
            }
        }

    }
}
