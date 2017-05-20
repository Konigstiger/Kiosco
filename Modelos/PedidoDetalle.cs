using System;

namespace Model
{
    public class PedidoDetalle: IEntidad
    {
        private long _IdPedido = 0;

        public long IdPedidoDetalle { get; set; }

        public long IdPedido { get; set; }

        public long IdProducto { get; set; }

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
