using System;
using System.ComponentModel;
using System.Windows.Forms;
using Controlador;
using Heimdall.UserControl;

namespace Kiosco.UserControl
{
    public partial class UcProveedorEdit : System.Windows.Forms.UserControl
    {
        public UcProveedorEdit()
        {
            InitializeComponent();
        }


        [Category("Action")]
        [Description("Es lanzado cuando el Proveedor es cambiado")]
        public event ValueChangedEventHandler ProveedorChanged;

        protected virtual void OnProveedorChanged(ValueChangedEventArgs e)
        {
            ProveedorChanged?.Invoke(this, e);
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


        [Description("Razon Social."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string RazonSocial
        {
            get { return txtRazonSocial.Text.Trim(); }
            set { txtRazonSocial.Text = value; }
        }


        [Description("Direccion."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string Direccion
        {
            get { return txtDireccion.Text.Trim(); }
            set { txtDireccion.Text = value; }
        }


        [Description("Email."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string Email
        {
            get { return txtEmail.Text.Trim(); }
            set { txtEmail.Text = value; }
        }


        [Description("HorarioAtencion."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string HorarioAtencion
        {
            get { return txtHorarioAtencion.Text.Trim(); }
            set { txtHorarioAtencion.Text = value; }
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



        [Description("Telefono."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string Telefono
        {
            get { return txtTelefono.Text.Trim(); }
            set { txtTelefono.Text = value; }
        }


        [Description("Persona de Contacto."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string PersonaContacto
        {
            get { return txtPersonaContacto.Text.Trim(); }
            set { txtPersonaContacto.Text = value; }
        }



        [Description("Dias de Visita."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string DiasDeVisita
        {
            get { return txtDiasDeVisita.Text.Trim(); }
            set { txtDiasDeVisita.Text = value; }
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


        private void txtIdProveedor_TextChanged(object sender, EventArgs e)
        {
            if (DesignMode) return;

            int v;
            var id = int.TryParse(txtIdProveedor.Text.Trim(), out v) ? v : 0;

            var c = ProveedorControlador.GetByPrimaryKey(id);

            txtRazonSocial.Text = c.RazonSocial;
            txtDireccion.Text = c.Direccion;
            txtTelefono.Text = c.Telefono;
            txtEmail.Text = c.Email;
            txtPersonaContacto.Text = c.PersonaContacto;
            txtHorarioAtencion.Text = c.HorarioAtencion;
            txtDiasDeVisita.Text = c.DiasDeVisita;
            txtNotas.Text = c.Notas;

            cboRubro.SelectedValue = c.IdRubro;


        }

        private void UcProveedorEdit_Load(object sender, EventArgs e)
        {
            SetControles();
            CargarControles();
            LimpiarControles();
        }

        private void CargarControles()
        {
            CargarRubro();
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
            txtIdProveedor.Visible = false;
            txtDireccion.MaxLength = 255;
            txtEmail.MaxLength = 50;
            txtPersonaContacto.MaxLength = 50;
            txtRazonSocial.MaxLength = 100;
            txtTelefono.MaxLength = 25;
            txtHorarioAtencion.MaxLength = 100;
            txtDiasDeVisita.MaxLength = 100;
            txtNotas.MaxLength = 255;

        }

        public void LimpiarControles()
        {
            txtIdProveedor.Clear();
            txtRazonSocial.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtRazonSocial.Clear();
            txtHorarioAtencion.Clear();
            txtPersonaContacto.Clear();
            txtDiasDeVisita.Clear();
            txtNotas.Clear();
        }

        public void Clear()
        {
            LimpiarControles();
        }
    }
}
