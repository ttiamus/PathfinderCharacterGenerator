using System.Threading.Tasks;
using Common.Interfaces;
using Common.Results;

namespace Core.V2.Weapons.CreateWeapon
{
    public class CreateWeaponHandler : ICommandHandler<CreateWeaponRequest>
    {
        public Task<bool> Validate(CreateWeaponRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<Result> Execute(CreateWeaponRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}