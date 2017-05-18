using System;

namespace Model
{
    public class MovimientoProducto: IEntidad
    {
        public const int IdClaseMovimientoProductoVenta = 1;
        public const int IdClaseMovimientoProductoCompra = 2;
        //... ver que conviene aqui. Por ahora es util.

        public long IdMovimientoProducto { get; set; }

        public long IdProducto { get; set; }

        public int Cantidad { get; set; }

        public int IdClaseMovimientoProducto { get; set; }

        public DateTime Fecha { get; set; }

        public bool SoloAdultos { get; set; }

        public int IdUsuario { get; set; }

        public bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}
