using System;

namespace Model
{
    public class Cliente: IEntidad
    {
        public long IdCliente { get; set; }

        public string Descripcion { get; set; }

        public string Apellido { get; set; }

        public string Nombre { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string Notas { get; set; }

        public bool Validate()
        {
            //TODO: Pendiente
            return true;
        }
    }
}
