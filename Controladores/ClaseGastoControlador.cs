using System;
using System.Collections.Generic;

using Data;
using Model;
using Model.View;

namespace Controlador
{
    public class ClaseGastoControlador
    {
        public static List<ClaseGastoView> GetAll()
        {
            return ClaseGastoData.GetAll();
        }

        public static ClaseGasto GetByPrimaryKey(int idClaseGasto)
        {
            return ClaseGastoData.GetByPrimaryKey(idClaseGasto);
        }

        
        public static int Insert(ClaseGasto c)
        {
            var idClaseGasto = ClaseGastoData.Insert(c);
            return idClaseGasto;
        }

        /*

        public static bool Delete(ClaseGasto c)
        {
            return ClaseGastoData.Delete(c);
        }

        public static void Update(ClaseGasto c)
        {
            ClaseGastoData.Update(c);
        }
        */

    }
}

