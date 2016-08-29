using System;
using System.Threading.Tasks;
using System.Web.Http;
using API.Filters;
using Core.Items;
using Core.Items.Requests;

namespace API.Controllers
{
    public class ItemController : ApiController
    {
        private readonly IItemService itemService;

        public ItemController(IItemService itemService)
        {
            this.itemService = itemService;
        }

        [HttpGet]
        [Route("items")]
        [UnhandledExceptionFilter]
        public async Task<IHttpActionResult> GetItems()
        {
            var result = await itemService.GetItems();

            if (result.Success)
            {
                return Ok(result.Data);
            }

            return NotFound();
        }

        [HttpGet]
        [Route("items/itemId/{id}")]
        public async Task<IHttpActionResult> GetItem(GetItemRequest request)
        {
            var result = await itemService.GetItem(request);

            if (result.Success)
            {
                return Ok(result.Data);
            }

            return NotFound();
        }

        [HttpPost]
        [Route("items")]
        public async Task<IHttpActionResult> InsertItem(InsertItemRequest request)
        {
            var result = await itemService.InsertItem(request);
            if (!result.Success)
            {
                return Ok();
            }

            return InternalServerError();
        }

        [HttpPut]
        [Route("items")] 
        public async Task<IHttpActionResult> UpdateItem(UpdateItemRequest request)
        {
            var result = await itemService.UpdateItem(request);

            if (result.Success)
            {
                return Ok();
            }
            return BadRequest();
            //return BadRequest($"Could not find item with Id {item.Id}");
        }

        [HttpDelete]
        [Route("items/itemId/{id}")]
        public async Task<IHttpActionResult> DeleteItem(DeleteItemRequest request)
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
