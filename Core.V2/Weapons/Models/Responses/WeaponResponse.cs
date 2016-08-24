using System.Collections.Generic;
using Core.V2.Enum;
using Core.V2.WeaponDamageTypes.Models.Responses;
using Core.V2.WeaponProperties.Models.Responses;

namespace Core.V2.Weapons.Models.Responses
{
    public class WeaponResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int WeaponTypeId { get; set; }
        public WeaponDamageTypeResponse WeaponType{ get; set; }     //TODO:This is wrong
        public int NumberOfDice { get; set; }
        public Dice DamageDice { get; set; }
        public decimal Cost { get; set; }                               //in gold
        public string CriticalThreatRange { get; set; }
        public int CriticalMultiplier { get; set; }
        public int Range { get; set; }                                  //in feet
        public decimal Weight { get; set; }                                 //in lbs
        public IEnumerable<int> DamageTypeIds { get; set; }
        public IEnumerable<WeaponDamageTypeResponse> DamageTypes { get; set; }
        public IEnumerable<int> PropertyIds { get; set; } 
        public IEnumerable<WeaponPropertyResponse> Properties { get; set; }
    }
}
