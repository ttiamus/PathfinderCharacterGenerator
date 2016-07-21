using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Feats
{
    public class FeatService : IFeatService
    {
        public Task<IEnumerable<Feat>> GetFeats()
        {
            throw new System.NotImplementedException();
        }

        public Task<Feat> GetFeat(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> InsertFeat(Feat feat)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpdateFeat(Feat feat)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteFeat(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}
