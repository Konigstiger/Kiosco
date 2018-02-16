using System;
using System.Windows.Forms;

namespace Heimdall
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
            Util.CenterFormX(btnRecaudacion, this);
            Util.CenterFormX(btnProductoProveedor, this);
            Util.CenterFormX(btnVenta, this);
            Util.CenterFormX(btnVentas, this);
            Util.CenterFormX(btnCerrarSesion, this);
            Util.CenterFormX(btnUsuarios, this);
            Util.CenterFormX(btnTurno, this);
            
            //TODO: Reactivar
            //Util.CenterFormX(btnTareas, this);


            if (Program.UsuarioConectado.EsAdmin == false)
            {
                btnAbmProveedor.Enabled = false;
                btnProductoProveedor.Enabled = false;
                btnEstadisticas.Enabled = false;
                btnRecaudacion.Enabled = false;
                //...
            }

            btnConsultaProducto.Focus();
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

        private void btnRecaudacion_Click(object sender, EventArgs e)
        {
            var f = new FrmRecaudacion();
            f.Show();
        }



        private void btnVenta_Click(object sender, EventArgs e)
        {
            var f = new FrmRegistrarVenta();
            f.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            var f = new FrmVenta();
            f.Show();
        }


        private void btnTableroDemo_Click(object sender, EventArgs e)
        {
            var f = new FrmTableroPedidos();
            f.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            var f = new FrmUsuario();
            f.Show();
        }

        private void btnTurno_Click(object sender, EventArgs e)
        {
            var f = new FrmTurno();
            f.Show();
        }

        private void btnTareas_Click(object sender, EventArgs e)
        {
            var f = new FrmTarea();
            f.Show();
        }
    }
}
