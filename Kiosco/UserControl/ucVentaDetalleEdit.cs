using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Windows.Forms;
using Controlador;
using Kiosco;
using Kiosco.UserControl;
using Model;

namespace Heimdall.UserControl
{
    public partial class UcVentaDetalleEdit : System.Windows.Forms.UserControl, ISelectorProducto
    {
        private const int MaxLenghtCodeBar = 13;

        [Category("Action")]
        [Description("Es lanzado cuando se desea agregar un elemento nuevo.")]
        public event AddActionEventHandler AddAction;

        protected virtual void OnAddAction(EventArgs e)
        {
            AddAction?.Invoke(this, e);
        }


        [Category("Action")]
        [Description("Es lanzado cuando se desea actualizar un elemento existente.")]
        public event UpdateActionEventHandler UpdateAction;

        protected virtual void OnUpdateAction(EventArgs e)
        {
            UpdateAction?.Invoke(this, e);
        }


        [Category("Action")]
        [Description("Es lanzado cuando se desea remover un elemento existente.")]
        public event RemoveActionEventHandler RemoveAction;

        protected virtual void OnRemoveAction(EventArgs e)
        {
            RemoveAction?.Invoke(this, e);
        }


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


        [Description("Cantidad."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public int Cantidad
        {
            get {
                return (int)nudCantidad.Value;
            }
            set { nudCantidad.Value = value; }
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


        [Description("Importe."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public decimal Importe
        {
            get { return nudImporte.Value; }
            set { nudImporte.Value = value; }
        }


        [Description("Stock."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public int Stock
        {
            get {
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
            //Se ha elegido un producto. Habilitar controles.
            btnAgregar.Enabled = true;
            btnRemoverItem.Enabled = true;
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
            txtCodigoBarras.MaxLength = MaxLenghtCodeBar;
            Util.SetNumericBounds(nudPrecio);
            txtDescripcion.MaxLength = 255;

            btnAgregar.Enabled = false;
            btnRemoverItem.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void CargarControles()
        {
            //CargarUnidad();
        }

        private void btnSeleccionarProducto_Click(object sender, EventArgs e)
        {
            var f = new FrmSeleccionarProducto(this);
            f.Show();
        }

        private void nudPrecio_ValueChanged(object sender, EventArgs e)
        {
            nudImporte.Value = Cantidad * PrecioVenta;
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            nudImporte.Value = Cantidad * PrecioVenta;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = true;
            nudCantidad.Value = 1;
            OnAddAction(new EventArgs());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            OnUpdateAction(new EventArgs());
        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            OnRemoveAction(new EventArgs());
        }


        private void txtCodigoBarras_KeyDown(object sender, KeyEventArgs e)
        {
            //si se produce este evento con Enter, es porque se ha ingresado con la lectora,
            //o bien el usuario presiono enter a proposito...
            if (e.KeyCode == Keys.Enter) {
                e.SuppressKeyPress = true;
                VerificarProducto();
                txtCodigoBarras.Select(0, txtCodigoBarras.Text.Length);

                OnAddAction(new EventArgs());
            }
        }


        private void VerificarProducto()
        {
            var codigo = this.CodigoBarras;
            var c = ProductoControlador.GetByCodigoBarras(codigo);

            txtCodigoBarras.Text = c.CodigoBarras;
            txtDescripcion.Text = c.Descripcion;
            nudPrecio.Value = c.PrecioVenta;

            var s = new Stock {
                IdProducto = c.IdProducto,
                IdDeposito = 1
            };

            var q = StockControlador.GetByParameters(s);
            txtStock.Text = q.Cantidad.ToString();
        }


        public new void Focus()
        {
            txtCodigoBarras.Focus();
        }

        private void btnActualizarStock_Click(object sender, EventArgs e)
        {
            ActualizarStock();
        }

        private void ActualizarStock()
        {
            var cantidad = Convert.ToInt32(txtStock.Text.Trim());
            var idProducto = Convert.ToInt64(txtIdProducto.Text.Trim());
            var idDeposito = Deposito.IdDepositoNegocio;

            var s = new Stock {
                IdProducto = idProducto,
                IdDeposito = idDeposito,
                Cantidad = cantidad,
                IdStock = -1
            };

            //invocar a metodo update de Clase Stock
            var res = StockControlador.Update(s);
        }
    }
}
