using System.Threading.Tasks;
using Common.Interfaces;
using Common.Results;

namespace Core.V2.WeaponProperties.DeleteWeaponProperty
{
    public class DeleteWeaponPropertyRepository : ICommandRepository<DeleteWeaponPropertyRequest>
    {
        public Task<Result> SaveChanges(DeleteWeaponPropertyRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}