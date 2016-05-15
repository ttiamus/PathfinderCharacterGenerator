using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class WeaponController : ApiController
    {
        [Route("api/items/weapons")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [Route("api/items/weapons/{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [Route("api/items/weapons")]
        public void Post([FromBody]string value)
        {
        }

        [Route("api/items/weapons/{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        [Route("api/items/weapons/{id}")]
        public void Delete(int id)
        {
        }
    }
}
