using System.Net;
using System.Web.Http;
using System.Web.Http.OData;
using System.Web.Http.OData.Query;
using Demo.Entities;
using Microsoft.Data.OData;

namespace Demo.Controllers
{
    /*
    The WebApiConfig class may require additional changes to add a route for this controller. Merge these statements into the Register method of the WebApiConfig class as applicable. Note that OData URLs are case sensitive.

    using System.Web.Http.OData.Builder;
    using Demo.Entities;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<Product>("ODataProducts");
    config.Routes.MapODataRoute("odata", "odata", builder.GetEdmModel());
    */
    public class ProductsV2Controller : ODataController
    {
        private static ODataValidationSettings _validationSettings = new ODataValidationSettings();

        // GET: odata/ODataProducts
        public IHttpActionResult GetODataProducts(ODataQueryOptions<Product> queryOptions)
        {
            // validate the query.
            try
            {
                queryOptions.Validate(_validationSettings);
            }
            catch (ODataException ex)
            {
                return BadRequest(ex.Message);
            }

            // return Ok<IEnumerable<Product>>(products);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // GET: odata/ODataProducts(5)
        public IHttpActionResult GetProduct([FromODataUri] int key, ODataQueryOptions<Product> queryOptions)
        {
            // validate the query.
            try
            {
                queryOptions.Validate(_validationSettings);
            }
            catch (ODataException ex)
            {
                return BadRequest(ex.Message);
            }

            // return Ok<Product>(product);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

    }
}
