using MongoDB.Bson;

namespace DAL.Races
{
    public static class RaceMapper
    {
        public static Core.Races.Race ToCore(this Race dal)
        {
            return new Core.Races.Race()
            {
                Id = dal.Id.ToString(),
                Description = dal.Description,
                Size = dal.Size,
                Speed = dal.Speed
            };
        }

        public static Race ToDal(this Core.Races.Race core)
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
