using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Core.Enum;
using Core.Weapon.WeaponProperty;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DAL.Weapon
{
    public class Weapon
    {
        public ObjectId Id { get; set; }
        public int NumberOfDice { get; set; }
        public Dice DamageDice { get; set; }  
        public decimal Cost { get; set; }                               //in gold
        public string CriticalThreatRange { get; set; }
        public int CriticalMultiplier { get; set; }
        public int Range { get; set; }                                  //in feet
        public int Weight { get; set; }                                 //in lbs
        public string DamageType { get; set; }
        public IEnumerable<IWeaponProperty> Properties { get; set; }
    }
}
