using System;

namespace Model.View
{
    public class MovimientoProductoView
    {
        public long IdMovimientoProducto { get; set; }

        public long IdProducto { get; set; }

        public int Cantidad { get; set; }

        public int IdClaseMovimientoProducto { get; set; }

        public DateTime Fecha { get; set; }

        public bool SoloAdultos { get; set; }

        public int IdUsuario { get; set; }

    }
}
