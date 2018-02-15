using System;
using System.Collections.Generic;
using Model.View;

namespace Model
{
    //Sin uso. Ver si la uso o se descarta.
    //TODO: Es factible de aplicar en FrmVenta.
    public class ItemFactura: IEntidad
    {
        public int IdItemFactura { get; set; }

        public ProductoView Producto { get; set; }

        public int Cantidad { get; set; }

        public decimal Importe { get; set; }

        public string CodigoBarras { get; set; }
        public bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}
