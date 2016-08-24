using System.Threading.Tasks;
using Common.Interfaces;
using Common.Results;

namespace Core.V2.WeaponProperties.UpdateWeaponProperty
{
    public class UpdateWeaponPropertyHandler : ICommandHandler<UpdateWeaponPropertyRequest>
    {
        public Task<bool> Validate(UpdateWeaponPropertyRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<Result> Execute(UpdateWeaponPropertyRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}