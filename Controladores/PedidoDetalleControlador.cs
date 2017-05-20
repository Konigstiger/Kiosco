using System;
using System.Collections.Generic;

using Data;
using Model;

namespace Controlador
{
    public class PedidoDetalleControlador
    {
        public static List<PedidoDetalleView> GetAll()
        {
            return PedidoDetalleData.GetAll();
        }

        public static PedidoDetalle GetByPrimaryKey(int idPedidoDetalle)
        {
            return PedidoDetalleData.GetByPrimaryKey(idPedidoDetalle);
        }


        public static List<PedidoDetalleView> SearchByParameters(string nombre)
        {
            return PedidoDetalleData.SearchByParameters(nombre);

        }

        
        public static long Insert(PedidoDetalle c)
        {
            long idPedidoDetalle = PedidoDetalleData.Insert(c);
            return idPedidoDetalle;
        }


        public static List<PedidoDetalleView> GetAll_GetByDescripcion(string searchText)
        {
            return PedidoDetalleData.SearchByParameters(searchText);
        }

        public static PedidoDetalleView GetByPrimaryKeyView(int idPedidoDetalle)
        {
            return PedidoDetalleData.GetByPrimaryKeyView(idPedidoDetalle);
        }

        public static long Update(PedidoDetalle m)
        {
            return PedidoDetalleData.Update(m);
        }

        public static bool Delete(PedidoDetalle m)
        {
            return PedidoDetalleData.Delete(m);
        }
    }
}

