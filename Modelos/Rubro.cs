using System;

namespace Model
{
    public class Rubro: IEntidad
    {
        public int IdRubro { get; set; }

        public string Descripcion { get; set; }

        public string Notas { get; set; }

        public bool Validate()
        {
            return true;
        }
    }
}
