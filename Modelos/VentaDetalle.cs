using System;

namespace Model
{
    public class VentaDetalle
    {
        /* VentaDetalle
         IdVentaDetalle         bigint
         @IdVenta			    bigint
        ,@Cantidad			    int
        ,@Importe			    decimal(8,2)
        ,@IdMovimientoProducto  bigint
        ,@IdProducto			bigint    
        */

        public long IdVentaDetalle { get; set; }

        public long IdVenta { get; set; }

        public int Cantidad { get; set; }

        public decimal Importe { get; set; }

        public long IdMovimientoProducto { get; set; }

        public long IdProducto { get; set; }

    }
}
