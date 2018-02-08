using System;

namespace Model
{
    public class PagoEmpleado: IEntidad
    {
        public int IdPagoEmpleado { get; set; }

        public string Descripcion { get; set; }

        public string Notas { get; set; }

        public bool Validate()
        {
            return true;
        }
    }
}
