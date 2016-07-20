using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class FeatController : ApiController
    {
        // GET: api/feat
        [Route("api/feats")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [Route("api/feats/{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [Route("api/feats")]
        public void Post([FromBody]string value)
        {
        }

        [Route("api/feats/{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        [Route("api/feats/{id}")]
        public void Delete(int id)
        {
        }
    }
}
