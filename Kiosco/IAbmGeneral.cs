namespace Kiosco
{
    public interface IAbmGeneral
    {
        /// <summary>
        ///     Define propiedades de los controles.
        /// </summary>
        void SetControles();

        void CargarControles();

        /// <summary>
        ///     Define propiedades de visualizacion y comportamiento de la Grilla.
        /// </summary>
        void CargarGrilla(string searchText);

        void ExecuteSearch();

        void GuardarOInsertar();

        void Eliminar();

        void LimpiarControles();
    }
}