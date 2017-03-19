using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHT.CRM.Model;
using LHT.CRM.DAL.ServiceRespository.CRM;

namespace LHT.CRM.BLL.CRM
{
    public class CRM_ContactLogic
    {
        CRM_ContactService ccs = new CRM_ContactService();
        /// <summary>
        /// 获取所有联系人列表
        /// </summary>
        /// <returns></returns>
        public List<CRM_Contact> GetAll()
        {
            return ccs.GetAll();
        }

        /// <summary>
        /// 添加一个联系人
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        public int Add(CRM_Contact contact)
        {
            ccs.Add(contact);
            int result = ccs.SaveChanges();
            if (result >0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 更新一个联系人信息
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        public int Update(CRM_Contact contact)
        {
            ccs.Update(contact);
            int result = ccs.SaveChanges();
            if (result > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 删除一个联系人
        /// </summary>
        /// <param name="conId"></param>
        /// <returns></returns>
        public int Delete(int conId)
        {
            ccs.Delete(conId);
            int result = ccs.SaveChanges();
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
