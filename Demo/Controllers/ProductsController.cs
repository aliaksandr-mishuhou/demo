using System.Collections.Generic;
using System.Web.Http;
using Demo.BusinessServices;
using Demo.Entities;
using Microsoft.Practices.Unity;

namespace Demo.Controllers
{
    public class ProductsController : ApiController
    {
        [Dependency]
        public IShop Shop { get; set; }

        public IHttpActionResult GetProduct(int id)
        {
            var item = Shop.GetProduct(id);
            if (item == null)
                return NotFound();
            return Ok(item);
        }

        [HttpGet]
        public IEnumerable<Product> FindByCategory(int id)
        {
            return Shop.GetProducts(id);
        }
    }
}
