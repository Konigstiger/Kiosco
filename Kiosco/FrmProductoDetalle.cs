using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Controlador;
using Model;
using NLog;

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
            //si se produce este evento con Enter, es porque se ha ingresado con la lectora,
            //o bien el usuario presiono enter a proposito...
            if (e.KeyCode == Keys.Enter) {
                e.SuppressKeyPress = true;
                VerificarProducto();
                txtCodigoBarras.Select(0, txtCodigoBarras.Text.Length);
            }

        }


        //private static Logger logger = LogManager.GetCurrentClassLogger();

        private void VerificarProducto()
        {
            var productoEncontrado = false;
            var productoIngresado = false;

            var codigo = txtCodigoBarras.Text.Trim();

            //logger.Error("Consulta de Producto: " + codigo);
            //logger.Debug("Consulta de Producto: " + codigo);

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

            //CargarProveedores(p.IdProducto);
            ucProveedorList1.IdProducto = p.IdProducto;

            CargarStockActual(p.IdProducto);
        }


        private void CargarStockActual(long idProducto)
        {
            var s = new Stock { IdProducto = idProducto, IdDeposito = Deposito.IdDepositoNegocio };
            var cantidad = StockControlador.GetByParameters(s).Cantidad;
            nudStockActual.Value = cantidad;
        }


        private const int colCount = 6;

        private List<ProductoProveedorView> origenDatos = null;

   
        private void txtIdProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void txtCodigoBarras_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            var cantidad = (int)nudStockActual.Value;
            var idProducto = Convert.ToInt64(txtIdProducto.Text.Trim());
            var idDeposito = Deposito.IdDepositoNegocio;

            var s = new Stock {
                IdProducto = idProducto,
                IdDeposito = idDeposito,
                Cantidad = cantidad,
                IdStock = -1

            };

            // El codigo IdStock no se conoce a priori, y no deberia ser importante.
            //invocar a metodo update de Clase Stock
            var res = StockControlador.Update(s);
        }
    }
}
