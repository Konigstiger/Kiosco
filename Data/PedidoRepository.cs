using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Data
{
    public class PedidoRepository
    {
        private IList<Pedido> clients = new List<Pedido>()
{
            new Pedido { IdPedido = 1, Total = 10 },
            new Pedido { IdPedido = 2, Total = 20 }
        };

        public virtual Pedido GetById(long id)
        {
            foreach (Pedido client in this.clients) {
                if (client.IdPedido == id) {
                    return client;
                }
            }

            return null;
        }

        public virtual IList<Pedido> FindAll()
        {
            return this.clients;
        }
    }
}
