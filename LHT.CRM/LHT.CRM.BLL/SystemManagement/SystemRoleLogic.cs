using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHT.CRM.Model;
using LHT.CRM.DAL.ServiceRespository.SystemManagement;

namespace LHT.CRM.BLL.SystemManagement
{
    public class SystemRoleLogic
    {
        /// <summary>
        /// 返回角色列表信息
        /// </summary>
        /// <returns></returns>
        public List<SystemRole> GetAll()
        {
            SystemRoleService srs = new SystemRoleService();
            List<SystemRole> list = srs.GetAll();
            return list;
        }

        public int Add(SystemRole role)
        {
            if (role != null)
            {
                SystemRole sr = new SystemRole();
                sr.RoleName = role.RoleName;
                sr.RoleDescription = role.RoleDescription;
                SystemRoleService srs = new SystemRoleService();
                srs.Add(sr);
                int result=srs.SaveChanges();
                return result;
            }
            else
            {
                return 0;
            }
        }

    }
}
