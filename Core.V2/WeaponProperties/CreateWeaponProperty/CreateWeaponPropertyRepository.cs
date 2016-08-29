using System.Threading.Tasks;
using Common.Interfaces;
using Common.Results;
using Core.V2.Weapons.CreateWeapon;

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