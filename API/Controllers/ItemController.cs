using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Core.Items;
using Core.Items.DeleteItem;
using Core.Items.GetItem;
using Core.Items.GetItems;
using Core.Items.InsertItem;
using Core.Items.UpdateItem;

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
            var result = await itemService.GetItems(new GetItemsRequest());
            

            if (result.Success)
            {
                return Ok(result.Data);
            }

            return NotFound();
        }

        [Route("api/items/{id}")]
        public async Task<IHttpActionResult> Get(GetItemRequest request)
        {
            var result = await itemService.GetItem(request);

            if (result.Success)
            {
                return Ok(result.Data);
            }

            return NotFound();
        }

        [Route("api/items")]
        public async Task<IHttpActionResult> Post(InsertItemRequest request)
        {
            var result = await itemService.InsertItem(request);
            if (!result.Success)
            {
                return Ok();
            }

            return InternalServerError();
        }

        //update
        [Route("api/items/")] 
        public async Task<IHttpActionResult> Put(UpdateItemRequest request)
        {
            var result = await itemService.UpdateItem(request);

            if (result.Success)
            {
                return Ok();
            }
            return BadRequest();
            //return BadRequest($"Could not find item with Id {item.Id}");
        }

        [Route("api/items/{id}")]
        public async Task<IHttpActionResult> Delete(DeleteItemRequest request)
        {
            var result = await itemService.DeleteItem(request);

            if (result.Success)
            {
                return Ok();
            }

            return BadRequest($"Could not find item with Id {request.Id}");
        }
    }
}
