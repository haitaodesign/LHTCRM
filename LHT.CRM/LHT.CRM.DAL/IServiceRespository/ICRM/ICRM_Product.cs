using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHT.CRM.Model;

namespace LHT.CRM.DAL.IServiceRespository.ICRM
{
    interface ICRM_Product
    {
        List<CRM_Product> GetAll();

        void Add(CRM_Product product);

        void Delete(int productId);

        void Update(CRM_Product product);
    }
}
