using System;

namespace Model
{
    public class Usuario
    {
        public const int IdUsuarioPredeterminado = 1;



        public int IdUsuario { get; set; }

        public string Usr { get; set; }

        public string Descripcion { get; set; }

        public string Pwd { get; set; }

        public string Apellido { get; set; }

        public string Nombre { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string Notas { get; set; }

    }
}
