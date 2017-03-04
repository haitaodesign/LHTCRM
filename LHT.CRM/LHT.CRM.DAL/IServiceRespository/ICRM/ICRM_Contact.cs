using LHT.CRM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHT.CRM.DAL.IServiceRespository.ICRM
{
    interface ICRM_Contact
    {
        List<CRM_Contact> GetAll();
        CRM_Contact GetModel(int id);
        void Add(CRM_Contact contact);
        void Delete(int id);
        void Update(CRM_Contact contact);
    }
}
