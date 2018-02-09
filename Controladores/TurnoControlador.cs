using System;
using System.Collections.Generic;

using Data;
using Model;

namespace Controlador
{
    public class TurnoControlador
    {
        public static List<TurnoView> GetAll()
        {
            return TurnoData.GetAll();
        }

        public static Turno GetByPrimaryKey(int idTurno)
        {
            return TurnoData.GetByPrimaryKey(idTurno);
        }


        public static List<TurnoView> SearchByParameters(string nombre)
        {
            return TurnoData.SearchByParameters(nombre);

        }

        
        public static long Insert(Turno c)
        {
            long idTurno = TurnoData.Insert(c);
            return idTurno;
        }


        public static List<TurnoView> GetAll_GetByDescripcion(string searchText)
        {
            return TurnoData.SearchByParameters(searchText);
        }

        public static TurnoView GetByPrimaryKeyView(int idTurno)
        {
            return TurnoData.GetByPrimaryKeyView(idTurno);
        }

        public static long Update(Turno m)
        {
            return TurnoData.Update(m);
        }

        public static bool Delete(Turno m)
        {
            return TurnoData.Delete(m);
        }
    }
}

