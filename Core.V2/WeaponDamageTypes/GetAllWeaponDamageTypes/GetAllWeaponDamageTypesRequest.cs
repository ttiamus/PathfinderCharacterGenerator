using System.Collections.Generic;
using Common.Interfaces;

namespace Core.V2.WeaponDamageTypes.GetAllWeaponDamageTypes
{
    public class GetAllWeaponDamageTypesRequest : IRequest
    {
        public IEnumerable<int> WeaponDamageTypeIds { get; set; }
    }
}