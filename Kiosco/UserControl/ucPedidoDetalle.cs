using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace Kiosco
{
    public partial class ucPedidoDetalle : System.Windows.Forms.UserControl, IPedidoDetalle, ISelectorProducto
    {
        public ucPedidoDetalle()
        {
            InitializeComponent();
        }

        private void ucPedidoDetalle_Load(object sender, EventArgs e)
        {
            SetControles();
            CargarControles();
        }

        public void SetControles()
        {
            txtIdProducto.Visible = false;

        }

        private void CargarControles()
        {
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


        [Description("Cantidad de Producto."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public int Cantidad
        {
            get {return (int)nudCantidad.Value;}
            set {nudCantidad.Value = value;}
        }


        [Description("Codigo de Barras del Producto."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string CodigoBarras
        {
            get {return txtCodigoBarras.Text.Trim();}
            set {txtCodigoBarras.Text = value;}
        }


        [Description("Descripcion del Producto."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string Descripcion
        {
            get { return txtDescripcion.Text.Trim(); }
            set { txtDescripcion.Text = value; }
        }


        [Description("Precio del Producto."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public decimal Precio
        {
            get { return nudPrecioCosto.Value; }
            set { nudPrecioCosto.Value = value; }
        }


        [Description("Importe del Producto."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public decimal Importe
        {
            get { return nudImporte.Value; }
            set { nudImporte.Value = value; }
        }

        private void txtCodigoBarras_TextChanged(object sender, EventArgs e)
        {
            var codigo = txtCodigoBarras.Text.Trim();
            var p = ProductoControlador.GetByCodigoBarrasView(codigo);

            txtDescripcion.Text = p.Descripcion;
            nudPrecioCosto.Value = p.PrecioCosto;
            
            txtStock.Text = p.Stock.ToString();
        }


        private void txtIdProducto_TextChanged(object sender, EventArgs e)
        {
            int v = int.TryParse(txtIdProducto.Text.Trim(), out v) ? v : 0;
            var id = v;

            var p = ProductoControlador.GetByPrimaryKey(id);

            txtCodigoBarras.Text = p.CodigoBarras; // esto desencadena evento.

        }


        public long IdProducto
        {
            get
            {
                long v = long.TryParse(txtIdProducto.Text.Trim(), out v) ? v : 0;
                return v;
            }
            set { txtIdProducto.Text = value.ToString(); }
        }

        [Description("IdPedidoDetalle. Su evento de cambio genera DataBinding."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public long IdPedidoDetalle
        {
            //TODO: VER
            get {
                long v = long.TryParse(txtIdPedidoDetalle.Text.Trim(), out v) ? v : 0;
                return v;
            }
            set { txtIdPedidoDetalle.Text = value.ToString(); }
        }

        private void txtIdPedidoDetalle_TextChanged(object sender, EventArgs e)
        {
            //TODO: VER
            long v = long.TryParse(txtIdPedidoDetalle.Text.Trim(), out v) ? v : 0;
            var id = v;

            var p = PedidoDetalleControlador.GetByPrimaryKey(id);

            txtIdProducto.Text = p.IdProducto.ToString();
            nudCantidad.Value = p.Cantidad;
            nudImporte.Value = p.Importe;

        }
    }
}
