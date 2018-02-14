using System;

namespace Model
{
    public class ClaseTarea: IEntidad
    {
        public int IdClaseTarea { get; set; }

        public string Descripcion { get; set; }

        public string Notas { get; set; }

        public bool Validate()
        {
            return true;
        }
    }
}
