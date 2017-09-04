using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;

namespace Web.Controllers
{
    public class ProductoController : ApiController
    {
        Producto[] products = new Producto[]
        {
            new Producto {CodigoBarras = "12345", Descripcion = "Producto 1", IdProducto = 1},
            new Producto {CodigoBarras = "67890", Descripcion = "Producto 2", IdProducto = 2},
            new Producto {CodigoBarras = "11223", Descripcion = "Producto 3", IdProducto = 3}
        };

        public IEnumerable<Producto> GetAllProductos()
        {
            return products;
        }


        public IHttpActionResult GetProducto(long id)
        {
            Producto product = null;
            foreach (var p in products) {
                if (p.IdProducto == id) {
                    product = p;
                    break;
                }
            }
            if (product == null) {
                return NotFound();
            }
            return Ok(product);
        }


    }
}
