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
using Model.View;

namespace Heimdall.UserControl
{
    public partial class UcProductoPromocionList : System.Windows.Forms.UserControl
    {
        public UcProductoPromocionList()
        {
            InitializeComponent();
            SetControles();
        }

        private void SetControles()
        {
            txtIdProducto.Visible = false;
            txtIdPromocion.Visible = false;
            txtIdProductoPromocion.Visible = false;
        }


        private const int ColCount = 6;

        private List<ProductoPromocionView> _origenDatos = null;

        [Category("Action")]
        [Description("Es lanzado cuando se selecciona otro producto.")]
        public event ProductoChangedEventHandler ProductoChanged;

        protected virtual void OnProductoChanged(ValueChangedEventArgs e)
        {
            ProductoChanged?.Invoke(this, e);
        }

        [Description("IdProducto. Su evento de cambio genera DataBinding."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public long IdProducto
        {
            get {
                long v = long.TryParse(txtIdProducto.Text.Trim(), out v) ? v : 0;
                return v;
            }
            set {
                txtIdProducto.Text = value.ToString();
                OnProductoChanged(new ValueChangedEventArgs(value));
            }
        }

        [Description("IdPromocion. Su evento de cambio genera DataBinding."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public int IdPromocion
        {
            get {
                int v = int.TryParse(txtIdPromocion.Text.Trim(), out v) ? v : 0;
                return v;
            }
            set {
                txtIdPromocion.Text = value.ToString();
                OnProductoPromocionChanged(new ValueChangedEventArgs(value));

                CargarProductoPromocionList(value);
            }
        }


        [Description("IdProductoPromocion. Su evento de cambio genera DataBinding."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public int IdProductoPromocion
        {
            get {
                int v = int.TryParse(txtIdProductoPromocion.Text.Trim(), out v) ? v : 0;
                return v;
            }
            set {
                txtIdPromocion.Text = value.ToString();
                OnProductoPromocionChanged(new ValueChangedEventArgs(value));
            }
        }


        public void CargarProductoPromocionList(int idPromocion)
        {
            if (DesignMode)
                return;
            Util.SetGrid(dgv, DataGridViewAutoSizeColumnsMode.AllCells);

            dgv.Columns.Clear();

            var c = new DataGridViewColumn[ColCount];

            for (var i = 0; i < ColCount; i++) {
                c[i] = new DataGridViewTextBoxColumn();
            }

            c[(int)ProductoPromocionView.GridColumn.IdProductoPromocion].Width = 0;
            c[(int)ProductoPromocionView.GridColumn.IdProductoPromocion].Visible = false;

            c[(int)ProductoPromocionView.GridColumn.IdProducto].Width = 0;
            c[(int)ProductoPromocionView.GridColumn.IdProducto].Visible = false;

            /*
            ProductoPromocion.IdProductoPromocion
            ,ProductoPromocion.IdProducto
            ,ProductoPromocion.Cantidad
            ,Producto.Descripcion
            ,ProductoPromocion.PrecioPromocion
            --,ProductoPromocion.PorcentajeDescuento
            ,ProductoPromocion.Notas
             */
            Util.SetColumn(c[(int)ProductoPromocionView.GridColumn.IdProductoPromocion], "IdProductoPromocion", "IdProductoPromocion", 0);
            Util.SetColumn(c[(int)ProductoPromocionView.GridColumn.IdProducto], "IdProducto", "IdProducto", 1);
            Util.SetColumn(c[(int)ProductoPromocionView.GridColumn.Cantidad], "Cantidad", "Cantidad", 2);
            Util.SetColumn(c[(int)ProductoPromocionView.GridColumn.Descripcion], "Descripcion", "Descripcion", 3);
            Util.SetColumn(c[(int)ProductoPromocionView.GridColumn.PrecioPromocion], "PrecioPromocion", "PrecioPromocion", 4);
            Util.SetColumn(c[(int)ProductoPromocionView.GridColumn.Notas], "Notas", "Notas", 5);

            dgv.Columns.AddRange(c);


            Util.SetColumnsReadOnly(dgv);

            _origenDatos = ProductoPromocionControlador.GetGrid_GetByIdPromocion(idPromocion);

            var bindingList = new MySortableBindingList<ProductoPromocionView>(_origenDatos);
            var source = new BindingSource(bindingList, null);
            dgv.DataSource = source;

            dgv.AllowUserToResizeRows = false;
            dgv.RowHeadersVisible = false;
        }








        [Category("Action")]
        [Description("Es lanzado cuando se selecciona otro ProductoPromocion.")]
        public event ProductoPromocionChangedEventHandler ProductoPromocionChanged;

        protected virtual void OnProductoPromocionChanged(ValueChangedEventArgs e)
        {
            ProductoPromocionChanged?.Invoke(this, e);
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            //al suceder esto, debe lanzar un nuevo evento, exponiendo los datos, el id.
            if (dgv.SelectedRows.Count <= 0)
                return;

            var idProductoPromocion = 0;

            foreach (DataGridViewRow item in dgv.SelectedRows) {
                idProductoPromocion = (int)item.Cells[(int)ProductoPromocionView.GridColumn.IdProductoPromocion].Value;
            }

            IdProductoPromocion = idProductoPromocion;
        }
    }
}
