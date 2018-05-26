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
            Util.CenterFormX(labTitulo, this);

            Util.CenterFormX2(btnConsultaProducto, this);
            Util.CenterFormX2(btnAbmProducto, this);
            Util.CenterFormX2(btnPedido, this);
            Util.CenterFormX2(btnTareas, this);
            Util.CenterFormX2(btnFaltante, this);
            Util.CenterFormX2(btnAbmProveedor, this);
            Util.CenterFormX2(btnAbmMarca, this);
            Util.CenterFormX2(btnCerrarSesion, this);
            Util.CenterFormX2(btnGastos, this);

            Util.CenterFormX4(btnVentaRegistro, this);
            Util.CenterFormX4(btnVentasReporte, this);
            Util.CenterFormX4(btnEstadisticas, this);
            Util.CenterFormX4(btnRecaudacion, this);
            Util.CenterFormX4(btnTurno, this);
            Util.CenterFormX4(btnUsuarios, this);
            Util.CenterFormX4(btnProductoProveedor, this);
            Util.CenterFormX4(btnOpciones, this);

            Util.CenterFormX(btnSalir, this);


            //TODO: Ver si ademas de estar deshabilitado se puede hacer que sea invisible.
            //Esto es recodificable de varias formas distintas.
            //TODO: Estas cosas deben estar definidas en base de datos o xml, no en codigo compilado.
            if (Program.UsuarioConectado.EsAdmin == false)
            {
                //btnAbmProveedor.Enabled = false;
                btnVentasReporte.Enabled = false;
                btnProductoProveedor.Enabled = false;
                btnEstadisticas.Enabled = false;
                btnRecaudacion.Enabled = false;
                btnTurno.Enabled = false;
                btnUsuarios.Enabled = false;
                btnOpciones.Enabled = false;
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

        private void btnFaltante_Click(object sender, EventArgs e)
        {
            var f = new FrmFaltante();
            f.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            //TODO: Esto deberia llevar al login y no cerrar todo. Pero bueno.
            Application.Exit();
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            var f = new FrmGasto();
            f.Show();
        }
    }
}
