using System;

namespace Model
{
    public class ProductoProveedorView: IEntidad
    {
        //TODO: Completar esta clase, pensada para actuar con una Vista SP
        public long IdProductoProveedor { get; set; }
        public long IdProducto { get; set; }
        public string Proveedor { get; set; }
        public string Producto { get; set; }
        public decimal PrecioProveedor { get; set; }
        public decimal PrecioVenta { get; set; }

        public DateTime? FechaModificacion { get; set; }

        public int IdUnidad { get; set; }
        public string Notas { get; set; }
        public long IdProveedor { get; set; }

        public bool Validate()
        {
            return true;
        }

        public enum GridColumn
        {
            IdProductoProveedor = 0,
            IdProducto = 1,
            IdProveedor = 2,
            Producto = 3,
            Proveedor = 4,
            PrecioProveedor = 5,
            PrecioVenta = 6,
            FechaModificacion = 7,
            Notas = 8
        }

    }
}
