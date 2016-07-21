using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Deites
{
    public class DeityService : IDeityService
    {
        public Task<IEnumerable<Deity>> GetDeities()
        {
            throw new System.NotImplementedException();
        }

        public Task<Deity> GetDeity(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> InsertDeity(Deity Deity)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpdateDeity(Deity Deity)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteDeity(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}
