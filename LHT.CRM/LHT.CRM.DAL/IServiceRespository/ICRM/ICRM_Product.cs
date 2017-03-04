using LHT.CRM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHT.CRM.DAL.IServiceRespository.ICRM
{
    interface ICRM_Product
    {
        List<CRM_Product> GetAll();
        CRM_Product GetModel(int id);
        void Add(CRM_Product product);
        void Delete(int id);
        void Update(CRM_Product product);
    }
}
