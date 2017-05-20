using System;

namespace Model
{
    public class PedidoDetalleView: IEntidad
    {
        public long IdPedidoDetalle { get; set; }

        public long IdPedido { get; set; }

        public long IdProducto { get; set; }
        public string ProductoDescripcion { get; set; }

        public int Cantidad { get; set; }

        public decimal Importe { get; set; }

        public int? IdUnidad { get; set; }

        public string Notas { get; set; }

        public bool Validate()
        {
            return true;
        }
    }
}
