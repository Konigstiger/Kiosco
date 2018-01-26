using System;
using System.Collections.Generic;
using Model;

namespace Heimdall.View
{
    public interface IPedidoView
    {
        event Action PedidoSelected;
        event Action Closed;

        IList<Pedido> Pedidos { get; }

        Pedido SelectedPedido { get; }

        void LoadPedidos(IList<Pedido> pedidos);

        void LoadPedido(Pedido pedido);
    }
}
