using System;
using Model.View;

namespace Model
{
    public class Tarea : IEntidad
    {
        //TODO: Estudiar esto, puede ser util en algunas entidades.
        /*
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        */

        private int v;

        public Tarea(int v)
        {
            this.v = v;
        }

        public Tarea()
        {
        }

        public long IdTarea { get; set; }

        public string Descripcion { get; set; }

        public int? IdPrioridad { get; set; }

        public DateTime Fecha { get; set; }

        public DateTime FechaVencimiento { get; set; }

        public int IdEstadoTarea { get; set; }

        public int? IdDificultad { get; set; }

        public int? IdClaseTarea { get; set; }

        public int? IdUsuario { get; set; }

        public int PorcentajeCompleto { get; set; }

        public string Detalle { get; set; }

        public bool? Archivado { get; set; }

        public long? IdTareaPadre { get; set; }

        public string Notas { get; set; }

        public bool Validate()
        {
            //TODO: Este metodo, tiene como objetivo realizar validaciones basicas.
            //por ejemplo, ver si su codigo es -1. De ser asi, retornar false.
            //se pueden agregar muchas mas validaciones. Tambien podrian ir en el Controlador. 
            //Pero creo que me gustan aqui.

            //if (IdTarea.Equals(-1)) return false;

            if (Fecha > FechaVencimiento)
                return false;
            //TODO: Pensar y agregar mas posibles validaciones de cosas que podrian estar mal en el modelo.           

            return true;
        }

    }
}
