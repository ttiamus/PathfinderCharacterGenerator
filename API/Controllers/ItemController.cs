using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Core.Items;

namespace API.Controllers
{
    public class ItemController : ApiController
    {
        private readonly IItemService itemService;

        public ItemController(IItemService itemService)
        {
            this.itemService = itemService;
        }

        [Route("api/items")]
        public async Task<IHttpActionResult> Get()
        {
            var result = await itemService.GetItems();
            var items = result.ToList();        //To keep from enumerating multiple times 

            if (items.Any())
            {
                return Ok(items);
            }

            return NotFound();
        }

        [Route("api/items/{id}")]
        public async Task<IHttpActionResult> Get(string id)
        {
            var item = await itemService.GetItem(id);

            if (item != null)
            {
                return Ok(item);
            }

            return NotFound();
        }

        [Route("api/items")]
        public async Task<IHttpActionResult> Post(Item item)
        {
            var success = await itemService.InsertItem(item);
            if (!success)
            {
                return Ok();
            }

            return InternalServerError();
        }

        //update
        [Route("api/items/")] 
        public async Task<IHttpActionResult> Put(Item item)
        {
            var success = await itemService.UpdateItem(item);

            if (success)
            {
                return Ok();
            }
            return BadRequest();
            //return BadRequest($"Could not find item with Id {item.Id}");
        }

        [Route("api/items/{id}")]
        public async Task<IHttpActionResult> Delete(string id)
        {
            var success = await itemService.DeleteItem(id);

            if (success)
            {
                return Ok();
            }

            return BadRequest($"Could not find item with Id {id}");
        }
    }
}
