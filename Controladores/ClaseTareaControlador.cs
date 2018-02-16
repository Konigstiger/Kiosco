using System;
using System.Collections.Generic;

using Data;
using Model;
using Model.View;

namespace Controlador
{
    public class ClaseTareaControlador
    {
        public static List<ClaseTareaView> GetAll()
        {
            return ClaseTareaData.GetAll();
        }

        public static ClaseTarea GetByPrimaryKey(int idClaseTarea)
        {
            return ClaseTareaData.GetByPrimaryKey(idClaseTarea);
        }

        
        public static int Insert(ClaseTarea c)
        {
            var idClaseTarea = ClaseTareaData.Insert(c);
            return idClaseTarea;
        }

        /*

        public static bool Delete(ClaseTarea c)
        {
            return ClaseTareaData.Delete(c);
        }

        public static void Update(ClaseTarea c)
        {
            ClaseTareaData.Update(c);
        }
        */

    }
}

