using System.Collections.Generic;
using System.Threading.Tasks;
using Common.Results;
using Core.WeaponDamageTypes;
using Core.WeaponDamageTypes.Requests;
using Core.WeaponProperties;
using Core.WeaponProperties.Requests;
using Core.Weapons.Requests;
using Core.Weapons.Responses;

namespace Core.Weapons
{
    public class WeaponService : IWeaponService
    {
        private readonly IWeaponRepository repo;

        private readonly IWeaponPropertyService weaponPropertyService;
        private readonly IWeaponDamageTypeService weaponDamageTypeService;

        public WeaponService(IWeaponRepository repo, IWeaponPropertyService weaponPropertyService, IWeaponDamageTypeService weaponDamageTypeService)
        {
            this.weaponPropertyService = weaponPropertyService;
            this.weaponDamageTypeService = weaponDamageTypeService;

            this.repo = repo;
        }

        public async Task<Result<IEnumerable<WeaponResponse>>> GetWeapons()
        {
            return await repo.GetWeapons();
        }

        public async Task<Result<WeaponResponse>> GetWeapon(GetWeaponRequest request)
        {
            if (request.Validate())
            {
                var weaponResult = await repo.GetWeapon(request);
                if (weaponResult.Success)
                {
                    var damageTypeRequest = new GetWeaponDamageTypesRequest() { WeaponDamageTypeIds = weaponResult.Data.DamageTypeIds };
                    var damageTypeResult = await weaponDamageTypeService.GetWeaponDamageTypes(damageTypeRequest);
                    if (damageTypeResult.Success)
                    {
                        weaponResult.Data.DamageTypes = damageTypeResult.Data;

                        var propertyRequest = new GetWeaponPropertiesRequest() {WeaponPropertyIds = weaponResult.Data.PropertyIds};
                        var propertyResult = await weaponPropertyService.GetWeaponProperties(propertyRequest);

                        if (propertyResult.Success)
                        {
                            weaponResult.Data.Properties = propertyResult.Data;
                            return weaponResult;
                        }
                    }

                    return weaponResult;
                }
            }

            return await Task.Run(() => new Result<WeaponResponse>("Invalid Get Weapon request"));
        }

        public async Task<Result> InsertWeapon(InsertWeaponRequest request)
        {
            if (request.Validate())
            {
                return await repo.InsertWeapon(request);
            }

            return await Task.Run(() => new Result("Invalid Get Weapon request"));
        }

        public async Task<Result> UpdateWeapon(UpdateWeaponRequest request)
        {
            if (request.Validate())
            {
                return await repo.UpdateWeapon(request);
            }

            return await Task.Run(() => new Result("Invalid Update Weapon request"));
        }

        public async Task<Result> DeleteWeapon(DeleteWeaponRequest request)
        {
            if (request.Validate())
            {
                return await repo.DeleteWeapon(request);
            }

            return await Task.Run(() => new Result("Invalid Delete Weapon request"));
        }
    }
}
