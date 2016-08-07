using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Core.Armors;

namespace API.Controllers
{
    public class ArmorController : ApiController
    {
        private readonly IArmorService armorService;

        public ArmorController(IArmorService armorService)
        {
            this.armorService = armorService;
        }

        // GET: api/Armor
        [Route("api/items/armors")]
        public async Task<IHttpActionResult> Get()
        {
            var result = await armorService.GetArmors();
            var armors = result.ToList();        //To keep from enumerating multiple times 

            if (armors.Any())
            {
                return Ok(armors);
            }

            return NotFound();
        }

        [Route("api/items/armors/{id}")]
        public async Task<IHttpActionResult> Get(string id)
        {
            var item = await armorService.GetArmor(id);

            if (item != null)
            {
                return Ok(item);
            }

            return NotFound();
        }

        [Route("api/items/armors")]
        public async Task<IHttpActionResult> Post(Armor armor)
        {
            var success = await armorService.InsertArmor(armor);
            if (!success)
            {
                return Ok();
            }

            return InternalServerError();
        }

        [Route("api/items/armors/{id}")]
        public async Task<IHttpActionResult> Put(Armor armor)
        {
            var success = await armorService.UpdateArmor(armor);

            if (success)
            {
                return Ok();
            }

            return BadRequest($"Could not find armor with Id {armor.Id}");
        }

        [Route("api/items/armors/{id}")]
        public async Task<IHttpActionResult> Delete(string id)
        {
            var success = await armorService.DeleteArmor(id);

            if (success)
            {
                return Ok();
            }

            return BadRequest($"Could not find armor with Id {id}");
        }
    }
}
