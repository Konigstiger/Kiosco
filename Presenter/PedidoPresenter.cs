using System.Linq;

using Kiosco.View;
using Data;

namespace Presenter
{
    public class PedidoPresenter
    {
        private readonly IPedidoView view;
        private readonly PedidoRepository pedidoRepository;

        public PedidoPresenter(IPedidoView view, PedidoRepository pedidoRepository)
        {
            this.view = view;
            this.pedidoRepository = pedidoRepository;

            var clients = pedidoRepository.FindAll();

            this.view.PedidoSelected += OnPedidoSelected;
            this.view.LoadPedidos(clients);

            if (clients != null) {
                this.view.LoadPedido(clients.First());
            }
        }


        public void OnPedidoSelected()
        {
            if (this.view.SelectedPedido != null) {
                var id = this.view.SelectedPedido.IdPedido;
                var client = this.pedidoRepository.GetById(id);

                this.view.LoadPedido(client);
            }
        }



    }
}
