using System;

namespace Model
{
    public class Recaudacion: IEntidad
    {
        public long IdRecaudacion { get; set; }

        public int IdUsuario { get; set; }

        public DateTime Fecha { get; set; }
        public Decimal Total { get; set; }
        public decimal Compras { get; set; }
        public string Notas { get; set; }
        

        public bool Validate()
        {
            //TODO: Hacer que verifique que no existe ya un registro con esa misma descripcion.
            return true;
        }
    }
}
