using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Feats
{
    public interface IFeatRepository
    {
        Task<IEnumerable<Feat>> GetFeats();
        Task<Feat> GetFeat(string id);
        Task InsertFeat(Feat feat);
        Task UpdateFeat(Feat feat);
        Task DeleteFeat(string id);
    }
}
