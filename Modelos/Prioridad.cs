using System;

namespace Model
{
    public class Prioridad: IEntidad
    {
        public int IdPrioridad { get; set; }

        public string Descripcion { get; set; }

        public string Notas { get; set; }


        public bool Validate()
        {
            return true;
        }
    }
}
