namespace Model.View
{
    public class ProductoView
    {
        public ProductoView()
        {
        }

        public ProductoView(long idProducto)
        {
            IdProducto = idProducto;
        }

        public long IdProducto { get; set; }

        public string CodigoBarras { get; set; }

        public string Descripcion { get; set; }

        public string Marca { get; set; }

        public string Rubro { get; set; }
        public string Unidad { get; set; }

        public decimal Precio { get; set; }

        public decimal PrecioCosto { get; set; }

        public int Stock { get; set; }

        public int Capacidad { get; set; }

        public string Ganancia { get; set; }

        public string Notas { get; set; }
        public decimal PrecioVentaPremium { get; set; }

        public bool Archivado { get; set; }


        public enum GridColumn
        {
            IdProducto = 0,
            CodigoBarras = 1,
            Descripcion = 2,
            Capacidad = 3,
            Precio = 4,
            Ganancia = 5,
            Marca = 6,
            Stock = 7,
            Rubro = 8
        }

    }
}