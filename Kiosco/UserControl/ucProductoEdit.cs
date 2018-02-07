using System;
using System.ComponentModel;
using System.Windows.Forms;
using Controlador;
using Model;

namespace Heimdall.UserControl
{
    public partial class UcProductoEdit : System.Windows.Forms.UserControl, ISelectorMarca
    {
        [Category("Action")]
        [Description("Es lanzado cuando el Stock es cambiado")]
        public event ProductoChangedEventHandler StockChanged;

        protected virtual void OnStockChanged(ValueChangedEventArgs e)
        {
            StockChanged?.Invoke(this, e);
        }

        [Category("Action")]
        [Description("Es lanzado cuando se selecciona otro producto.")]
        public event ProductoChangedEventHandler ProductoChanged;

        protected virtual void OnProductoChanged(ValueChangedEventArgs e)
        {
            ProductoChanged?.Invoke(this, e);
        }



        public UcProductoEdit()
        {
            InitializeComponent();
            if (Program.UsuarioConectado.EsAdmin == false)
            {
                labPrecioCosto.Visible = false;
                nudPrecioCosto.Visible = false;
            }
        }


        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            ActualizarStock();
        }

        private void ActualizarStock()
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


            //TODO: Para actualizar celda de stock, debo EXPONER un evento aqui.
            OnStockChanged(new ValueChangedEventArgs(s.Cantidad));
            //Evento StockActualizado, y devolver al cliente (formulario) la Cantidad final.
        }


        private void nudPrecio_Enter(object sender, EventArgs e)
        {
            var valor = nudPrecio.Value.ToString();
            nudPrecio.Select(0, valor.Length);
            //nudPrecio.ForeColor = Color.Yellow;
            //nudPrecio.BackColor = Color.Yellow;
        }

        private void nudPrecioCosto_Enter(object sender, EventArgs e)
        {
            var valor = nudPrecioCosto.Value.ToString();
            nudPrecioCosto.Select(0, valor.Length);

        }

        private void nudPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('.') || e.KeyChar.Equals(',')) {
                e.KeyChar = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
            }
        }

        private void nudPrecioCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('.') || e.KeyChar.Equals(',')) {
                e.KeyChar = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
            }
        }

        private void btnSeleccionarMarca_Click(object sender, EventArgs e)
        {
            var f = new FrmSeleccionarMarca(this);
            f.Show();
        }

        [Description("IdMarca. Su evento de cambio genera DataBinding."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public int IdMarca
        {
            get {
                int v = int.TryParse(txtIdMarca.Text.Trim(), out v) ? v : 0;
                return v;
            }
            set { txtIdMarca.Text = value.ToString(); }
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

        [Description("PrecioVentaPremium."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public decimal PrecioVentaPremium
        {
            get { return nudPrecioVentaPremium.Value; }
            set { nudPrecioVentaPremium.Value = value; }
        }


        [Description("PrecioCosto."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public decimal PrecioCosto
        {
            get { return nudPrecioCosto.Value; }
            set { nudPrecioCosto.Value = value; }
        }

        [Description("StockMinimo."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public int StockMinimo
        {
            get { return (int)nudStockMinimo.Value; }
            set { nudStockMinimo.Value = value; }
        }

        [Description("StockMaximo."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public int StockMaximo
        {
            get { return (int)nudStockMaximo.Value; }
            set { nudStockMaximo.Value = value; }
        }

        [Description("Stock."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public int StockActual
        {
            get { return (int)nudStockActual.Value; }
            set { nudStockActual.Value = value; }
        }

        [Description("Notas."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string Notas
        {
            get { return txtNotas.Text; }
            set { txtNotas.Text = value; }
        }

        private void btnAbmMarca_Click(object sender, EventArgs e)
        {
            var f = new FrmMarca();
            f.Show();
        }

        [Description("SoloAdultos."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public bool SoloAdultos
        {
            get { return chkSoloAdultos.Checked; }
            set { chkSoloAdultos.Checked = value; }
        }

        [Description("IdRubro."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public int IdRubro
        {
            get {
                int v = int.TryParse(cboRubro.SelectedValue?.ToString(), out v) ? v : 0;
                return v;
            }
            set { cboRubro.SelectedValue = value; }
        }

        [Description("Rubro."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string Rubro => cboRubro.Text.Trim();


        [Description("Marca."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string Marca => txtMarca.Text.Trim();


        [Description("IdUnidad."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public int IdUnidad
        {
            get {
                int v = int.TryParse(cboUnidad.SelectedValue?.ToString(), out v) ? v : 0;
                return v;
            }
            set { cboUnidad.SelectedValue = value; }
        }


        [Description("Capacidad."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public int Capacidad
        {
            get { return (int)nudCapacidad.Value; }
            set { nudCapacidad.Value = value; }
        }


        private void txtIdProducto_TextChanged(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            var id = Convert.ToInt64(txtIdProducto.Text.Trim());

            var c = ProductoControlador.GetByPrimaryKey(id);

            txtCodigoBarras.Text = c.CodigoBarras;
            txtDescripcion.Text = c.Descripcion;
            nudCapacidad.Value = c.Capacidad;
            nudPrecio.Value = c.PrecioVenta;
            nudPrecioVentaPremium.Value = c.PrecioVentaPremium;
            nudStockMinimo.Value = c.StockMinimo;
            nudStockMaximo.Value = c.StockMaximo;
            chkSoloAdultos.Checked = c.SoloAdultos ?? false;
            nudPrecioCosto.Value = c.PrecioCostoPromedio;

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
        }


        private void txtIdMarca_TextChanged(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            //TODO: Validar. Puede usarse un try/catch
            var codigo = Convert.ToInt32(txtIdMarca.Text.Trim());

            var c = MarcaControlador.GetByPrimaryKey(codigo);

            txtMarca.Text = c.Descripcion;
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
            nudPrecioVentaPremium.Value = 0;
            nudPrecioCosto.Value = 0;
            nudStockMaximo.Value = 0;
            nudStockMinimo.Value = 0;
            chkSoloAdultos.Checked = false;
            txtNotas.Clear();

            //Para estos controles, se puede poner un valor default.
            //No obstante, es util para el operador, si va a cargar productos similares.
            //cboRubro
            //cboUnidad
        }

        private void ucProductoEdit_Load(object sender, EventArgs e)
        {
            SetControles();
            CargarControles();
        }

        private void CargarControles()
        {
            CargarRubro();
            CargarUnidad();
        }

        private void CargarUnidad()
        {
            if (DesignMode)
                return;

            cboUnidad.DropDownStyle = ComboBoxStyle.DropDownList;
            var list = UnidadControlador.GetAll();
            cboUnidad.DataSource = list;
            cboUnidad.ValueMember = "IdUnidad";
            cboUnidad.DisplayMember = "Descripcion";
        }


        private void CargarRubro()
        {
            if (DesignMode)
                return;
            cboRubro.DropDownStyle = ComboBoxStyle.DropDownList;
            var list = RubroControlador.GetAll();
            cboRubro.DataSource = list;
            cboRubro.ValueMember = "IdRubro";
            cboRubro.DisplayMember = "Descripcion";
        }


        private void SetControles()
        {
            txtIdProducto.Visible = false;
            txtCodigoBarras.MaxLength = 13;

            Util.SetNumericBounds(nudPrecio);
            Util.SetNumericBounds(nudPrecioVentaPremium);
            Util.SetNumericBounds(nudPrecioCosto);
            Util.SetNumericBounds(nudStockActual);
            Util.SetNumericBounds(nudStockMaximo);
            Util.SetNumericBounds(nudStockMinimo);
            Util.SetNumericBounds(nudCapacidad);
            Util.SetNumericBounds(nudStockActual);
            nudStockActual.Increment = 1;
            nudStockMaximo.Increment = 1;
            nudStockMinimo.Increment = 1;
            nudCapacidad.Increment = 250;
            txtIdMarca.Visible = false;

            txtDescripcion.MaxLength = 255;
            txtNotas.MaxLength = 255;
        }


        private void txtCodigoBarras_TextChanged(object sender, EventArgs e)
        {
            //barCodeControl1.Text = txtCodigoBarras.Text.Trim();
        }

        private void txtCodigoBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void nudPrecioVentaPremium_Enter(object sender, EventArgs e)
        {
            var valor = nudPrecioVentaPremium.Value.ToString();
            nudPrecioVentaPremium.Select(0, valor.Length);
        }

        private void nudPrecioVentaPremium_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('.') || e.KeyChar.Equals(',')) {
                e.KeyChar = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
            }
        }
    }
}
