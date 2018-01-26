using System;
using System.ComponentModel;
using System.Windows.Forms;
using Controlador;
using Model;

namespace Heimdall.UserControl
{
    public partial class UcUsuarioEdit : System.Windows.Forms.UserControl
    {
        public UcUsuarioEdit()
        {
            InitializeComponent();
        }


        [Category("Action")]
        [Description("Es lanzado cuando el Usuario es cambiado")]
        public event ValueChangedEventHandler UsuarioChanged;

        protected virtual void OnUsuarioChanged(ValueChangedEventArgs e)
        {
            UsuarioChanged?.Invoke(this, e);
        }


        [Description("IdUsuario. Su evento de cambio genera DataBinding."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public int IdUsuario
        {
            get {
                int v = int.TryParse(txtIdUsuario.Text.Trim(), out v) ? v : 0;
                return v;
            }
            set {
                txtIdUsuario.Text = value.ToString();
                OnUsuarioChanged(new ValueChangedEventArgs(value));
            }
        }


        [Description("Descripcion de Usuario."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string Descripcion
        {
            get { return txtDescripcion.Text.Trim(); }
            set { txtDescripcion.Text = value; }
        }


        [Description("Usr."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string Usr
        {
            get { return txtUsr.Text.Trim(); }
            set { txtUsr.Text = value; }
        }


        [Description("Password."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string Pwd
        {
            get { return txtPwd.Text.Trim(); }
            set { txtPwd.Text = value; }
        }


        [Description("Email."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string Email
        {
            get { return txtUsr.Text.Trim(); }
            set { txtUsr.Text = value; }
        }



        [Description("Id de Clase de Usuario."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public int IdClaseUsuario
        {
            get {
                int v = int.TryParse(cboClaseUsuario.SelectedValue?.ToString(), out v) ? v : 0;
                return v;
            }
            set { cboClaseUsuario.SelectedValue = value; }
        }



        [Description("Id de Estado de Usuario."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public int IdEstadoUsuario
        {
            get {
                int v = int.TryParse(cboEstadoUsuario.SelectedValue?.ToString(), out v) ? v : 0;
                return v;
            }
            set { cboEstadoUsuario.SelectedValue = value; }
        }


        [Description("ClaseUsuario."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string ClaseUsuario => cboClaseUsuario.Text.Trim();

        [Description("EstadoUsuario."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string EstadoUsuario => cboEstadoUsuario.Text.Trim();


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


        private void txtIdUsuario_TextChanged(object sender, EventArgs e)
        {
            if (DesignMode) return;

            int v;
            var id = int.TryParse(txtIdUsuario.Text.Trim(), out v) ? v : 0;
            var u = new Usuario();
            u.IdUsuario = id;

            var c = UsuarioControlador.GetByPrimaryKey(u);

            txtDescripcion.Text = c.Descripcion;
            txtUsr.Text = c.Usr;
            txtPwd.Text = c.Pwd;
            txtApellido.Text = c.Apellido;
            txtTelefono.Text = c.Telefono;
            txtNotas.Text = c.Notas;

            cboClaseUsuario.SelectedValue = c.IdClaseUsuario;
            cboEstadoUsuario.SelectedValue = c.IdEstadoUsuario;


        }

        private void UcUsuarioEdit_Load(object sender, EventArgs e)
        {
            SetControles();
            CargarControles();
            LimpiarControles();
        }

        private void CargarControles()
        {
            CargarRubro();
            CargarEstadoUsuario();
        }

        private void CargarRubro()
        {
            if (DesignMode)
                return;

            cboClaseUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            var list = RubroControlador.GetAll();
            cboClaseUsuario.DataSource = list;
            cboClaseUsuario.ValueMember = "IdRubro";
            cboClaseUsuario.DisplayMember = "Descripcion";
        }


        private void CargarEstadoUsuario()
        {
            if (DesignMode)
                return;

            cboEstadoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            var list = EstadoUsuarioControlador.GetAll();
            cboEstadoUsuario.DataSource = list;
            cboEstadoUsuario.ValueMember = "IdEstadoUsuario";
            cboEstadoUsuario.DisplayMember = "Descripcion";
        }



        private void SetControles()
        {
            //txtIdUsuario.Visible = false;
            txtUsr.MaxLength = 20;
            txtApellido.MaxLength = 50;
            txtDescripcion.MaxLength = 50;
            txtTelefono.MaxLength = 25;
            txtPwd.MaxLength = 20;
            txtNotas.MaxLength = 255;

        }

        public void LimpiarControles()
        {
            //txtIdUsuario.Clear();
            txtDescripcion.Clear();
            txtTelefono.Clear();
            txtDescripcion.Clear();
            txtPwd.Clear();
            txtApellido.Clear();
            txtNotas.Clear();
        }

        public void Clear()
        {
            LimpiarControles();
        }
    }
}
