using MongoDB.Bson;

namespace DAL.Feats
{
    public static class FeatMapper
    {
        public static Core.Feats.Feat ToCore(this Feat dal)
        {
            return new Core.Feats.Feat()
            {
                Id = dal.Id.ToString(),
                Description = dal.Description,
                Effect = dal.Effect,
                Requirements = dal.Requirements
            };
        }

        public static Feat ToDal(this Core.Feats.Feat core)
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
