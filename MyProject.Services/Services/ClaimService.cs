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
    public class ClaimService : IClaimService
    {

        private readonly IClaimRepository _claimRepository;
        private readonly IMapper _mapper;

        public ClaimService(IClaimRepository claimRepository, IMapper mapper)
        {
            _claimRepository = claimRepository;
            _mapper = mapper;
        }

        public ClaimDTO Add(int id, int roleId, int premissionId, EPolicyDTO ePolicy)
        {
            return _mapper.Map<ClaimDTO>(Add(id, roleId, premissionId, ePolicy));
        }

        public void Delete(int id)
        {
            _claimRepository.Delete(id);
        }

        public ClaimDTO GetBiId(int id)
        {
            return _mapper.Map<ClaimDTO>(_claimRepository.GetById(id));
        }

        public List<ClaimDTO> GetList()
        {
            return _mapper.Map<List<ClaimDTO>>(_claimRepository.GetAll());
        }

        public ClaimDTO Update(ClaimDTO claim)
        {
            return _mapper.Map<ClaimDTO>(_claimRepository.Update(claim));
        }
    }
}
