using System.Threading.Tasks;
using Common.Interfaces;

namespace Core.V2.Weapons.UpdateWeapon
{
    public class UpdateWeaponRepository : ICommandRepository<UpdateWeaponRequest>
    {
        public Task SaveChanges(UpdateWeaponRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}