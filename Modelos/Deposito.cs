using System;

namespace Model
{
    public class Deposito: IEntidad
    {
        public const int IdDepositoNegocio = 1;

        public int IdDeposito { get; set; }

        public string Descripcion { get; set; }

        public string Direccion { get; set; }

        public bool PuntoVenta { get; set; }

        public string Notas { get; set; }

        public bool Validate()
        {
            return true;
        }
    }
}
