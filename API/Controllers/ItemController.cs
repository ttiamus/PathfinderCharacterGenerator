using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
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
    //Allow any request from anywhere
    [EnableCors("*", "*", "*")]
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
        [Route("items/{id}")]
        [UnhandledExceptionFilter]
        public async Task<ItemResponse> GetItem(string id)
        {
            return await itemService.GetItem(new GetItemRequest(id));
        }

        [HttpPost]
        [Route("items")]
        [UnhandledExceptionFilter]
        public async Task InsertItem(CreateItemRequest request)
        {
            await itemService.CreateItem(request);
        }

        [HttpPut]
        [Route("items")]
        [UnhandledExceptionFilter]
        public async Task UpdateItem(UpdateItemRequest request)
        {
            await itemService.UpdateItem(request);
        }

        [HttpDelete]
        [Route("items/{id}")]
        [UnhandledExceptionFilter]
        public async Task DeleteItem(string id)
        {
            await itemService.DeleteItem(new DeleteItemRequest(id));
        }
    }
}
