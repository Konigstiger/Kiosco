using System;
using System.Collections.Generic;

using Data;
using Model;
using Model.View;

namespace Controlador
{
    public class EstadoTareaControlador
    {
        public static List<EstadoTareaView> GetAll()
        {
            return EstadoTareaData.GetAll();
        }

        public static EstadoTarea GetByPrimaryKey(int idEstadoTarea)
        {
            return EstadoTareaData.GetByPrimaryKey(idEstadoTarea);
        }

        
        public static int Insert(EstadoTarea c)
        {
            var idEstadoTarea = EstadoTareaData.Insert(c);
            return idEstadoTarea;
        }

        /*

        public static bool Delete(EstadoTarea c)
        {
            return EstadoTareaData.Delete(c);
        }

        public static void Update(EstadoTarea c)
        {
            EstadoTareaData.Update(c);
        }
        */

    }
}

