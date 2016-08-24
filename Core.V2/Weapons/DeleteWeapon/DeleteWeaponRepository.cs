using System.Threading.Tasks;
using Common.Interfaces;
using Common.Results;

namespace Core.V2.Weapons.DeleteWeapon
{
    public class DeleteWeaponRepository : ICommandRepository<DeleteWeaponRequest>
    {
        public Task<Result> SaveChanges(DeleteWeaponRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}