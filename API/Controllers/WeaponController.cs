using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Core.Items;
using Core.Weapons;

namespace API.Controllers
{
    public class WeaponController : ApiController
    {
        private readonly IWeaponService weaponService;

        public WeaponController(IWeaponService weaponService)
        {
            this.weaponService = weaponService;
        }

        [Route("api/items/weapons")]
        public async Task<IHttpActionResult> Get()
        {
            var result = await weaponService.GetWeapons();
            var weapons = result.ToList();        //To keep from enumerating multiple times 

            if (weapons.Any())
            {
                return Ok(weapons);
            }

            return NotFound();
        }

        [Route("api/items/weapons/{id}")]
        public async Task<IHttpActionResult> Get(string id)
        {
            var item = await weaponService.GetWeapon(id);

            if (item != null)
            {
                return Ok(item);
            }

            return NotFound();
        }

        [Route("api/items/weapons")]
        public async Task<IHttpActionResult> Post(Weapon weapon)
        {
            var success = await weaponService.InsertWeapon(weapon);
            if (!success)
            {
                return Ok();
            }

            return InternalServerError();
        }

        [Route("api/items/weapons/{id}")]
        public async Task<IHttpActionResult> Put(Weapon weapon)
        {
            var success = await weaponService.UpdateWeapon(weapon);

            if (success)
            {
                return Ok();
            }

            return BadRequest($"Could not find weapon with Id {weapon.Id}");
        }

        [Route("api/items/weapons/{id}")]
        public async Task<IHttpActionResult> Delete(string id)
        {
            var success = await weaponService.DeleteWeapon(id);

            if (success)
            {
                return Ok();
            }

            return BadRequest($"Could not find weapon with Id {id}");
        }
    }
}
