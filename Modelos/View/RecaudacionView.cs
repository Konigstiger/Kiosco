using System;

namespace Model.View
{
    public class RecaudacionView: IEntidad
    {
        public long IdRecaudacion { get; set; }

        public int IdUsuario { get; set; }
        public string Usuario { get; set; }

        public DateTime Fecha { get; set; }

        public Decimal Total { get; set; }

        public string Notas { get; set; }
        public decimal Compras { get; set; }
        public decimal Gastos { get; set; }

        public bool Validate()
        {
            //TODO: Hacer que verifique que no existe ya un registro con esa misma descripcion.
            return true;
        }


        public enum GridColumn
        {
            IdRecaudacion = 0,
            Fecha = 1,
            Total = 2,
            Compras = 3,
            Gastos = 4
        }
    }
}
