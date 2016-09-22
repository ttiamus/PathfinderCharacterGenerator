using System.Threading.Tasks;
using Common.Interfaces;

namespace Core.V2.Weapons.DeleteWeapon
{
    public class DeleteWeaponHandler : ICommandHandler<DeleteWeaponRequest>
    {
        public void Validate(DeleteWeaponRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task Execute(DeleteWeaponRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}