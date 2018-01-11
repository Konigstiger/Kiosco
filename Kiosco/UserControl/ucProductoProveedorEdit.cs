using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using Kiosco;
using Model;

namespace Heimdall.UserControl
{
    public partial class UcProductoProveedorEdit : System.Windows.Forms.UserControl
    {
        public UcProductoProveedorEdit()
        {
            InitializeComponent();
        }

        [Description("IdProveedor."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public int IdProveedor
        {
            get { return ucProveedorView1.IdProveedor; }
            set { ucProveedorView1.IdProveedor = value; }
        }


        [Description("IdProducto."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public long IdProducto
        {
            get { return Convert.ToInt64(txtIdProducto.Text.Trim()); }
            set { txtIdProducto.Text = value.ToString(); }
        }


        [Description("IdProductoProveedor."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public long IdProductoProveedor
        {
            get { return Convert.ToInt64(txtIdProductoProveedor.Text.Trim()); }
            set { txtIdProductoProveedor.Text = value.ToString(); }
        }


        [Description("Precio."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public decimal Precio
        {
            get { return nudPrecioCompra.Value; }
            set { nudPrecioCompra.Value = value; }
        }


        [Description("Fecha."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public DateTime Fecha
        {
            get { return dtpFechaModificacion.Value; }
            set { dtpFechaModificacion.Value = value; }
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

        public ModoFormulario Modo { get; set; } = ModoFormulario.Nuevo;

        private void txtIdProductoProveedor_TextChanged(object sender, EventArgs e)
        {
            if (DesignMode)
                return;
            var id = Convert.ToInt64(txtIdProductoProveedor.Text.Trim());
            var c = ProductoProveedorControlador.GetByPrimaryKey(id);

            ucProveedorView1.IdProveedor = c.IdProveedor;
            IdProducto = c.IdProducto;
            nudPrecioCompra.Value = c.PrecioProveedor;
            Util.CheckDateNullable(c.FechaModificacion, dtpFechaModificacion);
            txtNotas.Text = c.Notas;

        }

        private void nudPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('.') || e.KeyChar.Equals(',')) {
                e.KeyChar = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
            }
        }

        private void btnSetPrecioCosto_Click(object sender, EventArgs e)
        {
            //Producto p = new Producto();
            //p.IdProducto = ucProductoView1.IdProducto;
            //p = ProductoControlador.GetByPrimaryKey(p.IdProducto);
            //p.PrecioCostoPromedio = PCP;
            //ProductoControlador.Update(p);
            //ucProductoView1.PrecioCosto = p.PrecioCostoPromedio;
            //dgv.Focus();
        }
    }
}
