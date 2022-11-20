using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyProject.Repositories.Interfaces;
using MyProject.Repositories.Repositories;
using MyProject.Mock;

namespace MyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        private readonly IPermissionRepository _permissionRepository;
        public PermissionController(IPermissionRepository permissionRepository)
        {
            _permissionRepository = permissionRepository;

        }
        [HttpGet]
        public List<Permission> Get()
        {
            return _permissionRepository.GetAll();
        }
        [HttpGet("{id}")]
        public Permission Get(int id)
        {
            return _permissionRepository.GetById(id);
        }
        [HttpPost]
        public Permission Add(int id, string name, string description)
        {
            return _permissionRepository.Add(id, name, description);
        }
        [HttpDelete("{id}")]
        public void delete(int id)
        {
            _permissionRepository.Delete(id);
        }
        [HttpPut("{p}")]
        public Permission Update(Permission p)
        {
            return _permissionRepository.Update(p);
        }
    }
}
