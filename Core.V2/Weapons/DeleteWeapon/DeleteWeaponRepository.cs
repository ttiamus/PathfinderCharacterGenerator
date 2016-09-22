using System.Threading.Tasks;
using Common.Interfaces;

namespace Core.V2.Weapons.DeleteWeapon
{
    public class DeleteWeaponRepository : ICommandRepository<DeleteWeaponRequest>
    {
        public Task SaveChanges(DeleteWeaponRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}