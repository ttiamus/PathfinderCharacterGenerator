using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace DAL.Feat
{
    public static class FeatMapper
    {
        public static Core.Feat.Feat ToCore(this Feat dal)
        {
            return new Core.Feat.Feat()
            {
                Id = dal.Id.ToString(),
                Description = dal.Description,
                Effect = dal.Effect,
                Requirements = dal.Requirements
            };
        }

        public static Feat ToDal(this Core.Feat.Feat core)
        {
            var feat = new Feat()
            {
                Description = core.Description,
                Effect = core.Effect,
                Requirements = core.Requirements
            };

            if (!string.IsNullOrWhiteSpace(core.Id))
            {
                feat.Id = ObjectId.Parse(core.Id);
            }

            return feat;
        }
    }
}
