using Core.Races.Requests;
using Core.Races.Responses;
using MongoDB.Bson;

namespace DAL.Races
{
    public static class RaceMapper
    {
        public static RaceResponse ToRaceResponse(this Race race)
        {
            return new RaceResponse()
            {
                Id = race.Id.ToString(),
                Name = race.Name,
                Description = race.Description,
                Size = race.Size,
                Speed = race.Speed
            };
        }

        public static Race ToRace(this InsertRaceRequest request)
        {
            return new Race()
            {
                Name = request.Name,
                Description = request.Description,
                Size = request.Size,
                Speed = request.Speed
            };
        }

        public static Race ToRace(this UpdateRaceRequest request)
        {
            return new Race()
            {
                Id = ObjectId.Parse(request.Id),
                Name = request.Name,
                Description = request.Description,
                Size = request.Size,
                Speed = request.Speed
            };
        }
    }
}
