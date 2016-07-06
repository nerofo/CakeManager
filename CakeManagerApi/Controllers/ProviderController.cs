using CakeManager.Entities;
using CakeManagerApi.Controllers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace CakeManagerApi.Controllers
{
    public class ProviderController : BaseController<Provider>
    {
        [Route("api/Providers")]
        public override Task<IHttpActionResult> Post(IEnumerable<Provider> values)
        {
            return base.Post(values);
        }

        [Route("api/Providers")]
        public override Task<IHttpActionResult> Put(IEnumerable<Provider> values)
        {
            return base.Put(values);
        }

        [Route("api/Providers")]
        public override Task<IHttpActionResult> Delete(IEnumerable<Provider> values)
        {
            return base.Delete(values);
        }
    }
}
