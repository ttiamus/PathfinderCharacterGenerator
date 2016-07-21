using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Core.Items;
using Core.Races;

namespace API.Controllers
{
    public class RaceController : ApiController
    {
        private readonly IRaceService raceService;

        public RaceController(IRaceService raceService)
        {
            this.raceService = raceService;
        }

        [Route("api/races")]
        public async Task<IHttpActionResult> Get()
        {
            var result = await raceService.GetRaces();
            var races = result.ToList();        //To keep from enumerating multiple times 

            if (races.Any())
            {
                return Ok(races);
            }

            return NotFound();
        }

        [Route("api/races/{id}")]
        public async Task<IHttpActionResult> Get(string id)
        {
            var item = await raceService.GetRace(id);

            if (item != null)
            {
                return Ok(item);
            }

            return NotFound();
        }

        [Route("api/races")]
        public async Task<IHttpActionResult> Post(Race race)
        {
            var success = await raceService.InsertRace(race);
            if (!success)
            {
                return Ok();
            }

            return InternalServerError();
        }

        [Route("api/races/{id}")]
        public async Task<IHttpActionResult> Put(Race race)
        {
            var success = await raceService.UpdateRace(race);

            if (success)
            {
                return Ok();
            }

            return BadRequest($"Could not find race with Id {race.Id}");
        }

        [Route("api/races/{id}")]
        public async Task<IHttpActionResult> Delete(string id)
        {
            var success = await raceService.DeleteRace(id);

            if (success)
            {
                return Ok();
            }

            return BadRequest($"Could not find race with Id {id}");
        }
    }
}
