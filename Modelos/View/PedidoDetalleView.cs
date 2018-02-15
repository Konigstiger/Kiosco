namespace Model.View
{
    public class PedidoDetalleView: IEntidad
    {
        public long IdPedidoDetalle { get; set; }

        public long IdPedido { get; set; }

        public long IdProducto { get; set; }
        public string Producto { get; set; }
        public string Unidad { get; set; }

        public int Cantidad { get; set; }

        public decimal Importe { get; set; }

        public int? IdUnidad { get; set; }
        public int? Capacidad { get; set; }

        public string Marca { get; set; }
        public string Notas { get; set; }

        public enum GridColumn
        {
            IdPedido = 0,
            IdPedidoDetalle = 0,
            Cantidad = 1,
            Unidad = 2,
            Producto = 3,
            Importe = 4,
            Marca = 5,
            Capacidad = 6,
            Notas = 7
        }


        public bool Validate()
        {
            return true;
        }
    }
}
