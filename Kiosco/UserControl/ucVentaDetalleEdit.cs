using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using Kiosco;
using Kiosco.UserControl;
using Model;

namespace Heimdall.UserControl
{
    public partial class UcVentaDetalleEdit : System.Windows.Forms.UserControl, ISelectorProducto
    {
        [Description("IdProducto. Su evento de cambio genera DataBinding."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public long IdProducto
        {
            get {
                long v = long.TryParse(txtIdProducto.Text.Trim(), out v) ? v : 0;
                return v;
            }
            set {
                txtIdProducto.Text = value.ToString();
                OnProductoChanged(new ValueChangedEventArgs(value));
            }
        }


        [Description("CodigoBarras."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string CodigoBarras
        {
            get { return txtCodigoBarras.Text.Trim(); }
            set { txtCodigoBarras.Text = value; }
        }


        [Description("Descripcion."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string Descripcion
        {
            get { return txtDescripcion.Text; }
            set { txtDescripcion.Text = value; }
        }

            
        [Description("PrecioVenta."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public decimal PrecioVenta
        {
            get { return nudPrecio.Value; }
            set { nudPrecio.Value = value; }
        }


        [Description("StockActual."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public int StockActual
        {
            get
            {
                int v = int.TryParse(txtStock.Text.Trim(), out v) ? v : 0;
                return v;
            }
            set { txtStock.Text = value.ToString(); }
        }


        [Category("Action")]
        [Description("Es lanzado cuando se selecciona otro producto.")]
        public event ProductoChangedEventHandler ProductoChanged;

        protected virtual void OnProductoChanged(ValueChangedEventArgs e)
        {
            ProductoChanged?.Invoke(this, e);
        }


        public UcVentaDetalleEdit()
        {
            InitializeComponent();
        }


        private void nudPrecio_Enter(object sender, EventArgs e)
        {
            var valor = nudPrecio.Value.ToString();
            nudPrecio.Select(0, valor.Length);
            //nudPrecio.ForeColor = Color.Yellow;
            //nudPrecio.BackColor = Color.Yellow;
        }


        private void nudPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('.') || e.KeyChar.Equals(',')) {
                e.KeyChar = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
            }
        }

        private void nudImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('.') || e.KeyChar.Equals(',')) {
                e.KeyChar = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
            }
        }

        private void txtIdProducto_TextChanged(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            var id = Convert.ToInt64(txtIdProducto.Text.Trim());

            var c = ProductoControlador.GetByPrimaryKey(id);

            txtCodigoBarras.Text = c.CodigoBarras;
            txtDescripcion.Text = c.Descripcion;
            nudPrecio.Value = c.PrecioVenta;

            var s = new Stock {
                IdProducto = id,
                IdDeposito = 1
            };

            var q = StockControlador.GetByParameters(s);
            txtStock.Text = q.Cantidad.ToString();
        }


        public void Clear()
        {
            LimpiarControles();
        }

        public void LimpiarControles()
        {
            txtCodigoBarras.Clear();
            txtDescripcion.Clear();
            nudPrecio.Value = 0;
        }

        private void UcVentaDetalleEdit_Load(object sender, EventArgs e)
        {
            SetControles();
            CargarControles();
        }


        private void SetControles()
        {
            txtIdProducto.Visible = false;
            txtCodigoBarras.MaxLength = 13;
            Util.SetNumericBounds(nudPrecio);
            txtDescripcion.MaxLength = 255;
        }

        private void CargarControles()
        {
            //CargarUnidad();
        }

    }
}
