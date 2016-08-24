using System.Collections.Generic;
using Common.Interfaces;

namespace Core.V2.WeaponProperties.GetAllWeaponProperties
{
    public class GetAllWeaponPropertiesRequest : IRequest
    {
        public IEnumerable<int> WeaponPropertyIds { get; set; }
    }
}