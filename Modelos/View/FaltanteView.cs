using System;

namespace Model.View
{
    public class FaltanteView : IEntidad
    {
        public long IdFaltante { get; set; }

        public string Descripcion { get; set; }

        public long? IdProducto { get; set; }

        public int Cantidad { get; set; }

        public int IdEstadoFaltante { get; set; }

        public string EstadoFaltante { get; set; }

        public DateTime Fecha { get; set; }

        public DateTime? FechaResuelto { get; set; }

        public bool? Archivado { get; set; }

        public int IdClaseFaltante { get; set; }

        public string Notas { get; set; }


        public enum GridColumn
        {
            IdFaltante = 0,
            Descripcion = 1,
            Fecha = 2,
            EstadoFaltante = 3,
            Notas = 4
        }


        public bool Validate()
        {
            //TODO: Este metodo, tiene como objetivo realizar validaciones basicas.
            //por ejemplo, ver si su codigo es -1. De ser asi, retornar false.
            //se pueden agregar muchas mas validaciones. Tambien podrian ir en el Controlador. 
            //Pero creo que me gustan aqui.

            if (Fecha > FechaResuelto)
                return false;
            //TODO: Pensar y agregar mas posibles validaciones de cosas que podrian estar mal en el modelo.           

            return true;
        }

    }
}
