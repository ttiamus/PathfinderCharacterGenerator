using DAL.Weapons;
using MongoDB.Bson;

namespace DAL.Deities
{
    public static class DeityMapper
    {
        public static Core.Deites.Deity ToCore(this Deity dal)
        {
            return new Core.Deites.Deity()
            {
                Id = dal.Id.ToString(),
                Alignment = dal.Alignment,
                Description = dal.Description,
                FavoredWeapon = dal.FavoredWeapon.ToCore()
            };
        }

        public static Deity ToDal(this Core.Deites.Deity core)
        {
            var deity = new Deity()
            {
                Alignment = core.Alignment,
                Description = core.Description,
                FavoredWeapon = core.FavoredWeapon.ToDal()
            };

            if (!string.IsNullOrWhiteSpace(core.Id))
            {
                deity.Id = ObjectId.Parse(core.Id);
            }

            return deity;
        }
    }
}
