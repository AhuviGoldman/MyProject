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
    public class ClaimController : ControllerBase
    {
        private readonly IClaimRepository _claimRepository;
        public ClaimController(IClaimRepository claimRepository)
        {
            _claimRepository = claimRepository;

        }
        [HttpGet]
        public List<Claim> Get()
        {
            return _claimRepository.GetAll();
        }
        [HttpGet("{id}")]
        public Claim Get(int id)
        {
            return _claimRepository.GetById(id);
        }
        [HttpPost]
        public Claim Add(int id, int roleId, int permissionId, EPolicy policy)
        {
            return _claimRepository.Add(id, roleId, permissionId, policy);
        }
        [HttpDelete("{id}")]
        public void delete(int id)
        {
            _claimRepository.Delete(id);
        }
        [HttpPut("{c}")]
        public Claim Update(Claim c)
        {
           return _claimRepository.Update(c);
        }
    }
}
