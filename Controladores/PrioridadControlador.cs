using System;
using System.Collections.Generic;

using Data;
using Model;
using Model.View;

namespace Controlador
{
    public class PrioridadControlador
    {
        public static List<PrioridadView> GetAll()
        {
            return PrioridadData.GetAll();
        }

        public static Prioridad GetByPrimaryKey(int idPrioridad)
        {
            return PrioridadData.GetByPrimaryKey(idPrioridad);
        }

        
        public static int Insert(Prioridad c)
        {
            var idPrioridad = PrioridadData.Insert(c);
            return idPrioridad;
        }

        /*

        public static bool Delete(Prioridad c)
        {
            return PrioridadData.Delete(c);
        }

        public static void Update(Prioridad c)
        {
            PrioridadData.Update(c);
        }
        */

    }
}

