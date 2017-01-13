using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHT.CRM.Model;

namespace LHT.CRM.DAL.IServiceRespository.ISystemManagement
{
    public interface ISystemRoleAuthority
    {
        List<SystemRoleAuthority> GetAll();

        List<SystemRoleAuthority> GetAll(int roleId);

        void Add(SystemRoleAuthority roleAuth);

        void Delete(int roleAuthId);

        void Update(SystemRoleAuthority roleAuth);
    }
}
