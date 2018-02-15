namespace Model.View
{
    public class MarcaView
    {
        public int IdMarca { get; set; }

        public string Descripcion { get; set; }

        public string Notas { get; set; }

        public enum GridColumn
        {
            IdMarca = 0,
            Descripcion = 1,
            Notas = 2
        }
    }
}
