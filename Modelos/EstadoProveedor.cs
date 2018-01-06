using System;

namespace Model
{

    public class EstadoProveedor: IEntidad
    {
        public int IdEstadoProveedor { get; set; }

        public string Descripcion { get; set; }

        public string Notas { get; set; }

        public bool Validate()
        {
            return true;
        }
    }
}
