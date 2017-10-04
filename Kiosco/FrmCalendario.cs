using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using Model;

//using Kiosco.View;

namespace Heimdall
{
    public partial class FrmCalendario : DevExpress.XtraEditors.XtraForm
    {
        public FrmCalendario()
        {
            InitializeComponent();
        }

        private void FrmCalendario_Load(object sender, EventArgs e)
        {
            //Cargar los registros de PedidoView.

            var list = new List<PedidoView>();

            list = PedidoControlador.GetAll();

            pedidoViewBindingSource.DataSource = list;
            
            


        }
    }
}