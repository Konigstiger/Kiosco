using System;
using System.Collections.Generic;

using Data;
using Model;
using Model.View;

namespace Controlador
{
    public class UnidadControlador
    {
        public static List<UnidadView> GetAll()
        {
            return UnidadData.GetAll();
        }

        public static Unidad GetByPrimaryKey(int idUnidad)
        {
            return UnidadData.GetByPrimaryKey(idUnidad);
        }


        
        public static int Insert(Unidad c)
        {
            var idUnidad = UnidadData.Insert(c);
            return idUnidad;
        }

        /*

        public static bool Delete(Unidad c)
        {
            return UnidadData.Delete(c);
        }
        */

        public static void Update(Unidad c)
        {
            UnidadData.Update(c);
        }
        

    }
}

