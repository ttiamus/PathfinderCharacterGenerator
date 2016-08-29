using System.Threading.Tasks;
using Common.Interfaces;
using Common.Results;
using Core.V2.Weapons.CreateWeapon;

namespace Core.V2.WeaponProperties.CreateWeaponProperty
{
    public class CreateWeaponPropertyHandler : ICommandHandler<CreateWeaponPropertyRequest>
    {
        public void Validate(CreateWeaponPropertyRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task Execute(CreateWeaponPropertyRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}