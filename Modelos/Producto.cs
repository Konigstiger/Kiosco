using System;

namespace Model
{
    public class Producto : IEntidad
    {

        //TODO: Estudiar esto, puede ser util en algunas entidades.
        /*
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        */

        private int v;

        public Producto(int v)
        {
            this.v = v;
        }

        public Producto()
        {
        }

        public long IdProducto { get; set; }

        public string CodigoBarras { get; set; }

        public string Descripcion { get; set; }

        public int? IdMarca { get; set; }

        public int? IdRubro { get; set; }

        public decimal PrecioCostoPromedio { get; set; }

        public decimal PrecioVenta { get; set; }

        public bool? SoloAdultos { get; set; }

        public int StockMinimo { get; set; }

        public int StockMaximo { get; set; }

        public int? IdUnidad { get; set; }

        public string Notas { get; set; }


        public bool Validate()
        {
            //TODO: Este metodo, tiene como objetivo realizar validaciones basicas.
            //por ejemplo, ver si su codigo es -1. De ser asi, retornar false.
            //se pueden agregar muchas mas validaciones. Tambien podrian ir en el Controlador. 
            //Pero creo que me gustan aqui.

            //if (IdProducto.Equals(-1)) return false;

            if (StockMaximo < StockMinimo)
                return false;
            //TODO: Pensar y agregar mas posibles validaciones de cosas que podrian estar mal en el modelo.           

            return true;
        }

        //TODO: Esto es algo nuevo que hago, puede ser muy util!
        public static explicit operator Producto(ProductoView v)
        {
            return new Producto() {
                IdProducto = v.IdProducto,
                CodigoBarras = v.CodigoBarras,
                Descripcion = v.Descripcion,
                IdMarca = null,
                IdRubro = null,
                IdUnidad = null,
                PrecioCostoPromedio = 1,
                PrecioVenta = v.Precio,
                SoloAdultos = null,
                StockMaximo = 0,
                StockMinimo = 0
            };

        }

    }
}
