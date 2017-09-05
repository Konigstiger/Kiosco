using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;
using Controlador;

namespace Web.Controllers
{
    public class ProductoController : ApiController
    {
        public IEnumerable<Producto> GetAllProductos()
        {
            var products2 = ProductoControlador.GetAll();
            return products2;
        }


        public IHttpActionResult GetProducto(long id)
        {
            var product = ProductoControlador.GetByPrimaryKey(id);

            //Producto product = null;
            //foreach (var p in products) {
            //    if (p.IdProducto == id) {
            //        product = p;
            //        break;
            //    }
            //}
            if (product == null) {
                return NotFound();
            }
            return Ok(product);
        }


    }
}
