using System;

namespace Model
{
    public class EstadoUsuario: IEntidad
    {
        public int IdEstadoUsuario { get; set; }

        public string Descripcion { get; set; }

        public string Notas { get; set; }

        public bool Validate()
        {
            //TODO: Hacer que verifique que no existe ya un registro con esa misma descripcion.
            return true;
        }
    }
}
