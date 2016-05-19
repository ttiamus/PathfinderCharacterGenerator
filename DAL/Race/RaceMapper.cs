using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace DAL.Race
{
    public static class RaceMapper
    {
        public static Core.Race.Race ToCore(this Race dal)
        {
            return new Core.Race.Race()
            {
                Id = dal.Id.ToString(),
                Description = dal.Description,
                Size = dal.Size,
                Speed = dal.Speed
            };
        }

        public static Race ToDal(this Core.Race.Race core)
        {
            var race = new Race()
            {
                Description = core.Description,
                Size = core.Size,
                Speed = core.Speed
            };

            if (!string.IsNullOrWhiteSpace(core.Id))
            {
                race.Id = ObjectId.Parse(core.Id);
            }

            return race;
        }
    }
}
