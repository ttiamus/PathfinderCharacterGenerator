using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class ArmorController : ApiController
    {
        // GET: api/Armor
        [Route("api/items/armors")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [Route("api/items/armors/{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [Route("api/items/armors")]
        public void Post([FromBody]string value)
        {
        }

        [Route("api/items/armors/{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        [Route("api/items/armors/{id}")]
        public void Delete(int id)
        {
        }
    }
}
