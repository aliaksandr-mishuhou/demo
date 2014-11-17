using System.Collections.Generic;
using System.Web.Http;
using Demo.BusinessServices;
using Demo.Entities;
using Microsoft.Practices.Unity;

namespace Demo.Controllers
{
    public class CategoriesController : ApiController
    {
        [Dependency]
        public IShop Shop { get; set; }

        public IEnumerable<Category> GetCategories()
        {
            return Shop.GetCategories();
        }
    }
}
