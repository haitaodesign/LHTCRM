using LHT.CRM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHT.CRM.DAL.IServiceRespository.ICRM
{
    interface ICRM_Customer
    {
        List<CRM_Customer> GetAll();
        CRM_Customer GetModel(int id);
        void Add(CRM_Customer customer);
        void Delete(int id);
        void Update(CRM_Customer customer);
    }
}
