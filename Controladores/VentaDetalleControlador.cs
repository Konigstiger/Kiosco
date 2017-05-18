using System;
using System.Collections.Generic;

using Data;
using Model;

namespace Controlador
{
    public class VentaDetalleControlador
    {
        public static List<VentaDetalleView> GetAll()
        {
            return VentaDetalleData.GetAll();
        }

        public static VentaDetalleView GetByPrimaryKey(int idVentaDetalle)
        {
            return VentaDetalleData.GetByPrimaryKey(idVentaDetalle);
        }

       
        public static long Insert(VentaDetalle c)
        {
            var idVentaDetalle = VentaDetalleData.Insert(c);
            return idVentaDetalle;
        }


        public static bool Delete(VentaDetalle c)
        {
            return VentaDetalleData.Delete(c);
        }

        public static void Update(VentaDetalle c)
        {
            VentaDetalleData.Update(c);
        }

    }
}

