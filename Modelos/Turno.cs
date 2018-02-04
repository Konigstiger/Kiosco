using System;

namespace Model
{
    public class Turno: IEntidad
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

        public bool Validate()
        {
            return true;
        }
    }
}
