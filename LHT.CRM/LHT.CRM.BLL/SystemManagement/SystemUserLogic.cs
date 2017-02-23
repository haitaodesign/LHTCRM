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
        List<SystemUser> list;
        /// <summary>
        /// 返回所有用户列表
        /// </summary>
        /// <returns></returns>
        public List<SystemUser> GetAllUsers()
        {
            return sus.GetAll();
        }



        /// <summary>
        /// 添加一个用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int AddUser(SystemUser user)
        {
            if (user != null)
            {
                sus.Add(user);
                int result = sus.SaveChanges();
                return result;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 根据登录账号返回用户Id
        /// </summary>
        /// <param name="loginname"></param>
        /// <returns></returns>
        public int GetId(string loginname)
        {
            list = sus.GetAll();
            return list.Find(u => u.LoginName == loginname).Id;
        }


    }
}
