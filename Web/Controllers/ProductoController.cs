using System.Collections.Generic;
using System.Web.Http;
using Controlador;
using Model;

namespace Web.Controllers
{
    public class ProductoController : ApiController
    {
        List<Producto> products;

        // GET: api/Producto
        public IEnumerable<Producto> Get()
        {
            products = ProductoControlador.GetAll();
            return products;
            //return new string[] { "value1", "value2" };
        }

        // GET: api/Producto/5
        public IHttpActionResult Get(int id)
        {
            var product = ProductoControlador.GetByPrimaryKey(id);

            if (product == null) {
                return NotFound();
            }
            return Ok(product);
            //return "value";
        }

        // POST: api/Producto
        public void Post([FromBody]string value)
        {
            //update!
        }

        // PUT: api/Producto/5
        public void Put(int id, [FromBody]string value)
        {
            //insert
        }

        // DELETE: api/Producto/5
        public void Delete(int id)
        {
            //delete
        }
    }
}
