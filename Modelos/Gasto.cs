using System;

namespace Model
{
    public class Gasto : IEntidad
    {
        public long IdGasto { get; set; }

        public string Descripcion { get; set; }

        public decimal Monto { get; set; }

        public decimal MontoPendiente { get; set; }

        public int IdClaseGasto { get; set; }

        public int IdEstadoGasto { get; set; }

        public int IdPrioridad { get; set; }

        public DateTime? FechaPago { get; set; }

        public DateTime? FechaVencimiento { get; set; }

        public bool? Archivado { get; set; }

        public string Notas { get; set; }

        


        public bool Validate()
        {
            //TODO: Este metodo, tiene como objetivo realizar validaciones basicas.
            //por ejemplo, ver si su codigo es -1. De ser asi, retornar false.
            //se pueden agregar muchas mas validaciones. Tambien podrian ir en el Controlador. 
            //Pero creo que me gustan aqui.

            //if (FechaPago > FechaVencimiento)
            //    return false;
            //TODO: Pensar y agregar mas posibles validaciones de cosas que podrian estar mal en el modelo.           

            return true;
        }

    }
}
