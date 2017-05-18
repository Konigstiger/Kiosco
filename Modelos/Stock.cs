using System;

namespace Model
{
    public class Stock
    {
        /*
        [IdStock] [bigint] NOT NULL,
	    [Cantidad] [int] NOT NULL,
	    [IdDeposito] [int] NOT NULL,
	    [IdProducto] [bigint] NULL
         */

        public long IdStock { get; set; }

        public int Cantidad { get; set; }

        public int IdDeposito { get; set; }

        public long IdProducto { get; set; }
    }
}
