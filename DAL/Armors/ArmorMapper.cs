﻿using MongoDB.Bson;

namespace DAL.Armors
{
    public static class ArmorMapper
    {
       public static Core.Armors.Armor ToCore(this Armor dal)
        {
            return new Core.Armors.Armor()
            {
                Id = dal.Id.ToString(),
                Cost = dal.Cost,
                Weight = dal.Weight,
                ArcaneSpellFailure = dal.ArcaneSpellFailure,
                ArmorCheckPenalty = dal.ArmorCheckPenalty,
                Description = dal.Description,
                MaxDexBonus = dal.MaxDexBonus,
                SpeedModifier = dal.SpeedModifier,
                Type = dal.Type
            };
        }

        public static Armor ToDal(this Core.Armors.Armor core)
        {
            var armor = new Armor()
            {
                Id = ObjectId.Parse(core.Id),
                Cost = core.Cost,
                Weight = core.Weight,
                ArcaneSpellFailure = core.ArcaneSpellFailure,
                ArmorCheckPenalty = core.ArmorCheckPenalty,
                Description = core.Description,
                MaxDexBonus = core.MaxDexBonus,
                SpeedModifier = core.SpeedModifier,
                Type = core.Type
            };

            if (!string.IsNullOrWhiteSpace(core.Id))
            {
                armor.Id = ObjectId.Parse(core.Id);
            }

            return armor;
        }
    }
}
