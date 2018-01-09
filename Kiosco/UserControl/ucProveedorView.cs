using System;
using System.ComponentModel;
using Controlador;
using Kiosco;

namespace Heimdall.UserControl
{
    public partial class UcProveedorView : System.Windows.Forms.UserControl, ISelectorProveedor
    {
        [Category("Action")]
        [Description("Es lanzado cuando el valor es cambiado")]
        public event ValueChangedEventHandler ValueChanged;

        protected virtual void OnValueChanged(ValueChangedEventArgs e)
        {
            ValueChanged?.Invoke(this, e);
        }


        public UcProveedorView()
        {
            InitializeComponent();
            SetControles();
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
                OnValueChanged(new ValueChangedEventArgs(value));
            }
        }

        [Description("Descripcion o Razon Social de Proveedor."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string Proveedor => txtRazonSocial.Text.Trim();


        private void txtIdProveedor_TextChanged(object sender, EventArgs e)
        {
            int v = int.TryParse(txtIdProveedor.Text.Trim(), out v) ? v : 0;
            var c = ProveedorControlador.GetByPrimaryKey(v);

            txtRazonSocial.Text = c.RazonSocial;
            //txtApellido.Text = c.Apellido;
            //txtNombre.Text = c.Nombre;
            //txtDireccion.Text = c.Direccion;
            //txtTelefono.Text = c.Telefono;
            //txtNotas.Text = c.Notas;
            //OnValueChanged(new ValueChangedEventArgs(c.IdProveedor));

        }


        public void SetControles()
        {

            txtRazonSocial.Enabled = false;
            txtIdProveedor.Visible = false;
        }

        private void btnSeleccionarProveedor_Click(object sender, EventArgs e)
        {
            var f = new FrmSeleccionarProveedor(this);
            f.Show();

        }

        private void btnAbmProveedor_Click(object sender, EventArgs e)
        {
            var f = new FrmProveedor();
            f.Show();
        }



    }


}
