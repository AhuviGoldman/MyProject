﻿using MyProject.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interfaces
{
    public interface IPermissionService
    {
        List<PermissionDTO> GetList();
        PermissionDTO GetBiId(int id);
        PermissionDTO Add(int id, string name, string description);
        PermissionDTO Update(PermissionDTO permission);
        void Delete(int id);
    }
}
