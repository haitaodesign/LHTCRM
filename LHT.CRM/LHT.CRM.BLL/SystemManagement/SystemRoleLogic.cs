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
        SystemRoleService srs = new SystemRoleService();
        SystemRole sr = new SystemRole();
        /// <summary>
        /// 返回角色列表信息
        /// </summary>
        /// <returns></returns>
        public List<SystemRole> GetAll()
        {
            List<SystemRole> list = srs.GetAll();
            return list;
        }

        public int Add(SystemRole role)
        {
            if (role != null)
            {
                sr.RoleName = role.RoleName;
                sr.RoleDescription = role.RoleDescription;
                srs.Add(sr);
                int result=srs.SaveChanges();
                return result;
            }
            else
            {
                return 0;
            }
        }

        public int RoleId()
        {
           sr= srs.LastSystemRole();
            return sr.Id;
        }

        public int Update(SystemRole role)
        {
            if (role != null)
            {
                srs.Update(role);
                return srs.SaveChanges();
            }
            else
            {
                return 0;
            }
        }
    }
}
