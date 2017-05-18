using System;
using System.Drawing;
using System.Windows.Forms;
using Controlador;

namespace Kiosco
{
    public partial class FrmProductoDetalle : Form
    {
        public FrmProductoDetalle()
        {
            InitializeComponent();
        }

        private void FrmProductoDetalle_Load(object sender, EventArgs e)
        {
            SetControles();

        }


        public void SetControles()
        {
            txtIdProducto.Visible = false;
            txtIdMarca.Visible = false;
            txtIdRubro.Visible = false;
            txtCodigoBarras.MaxLength = 13;
            txtDescripcion.Enabled = false;
            txtMarca.Enabled = false;
            txtRubroDescripcion.Enabled = false;
            txtNotas.Enabled = false;
            txtPrecio.Enabled = false;
            txtPrecioCosto.Enabled = false;

        }

        private void txtCodigoBarras_TextChanged(object sender, EventArgs e)
        {
            //TODO: De aqui saque codigo.

        }


        private void txtIdMarca_TextChanged(object sender, EventArgs e)
        {
            if (txtIdMarca.Text.Trim() == "")
                return;
            var codigo = Convert.ToInt32(txtIdMarca.Text.Trim());
            var c = MarcaControlador.GetByPrimaryKey(codigo);
            txtMarca.Text = c.Descripcion;
        }


        private void txtIdRubro_TextChanged(object sender, EventArgs e)
        {
            if (txtIdRubro.Text.Trim() == "")
                return;
            var codigo = Convert.ToInt32(txtIdRubro.Text.Trim());
            var c = RubroControlador.GetByPrimaryKey(codigo);
            txtRubroDescripcion.Text = c.Descripcion;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            txtIdProducto.Clear();
            txtIdMarca.Clear();
            txtIdRubro.Clear();
            txtCodigoBarras.Clear();
            txtDescripcion.Clear();
            txtRubroDescripcion.Clear();
            txtMarca.Clear();
            txtNotas.Clear();
            txtPrecio.Clear();
            txtPrecioCosto.Clear();
        }


        private void txtCodigoBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                e.SuppressKeyPress = true;
                DoThis();
                txtCodigoBarras.Select(0, txtCodigoBarras.Text.Length);
            }

            //si se produce este evento con Enter, es porque se ha ingresado con la lectora,
            //o bien el usuario presiono enter a proposito...



        }


        private void DoThis()
        {
            var productoEncontrado = false;
            var productoIngresado = false;

            var codigo = txtCodigoBarras.Text.Trim();
            var p = ProductoControlador.GetByCodigoBarras(codigo);

            productoEncontrado = p.IdProducto != 0;
            txtIdProducto.Text = p.IdProducto.ToString();

            ucNotification.Text = !productoEncontrado ?
                    "Producto no encontrado en la Base de Datos." :
                    "Producto encontrado.";

            ucNotification.BackColor = !productoEncontrado ?
                Color.LightCoral : 
                Color.LightGreen;

            ucNotification.Ocultar();

            //esto sirve en ambos casos.
            txtDescripcion.Text = p.Descripcion;
            txtPrecio.Text = p.PrecioVenta.ToString();
            txtPrecioCosto.Text = p.PrecioCostoPromedio.ToString();

            txtIdRubro.Text = p.IdRubro.ToString();
            txtIdMarca.Text = p.IdMarca.ToString();
            chkSoloAdultos.Checked = p.SoloAdultos ?? false;
            txtNotas.Text = p.Notas;


            //TODO: Mostrar Stock Actual (permitir editarlo).

        }

        private void txtIdProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

    }
}
