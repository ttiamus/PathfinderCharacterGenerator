using System;
using System.Collections.Generic;
using Core.Feat;

namespace DAL.Feat
{
    public class FeatRepository : IFeatRepository
    {
        public FeatRepository()
        {
        }

        public IEnumerable<Core.Feat.Feat> GetFeats()
        {
            throw new NotImplementedException();
        }

        public Core.Feat.Feat GetFeat(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateFeat(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteFeat(int id)
        {
            throw new NotImplementedException();
        }

        private Core.Feat.Feat ToCore(Feat dal)
        {
            return new Core.Feat.Feat()
            {

            };
        }

        private Feat ToDal(Core.Feat.Feat core)
        {
            return new Feat()
            {

            };
        }
    }
}
