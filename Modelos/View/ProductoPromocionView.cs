namespace Model.View
{
    public class ProductoPromocionView: IEntidad
    {
        /*
         	[IdProductoPromocion] [int] NOT NULL,
	[IdPromocion] [int] NOT NULL,
	[IdProducto] [bigint] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[PrecioPromocion] [decimal](8, 2) NULL,
	[PorcentajeDescuento] [decimal](8, 2) NULL,
	[Notas] [varchar](100) NULL,
             */

        public long IdProductoPromocion { get; set; }
        public int IdPromocion { get; set; }
        public long IdProducto { get; set; }
        public string Producto { get; set; }
        public string Promocion { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioPromocion { get; set; }
        public decimal PorcentajeDescuento { get; set; }

        public string Notas { get; set; }

        public bool Validate()
        {
            return true;
        }
    }
}
