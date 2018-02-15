using System;
using System.Collections.Generic;

using Data;
using Model;
using Model.View;

namespace Controlador
{
    public class EstadoProveedorControlador
    {
        public static List<EstadoProveedorView> GetAll()
        {
            return EstadoProveedorData.GetAll();
        }

        public static EstadoProveedor GetByPrimaryKey(int idEstadoProveedor)
        {
            return EstadoProveedorData.GetByPrimaryKey(idEstadoProveedor);
        }


        
        public static int Insert(EstadoProveedor c)
        {
            var idEstadoProveedor = EstadoProveedorData.Insert(c);
            return idEstadoProveedor;
        }

        /*

        public static bool Delete(EstadoProveedor c)
        {
            return EstadoProveedorData.Delete(c);
        }

        public static void Update(EstadoProveedor c)
        {
            EstadoProveedorData.Update(c);
        }
        */

    }
}

