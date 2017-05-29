using System;
using System.ComponentModel;
using System.Windows.Forms;
using Controlador;
using Model;

namespace Kiosco.UserControl
{
    public partial class ucPedido : System.Windows.Forms.UserControl, ISelectorProveedor
    {
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
                    CargarPedido(value);
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
            get {
                return dtpFecha.Value;
            }
            set {
                dtpFecha.Value = value;
            }
        }


        [Description("Fecha."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public DateTime FechaEntrega
        {
            get {
                return dtpFechaEntrega.Value;
            }
            set {
                dtpFechaEntrega.Value = value;
            }
        }


        [Description("Descripcion."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string Descripcion
        {
            get {
                return txtDescripcion.Text.Trim();
            }
            set {
                txtDescripcion.Text = value;
            }
        }


        [Description("Notas."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string Notas
        {
            get {
                return txtNotas.Text.Trim();
            }
            set {
                txtNotas.Text = value;
            }
        }


        [Description("Proveedor."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string Proveedor
        {
            get {
                return txtProveedorDescripcion.Text.Trim();
            }
            set {
                txtProveedorDescripcion.Text = value;
            }
        }


        [Description("Estado."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string Estado => cboEstadoPedido.Text.Trim();




        public ucPedido()
        {
            InitializeComponent();

        }


        public void CargarPedido(long idPedido)
        {
            if (DesignMode)
                return;

            var p = PedidoControlador.GetByPrimaryKey(idPedido);

            txtDescripcion.Text = p.Descripcion;
            //dtpFecha.Value = (DateTime) p.Fecha; //TODO Continuar
            //dtpFechaEntrega.Value = p.FechaEntrega;
            CheckDateNullable(p.FechaEntrega, dtpFechaEntrega);
            CheckDateNullable(p.Fecha, dtpFecha);
            nudImporte.Value = p.Total;
            txtIdProveedor.Text = p.IdProveedor.ToString();
            cboEstadoPedido.SelectedValue = p.IdEstadoPedido;

            txtNotas.Text = p.Notas;


        }


        public void CheckDateNullable(DateTime? d, DateTimePicker ctrl)
        {
            if (d == null || d == DateTime.MinValue) {
                ctrl.Checked = false;
                ctrl.Value = DateTime.Today;
            } else {
                ctrl.Checked = true;
                ctrl.Value = (DateTime)d;
            }
        }

        private void CargarControles()
        {
            if (DesignMode)
                return;
            CargarEstadoPedido();
        }

        private void txtIdProveedor_TextChanged(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            int v = int.TryParse(txtIdProveedor.Text.Trim(), out v) ? v : 0;

            var c = ProveedorControlador.GetByPrimaryKey(v);

            txtProveedorDescripcion.Text = c.RazonSocial;
            //txtApellido.Text = c.Apellido;
            //txtNombre.Text = c.Nombre;
            //txtDireccion.Text = c.Direccion;
            //txtTelefono.Text = c.Telefono;
            //txtNotas.Text = c.Notas;
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
            dtpHoraEntrega.Checked = false;
            dtpHoraEntrega.Value = DateTime.Now;


        }

        private void btnSeleccionarProveedor_Click(object sender, EventArgs e)
        {
            var f = new FrmSeleccionarProveedor(this);
            f.Show();
        }


        private void CargarEstadoPedido()
        {
            if (DesignMode)
                return;

            cboEstadoPedido.DropDownStyle = ComboBoxStyle.DropDownList;
            var list = EstadoPedidoControlador.GetAll();
            cboEstadoPedido.DataSource = list;
            cboEstadoPedido.ValueMember = "IdEstadoPedido";
            cboEstadoPedido.DisplayMember = "Descripcion";
        }

        private void ucPedido_Load(object sender, EventArgs e)
        {
            SetControles();
            CargarControles();
        }

        private void txtIdPedido_TextChanged(object sender, EventArgs e)
        {
            if (DesignMode)
                return;
            CargarPedido(IdPedido);
        }

        private void btnAbmProveedor_Click(object sender, EventArgs e)
        {
            var f = new FrmProveedor();
            f.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //persistir la info del pedido.

            var p = new Pedido {
                IdPedido = this.IdPedido,
                Descripcion = this.txtDescripcion.Text.Trim(),
                Fecha = dtpFecha.Value,
                IdProveedor = this.IdProveedor,
                IdEstadoPedido = (int)cboEstadoPedido.SelectedValue,
                Notas = this.txtNotas.Text.Trim(),
                Total = nudImporte.Value
            };

            //ya con el modelo listo (meter todos los datos validados)
            if (p.Validate()) {
                PedidoControlador.Update(p);
            }


        }

        public void Clear()
        {
            this.nudImporte.Value = 0;
            this.Total = 0;
            this.txtNotas.Text = "";
            //TODO: Agregar segun sea necesario.
        }

        private void btnVerPedidoDetalle_Click(object sender, EventArgs e)
        {
            var f = new FrmPedidoDetalle(this.IdPedido);
            f.Show();
        }
    }
}
