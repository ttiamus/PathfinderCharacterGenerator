using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Common.Results;
using Core.WeaponProperties.Requests;
using Core.WeaponProperties.Responses;

namespace Core.WeaponProperties
{
    public class WeaponPropertyService : IWeaponPropertyService
    {
        public Task<Result<List<WeaponPropertyResponse>>> GetWeaponProperties(GetWeaponPropertiesRequest request)
        {
            throw new NotImplementedException();
        }
    }
}