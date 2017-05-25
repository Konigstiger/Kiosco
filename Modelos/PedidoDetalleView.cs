using System;

namespace Model
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

        public string Notas { get; set; }

        public enum GridColumn
        {
            IdPedidoDetalle = 0,
            Producto = 1,
            Cantidad = 2,
            Unidad = 3,
            Importe = 4,
            Notas = 5
        }

        public bool Validate()
        {
            return true;
        }
    }
}
