using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHT.CRM.Model;

namespace LHT.CRM.DAL.IServiceRespository.ISystemManagement
{
    public interface ISystemModule
    {
        List<SystemModule> GetAll();
        void Add(SystemModule sm);
        void Delete(int smId);
        void Update(SystemModule sm);
    }
}
