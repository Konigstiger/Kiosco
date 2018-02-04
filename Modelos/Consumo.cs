
namespace Model
{
    public class Consumo : IEntidad
    {
        public int IdConsumo { get; set; }

        public long IdTurno { get; set; }

        public long IdProducto { get; set; }

        public decimal Cantidad { get; set; }

        public decimal Monto { get; set; }

        public string Notas { get; set; }

        public bool Validate()
        {
            return true;
        }
    }
}
