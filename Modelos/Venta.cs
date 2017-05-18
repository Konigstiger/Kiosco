using System;

namespace Model
{
    public class Venta
    {
        /*
        [IdVenta] [bigint] IDENTITY(1,1) NOT NULL,
        [IdCliente] [bigint] NOT NULL,
        [Total] [decimal](8, 2) NOT NULL,
        [Fecha] [date] NOT NULL,
        [IdMovimientoCaja] [bigint] NULL,
        [PendientePago] [bit] NULL,
        */

        public long IdVenta { get; set; }

        public long IdCliente { get; set; }

        public decimal Total { get; set; }

        public DateTime Fecha { get; set; }

        public long? IdMovimientoCaja { get; set; }

        public bool? PendientePago { get; set; }

        public string Notas { get; set; }

    }
}
