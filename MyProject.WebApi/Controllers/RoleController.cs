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
    public class RoleController : ControllerBase
    {
        private readonly IRoleRepository _roleRepository;
        public RoleController(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;

        }
        [HttpGet]
        public List<Role> Get()
        {
            return _roleRepository.GetAll();
        }
        [HttpGet("{id}")]
        public Role Get(int id)
        {
            return _roleRepository.GetById(id);
        }
        [HttpPost]
        public Role Add(int id, string name, string description)
        {
            return _roleRepository.Add(id, name, description);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _roleRepository.Delete(id);
        }
        [HttpPut("{id},{name},{description}")]
        public Role Put(int id,string name,string description)
        {
            Role r = new Role(id, description, name);
            return _roleRepository.Update(r);
        }
    }
}
