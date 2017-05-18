namespace Model
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

        public decimal Precio { get; set; }

        public decimal PrecioCosto { get; set; }

        public int Stock { get; set; }

        public string Ganancia { get; set; }

        public string Notas { get; set; }

        public enum GridColumn
        {
            IdProducto = 0,
            CodigoBarras = 1,
            Descripcion = 2,
            Precio = 3,
            Ganancia = 4,
            Marca = 5,
            Stock = 6,
            Rubro = 7
        }

    }
}