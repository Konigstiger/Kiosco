using System;

namespace Model
{
    public class MovimientoCaja: IEntidad
    {
        public const int IdClaseMovimientoCajaVenta = 1;
        public const int IdClaseMovimientoCajaCompra = 2;
        //... ver que conviene aqui. Por ahora es util.


        public long IdMovimientoCaja { get; set; }

        public DateTime Fecha { get; set; }

        public TimeSpan Hora { get; set; }

        public decimal Monto { get; set; }

        public int IdClaseMovimientoCaja { get; set; }

        public int IdUsuario { get; set; }

        public int IdPuntoVenta { get; set; }

        public bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}
