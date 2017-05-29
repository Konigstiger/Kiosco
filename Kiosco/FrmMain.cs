using System;
using System.Windows.Forms;
using Kiosco.UI;

namespace Kiosco
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnAbmProducto_Click(object sender, EventArgs e)
        {
            var f = new FrmProducto();
            f.Show();
        }

        private void btnAbmMarca_Click(object sender, EventArgs e)
        {
            var f = new FrmMarca();
            f.Show();
        }


        private void btnConsultaProducto_Click(object sender, EventArgs e)
        {
            var f = new FrmProductoDetalle();
            f.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Util.CenterFormX(btnAbmMarca, this);
            Util.CenterFormX(btnAbmProducto, this);
            Util.CenterFormX(btnConsultaProducto, this);
            Util.CenterFormX(btnAbmProveedor, this);
            Util.CenterFormX(btnSalir, this);
            Util.CenterFormX(btnPedido, this);
            Util.CenterFormX(btnOpciones, this);
            Util.CenterFormX(btnEstadisticas, this);
            Util.CenterFormX(btnProductoProveedor, this);
        }


        private void btnAbmProveedor_Click(object sender, EventArgs e)
        {
            var f = new FrmProveedor();
            f.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            var f = new FrmPedido();
            f.Show();
        }

        private void btnOpciones_Click(object sender, EventArgs e)
        {
            var f = new frmOpciones();
            f.Show();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            var f = new FrmEstadisticas();
            f.Show();
        }

        private void btnProductoProveedor_Click(object sender, EventArgs e)
        {
            var f = new FrmProductoProveedor();
            f.Show();
        }
    }
}
