using System.Collections.Generic;
using Core.Enum;
using Core.Weapons.WeaponProperty;

namespace Core.Weapons
{
    public class Weapon
    {
        public string Id { get; set; }
        public int NumberOfDice { get; set; }
        public Dice DamageDice { get; set; }
        public decimal Cost { get; set; }                               //in gold
        public string CriticalThreatRange { get; set; }
        public int CriticalMultiplier { get; set; }
        public int Range { get; set; }                                  //in feet
        public decimal Weight { get; set; }                                 //in lbs
        public string DamageType { get; set; }
        public IEnumerable<IWeaponProperty> Properties { get; set; }
    }
}
