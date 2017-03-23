using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHT.CRM.DAL.ServiceRespository.SystemManagement;
using LHT.CRM.Model;
using LHT.CRM.DAL;


namespace LHT.CRM.BLL.SystemManagement
{
    public class SystemLoginLogic
    {
        SystemLoginService sls = new SystemLoginService();
        SystemLogin sl;
        //账号是否存在
        public bool IsExist(string loginName)
        {
            sl = sls.GetModel(loginName);
            if (sl != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 判断密码和账号是否匹配
        /// </summary>
        /// <param name="loginname"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool LoginNameAndPasswordIsMatch(string loginname,string password)
        {
            sl = sls.GetModel(loginname);
            if (sl.Password == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 添加一个账号
        /// </summary>
        /// <param name="sl"></param>
        /// <returns></returns>
        public int AddLogin(SystemLogin sl)
        {
            sls.Add(sl);
            int reuslt = sls.SaveChanges();
            if (reuslt != 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 获得账号列表
        /// </summary>
        /// <returns></returns>
        public List<SystemLogin> GetAllLogin()
        {
            return sls.GetAll();
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sl"></param>
        /// <returns></returns>
        public int Update(SystemLogin sl)
        {
            sls.Update(sl);
            int result = sls.SaveChanges();
            if (result != 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 根据用户名返回一个实体
        /// </summary>
        /// <param name="loginname"></param>
        /// <returns></returns>
        public SystemLogin GetLoginModel(string loginname)
        {
            return sls.GetModel(loginname);
        }

        /// <summary>
        /// 登录之前先验证数据库是否能够连接，提示用户检查网络
        /// </summary>
        /// <returns></returns>
        public bool IsConnection()
        {
            return DBConnection.OpenDB();
        }


        public int Delete(int loginId)
        {
            sls.Delete(loginId);
            int result = sls.SaveChanges();
            if (result > 0)
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
