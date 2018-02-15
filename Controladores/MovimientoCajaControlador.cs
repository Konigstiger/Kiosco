using System;
using System.Collections.Generic;

using Data;
using Model;
using Model.View;

namespace Controlador
{
    public class MovimientoCajaControlador
    {
        public static List<MovimientoCajaView> GetAll()
        {
            return MovimientoCajaData.GetAll();
        }

        public static MovimientoCajaView GetByPrimaryKey(int idMovimientoCaja)
        {
            return MovimientoCajaData.GetByPrimaryKey(idMovimientoCaja);
        }

       
        public static long Insert(MovimientoCaja c)
        {
            var idMovimientoCaja = MovimientoCajaData.Insert(c);
            return idMovimientoCaja;
        }

        /*

        public static bool Delete(MovimientoCaja c)
        {
            return MovimientoCajaData.Delete(c);
        }

        public static void Update(MovimientoCaja c)
        {
            MovimientoCajaData.Update(c);
        }
        */

    }
}

