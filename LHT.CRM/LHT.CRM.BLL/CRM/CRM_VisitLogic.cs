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
        CRM_Visit cv = new CRM_Visit();
        /// <summary>
        /// 返回客户拜访信息列表
        /// </summary>
        /// <returns></returns>
        public List<CRM_Visit> GetAll()
        {
            return cvs.GetAll();
        }


        public int Add(CRM_Visit visit)
        {
            cvs.Add(visit);
            int result = cvs.SaveChanges();
            if (result > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }


        public int Delete(int visitId)
        {
            cvs.Delete(visitId);
            int result = cvs.SaveChanges();
            if (result > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int Update(CRM_Visit visit)
        {
            cvs.Update(visit);
            int result = cvs.SaveChanges();
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
        /// 根据拜访记录Id返回一条记录
        /// </summary>
        /// <param name="visitId"></param>
        /// <returns></returns>
        public CRM_Visit GetCRM_VisitModel(int visitId)
        {
            return cvs.GetAll().Find(v => v.Id == visitId);
        }

    }
}
