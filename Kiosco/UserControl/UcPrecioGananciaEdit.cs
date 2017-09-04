using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heimdall.UserControl
{
    // Ganancia = 1 - (Costo / Precio) * 100
    //STR(ROUND( 1-(PrecioCostoPromedio / PrecioVenta) * 100, 2 ), 10, 2) + ' %' AS 'Ganancia'

    public partial class UcPrecioGananciaEdit : System.Windows.Forms.UserControl
    {
        public UcPrecioGananciaEdit()
        {
            InitializeComponent();
        }

        private void nudPrecio_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
