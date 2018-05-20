using System;
using Model.View;

namespace Model
{
    public class Promocion : IEntidad
    {

        /*
	[IdPromocion] [int] NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Importe] [decimal](8, 2) NOT NULL,
	[FechaInicio] [date] NOT NULL,
	[FechaFin] [date] NOT NULL,
	[Notas] [varchar](255) NULL,
        */

        public Promocion()
        {
        }

        public int IdPromocion { get; set; }

        public string Descripcion { get; set; }

        public decimal Importe { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public string Notas { get; set; }


        public bool Validate()
        {
            //TODO: Este metodo, tiene como objetivo realizar validaciones basicas.
            //por ejemplo, ver si su codigo es -1. De ser asi, retornar false.
            //se pueden agregar muchas mas validaciones. Tambien podrian ir en el Controlador. 
            //Pero creo que me gustan aqui.

            //if (IdPromocion.Equals(-1)) return false;

            if (FechaFin < FechaInicio)
                return false;
            //TODO: Pensar y agregar mas posibles validaciones de cosas que podrian estar mal en el modelo.           

            return true;
        }

        /*
        //TODO: Esto es algo nuevo que hago, puede ser muy util!
        public static explicit operator Promocion(PromocionView v)
        {
            return new Promocion() {
                IdPromocion = v.IdPromocion,
                CodigoBarras = v.CodigoBarras,
                Descripcion = v.Descripcion,
                IdMarca = null,
                IdRubro = null,
                IdUnidad = null,
                PrecioCostoPromedio = 1,
                PrecioVenta = v.Precio,
                Capacidad = v.Capacidad,
                SoloAdultos = null,
                StockMaximo = 0,
                StockMinimo = 0
            };
            
        }
        */
    }
}
