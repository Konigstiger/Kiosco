using System;

namespace Model
{
    public class VentaView
    {
        //TODO: Pendiente de revision.

        public long IdVenta { get; set; }

        public long IdCliente { get; set; }

        public decimal Total { get; set; }

        public decimal Ganancia { get; set; }

        public DateTime Fecha { get; set; }


        public long? IdMovimientoCaja { get; set; }

        public bool? PendientePago { get; set; }

        public string Notas { get; set; }

    }
}
