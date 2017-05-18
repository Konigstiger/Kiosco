using System;
using System.Collections.Generic;

using Data;
using Model;

namespace Controlador
{
    public class MovimientoProductoControlador
    {
        public static List<MovimientoProductoView> GetAll()
        {
            return MovimientoProductoData.GetAll();
        }

        public static MovimientoProductoView GetByPrimaryKey(int idMovimientoProducto)
        {
            return MovimientoProductoData.GetByPrimaryKey(idMovimientoProducto);
        }

       
        public static long Insert(MovimientoProducto c)
        {
            var idMovimientoProducto = MovimientoProductoData.Insert(c);
            return idMovimientoProducto;
        }

        /*

        public static bool Delete(MovimientoProducto c)
        {
            return MovimientoProductoData.Delete(c);
        }

        public static void Update(MovimientoProducto c)
        {
            MovimientoProductoData.Update(c);
        }
        */

    }
}

