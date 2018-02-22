using System;

namespace Model
{
    public class ClaseFaltante: IEntidad
    {
        public int IdClaseFaltante { get; set; }

        public string Descripcion { get; set; }

        public string Notas { get; set; }

        public bool Validate()
        {
            //TODO: Hacer que verifique que no existe ya un registro con esa misma descripcion.
            return true;
        }
    }
}
