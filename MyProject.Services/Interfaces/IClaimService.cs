using MyProject.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interfaces
{
  
    public interface IClaimService
    {
        List<ClaimDTO> GetList();
        ClaimDTO GetBiId(int id);
        ClaimDTO Add(int id, int roleId, int premissionId, EPolicyDTO policy);
        ClaimDTO Update(ClaimDTO claim);
        void Delete(int id);
    }
}
