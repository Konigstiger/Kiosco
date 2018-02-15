using System;
using System.Collections.Generic;

using Data;
using Model;
using Model.View;

namespace Controlador
{
    public class PedidoControlador
    {
        public static List<PedidoView> GetAll()
        {
            return PedidoData.GetAll();
        }

        public static Pedido GetByPrimaryKey(long idPedido)
        {
            return PedidoData.GetByPrimaryKey(idPedido);
        }


        public static List<PedidoView> SearchByParameters(string nombre, bool modoArchivo)
        {
            return PedidoData.GetByParameters(nombre, modoArchivo);

        }

        
        public static long Insert(Pedido c)
        {
            long idPedido = PedidoData.Insert(c);
            return idPedido;
        }


        public static List<PedidoView> GetAll_GetByParameters(string searchText, bool modoArchivo)
        {
            return PedidoData.GetByParameters(searchText, modoArchivo);
        }

        public static PedidoView GetByPrimaryKeyView(long idPedido)
        {
            return PedidoData.GetByPrimaryKeyView(idPedido);
        }

        public static long Update(Pedido m)
        {
            return PedidoData.Update(m);
        }

        public static bool Delete(Pedido m)
        {
            return PedidoData.Delete(m);
        }

    }
}

