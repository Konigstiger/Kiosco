using System;
using System.Collections.Generic;

using Data;
using Model;
using Model.View;

namespace Controlador
{
    public class EstadoFaltanteControlador
    {
        public static List<EstadoFaltanteView> GetAll()
        {
            return EstadoFaltanteData.GetAll();
        }

        public static EstadoFaltante GetByPrimaryKey(int idEstadoFaltante)
        {
            return EstadoFaltanteData.GetByPrimaryKey(idEstadoFaltante);
        }


        public static List<EstadoFaltanteView> SearchByParameters(string nombre)
        {
            return EstadoFaltanteData.SearchByParameters(nombre);

        }

        
        public static int Insert(EstadoFaltante c)
        {
            int idEstadoFaltante = EstadoFaltanteData.Insert(c);
            return idEstadoFaltante;
        }


        public static List<EstadoFaltanteView> GetAll_GetByDescripcion(string searchText)
        {
            return EstadoFaltanteData.SearchByParameters(searchText);
        }

        public static EstadoFaltanteView GetByPrimaryKeyView(int idEstadoFaltante)
        {
            return EstadoFaltanteData.GetByPrimaryKeyView(idEstadoFaltante);
        }

        public static int Update(EstadoFaltante m)
        {
            return EstadoFaltanteData.Update(m);
        }

        public static bool Delete(EstadoFaltante m)
        {
            return EstadoFaltanteData.Delete(m);
        }
    }
}

