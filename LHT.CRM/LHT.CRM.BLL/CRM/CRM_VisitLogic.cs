using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHT.CRM.DAL.ServiceRespository.CRM;
using LHT.CRM.Model;

namespace LHT.CRM.BLL.CRM
{
    public class CRM_VisitLogic
    {
        CRM_VisitService cvs = new CRM_VisitService();

        /// <summary>
        /// 返回客户拜访信息列表
        /// </summary>
        /// <returns></returns>
        public List<CRM_Visit> GetAll()
        {
            return cvs.GetAll();
        }
    }
}
