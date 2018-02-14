using System;

namespace Model
{
    public class Dificultad: IEntidad
    {
        public int IdDificultad { get; set; }

        public string Descripcion { get; set; }

        public string Notas { get; set; }

        public bool Validate()
        {
            return true;
        }
    }
}
