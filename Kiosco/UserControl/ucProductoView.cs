using System;
using System.ComponentModel;

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
            get { return Convert.ToInt64(txtIdProducto.Text); }
            set
            {
                txtIdProducto.Text = value.ToString();
                OnProductoChanged(new ValueChangedEventArgs(value));
            }
        }




        [Description("Descripcion de Producto."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string Descripcion => txtDescripcion.Text.Trim();


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


        [Category("Action")]
        [Description("Es lanzado cuando se selecciona otro producto.")]
        public event ProductoChangedEventHandler ProductoChanged;

        protected virtual void OnProductoChanged(ValueChangedEventArgs e)
        {
            ProductoChanged?.Invoke(this, e);
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
            txtIdProducto.Visible = false;
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
