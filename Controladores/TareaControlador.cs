using System;
using System.Collections.Generic;

using Data;
using Model;
using Model.View;

namespace Controlador
{
    public class TareaControlador
    {
        public static List<TareaView> GetAll()
        {
            return TareaData.GetAll();
        }

        public static Tarea GetByPrimaryKey(long idTarea)
        {
            return TareaData.GetByPrimaryKey(idTarea);
        }

        
        public static long Insert(Tarea c)
        {
            var idTarea = TareaData.Insert(c);
            return idTarea;
        }
        

        public static bool Delete(Tarea c)
        {
            return TareaData.Delete(c);
        }

        public static void Update(Tarea c)
        {
            TareaData.Update(c);
        }
        

    }
}

