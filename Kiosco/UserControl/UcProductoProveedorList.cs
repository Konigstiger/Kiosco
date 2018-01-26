using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Controlador;
using Model;

namespace Heimdall.UserControl
{
    /// <summary>
    /// Muestra los Proveedores de un Producto, y el precio de cada uno.
    /// </summary>
    public partial class UcProductoProveedorList : System.Windows.Forms.UserControl
    {
        public UcProductoProveedorList()
        {
            InitializeComponent();
            SetControles();
        }


        private void SetControles()
        {
            txtIdProducto.Visible = false;
        }


        private const int ColCount = 7;

        private List<ProductoProveedorView> _origenDatos = null;


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

                //TODO: Ver. Tal vez conviene invocar este metodo desde afuera, o sea en el evento OnProductoChanged.
                CargarProductoProveedorList(value);
            }
        }


        private void CargarProductoProveedorList(long idProducto)
        {
            if (DesignMode)
                return;
            SetGrid(dgv);

            dgv.Columns.Clear();

            var c = new DataGridViewColumn[ColCount];

            for (var i = 0; i < ColCount; i++) {
                c[i] = new DataGridViewTextBoxColumn();
            }

            
            c[(int)ProductoProveedorView.GridColumn.IdProductoProveedor].Width = 0;
            c[(int)ProductoProveedorView.GridColumn.IdProductoProveedor].Visible = false;
            c[(int)ProductoProveedorView.GridColumn.IdProducto].Width = 0;
            c[(int)ProductoProveedorView.GridColumn.IdProducto].Visible = false;
            c[(int)ProductoProveedorView.GridColumn.IdProveedor].Width = 0;
            c[(int)ProductoProveedorView.GridColumn.IdProveedor].Visible = false;
            

            Util.SetColumn(c[(int)ProductoProveedorView.GridColumn.IdProductoProveedor], "IdProductoProveedor", "IdProductoProveedor", 0);
            Util.SetColumn(c[(int)ProductoProveedorView.GridColumn.IdProducto], "IdProducto", "IdProducto", 1);
            Util.SetColumn(c[(int)ProductoProveedorView.GridColumn.IdProveedor], "IdProveedor", "IdProveedor", 2);

            //Util.SetColumn(c[(int)ProductoProveedorView.GridColumn.Producto], "Producto", "Producto", 2);
            Util.SetColumn(c[3], "Proveedor", "Proveedor", 3);
            Util.SetColumn(c[4], "PrecioProveedor", "Precio Proveedor", 4);
            Util.SetColumn(c[5], "FechaModificacion", "Fecha de Modificacion", 5);
            Util.SetColumn(c[6], "Notas", "Notas", 6);dgv.Columns.AddRange(c);


            Util.SetColumnsReadOnly(dgv);

            _origenDatos = ProductoProveedorControlador.GetGrid_GetByIdProducto(idProducto);

            var bindingList = new MySortableBindingList<ProductoProveedorView>(_origenDatos);
            var source = new BindingSource(bindingList, null);
            dgv.DataSource = source;

            dgv.AllowUserToResizeRows = false;
            dgv.RowHeadersVisible = false;
        }


        private static void SetGrid(DataGridView dgv)
        {
            //TODO: Ver si se puede parametrizar dentro de las opciones del programa.
            dgv.AutoGenerateColumns = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv.BorderStyle = BorderStyle.None;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersHeight = 20;

            dgv.MultiSelect = false;
            dgv.AllowUserToAddRows = false;

            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure;
        }


        private void dgv_SelectionChanged(object sender, System.EventArgs e)
        {
            //al suceder esto, debe lanzar un nuevo evento, exponiendo los datos, el id.
            if (dgv.SelectedRows.Count <= 0)
                return;

            long idProductoProveedor = 0;

            foreach (DataGridViewRow item in dgv.SelectedRows) {
                idProductoProveedor = (long)item.Cells[(int)ProductoProveedorView.GridColumn.IdProductoProveedor].Value;
            }

            IdProductoProveedor = idProductoProveedor;
        }

        public decimal Precio { get; set; }

        public DateTime? Fecha { get; set; }


        [Description("IdProductoProveedor. Su evento de cambio genera DataBinding."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public long IdProductoProveedor
        {
            get {
                long v = long.TryParse(txtIdProductoProveedor.Text.Trim(), out v) ? v : 0;
                return v;
            }
            set {
                txtIdProductoProveedor.Text = value.ToString();
                OnProductoProveedorChanged(new ValueChangedEventArgs(value));

                //esto no va, creo. Copiado de IdProducto solamente
                //TODO: Ver. Tal vez conviene invocar este metodo desde afuera, o sea en el evento OnProductoChanged.
                //CargarProductoProveedorList(value);
            }
        }
        public int IdProveedor { get; set; }


        [Category("Action")]
        [Description("Es lanzado cuando se selecciona otro ProductoProveedor.")]
        public event ProductoChangedEventHandler ProductoProveedorChanged;

        protected virtual void OnProductoProveedorChanged(ValueChangedEventArgs e)
        {
            ProductoProveedorChanged?.Invoke(this, e);
        }



    }
}