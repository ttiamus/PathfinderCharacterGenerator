using System.Threading.Tasks;
using Common.Interfaces;
using Common.Results;

namespace Core.V2.WeaponProperties.DeleteWeaponProperty
{
    public class DeleteWeaponPropertyHandler : ICommandHandler<DeleteWeaponPropertyRequest>
    {
        public Task<bool> Validate(DeleteWeaponPropertyRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<Result> Execute(DeleteWeaponPropertyRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}