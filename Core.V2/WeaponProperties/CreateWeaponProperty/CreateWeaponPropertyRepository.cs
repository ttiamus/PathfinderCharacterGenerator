using System.Threading.Tasks;
using Common.Interfaces;

namespace Core.V2.WeaponProperties.CreateWeaponProperty
{
    public class CreateWeaponPropertyRepository : ICommandRepository<CreateWeaponPropertyRequest>
    {
        public Task SaveChanges(CreateWeaponPropertyRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}