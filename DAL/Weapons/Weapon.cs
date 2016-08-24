using System.Collections.Generic;
using Core.Enum;
using DAL.WeaponProperties;
using MongoDB.Bson;

namespace DAL.Weapons
{
    public class Weapon
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public int WeaponTypeId { get; set; }
        public int NumberOfDice { get; set; }
        public Dice DamageDice { get; set; }
        public decimal Cost { get; set; } //in gold
        public string CriticalThreatRange { get; set; }
        public int CriticalMultiplier { get; set; }
        public int Range { get; set; } //in feet
        public decimal Weight { get; set; } //in lbs
        public IEnumerable<WeaponDamageType> DamageTypes { get; set; }
        public IEnumerable<int> PropertyIds { get; set; } 
    }
}
