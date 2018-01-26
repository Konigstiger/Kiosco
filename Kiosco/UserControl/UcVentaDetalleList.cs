using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Controlador;
using Model;

namespace Heimdall.UserControl
{
    public partial class UcVentaDetalleList : System.Windows.Forms.UserControl
    {
        public UcVentaDetalleList()
        {
            InitializeComponent();
        }

        private void SetControles()
        {
            txtIdVenta.Visible = false;
        }


        private const int colCount = 6;

        private List<VentaDetalleView> origenDatos = null;

        [Category("Action")]
        [Description("Es lanzado cuando se selecciona otra venta.")]
        public event ValueChangedEventHandler VentaChanged;

        protected virtual void OnVentaChanged(ValueChangedEventArgs e)
        {
            VentaChanged?.Invoke(this, e);
        }



        [Description("IdVenta. Su evento de cambio genera DataBinding."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public long IdVenta
        {
            get {
                long v = long.TryParse(txtIdVenta.Text.Trim(), out v) ? v : 0;
                return v;
            }
            set {
                txtIdVenta.Text = value.ToString();
                OnVentaChanged(new ValueChangedEventArgs(value));

                //TODO: Ver. Tal vez conviene invocar este metodo desde afuera, o sea en el evento OnProductoChanged.
                CargarVentaDetalle(value);
            }
        }


        private void CargarVentaDetalle(long idVenta)
        {
            if (DesignMode)
                return;
            SetGrid(dgv);

            dgv.Columns.Clear();

            var c = new DataGridViewColumn[colCount];

            for (var i = 0; i < colCount; i++) {
                c[i] = new DataGridViewTextBoxColumn();
            }

            c[(int)VentaDetalleView.GridColumn.IdVentaDetalle].Width = 0;
            c[(int)VentaDetalleView.GridColumn.IdVentaDetalle].Visible = false;

            Util.SetColumn(c[(int)VentaDetalleView.GridColumn.IdVentaDetalle], "IdVentaDetalle", "IdVentaDetalle", 0);
            Util.SetColumn(c[(int)VentaDetalleView.GridColumn.Cantidad], "Cantidad", "Cantidad", 1);
            Util.SetColumn(c[(int)VentaDetalleView.GridColumn.Producto], "Producto", "Producto", 2);
            Util.SetColumn(c[(int)VentaDetalleView.GridColumn.PrecioUnitario], "PrecioUnitario", "Precio Unitario", 3);
            Util.SetColumn(c[(int)VentaDetalleView.GridColumn.Importe], "Importe", "Importe", 4);
            Util.SetColumn(c[(int)VentaDetalleView.GridColumn.Ganancia], "Ganancia", "Ganancia", 5);
            dgv.Columns.AddRange(c);

            Util.SetColumnsReadOnly(dgv);

            origenDatos = VentaDetalleControlador.GetAll_ByIdVenta(idVenta);

            var bindingList = new MySortableBindingList<VentaDetalleView>(origenDatos);
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

        private void UcVentaDetalleList_Load(object sender, EventArgs e)
        {
            SetControles();
        }
    }
}
