using System.Collections.Generic;

namespace Core.WeaponDamageTypes.Requests
{
    public class GetWeaponDamageTypesRequest
    {
        public IEnumerable<int> WeaponDamageTypeIds { get; set; }
    }
}