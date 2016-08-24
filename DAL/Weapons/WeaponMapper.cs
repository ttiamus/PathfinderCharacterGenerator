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
                WeaponTypeId = weapon.WeaponTypeId,
                Cost = weapon.Cost,
                CriticalMultiplier = weapon.CriticalMultiplier,
                CriticalThreatRange = weapon.CriticalThreatRange,
                DamageDice = weapon.DamageDice,
                //DamageTypes = weapon.DamageTypes, //TODO:Come back to this
                NumberOfDice = weapon.NumberOfDice,
                PropertyIds = weapon.PropertyIds,
                Range = weapon.Range,
                Weight = weapon.Weight
            };
        }

        public static Weapon ToWeapon(this InsertWeaponRequest request)
        {
            return new Weapon()
            {
                Name = request.Name,
                WeaponTypeId = request.WeaponTypeId,
                Cost = request.Cost,
                CriticalMultiplier = request.CriticalMultiplier,
                CriticalThreatRange = request.CriticalThreatRange,
                DamageDice = request.DamageDice,
                DamageTypes = request.DamageTypes,
                NumberOfDice = request.NumberOfDice,
                PropertyIds = request.PropertyIds,
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
                WeaponTypeId = request.WeaponTypeId,
                Cost = request.Cost,
                CriticalMultiplier = request.CriticalMultiplier,
                CriticalThreatRange = request.CriticalThreatRange,
                DamageDice = request.DamageDice,
                DamageTypes = request.DamageTypes,
                NumberOfDice = request.NumberOfDice,
                PropertyIds = request.PropertyIds,
                Range = request.Range,
                Weight = request.Weight
            };
        }
    }
}
