using System;

namespace Model
{
    public class VentaDetalleView
    {

        public long IdVentaDetalle { get; set; }

        public long IdVenta { get; set; }

        public int Cantidad { get; set; }

        public decimal PrecioUnitario { get; set; }

        public decimal Importe { get; set; }

        public long IdMovimientoProducto { get; set; }

        public long IdProducto { get; set; }

    }
}
