using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Core.Feats;
using Core.Items;

namespace API.Controllers
{
    public class FeatController : ApiController
    {
        private readonly IFeatService featService;

        public FeatController(IFeatService featService)
        {
            this.featService = featService;
        }

        // GET: api/feat
        [Route("api/feats")]
        public async Task<IHttpActionResult> Get()
        {
            var result = await featService.GetFeats();
            var feats = result.ToList();        //To keep from enumerating multiple times 

            if (feats.Any())
            {
                return Ok(feats);
            }

            return NotFound();
        }

        [Route("api/feats/{id}")]
        public async Task<IHttpActionResult> Get(string id)
        {
            var feat = await featService.GetFeat(id);

            if (feat != null)
            {
                return Ok(feat);
            }

            return NotFound();
        }

        [Route("api/feats")]
        public async Task<IHttpActionResult> Post(Feat feat)
        {
            var success = await featService.InsertFeat(feat);
            if (!success)
            {
                return Ok();
            }

            return InternalServerError();
        }

        [Route("api/feats/{id}")]
        public async Task<IHttpActionResult> Put(Feat feat)
        {
            var success = await featService.UpdateFeat(feat);

            if (success)
            {
                return Ok();
            }

            return BadRequest($"Could not find feat with Id {feat.Id}");
        }

        [Route("api/feats/{id}")]
        public async Task<IHttpActionResult> Delete(string id)
        {
            var success = await featService.DeleteFeat(id);

            if (success)
            {
                return Ok();
            }

            return BadRequest($"Could not find feat with Id {id}");
        }
    }
}
