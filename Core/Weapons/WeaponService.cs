using System.Collections.Generic;
using System.Threading.Tasks;
using Common.Results;
using Core.Weapons.Requests;
using Core.Weapons.Responses;

namespace Core.Weapons
{
    public class WeaponService : IWeaponService
    {
        private readonly IWeaponRepository repo;

        public WeaponService(IWeaponRepository repo)
        {
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
                return await repo.GetWeapon(request);
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
