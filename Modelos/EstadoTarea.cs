using System;

namespace Model
{
    public class EstadoTarea: IEntidad
    {
        public int IdEstadoTarea { get; set; }

        public string Descripcion { get; set; }

        public string Notas { get; set; }

        public bool Validate()
        {
            return true;
        }
    }
}
