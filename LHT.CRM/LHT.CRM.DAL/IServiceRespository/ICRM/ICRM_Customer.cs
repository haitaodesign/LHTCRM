using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHT.CRM.Model;

namespace LHT.CRM.DAL.IServiceRespository.ICRM
{
    interface ICRM_Customer
    {
        List<CRM_Customer> GetAll();

        void Add(CRM_Customer customer);

        void Delete(int cusId);

        void Update(CRM_Customer customer);
    }
}
