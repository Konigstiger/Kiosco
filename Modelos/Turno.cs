﻿using System;

namespace Model
{
    public class Turno: IEntidad
    {
        public long IdTurno { get; set; }

        public string Descripcion { get; set; }

        public DateTime Fecha { get; set; }

        public DateTime HoraInicio { get; set; }

        public DateTime HoraFin { get; set; }

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
