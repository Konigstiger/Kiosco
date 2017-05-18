using System;

namespace Model
{
    public class ProductoProveedor: IEntidad
    {
        public long IdProductoProveedor { get; set; }
        public int IdProveedor { get; set; }
        public long IdProducto { get; set; }
        public decimal PrecioProveedor { get; set; }
        public int IdUnidad { get; set; }
        public string Notas { get; set; }

        public bool Validate()
        {
            return true;
        }
    }
}
