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


        /// <summary>
        /// 根据业务员名字返回Id
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public int GetSaleId(string username)
        {
            list = sus.GetAll();
            return list.Find(u => u.UserName == username).Id;
        }


        /// <summary>
        /// 根据Id返回一个用户对象
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public SystemUser GetUserModel(int Id)
        {
            list = sus.GetAll();
            return list.Find(u => u.Id == Id);
        }


        public int Update(SystemUser user)
        {
            sus.Update(user);
            int result = sus.SaveChanges();
            if (result == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int Delete(int userId)
        {
            sus.Delete(userId);
            int result = sus.SaveChanges();
            if (result == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}