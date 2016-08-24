using System.Collections.Generic;

namespace Core.WeaponProperties.Requests
{
    public class GetWeaponPropertiesRequest
    {
        public IEnumerable<int> WeaponPropertyIds { get; set; }
    }
}