using System.Threading.Tasks;
using Common.Interfaces;
using Common.Results;

namespace Core.V2.Weapons.CreateWeapon
{
    public class CreateWeaponRepository : ICommandRepository<CreateWeaponRequest>
    {
        public Task<Result> SaveChanges(CreateWeaponRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}