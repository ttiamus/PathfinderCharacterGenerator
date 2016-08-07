using System.Threading.Tasks;
using System.Web.Http;
using Core.Weapons;
using Core.Weapons.Requests;
using Core.Weapons.Responses;

namespace API.Controllers
{
    public class WeaponController : ApiController
    {
        private readonly IWeaponService weaponService;

        public WeaponController(IWeaponService weaponService)
        {
            this.weaponService = weaponService;
        }

        [HttpGet]
        [Route("api/items/weapons")]
        public async Task<IHttpActionResult> GetWeapons()
        {
            var result = await weaponService.GetWeapons();

            if (result.Success)
            {
                return Ok(result);
            }

            return NotFound();
        }

        [HttpGet]
        [Route("api/items/weapons/{id}")]
        public async Task<IHttpActionResult> GetWeapon(GetWeaponRequest request)
        {
            var result = await weaponService.GetWeapon(request);

            if (result.Success)
            {
                return Ok(result);
            }

            return NotFound();
        }

        [HttpPost]
        [Route("api/items/weapons")]
        public async Task<IHttpActionResult> InsertWeapon(InsertWeaponRequest request)
        {
            var result = await weaponService.InsertWeapon(request);
            if (result.Success)
            {
                return Ok();
            }

            return InternalServerError();
        }

        [HttpPut]
        [Route("api/items/weapons/{id}")]
        public async Task<IHttpActionResult> UpdateWeapon(UpdateWeaponRequest request)
        {
            var result = await weaponService.UpdateWeapon(request);

            if (result.Success)
            {
                return Ok();
            }

            return BadRequest($"Could not find weapon with Id {request.Id}");
        }

        [HttpDelete]
        [Route("api/items/weapons/{id}")]
        public async Task<IHttpActionResult> DeleteWeapon(DeleteWeaponRequest request)
        {
            var result = await weaponService.DeleteWeapon(request);

            if (result.Success)
            {
                return Ok();
            }

            return BadRequest($"Could not find weapon with Id {request.Id}");
        }
    }
}
