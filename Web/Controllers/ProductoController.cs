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
        List<Producto> products;

        [HttpGet]
        public IEnumerable<Producto> GetAllProductos()
        {
            products = ProductoControlador.GetAll();
            return products;
        }

        [HttpGet]
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


        [HttpPost]
        public bool AddProducto(Producto p)
        {
            return true;
            //write insert logic  
        }

        /*
            GET: Get the resource (Records) from particular source such as SQL database.
            POST: Used to insert the records into the particular source such as SQL, Oracle database.
            PUT: Used to modify the resource or records.
            DELETE : Used to delete the specific resource or record from particular source.
         */


        [HttpDelete]
        public bool DeleteProducto(long id)
        {
            return true;
            //return "Employee details deleted having Id " + id;
        }


        [HttpPut]
        public bool UpdateProducto(long id, decimal precio)
        {
            //return "Employee details Updated with Name " + Name + " and Id " + Id;
            return true;
        }


    }
}
