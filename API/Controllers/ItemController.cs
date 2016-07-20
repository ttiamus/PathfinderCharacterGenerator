using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Core.Item;

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
            return Ok( await itemService.GetItems());
        }

        [Route("api/items/{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [Route("api/items")]
        public async Task<IHttpActionResult> Post(Item item)
        {
            await itemService.InsertItem(item);
            return Ok();
        }

        [Route("api/items/{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        [Route("api/items/{id}")]
        public void Delete(int id)
        {
        }
    }
}
