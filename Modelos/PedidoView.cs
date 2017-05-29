using System;

namespace Model
{
    public class PedidoView: IEntidad
    {
        public long IdPedido { get; set; }

        public string Descripcion { get; set; }
        public string Proveedor { get; set; }

        public int IdProveedor { get; set; }

        public DateTime Fecha { get; set; }

        public int IdEstadoPedido { get; set; }

        public string Estado { get; set; }

        public DateTime FechaEntrega { get; set; }

        public DateTime HoraEntrega { get; set; }

        public decimal Total { get; set; }

        public string Notas { get; set; }

        public bool Validate()
        {
            return true;
        }

        public enum GridColumn
        {
            IdPedido = 0,
            Proveedor = 1,
            Descripcion = 2,
            Fecha = 3,
            Estado = 4,
            Total = 5
        }

        /*
         IdPedido
         Proveedo
         Descripc
         Fecha], 
         Estado],
         Total], 
         */

        //Proveedor
        //Estado (Estado Pedido)
    }
}
