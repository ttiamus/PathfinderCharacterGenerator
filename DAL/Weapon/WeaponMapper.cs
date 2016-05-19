using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace DAL.Weapon
{
    public static class WeaponMapper
    {
        public static Core.Weapon.Weapon ToCore(this Weapon dal)
        {
            return new Core.Weapon.Weapon()
            {
                Id = dal.Id.ToString(),
                Cost = dal.Cost,
                CriticalMultiplier = dal.CriticalMultiplier,
                CriticalThreatRange = dal.CriticalThreatRange,
                DamageDice = dal.DamageDice,
                DamageType = dal.DamageType,
                NumberOfDice = dal.NumberOfDice,
                Properties = dal.Properties,
                Range = dal.Range,
                Weight = dal.Weight
            };
        }

        public static Weapon ToDal(this Core.Weapon.Weapon core)
        {
            var weapon = new Weapon()
            {
                Cost = core.Cost,
                CriticalMultiplier = core.CriticalMultiplier,
                CriticalThreatRange = core.CriticalThreatRange,
                DamageDice = core.DamageDice,
                DamageType = core.DamageType,
                NumberOfDice = core.NumberOfDice,
                Properties = core.Properties,
                Range = core.Range,
                Weight = core.Weight
            };


            if (!string.IsNullOrWhiteSpace(core.Id))
            {
                weapon.Id = ObjectId.Parse(core.Id);
            }

            return weapon;
        }
    }
}
