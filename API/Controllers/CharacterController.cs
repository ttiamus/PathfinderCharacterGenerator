using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Core.Characters;
using Core.Items;

namespace API.Controllers
{
    public class CharacterController : ApiController
    {
        private readonly ICharacterService characterService;

        public CharacterController(ICharacterService characterService)
        {
            this.characterService = characterService;
        }

        [Route("api/characters")]
        public async Task<IHttpActionResult> Get()
        {
            var result = await characterService.GetCharacters();
            var characters = result.ToList();        //To keep from enumerating multiple times 

            if (characters.Any())
            {
                return Ok(characters);
            }

            return NotFound();
        }

        [Route("api/characters/{id}")]
        public async Task<IHttpActionResult> Get(string id)
        {
            var item = await characterService.GetCharacter(id);

            if (item != null)
            {
                return Ok(item);
            }

            return NotFound();
        }

        [Route("api/characters")]
        public async Task<IHttpActionResult> Post(Character character)
        {
            var success = await characterService.InsertCharacter(character);
            if (!success)
            {
                return Ok();
            }

            return InternalServerError();
        }

        [Route("api/characters/{id}")]
        public async Task<IHttpActionResult> Put(Character character)
        {
            var success = await characterService.UpdateCharacter(character);

            if (success)
            {
                return Ok();
            }

            return BadRequest($"Could not find character with Id {character.Id}");
        }

        [Route("api/characters/{id}")]
        public async Task<IHttpActionResult> Delete(string id)
        {
            var success = await characterService.DeleteCharacter(id);

            if (success)
            {
                return Ok();
            }

            return BadRequest($"Could not find character with Id {id}");
        }
    }
}
