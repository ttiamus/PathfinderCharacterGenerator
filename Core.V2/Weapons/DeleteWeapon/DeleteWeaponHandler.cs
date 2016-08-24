using System.Threading.Tasks;
using Common.Interfaces;
using Common.Results;

namespace Core.V2.Weapons.DeleteWeapon
{
    public class DeleteWeaponHandler : ICommandHandler<DeleteWeaponRequest>
    {
        public Task<bool> Validate(DeleteWeaponRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<Result> Execute(DeleteWeaponRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}