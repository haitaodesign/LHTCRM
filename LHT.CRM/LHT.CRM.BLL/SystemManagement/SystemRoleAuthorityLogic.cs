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
        public List<SystemRoleAuthority> GetAuthList(int roleId)
        {
            SystemRoleAuthorityService sras = new SystemRoleAuthorityService();
            return sras.GetAll(roleId);
        }
    }
}
