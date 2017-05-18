using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using Model;

namespace Kiosco.UserControl
{
    public partial class ucProductoView : System.Windows.Forms.UserControl, ISelectorProducto
    {
        public ucProductoView()
        {
            InitializeComponent();
        }

        [Description("IdProducto. Su evento de cambio genera DataBinding."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public long IdProducto
        {
            get { return Convert.ToInt32(txtIdProducto.Text); }
            set { txtIdProducto.Text = value.ToString(); }
        }


        private void btnSeleccionarProducto_Click(object sender, EventArgs e)
        {
            var f = new FrmSeleccionarProducto(this);
            f.Show();
        }


        private void txtIdProducto_TextChanged(object sender, EventArgs e)
        {
            var id = Convert.ToInt64(txtIdProducto.Text.Trim());

            var c = ProductoControlador.GetByPrimaryKey(id);

            IdProducto = id;

            txtCodigoBarras.Text = c.CodigoBarras;
            txtDescripcion.Text = c.Descripcion;
            nudPrecioCosto.Value = c.PrecioCostoPromedio;
            nudPrecio.Value = c.PrecioVenta;

            /*
            
            nudStockMinimo.Value = c.StockMinimo;
            nudStockMaximo.Value = c.StockMaximo;
            chkSoloAdultos.Checked = c.SoloAdultos ?? false;

            txtIdMarca.Text = c.IdMarca.ToString();
            cboRubro.SelectedValue = c.IdRubro;
            cboUnidad.SelectedValue = c.IdUnidad ?? 1;
            txtNotas.Text = c.Notas;

            //TODO: Recuperar valor actual de Stock, si existe.
            var s = new Stock {
                IdProducto = id,
                IdDeposito = 1
            };

            var q = StockControlador.GetByParameters(s);
            nudStockActual.Value = q.Cantidad;
            */
        }

        private void btnAbmProducto_Click(object sender, EventArgs e)
        {
            var f = new FrmProducto();
            f.Show();
        }

        private void ucProductoView_Load(object sender, EventArgs e)
        {
            SetControles();
            CargarControles();
        }

        private void SetControles()
        {
            nudPrecio.Enabled = false;
            nudPrecioCosto.Enabled = false;
        }

        private void CargarControles()
        {
            
        }

        public void Clear()
        {
            txtCodigoBarras.Clear();
            txtDescripcion.Clear();
            //
        }

    }
}
