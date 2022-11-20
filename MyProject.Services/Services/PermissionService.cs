using AutoMapper;
using MyProject.Common.DTOs;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Services
{
    public class PermissionService : IPermissionService
    {
        private readonly IPermissionRepository _permissionRopository;
        private readonly IMapper _mapper;

        public PermissionService(IPermissionRepository permissionRopository, IMapper mapper)
        {
            _permissionRopository = permissionRopository;
            _mapper = mapper;
        }

        public PermissionDTO Add(int id, string name, string description)
        {
            return _mapper.Map<PermissionDTO>(_permissionRopository.Add(id, name, description));
        }

        public void Delete(int id)
        {
            _permissionRopository.Delete(id);
        }

        public PermissionDTO GetBiId(int id)
        {
            return _mapper.Map<PermissionDTO>(_permissionRopository.GetById(id));
        }

        public List<PermissionDTO> GetList()
        {
            return _mapper.Map<List<PermissionDTO>>(_permissionRopository.GetAll());
        }

        public PermissionDTO Update(PermissionDTO permission)
        {
            return _mapper.Map<PermissionDTO>(_permissionRopository.Update(permission));
        }
    }
}
