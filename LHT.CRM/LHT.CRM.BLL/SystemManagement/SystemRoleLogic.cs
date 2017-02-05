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
        //返回角色列表信息
        public List<SystemRole> GetAll()
        {
            SystemRoleService srs = new SystemRoleService();
            List<SystemRole> list = srs.GetAll();
            return list;
        }

    }
}
