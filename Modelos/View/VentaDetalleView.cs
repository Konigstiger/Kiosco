namespace Model.View
{
    public class VentaDetalleView
    {

        public long IdVentaDetalle { get; set; }

        public long IdVenta { get; set; }

        public int Cantidad { get; set; }

        public string Producto { get; set; }

        public decimal PrecioUnitario { get; set; }

        public decimal Importe { get; set; }

        public decimal Ganancia { get; set; }

        public long IdMovimientoProducto { get; set; }

        public long IdProducto { get; set; }
        

        public enum GridColumn
        {
            IdVentaDetalle = 0,
            Cantidad = 1,
            Producto = 2,
            PrecioUnitario = 3,
            Importe = 4,
            Ganancia = 5
        }

    }
}
