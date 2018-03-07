using System;
using System.Collections.Generic;

using Data;
using Model;
using Model.View;

namespace Controlador
{
    public class EstadoGastoControlador
    {
        public static List<EstadoGastoView> GetAll()
        {
            return EstadoGastoData.GetAll();
        }

        public static EstadoGasto GetByPrimaryKey(int idEstadoGasto)
        {
            return EstadoGastoData.GetByPrimaryKey(idEstadoGasto);
        }


        public static List<EstadoGastoView> SearchByParameters(string nombre)
        {
            return EstadoGastoData.SearchByParameters(nombre);

        }

        
        public static int Insert(EstadoGasto c)
        {
            int idEstadoGasto = EstadoGastoData.Insert(c);
            return idEstadoGasto;
        }


        public static List<EstadoGastoView> GetAll_GetByDescripcion(string searchText)
        {
            return EstadoGastoData.SearchByParameters(searchText);
        }

        public static EstadoGastoView GetByPrimaryKeyView(int idEstadoGasto)
        {
            return EstadoGastoData.GetByPrimaryKeyView(idEstadoGasto);
        }

        public static int Update(EstadoGasto m)
        {
            return EstadoGastoData.Update(m);
        }

        public static bool Delete(EstadoGasto m)
        {
            return EstadoGastoData.Delete(m);
        }
    }
}

