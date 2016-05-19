using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Weapon;
using MongoDB.Bson;

namespace DAL.Deity
{
    public static class DeityMapper
    {
        public static Core.Deity.Deity ToCore(this Deity dal)
        {
            return new Core.Deity.Deity()
            {
                Id = dal.Id.ToString(),
                Alignment = dal.Alignment,
                Description = dal.Description,
                FavoredWeapon = dal.FavoredWeapon.ToCore()
            };
        }

        public static Deity ToDal(this Core.Deity.Deity core)
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
