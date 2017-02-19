using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHT.CRM.Model;
using LHT.CRM.DAL.ServiceRespository.SystemManagement;

namespace LHT.CRM.BLL.SystemManagement
{
    public class SystemRoleAuthorityLogic
    {
        SystemRoleAuthorityService sras = new SystemRoleAuthorityService();
        public List<SystemRoleAuthority> GetAuthList(int roleId)
        {
            return sras.GetAll(roleId);
        }

        public List<SystemRoleAuthority> GetAllAuthList(int roleId)
        {
            return sras.GetAllToRoleId(roleId);
        }

        public int UpdateRoleAuth(SystemRoleAuthority roleAuth)
        {
            if (roleAuth != null)
            {
                sras.Update(roleAuth);
                int result = sras.SaveChanges();
                return result;
            }
            else
            {
                return 0;
            }
        }

        public SystemRoleAuthority GetRoleIdAndModule(int roleId,string moduleName)
        {
            return sras.GetRoleIdAndModule(roleId, moduleName);
        }
    }
}
