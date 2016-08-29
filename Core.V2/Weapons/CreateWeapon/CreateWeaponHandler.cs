using System.Threading.Tasks;
using Common.Interfaces;
using Common.Results;

namespace Core.V2.Weapons.CreateWeapon
{
    public class CreateWeaponHandler : ICommandHandler<CreateWeaponRequest>
    {
        public void Validate(CreateWeaponRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task Execute(CreateWeaponRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}