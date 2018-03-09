using System;

namespace Model.View
{
    public class TareaView
    {
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
        public string Prioridad { get; set; }
        public string Clase { get; set; }
        public string Estado { get; set; }


        public enum GridColumn
        {
            IdTarea = 0,
            Descripcion = 1,
            Fecha = 2,
            Estado = 3,
            Prioridad = 4,
            Clase = 5
        }
    }


}
