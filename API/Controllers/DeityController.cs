using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class DeityController : ApiController
    {
        [Route("api/deities")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [Route("api/deities/{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [Route("api/deities")]
        public void Post([FromBody]string value)
        {
        }

        [Route("api/deities/{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        [Route("api/deities/{id}")]
        public void Delete(int id)
        {
        }
    }
}
