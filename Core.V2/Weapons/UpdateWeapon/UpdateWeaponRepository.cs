using System.Threading.Tasks;
using Common.Interfaces;
using Common.Results;
using Core.V2.Weapons.GetWeapon;

namespace Core.V2.Weapons.UpdateWeapon
{
    public class UpdateWeaponRepository : ICommandRepository<UpdateWeaponRequest>
    {
        public Task<Result> SaveChanges(UpdateWeaponRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}