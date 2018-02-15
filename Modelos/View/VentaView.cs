using System;

namespace Model.View
{
    public class VentaView
    {
        //TODO: Pendiente de revision.

        public long IdVenta { get; set; }

        public long IdCliente { get; set; }

        public decimal Total { get; set; }

        public decimal Ganancia { get; set; }

        public DateTime Fecha { get; set; }

        public TimeSpan Hora { get; set; }
        public long? IdMovimientoCaja { get; set; }

        public bool? PendientePago { get; set; }

        public string Notas { get; set; }
        public string Cliente { get; set; }

        public enum GridColumn
        {
            IdVenta = 0,
            Cliente = 1,
            Fecha = 2,
            Hora = 3,
            Total = 4,
            Ganancia = 5,
            Notas = 6
        }

    }
}
