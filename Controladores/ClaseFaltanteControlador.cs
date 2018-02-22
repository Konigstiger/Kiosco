using System;
using System.Collections.Generic;

using Data;
using Model;
using Model.View;

namespace Controlador
{
    public class ClaseFaltanteControlador
    {
        public static List<ClaseFaltanteView> GetAll()
        {
            return ClaseFaltanteData.GetAll();
        }

        public static ClaseFaltante GetByPrimaryKey(int idClaseFaltante)
        {
            return ClaseFaltanteData.GetByPrimaryKey(idClaseFaltante);
        }

        
        public static int Insert(ClaseFaltante c)
        {
            var idClaseFaltante = ClaseFaltanteData.Insert(c);
            return idClaseFaltante;
        }

        /*

        public static bool Delete(ClaseFaltante c)
        {
            return ClaseFaltanteData.Delete(c);
        }

        public static void Update(ClaseFaltante c)
        {
            ClaseFaltanteData.Update(c);
        }
        */

    }
}

