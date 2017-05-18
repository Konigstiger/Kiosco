using System;

namespace Model
{
    public class Unidad: IEntidad
    {
        public int IdUnidad { get; set; }

        public string Descripcion { get; set; }

        public string Simbolo { get; set; }

        public int Unidades { get; set; }

        public bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}
