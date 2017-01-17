using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHT.CRM.DAL
{
    public class DBConnection
    {
        /// <summary>
        ///判断当前数据库能否正常连接
        /// </summary>
        /// <returns></returns>
        public bool OpenDB()
        {
            using (var context =new LHTCRMEntities())
            {
                try
                {
                    context.Database.Connection.Open();
                    context.Database.Connection.Close();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            
        }


        /// <summary>
        /// 获得配置文件数据库连接字符串
        /// </summary>
        /// <returns></returns>
        public string GetConnectionStr()
        {
            using(var context=new LHTCRMEntities())
            {
                return context.Database.Connection.ConnectionString;
            }
        }



    }


}
