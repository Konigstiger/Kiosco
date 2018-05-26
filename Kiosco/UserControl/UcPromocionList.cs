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
    public partial class UcPromocionList : System.Windows.Forms.UserControl
    {
        public UcPromocionList()
        {
            InitializeComponent();
            SetControles();
        }


        private void SetControles()
        {
            txtIdProducto.Visible = false;
            txtIdPromocion.Visible = false;
        }


        private const int ColCount = 6;

        private List<PromocionView> _origenDatos = null;

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
                CargarPromocionList(value);
            }
        }


        [Description("IdPromocion. Su evento de cambio genera DataBinding."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public long IdPromocion
        {
            get {
                long v = long.TryParse(txtIdPromocion.Text.Trim(), out v) ? v : 0;
                return v;
            }
            set {
                txtIdPromocion.Text = value.ToString();
                OnPromocionChanged(new ValueChangedEventArgs(value));

                //esto no va, creo. Copiado de IdProducto solamente
                //TODO: Ver. Tal vez conviene invocar este metodo desde afuera, o sea en el evento OnProductoChanged.
                //CargarPromocionList(value);
            }
        }


        public void CargarPromocionList(long idProducto)
        {
            if (DesignMode)
                return;
            Util.SetGrid(dgv, DataGridViewAutoSizeColumnsMode.AllCells);

            dgv.Columns.Clear();

            var c = new DataGridViewColumn[ColCount];

            for (var i = 0; i < ColCount; i++) {
                c[i] = new DataGridViewTextBoxColumn();
            }
            
            c[(int)PromocionView.GridColumn.IdPromocion].Width = 0;
            c[(int)PromocionView.GridColumn.IdPromocion].Visible = false;


            Util.SetColumn(c[(int)PromocionView.GridColumn.IdPromocion], "IdPromocion", "IdPromocion", 0);
            Util.SetColumn(c[(int)PromocionView.GridColumn.Descripcion], "Descripcion", "Descripcion", 1);
            Util.SetColumn(c[(int)PromocionView.GridColumn.Importe], "Importe", "Importe", 2);

            Util.SetColumn(c[3], "FechaInicio", "Inicio", 3);
            Util.SetColumn(c[4], "FechaFin", "Fin", 4);
            Util.SetColumn(c[5], "Notas", "Notas", 5);

            dgv.Columns.AddRange(c);


            Util.SetColumnsReadOnly(dgv);

            _origenDatos = PromocionControlador.GetGrid_GetByIdProducto(idProducto);

            var bindingList = new MySortableBindingList<PromocionView>(_origenDatos);
            var source = new BindingSource(bindingList, null);
            dgv.DataSource = source;

            dgv.AllowUserToResizeRows = false;
            dgv.RowHeadersVisible = false;
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            //al suceder esto, debe lanzar un nuevo evento, exponiendo los datos, el id.
            if (dgv.SelectedRows.Count <= 0)
                return;

            long idPromocion = 0;

            foreach (DataGridViewRow item in dgv.SelectedRows) {
                idPromocion = (int)item.Cells[(int)PromocionView.GridColumn.IdPromocion].Value;
            }

            IdPromocion = idPromocion;
        }
        
        [Category("Action")]
        [Description("Es lanzado cuando se selecciona otra Promocion.")]
        public event PromocionChangedEventHandler PromocionChanged;

        protected virtual void OnPromocionChanged(ValueChangedEventArgs e)
        {
            PromocionChanged?.Invoke(this, e);
        }
    }
}
