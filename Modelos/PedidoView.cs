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
        public int IdPrioridad { get; set; }

        public string Estado { get; set; }

        public string Prioridad { get; set; }

        public DateTime FechaEntrega { get; set; }

        public DateTime HoraEntrega { get; set; }

        public decimal Total { get; set; }

        public string Notas { get; set; }

        public bool EstaPago { get; set; }

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
            FechaEntrega = 4,
            Estado = 5,
            Total = 6,
            IdEstadoPedido = 7,
            Prioridad = 8
        }

    }
}
