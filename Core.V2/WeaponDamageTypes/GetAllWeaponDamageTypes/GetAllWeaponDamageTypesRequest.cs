using System.Collections.Generic;
using Common.Interfaces;

namespace Core.V2.WeaponDamageTypes.GetAllWeaponDamataTypes
{
    public class GetAllWeaponDamageTypesRequest : IRequest
    {
        public IEnumerable<int> WeaponDamageTypeIds { get; set; }
    }
}