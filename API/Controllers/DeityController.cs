using System.Threading.Tasks;
using System.Web.Http;
using Core.Deites;
using Core.Deites.Requests;

namespace API.Controllers
{
    public class DeityController : ApiController
    {
        private readonly IDeityService deityService;

        public DeityController(IDeityService deityService)
        {
            this.deityService = deityService;
        }

        [HttpGet]
        [Route("api/deities")]
        public async Task<IHttpActionResult> GetDeities()
        {
            var result = await deityService.GetDeities();
            
            if (result.Success)
            {
                return Ok(result);
            }

            return NotFound();
        }

        [HttpGet]
        [Route("api/deities/{id}")]
        public async Task<IHttpActionResult> GetDeity(GetDeityRequest request)
        {
            var result = await deityService.GetDeity(request);

            if (result.Success)
            {
                return Ok(result);
            }

            return NotFound();
        }

        [HttpPost]
        [Route("api/deities")]
        public async Task<IHttpActionResult> InsertDeity(InsertDeityRequest request)
        {
            var result = await deityService.InsertDeity(request);
            if (result.Success)
            {
                return Ok();
            }

            return InternalServerError();
        }

        [HttpPut]
        [Route("api/deities/{id}")]
        public async Task<IHttpActionResult> UpdateDeity(UpdateDeityRequest request)
        {
            var result = await deityService.UpdateDeity(request);

            if (result.Success)
            {
                return Ok();
            }

            return BadRequest($"Could not find deity with Id {request.Id}");
        }

        [HttpDelete]
        [Route("api/deities/{id}")]
        public async Task<IHttpActionResult> DeleteDeity(DeleteDeityRequest request)
        {
            var result = await deityService.DeleteDeity(request);

            if (result.Success)
            {
                return Ok();
            }

            return BadRequest($"Could not find deity with Id {request.Id}");
        }
    }
}