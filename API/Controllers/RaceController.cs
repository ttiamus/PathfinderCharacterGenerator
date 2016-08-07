using System.Threading.Tasks;
using System.Web.Http;
using Core.Races;
using Core.Races.Requests;

namespace API.Controllers
{
    public class RaceController : ApiController
    {
        private readonly IRaceService raceService;

        public RaceController(IRaceService raceService)
        {
            this.raceService = raceService;
        }

        [HttpGet]
        [Route("api/races")]
        public async Task<IHttpActionResult> GetRaces()
        {
            var result = await raceService.GetRaces();

            if (result.Success)
            {
                return Ok(result);
            }

            return NotFound();
        }

        [HttpGet]
        [Route("api/races/{id}")]
        public async Task<IHttpActionResult> GetRace(GetRaceRequest request)
        {
            var result = await raceService.GetRace(request);

            if (result.Success)
            {
                return Ok(result);
            }

            return NotFound();
        }

        [HttpPost]
        [Route("api/races")]
        public async Task<IHttpActionResult> InsertRace(InsertRaceRequest request)
        {
            var result = await raceService.InsertRace(request);
            if (result.Success)
            {
                return Ok();
            }

            return InternalServerError();
        }

        [HttpPut]
        [Route("api/races/{id}")]
        public async Task<IHttpActionResult> UpdateRace(UpdateRaceRequest request)
        {
            var result = await raceService.UpdateRace(request);

            if (result.Success)
            {
                return Ok();
            }

            return BadRequest($"Could not find race with Id {request.Id}");
        }

        [HttpDelete]
        [Route("api/races/{id}")]
        public async Task<IHttpActionResult> DeleteRace(DeleteRaceRequest request)
        {
            var result = await raceService.DeleteRace(request);

            if (result.Success)
            {
                return Ok();
            }

            return BadRequest($"Could not find race with Id {request.Id}");
        }
    }
}
