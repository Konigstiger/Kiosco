using System;
using System.Collections.Generic;

using Data;
using Model;
using Model.View;

namespace Controlador
{
    public class VentaControlador
    {
        public static List<VentaView> GetAll_ByDateInterval(DateTime fechaInicio, DateTime fechaFin)
        {
            return VentaData.GetAll_ByDateInterval(fechaInicio, fechaFin);
        }

        public static VentaView GetByPrimaryKey(int idVenta)
        {
            return VentaData.GetByPrimaryKey(idVenta);
        }

       
        public static long Insert(Venta c)
        {
            var idVenta = VentaData.Insert(c);
            return idVenta;
        }

        /*

        public static bool Delete(Venta c)
        {
            return VentaData.Delete(c);
        }

        */

        public static void Update(Venta modelVenta)
        {
            VentaData.Update(modelVenta);
        }
    }
}

