namespace Model.View
{
    public class ProveedorView: IEntidad
    {
        public long IdProveedor { get; set; }

        public string RazonSocial { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }

        public string PersonaContacto { get; set; }

        public string HorarioAtencion { get; set; }

        public string DiasDeVisita { get; set; }

        public string Notas { get; set; }

        public string Estado { get; set; }

        public bool Validate()
        {
            //TODO: Pendiente
            return true;
        }

        public enum GridColumn
        {
            IdProveedor = 0,
            RazonSocial = 1,
            Direccion = 2,
            Telefono = 3,
            Estado = 4,
            Notas = 5
        }

    }
}
