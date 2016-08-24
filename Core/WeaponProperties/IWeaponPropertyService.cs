using System.Collections.Generic;
using System.Threading.Tasks;
using Common.Results;
using Core.WeaponProperties.Requests;
using Core.WeaponProperties.Responses;

namespace Core.WeaponProperties
{
    public interface IWeaponPropertyService
    {
        Task<Result<List<WeaponPropertyResponse>>> GetWeaponProperties(GetWeaponPropertiesRequest request);
    }
}