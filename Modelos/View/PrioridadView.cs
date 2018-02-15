namespace Model.View
{
    public class PrioridadView
    {
        public int IdPrioridad { get; set; }

        public string Descripcion { get; set; }

        public string Notas { get; set; }

        public enum GridColumn
        {
            IdPrioridad = 0,
            Descripcion = 1,
            Notas = 2
        }

    }
}
