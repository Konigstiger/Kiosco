using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

    }
}
