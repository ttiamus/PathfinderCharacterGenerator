using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Core.Deites;
using Core.Items;

namespace API.Controllers
{
    public class DeityController : ApiController
    {
        private readonly IDeityService deityService;

        public DeityController(IDeityService deityService)
        {
            this.deityService = deityService;
        }

        [Route("api/deities")]
        public async Task<IHttpActionResult> Get()
        {
            var result = await deityService.GetDeities();
            var deities = result.ToList(); //To keep from enumerating multiple times 

            if (deities.Any())
            {
                return Ok(deities);
            }

            return NotFound();
        }

        [Route("api/deities/{id}")]
        public async Task<IHttpActionResult> Get(string id)
        {
            var item = await deityService.GetDeity(id);

            if (item != null)
            {
                return Ok(item);
            }

            return NotFound();
        }

        [Route("api/deities")]
        public async Task<IHttpActionResult> Post(Deity deity)
        {
            var success = await deityService.InsertDeity(deity);
            if (!success)
            {
                return Ok();
            }

            return InternalServerError();
        }

        [Route("api/deities/{id}")]
        public async Task<IHttpActionResult> Put(Deity deity)
        {
            var success = await deityService.UpdateDeity(deity);

            if (success)
            {
                return Ok();
            }

            return BadRequest($"Could not find deity with Id {deity.Id}");
        }

        [Route("api/deities/{id}")]
        public async Task<IHttpActionResult> Delete(string id)
        {
            var success = await deityService.DeleteDeity(id);

            if (success)
            {
                return Ok();
            }

            return BadRequest($"Could not find deity with Id {id}");
        }
    }
}