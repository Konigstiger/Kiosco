using System;

namespace Model
{
    public class Pedido: IEntidad
    {
        public long IdPedido { get; set; }
        public string Descripcion { get; set; }

        public int IdProveedor { get; set; }

        public int IdEstadoPedido { get; set; }
        public int IdPrioridad { get; set; }

        public DateTime? Fecha { get; set; }

        public DateTime? FechaEntrega { get; set; }

        public DateTime? HoraEntrega { get; set; }

        public decimal Total { get; set; }

        public string Notas { get; set; }

        public bool EstaPago { get; set; }
        public string Prioridad { get; set; }

        public bool Validate()
        {
            return true;
        }
    }
}
