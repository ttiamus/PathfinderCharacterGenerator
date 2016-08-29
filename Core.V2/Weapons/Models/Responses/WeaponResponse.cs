using System.Collections.Generic;
using Core.V2.Shared;
using Core.V2.WeaponDamageTypes.Models.Responses;
using Core.V2.WeaponProperties.Models.Responses;

namespace Core.V2.Weapons.Models.Responses
{
    public class WeaponResponse : IDice
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int WeaponTypeId { get; set; }
        public WeaponDamageTypeResponse WeaponType{ get; set; }     //TODO:This is wrong
        public int NumberOfDice { get; set; }
        public decimal Cost { get; set; }                               //in gold
        public string CriticalThreatRange { get; set; }
        public int CriticalMultiplier { get; set; }
        public int Range { get; set; }                                  //in feet
        public decimal Weight { get; set; }                                 //in lbs
        public IEnumerable<int> DamageTypeIds { get; set; }
        public IEnumerable<WeaponDamageTypeResponse> DamageTypes { get; set; }
        public IEnumerable<int> PropertyIds { get; set; } 
        public IEnumerable<WeaponPropertyResponse> Properties { get; set; }

        //This is for damage dice
        public int numberOfDice { get; set; }
        public int numberOfSidesOnDice { get; set; }
    }
}
