using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;
using Controlador;

namespace Heimdall.UserControl
{
    public partial class UcPedido : System.Windows.Forms.UserControl, ISelectorProveedor
    {
        private bool _flagReady = false;


        [Category("Action")]
        [Description("Es lanzado cuando el Proveedor es cambiado")]
        public event ValueChangedEventHandler ProveedorChanged;

        protected virtual void OnProveedorChanged(ValueChangedEventArgs e)
        {
            ProveedorChanged?.Invoke(this, e);
        }


        [Description("IdPedido. Su evento de cambio genera DataBinding."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public long IdPedido
        {
            get {
                long v = long.TryParse(txtIdPedido.Text.Trim(), out v) ? v : 0;
                return v;
            }
            set {
                txtIdPedido.Text = value.ToString();
                //hacer cosas de bind aqui
                if (value != 0)
                    CargarPedido(value);    //Esta es la unica llamada.
            }
        }


        [Description("IdProveedor. Su evento de cambio genera DataBinding."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public int IdProveedor
        {
            get {
                int v = int.TryParse(txtIdProveedor.Text.Trim(), out v) ? v : 0;
                return v;
            }
            set {
                txtIdProveedor.Text = value.ToString();
                OnProveedorChanged(new ValueChangedEventArgs(value));
            }
        }


        [Description("ShowDetallePedido."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public bool ShowDetallePedido
        {
            get { return btnVerPedidoDetalle.Visible; }
            set { btnVerPedidoDetalle.Visible = value; }
        }


        [Description("Total."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public decimal Total
        {
            get {
                var v = nudImporte.Value;
                return v;
            }
            set {
                nudImporte.Value = value;
            }
        }


        [Description("Fecha."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public DateTime Fecha
        {
            get { return dtpFecha.Value; }
            set { dtpFecha.Value = value; }
        }


        [Description("Fecha de Entrega."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public DateTime FechaEntrega
        {
            get { return dtpFechaEntrega.Value; }
            set { dtpFechaEntrega.Value = value; }
        }


        [Description("Descripcion."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string Descripcion
        {
            get { return txtDescripcion.Text.Trim(); }
            set { txtDescripcion.Text = value; }
        }


        [Description("Notas."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string Notas
        {
            get { return txtNotas.Text.Trim(); }
            set { txtNotas.Text = value; }
        }


        [Description("Proveedor."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string Proveedor
        {
            get { return txtProveedorDescripcion.Text.Trim(); }
            set { txtProveedorDescripcion.Text = value; }
        }


        [Description("ShowEstadoPedido."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public bool ShowEstadoPedido
        {
            get { return panelEstadoyDetalles.Visible; }
            set { panelEstadoyDetalles.Visible = value; }
        }

        [Description("Estado."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string Estado => cboEstadoPedido.Text.Trim();


        [Description("IdEstadoPedido. Su evento de cambio genera DataBinding."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public int IdEstadoPedido
        {
            get {
                int v = int.TryParse(cboEstadoPedido.SelectedValue?.ToString(), out v) ? v : 0;
                return v;
            }
            set { cboEstadoPedido.SelectedValue = value; }
        }


        [Description("HoraEntrega."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string HoraEntrega => cboHoraEntrega.Text.Trim();


        [Description("IdHoraEntrega. Su evento de cambio genera DataBinding."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public int IdHoraEntrega
        {
            get {
                int v = int.TryParse(cboHoraEntrega.SelectedValue?.ToString(), out v) ? v : 0;
                return v;
            }
            set { cboHoraEntrega.SelectedValue = value; }
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


        [Description("EstaPago."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public bool EstaPago
        {
            get { return chkEstaPago.Checked; }
            set { chkEstaPago.Checked = value; }
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


        [Description("Fiscal."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public bool Fiscal
        {
            get { return chkFiscal.Checked; }
            set { chkFiscal.Checked = value; }
        }

        [Description("Prioridad."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string Prioridad => cboPrioridad.Text.Trim();

        public UcPedido()
        {
            if (DesignMode)
                return;

            InitializeComponent();
        }


        public void CargarPedido(long idPedido)
        {
            if (DesignMode)
                return;

            var p = PedidoControlador.GetByPrimaryKey(idPedido);

            CargarEstadoPedido();
            CargarPrioridad();
            CargarHoraEntrega();

            Descripcion = p.Descripcion;
            Util.CheckDateNullable(p.Fecha, dtpFecha);
            Util.CheckDateNullable(p.FechaEntrega, dtpFechaEntrega);
            Total = p.Total;
            IdProveedor = p.IdProveedor;
            IdEstadoPedido = p.IdEstadoPedido;
            Notas = p.Notas;
            EstaPago = p.EstaPago;
            Archivado = p.Archivado;
            Fiscal = p.Fiscal;
            IdPrioridad = p.IdPrioridad;
            IdHoraEntrega = p.IdHoraEntrega;

        }




        private void CargarControles()
        {
            if (!DesignMode) {
                CargarEstadoPedido();
            }
        }

        private void txtIdProveedor_TextChanged(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            int v = int.TryParse(txtIdProveedor.Text.Trim(), out v) ? v : 0;

            var c = ProveedorControlador.GetByPrimaryKey(v);

            txtProveedorDescripcion.Text = c.RazonSocial;
        }


        public void SetControles()
        {
            txtIdPedido.Visible = false;
            txtIdProveedor.Visible = false;

            txtProveedorDescripcion.Enabled = false;

            txtDescripcion.MaxLength = 100;
            txtNotas.MaxLength = 255;
            dtpFecha.Value = DateTime.Today;
            dtpFecha.Checked = true;
            dtpFechaEntrega.Value = DateTime.Today;
            dtpFechaEntrega.Checked = false;
            chkEstaPago.Checked = false;
            chkArchivado.Checked = false;
            chkFiscal.Checked = false;

        }


        private void btnSeleccionarProveedor_Click(object sender, EventArgs e)
        {
            var f = new FrmSeleccionarProveedor(this);
            f.Show();
        }


        private void CargarEstadoPedido()
        {
            if (_flagReady) {
                cboEstadoPedido.DropDownStyle = ComboBoxStyle.DropDownList;
                var list = EstadoPedidoControlador.GetAll();
                cboEstadoPedido.DataSource = list;
                cboEstadoPedido.ValueMember = "IdEstadoPedido";
                cboEstadoPedido.DisplayMember = "Descripcion";
            }
        }


        private void CargarPrioridad()
        {
            if (_flagReady) {
                cboPrioridad.DropDownStyle = ComboBoxStyle.DropDownList;
                var list = PrioridadControlador.GetAll();
                cboPrioridad.DataSource = list;
                cboPrioridad.ValueMember = "IdPrioridad";
                cboPrioridad.DisplayMember = "Descripcion";
            }
        }


        private void CargarHoraEntrega()
        {
            if (_flagReady) {
                cboHoraEntrega.DropDownStyle = ComboBoxStyle.DropDownList;
                var list = HoraEntregaControlador.GetAll();
                cboHoraEntrega.DataSource = list;
                cboHoraEntrega.ValueMember = "IdHoraEntrega";
                cboHoraEntrega.DisplayMember = "Descripcion";
            }
        }


        private void ucPedido_Load(object sender, EventArgs e)
        {
            _flagReady = true;
            //TODO: Aca deberia cargar o seleccionar.
            SetControles();
            CargarControles();
            CargarPedido(IdPedido);
        }

        private void txtIdPedido_TextChanged(object sender, EventArgs e)
        {
            //if (DesignMode)
            //    return;
            //CargarPedido(IdPedido);
        }

        private void btnAbmProveedor_Click(object sender, EventArgs e)
        {
            var f = new FrmProveedor();
            f.Show();
        }


        public void Clear()
        {
            IdPedido = 0;
            txtIdProveedor.Clear();
            txtDescripcion.Clear();
            nudImporte.Value = 0;
            nudImporte.Value = 0;
            txtNotas.Clear();
            dtpFecha.Value = DateTime.Today;
            dtpFechaEntrega.Value = DateTime.Today;
            cboHoraEntrega.SelectedValue = 1;
            cboEstadoPedido.SelectedValue = 1;
            chkEstaPago.Checked = false;
        }


        private void btnVerPedidoDetalle_Click(object sender, EventArgs e)
        {
            var f = new FrmPedidoDetalle(this.IdPedido);
            f.Show();
        }

        private void nudImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('.') || e.KeyChar.Equals(',')) {
                e.KeyChar = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
            }
        }
    }
}
