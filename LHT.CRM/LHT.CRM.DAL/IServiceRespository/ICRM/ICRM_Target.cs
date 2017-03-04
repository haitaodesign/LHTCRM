using LHT.CRM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHT.CRM.DAL.IServiceRespository.ICRM
{
    interface ICRM_Target
    {
        List<CRM_Contact> GetAll();

        CRM_Contact GetModel(string Name);

        void Add(CRM_Contact contact);

        void Delete(int id);

        void Update(CRM_Contact contact);
    }
}
