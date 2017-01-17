using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHT.CRM.DAL.ServiceRespository.SystemManagement;
using LHT.CRM.Model;


namespace LHT.CRM.BLL.SystemManagement
{
    public class SystemLoginLogic
    {
        SystemLoginService slogins = new SystemLoginService();
        //账号是否存在
        public bool IsExist(string loginName)
        {
            SystemLogin slogin = new SystemLogin();
            slogin = slogins.GetModel(loginName);
            if (slogin != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //判断密码和账号是否匹配
        public bool LoginNameAndPasswordIsMatch(string loginname,string password)
        {
            SystemLogin model = slogins.GetModel(loginname);
            if (model.Password == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
