using System;
using System.Collections.Generic;

using Data;
using Model;
using Model.View;

namespace Controlador
{
    public class EstadoPedidoControlador
    {
        public static List<EstadoPedidoView> GetAll()
        {
            return EstadoPedidoData.GetAll();
        }

        public static EstadoPedido GetByPrimaryKey(int idEstadoPedido)
        {
            return EstadoPedidoData.GetByPrimaryKey(idEstadoPedido);
        }


        public static List<EstadoPedidoView> SearchByParameters(string nombre)
        {
            return EstadoPedidoData.SearchByParameters(nombre);

        }

        
        public static int Insert(EstadoPedido c)
        {
            int idEstadoPedido = EstadoPedidoData.Insert(c);
            return idEstadoPedido;
        }

        public static List<EstadoPedidoView> GetAll_GetByDescripcion(string searchText)
        {
            return EstadoPedidoData.SearchByParameters(searchText);
        }

        public static EstadoPedidoView GetByPrimaryKeyView(int idEstadoPedido)
        {
            return EstadoPedidoData.GetByPrimaryKeyView(idEstadoPedido);
        }

        public static int Update(EstadoPedido m)
        {
            return EstadoPedidoData.Update(m);
        }

        public static bool Delete(EstadoPedido m)
        {
            return EstadoPedidoData.Delete(m);
        }
    }
}

