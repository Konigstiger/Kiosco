using System;

namespace Model
{
    public class UsuarioView
    {

        public int IdUsuario { get; set; }
        public int IdClaseUsuario { get; set; }

        public string Usr { get; set; }

        public string Descripcion { get; set; }
        public string ClaseUsuario { get; set; }
        public string EstadoUsuario { get; set; }

        public string Pwd { get; set; }

        public string Apellido { get; set; }

        public string Nombre { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string Notas { get; set; }

        public enum GridColumn
        {
            IdUsuario = 0,
            Descripcion = 1,
            Usr = 2,
            ClaseUsuario = 3,
            Estado = 4,
            Notas = 5
        }

    }
}
