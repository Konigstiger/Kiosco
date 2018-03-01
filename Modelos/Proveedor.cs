using System;

namespace Model
{
    public class Proveedor: IEntidad
    {
        public int IdProveedor { get; set; }

        public string RazonSocial { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }

        public string PersonaContacto { get; set; }
        

        public string Notas { get; set; }
        public string RutaCatalogo { get; set; }

        public string HorarioAtencion { get; set; }

        public string DiasDeVisita { get; set; }

        public int IdRubro { get; set; }
        public int IdEstadoProveedor { get; set; }

        public bool Validate()
        {
            //TODO: Pendiente
            return true;
        }
    }
}
