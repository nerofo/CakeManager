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
    public class OwnerController : BaseController<Owner>
    {
        [Route("api/Owners")]
        public override Task<IHttpActionResult> Post(IEnumerable<Owner> values)
        {
            return base.Post(values);
        }

        [Route("api/Owners")]
        public override Task<IHttpActionResult> Put(IEnumerable<Owner> values)
        {
            return base.Put(values);
        }

        [Route("api/Owners")]
        public override Task<IHttpActionResult> Delete(IEnumerable<Owner> values)
        {
            return base.Delete(values);
        }
    }
}
