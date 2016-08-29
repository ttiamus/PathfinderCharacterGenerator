using System.Threading.Tasks;
using Common.Interfaces;
using Common.Results;

namespace Core.V2.WeaponProperties.UpdateWeaponProperty
{
    public class UpdateWeaponPropertyRepository : ICommandRepository<UpdateWeaponPropertyRequest>
    {
        public Task SaveChanges(UpdateWeaponPropertyRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}