using System;
using System.Collections.Generic;

using Data;
using Model;
using Model.View;

namespace Controlador
{
    public class RecaudacionControlador
    {
        public static List<RecaudacionView> GetAll()
        {
            return RecaudacionData.GetAll();
        }

        public static Recaudacion GetByPrimaryKey(long idRecaudacion)
        {
            return RecaudacionData.GetByPrimaryKey(idRecaudacion);
        }


        public static List<RecaudacionView> SearchByParameters(DateTime fecha1, DateTime fecha2)
        {
            return RecaudacionData.SearchByParameters(fecha1, fecha2);
        }

        
        public static long Insert(Recaudacion c)
        {
            var idRecaudacion = RecaudacionData.Insert(c);
            return idRecaudacion;
        }


        public static List<RecaudacionView> GetAll_GetByDescripcion(DateTime fecha1, DateTime fecha2)
        {
            return RecaudacionData.SearchByParameters(fecha1, fecha2);
        }

        public static RecaudacionView GetByPrimaryKeyView(long idRecaudacion)
        {
            return RecaudacionData.GetByPrimaryKeyView(idRecaudacion);
        }

        public static long Update(Recaudacion m)
        {
            return RecaudacionData.Update(m);
        }

        public static bool Delete(Recaudacion m)
        {
            return RecaudacionData.Delete(m);
        }
    }
}

