using System.Threading.Tasks;
using Common.Interfaces;

namespace Core.V2.WeaponProperties.DeleteWeaponProperty
{
    public class DeleteWeaponPropertyRepository : ICommandRepository<DeleteWeaponPropertyRequest>
    {
        public Task SaveChanges(DeleteWeaponPropertyRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}