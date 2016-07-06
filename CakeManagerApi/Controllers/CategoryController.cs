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
    public class CategoryController : BaseController<Category>
    {
        [Route("api/Categorys")]
        public override Task<IHttpActionResult> Post(IEnumerable<Category> values)
        {
            return base.Post(values);
        }

        [Route("api/Categorys")]
        public override Task<IHttpActionResult> Put(IEnumerable<Category> values)
        {
            return base.Put(values);
        }

        [Route("api/Categorys")]
        public override Task<IHttpActionResult> Delete(IEnumerable<Category> values)
        {
            return base.Delete(values);
        }
    }
}
