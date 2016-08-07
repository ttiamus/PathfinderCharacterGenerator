using Core.Weapons.Requests;
using Core.Weapons.Responses;
using MongoDB.Bson;

namespace DAL.Weapons
{
    public static class WeaponMapper
    {
        public static WeaponResponse ToWeaponResponse(this Weapon weapon)
        {
            return new WeaponResponse()
            {
                Id = weapon.Id.ToString(),
                Name = weapon.Name,
                WeaponType = weapon.WeaponType,
                Cost = weapon.Cost,
                CriticalMultiplier = weapon.CriticalMultiplier,
                CriticalThreatRange = weapon.CriticalThreatRange,
                DamageDice = weapon.DamageDice,
                DamageType = weapon.DamageType,
                NumberOfDice = weapon.NumberOfDice,
                Properties = weapon.Properties,
                Range = weapon.Range,
                Weight = weapon.Weight
            };
        }

        public static Weapon ToWeapon(this InsertWeaponRequest request)
        {
            return new Weapon()
            {
                Name = request.Name,
                WeaponType = request.WeaponType,
                Cost = request.Cost,
                CriticalMultiplier = request.CriticalMultiplier,
                CriticalThreatRange = request.CriticalThreatRange,
                DamageDice = request.DamageDice,
                DamageType = request.DamageType,
                NumberOfDice = request.NumberOfDice,
                Properties = request.Properties,
                Range = request.Range,
                Weight = request.Weight
            };
        }

        public static Weapon ToWeapon(this UpdateWeaponRequest request)
        {
            return new Weapon()
            {
                Id = ObjectId.Parse(request.Id),
                Name = request.Name,
                WeaponType = request.WeaponType,
                Cost = request.Cost,
                CriticalMultiplier = request.CriticalMultiplier,
                CriticalThreatRange = request.CriticalThreatRange,
                DamageDice = request.DamageDice,
                DamageType = request.DamageType,
                NumberOfDice = request.NumberOfDice,
                Properties = request.Properties,
                Range = request.Range,
                Weight = request.Weight
            };
        }
    }
}
