namespace Model.View
{
    public class EstadoGastoView: IEntidad
    {
        public int IdEstadoGasto { get; set; }

        public string Descripcion { get; set; }

        public string Notas { get; set; }

        public bool Validate()
        {
            //TODO: Hacer que verifique que no existe ya un registro con esa misma descripcion.
            return true;
        }
    }
}
