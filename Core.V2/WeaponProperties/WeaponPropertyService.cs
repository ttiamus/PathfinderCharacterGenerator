using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Common.Results;
using Core.V2.WeaponProperties.GetAllWeaponProperties;
using Core.V2.WeaponProperties.Models.Responses;

namespace Core.V2.WeaponProperties
{
    public class WeaponPropertyService : IWeaponPropertyService
    {
        public Task<Result<List<WeaponPropertyResponse>>> GetWeaponProperties(GetAllWeaponPropertiesRequest request)
        {
            throw new NotImplementedException();
        }
    }
}