using System;

namespace Model
{
    public class MovimientoCajaView
    {
        public long IdMovimientoCaja { get; set; }

        public string Fecha { get; set; }

        public string Hora { get; set; }

        public decimal Monto { get; set; }

        public int IdClaseMovimientoCaja { get; set; }

        public int IdUsuario { get; set; }
        public int IdPuntoVenta { get; set; }

    }
}
