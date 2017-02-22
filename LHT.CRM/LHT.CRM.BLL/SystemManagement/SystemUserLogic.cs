using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHT.CRM.Model;
using LHT.CRM.DAL.ServiceRespository.SystemManagement;

namespace LHT.CRM.BLL.SystemManagement
{
    
    public class SystemUserLogic
    {
        SystemUserService sus = new SystemUserService();
        /// <summary>
        /// 返回所有用户列表
        /// </summary>
        /// <returns></returns>
        public List<SystemUser> GetAllUsers()
        {
            return sus.GetAll();
        }




    }
}
