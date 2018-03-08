using System;
using System.ComponentModel;
using System.Windows.Forms;
using Controlador;
using Model;

namespace Heimdall.UserControl
{
    public partial class UcGastoEdit : System.Windows.Forms.UserControl
    {
        public UcGastoEdit()
        {
            InitializeComponent();
            if (Program.UsuarioConectado.EsAdmin == false) {
                //labPrecioCosto.Visible = false;
                //nudPrecioCosto.Visible = false;
            }
        }


        private void CargarControles()
        {
            CargarClase();
            CargarEstado();
            CargarPrioridad();
        }

        private void CargarClase()
        {
            if (DesignMode)
                return;

            cboClaseGasto.DropDownStyle = ComboBoxStyle.DropDownList;
            var list = ClaseGastoControlador.GetAll();
            cboClaseGasto.DataSource = list;
            cboClaseGasto.ValueMember = "IdClaseGasto";
            cboClaseGasto.DisplayMember = "Descripcion";
        }


        private void CargarEstado()
        {
            if (DesignMode)
                return;

            cboEstadoGasto.DropDownStyle = ComboBoxStyle.DropDownList;
            var list = EstadoGastoControlador.GetAll();
            cboEstadoGasto.DataSource = list;
            cboEstadoGasto.ValueMember = "IdEstadoGasto";
            cboEstadoGasto.DisplayMember = "Descripcion";
        }


        private void CargarPrioridad()
        {
            if (DesignMode)
                return;
            cboPrioridad.DropDownStyle = ComboBoxStyle.DropDownList;
            var list = PrioridadControlador.GetAll();
            cboPrioridad.DataSource = list;
            cboPrioridad.ValueMember = "IdPrioridad";
            cboPrioridad.DisplayMember = "Descripcion";
        }


        [Category("Action")]
        [Description("Es lanzado cuando se selecciona otro Gasto.")]
        public event GastoChangedEventHandler GastoChanged;

        protected virtual void OnGastoChanged(ValueChangedEventArgs e)
        {
            GastoChanged?.Invoke(this, e);
        }


        
        /// <summary>
        /// Devuelve un objeto del tipo de la clase editada
        /// </summary>
        /// <returns></returns>
        public Gasto ToModel()
        {
            var model = new Gasto {
                IdGasto = IdGasto,
                Descripcion = Descripcion,
                Monto = Monto,
                //IdProducto = IdProducto == -1 ? (long?)null : IdProducto,
                IdEstadoGasto = IdEstadoGasto,
                IdClaseGasto = IdClaseGasto,
                FechaVencimiento = FechaVencimiento,
                FechaPago = FechaPago,
                IdPrioridad = IdPrioridad,
                Archivado = Archivado,
                Notas = Notas
            };
            return model;
        }
        

        [Description("IdGasto. Su evento de cambio genera DataBinding."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public long IdGasto
        {
            get {
                long v = long.TryParse(txtIdGasto.Text.Trim(), out v) ? v : 0;
                return v;
            }
            set {
                txtIdGasto.Text = value.ToString();
                OnGastoChanged(new ValueChangedEventArgs(value));
                CargarGasto(value);

            }
        }


        public void CargarGasto(long idGasto)
        {
            if (DesignMode)
                return;

            var p = GastoControlador.GetByPrimaryKey(idGasto);

            //TODO: Ver los valores predeterminados, ceros. Podrian ser valores 0 -  sin especificar.


            //Este orden de invocacion creo que es importante. Primero producto, y luego descripcion.
            //IdProducto = p.IdProducto ?? 0;
            Descripcion = p.Descripcion;

            Util.CheckDateNullable(p.FechaPago, dtpFechaPago);
            Util.CheckDateNullable(p.FechaVencimiento, dtpFechaVencimiento);

            if (dtpFechaPago.Checked == false)
                p.FechaPago = null;

            Archivado = p.Archivado ?? false;

            IdEstadoGasto = p.IdEstadoGasto;
            IdClaseGasto = p.IdClaseGasto;    //esto llama internamente a DefinirVis...
            Monto = p.Monto;
            IdPrioridad = p.IdPrioridad;
            Notas = p.Notas;

            //mostrar segun el valor de IdClaseGasto
            //DefinirVisualizacionSegunClaseGasto(IdClaseGasto);

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


        [Description("FechaVencimiento."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public DateTime FechaVencimiento
        {
            get { return dtpFechaVencimiento.Value; }
            set { dtpFechaVencimiento.Value = value; }
        }

        [Description("FechaPago."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public DateTime FechaPago
        {
            get { return dtpFechaPago.Value; }
            set { dtpFechaPago.Value = value; }
        }


        [Description("IdEstadoGasto."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public int IdEstadoGasto
        {
            get {
                int v = int.TryParse(cboEstadoGasto.SelectedValue?.ToString(), out v) ? v : 0;
                return v;
            }
            set { cboEstadoGasto.SelectedValue = value; }
        }


        [Description("EstadoGasto."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string EstadoGasto => cboEstadoGasto.Text.Trim();


        [Description("ClaseGasto."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string ClaseGasto => cboClaseGasto.Text.Trim();



        [Description("Monto."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public decimal Monto
        {
            get {
                var v = nudMonto.Value;
                return v;
            }
            set {
                nudMonto.Value = value;
            }
        }



        [Description("Archivado."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public bool Archivado
        {
            get { return chkArchivado.Checked; }
            set { chkArchivado.Checked = value; }
        }


        [Description("IdClaseGasto."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public int IdClaseGasto
        {
            get {
                int v = int.TryParse(cboClaseGasto.SelectedValue?.ToString(), out v) ? v : 0;
                return v;
            }
            set {
                cboClaseGasto.SelectedValue = value;
            }
        }


        [Description("IdPrioridad. Su evento de cambio genera DataBinding."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public int IdPrioridad
        {
            get {
                int v = int.TryParse(cboPrioridad.SelectedValue?.ToString(), out v) ? v : 0;
                return v;
            }
            set { cboPrioridad.SelectedValue = value; }
        }


        [Description("Prioridad."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string Prioridad => cboPrioridad.Text.Trim();


        public void Clear()
        {
            txtDescripcion.Clear();
            nudMonto.Value = 0;
            chkArchivado.Checked = false;
            dtpFechaVencimiento.Value = DateTime.Today;
            dtpFechaPago.Value = DateTime.Today;
            txtNotas.Clear();
            //todo: definir valores predeterminados.
            /*
                IdEstadoGasto = IdEstadoGasto,
                IdClaseGasto = IdClaseGasto,
                IdPrioridad = IdPrioridad,
             */
        }

        private void UcGastoEdit_Load(object sender, EventArgs e)
        {
            SetControles();
            CargarControles();
        }

        private void SetControles()
        {
            //todo: revisar campos

            txtIdGasto.Visible = false;
            txtDescripcion.MaxLength = 100;
            txtNotas.MaxLength = 255;
            nudMonto.Maximum = 99999;
            nudMonto.Minimum = 0;
            nudMonto.Increment = 100;
            nudMonto.DecimalPlaces = 2;

            dtpFechaVencimiento.Value = DateTime.Today;
            dtpFechaPago.Value = DateTime.Today;

            //Util.SetNumericBounds(nudPrecio);
        }

        private void nudMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('.') || e.KeyChar.Equals(',')) {
                e.KeyChar = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
                //e.Handled = true;
            }
        }
    }
}
