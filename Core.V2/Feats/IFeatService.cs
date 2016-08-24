using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.V2.Feats
{
    public interface IFeatService
    {
        Task<IEnumerable<Feat>> GetFeats();
        Task<Feat> GetFeat(string id);
        Task<bool> InsertFeat(Feat feat);
        Task<bool> UpdateFeat(Feat feat);
        Task<bool> DeleteFeat(string id);
    }
}
