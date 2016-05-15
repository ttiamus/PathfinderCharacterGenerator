using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class ItemController : ApiController
    {
        [Route("api/items")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [Route("api/items/{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [Route("api/items")]
        public void Post([FromBody]string value)
        {
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
