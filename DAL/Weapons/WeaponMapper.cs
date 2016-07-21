using MongoDB.Bson;

namespace DAL.Weapons
{
    public static class WeaponMapper
    {
        public static Core.Weapons.Weapon ToCore(this Weapon dal)
        {
            return new Core.Weapons.Weapon()
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

        public static Weapon ToDal(this Core.Weapons.Weapon core)
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
