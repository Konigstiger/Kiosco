using System;

namespace Model
{
    public class TurnoView: IEntidad
    {
        public int IdTurno { get; set; }

        public string Descripcion { get; set; }

        public DateTime Fecha { get; set; }

        public TimeSpan HoraInicio { get; set; }

        public TimeSpan HoraFin { get; set; }

        public decimal CantidadHoras { get; set; }

        public long IdPagoEmpleado { get; set; }

        public decimal Monto { get; set; }

        public string Notas { get; set; }

        public enum GridColumn
        {
            IdTurno = 0,
            Descripcion = 1,
            Fecha = 2,
            CantidadHoras = 3,
            Notas = 4
        }

        public bool Validate()
        {
            return true;
        }
    }
}
