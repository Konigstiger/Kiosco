
namespace Model
{
    public class HoraEntrega: IEntidad
    {
        public int IdHoraEntrega { get; set; }

        public string Descripcion { get; set; }

        public string Notas { get; set; }

        public bool Validate()
        {
            return true;
        }
    }
}
