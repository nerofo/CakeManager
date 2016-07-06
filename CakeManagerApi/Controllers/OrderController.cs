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
    public class OrderController : BaseController<Order>
    {
        [Route("api/Orders")]
        public override Task<IHttpActionResult> Post(IEnumerable<Order> values)
        {
            return base.Post(values);
        }

        [Route("api/Orders")]
        public override Task<IHttpActionResult> Put(IEnumerable<Order> values)
        {
            return base.Put(values);
        }

        [Route("api/Orders")]
        public override Task<IHttpActionResult> Delete(IEnumerable<Order> values)
        {
            return base.Delete(values);
        }
    }
}
