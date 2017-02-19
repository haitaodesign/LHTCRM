using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHT.CRM.Model;
using LHT.CRM.DAL.ServiceRespository.SystemManagement;

namespace LHT.CRM.BLL.SystemManagement
{
    public class SystemModuleLogic
    {
        /// <summary>
        /// 返回功能模块列表
        /// </summary>
        /// <returns></returns>
        public List<SystemModule> GetAllModule()
        {
            SystemModuleService sms = new SystemModuleService();
            return sms.GetAll();
        }
    }
}
