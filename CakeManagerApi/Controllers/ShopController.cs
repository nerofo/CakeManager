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
    public class ShopController : BaseController<Shop>
    {
        [Route("api/Shops")]
        public override Task<IHttpActionResult> Post(IEnumerable<Shop> values)
        {
            return base.Post(values);
        }

        [Route("api/Shops")]
        public override Task<IHttpActionResult> Put(IEnumerable<Shop> values)
        {
            return base.Put(values);
        }

        [Route("api/Shops")]
        public override Task<IHttpActionResult> Delete(IEnumerable<Shop> values)
        {
            return base.Delete(values);
        }
    }
}
