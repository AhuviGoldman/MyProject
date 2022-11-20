using MyProject.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interfaces
{
    public interface IRoleService
    {
        List<RoleDTO> GetList();
        RoleDTO GetBiId(int id);
        RoleDTO Add(int id, string name, string description);
        RoleDTO Update(RoleDTO role);
        void Delete(int id);
    }
}
