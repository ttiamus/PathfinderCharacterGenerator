using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using API.Filters;
using Core.V2.Items;
using Core.V2.Items.CreateItem;
using Core.V2.Items.DeleteItem;
using Core.V2.Items.GetAllItems;
using Core.V2.Items.GetItem;
using Core.V2.Items.Models.Responses;
using Core.V2.Items.UpdateItem;


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
        public async Task<IEnumerable<ItemResponse>> GetItems(GetAllItemsRequest request)
        {
            return await itemService.GetAllItems(request);
        }

        [HttpGet]
        [Route("items/itemId/{id}")]
        [UnhandledExceptionFilter]
        public async Task<IHttpActionResult> GetItem(GetItemRequest request)
        {
            await itemService.GetItem(request);
            return Ok();

        }

        [HttpPost]
        [Route("items")]
        [UnhandledExceptionFilter]
        public async Task<IHttpActionResult> InsertItem(CreateItemRequest request)
        {
            await itemService.CreateItem(request);
            return Ok();
        }

        [HttpPut]
        [Route("items")]
        [UnhandledExceptionFilter]
        public async Task<IHttpActionResult> UpdateItem(UpdateItemRequest request)
        {
            await itemService.UpdateItem(request);

            return Ok();

            //return BadRequest($"Could not find item with Id {item.Id}");
        }

        [HttpDelete]
        [Route("items/itemId/{id}")]
        [UnhandledExceptionFilter]
        public async Task<IHttpActionResult> DeleteItem(DeleteItemRequest request)
        {
            await itemService.DeleteItem(request);

            return Ok();
        }
    }
}
