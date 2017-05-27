using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using Controlador;
using Model;

namespace Kiosco
{
    public partial class FrmPedido : Form, ISelectorProducto
    {
        private ModoFormulario _modo = ModoFormulario.Nuevo;

        private int _rowIndex = 0;
        private const int colCount = 6;

        private List<PedidoDetalleView> origenDatos = null;


        private const int ColCount = 6;


        public FrmPedido()
        {
            InitializeComponent();
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            SetControles();
            CargarControles();
            LimpiarControles();
            _modo = ModoFormulario.Edicion;
        }


        public void SetControles()
        {
            SetGrid(dgv);
            ucPedido1.IdPedido = 1;
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

        public void CargarControles()
        {
            CargarGrilla(tsbSearchTextBox.Text);
        }


        public void CargarGrilla(string searchText)
        {
            dgv.Columns.Clear();

            var c = new DataGridViewColumn[colCount];

            for (var i = 0; i < colCount; i++) {
                c[i] = new DataGridViewTextBoxColumn();
            }


            c[(int)PedidoDetalleView.GridColumn.IdPedidoDetalle].Width = 0;
            c[(int)PedidoDetalleView.GridColumn.IdPedidoDetalle].Visible = false; //true;

            Util.SetColumn(c[(int)PedidoDetalleView.GridColumn.IdPedidoDetalle], "IdPedidoDetalle", "IdPedidoDetalle", 0);
            Util.SetColumn(c[(int)PedidoDetalleView.GridColumn.Cantidad], "Cantidad", "Cantidad", 1);
            Util.SetColumn(c[(int)PedidoDetalleView.GridColumn.Unidad], "Unidad", "Unidad", 2);
            Util.SetColumn(c[(int)PedidoDetalleView.GridColumn.Producto], "Producto", "Producto", 3);
            Util.SetColumn(c[(int)PedidoDetalleView.GridColumn.Importe], "Importe", "Importe", 4);
            Util.SetColumn(c[(int)PedidoDetalleView.GridColumn.Notas], "Notas", "Notas", 5);
            dgv.Columns.AddRange(c);

            Util.SetColumnsReadOnly(dgv);

            //TODO: Corregir esto.
            origenDatos = searchText.Equals("") ?
                PedidoDetalleControlador.GetByIdPedido(ucPedido1.IdProveedor) :
                PedidoDetalleControlador.GetByIdPedido(ucPedido1.IdProveedor);


            var bindingList = new BindingList<PedidoDetalleView>(origenDatos);
            var source = new BindingSource(bindingList, null);
            dgv.DataSource = source;

            dgv.AllowUserToResizeRows = false;
            dgv.RowHeadersVisible = false;
        }



        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            //if (_modo == ModoFormulario.Nuevo) return;

            if (dgv.SelectedRows.Count <= 0)
                return;

            // esto funciona, pero con el numero de celda, no con ID.
            var id = Convert.ToInt64(dgv.SelectedRows[0].Cells[(int)PedidoDetalleView.GridColumn.IdPedidoDetalle].Value.ToString());

            _rowIndex = dgv.SelectedRows[0].Index;

            ucPedidoDetalle1.IdPedidoDetalle = id;
        }


        private void tsbSearchPerform_Click(object sender, EventArgs e)
        {
            ExecuteSearch();
        }


        private void tsbSearch_Click(object sender, EventArgs e)
        {
            ToggleSearch();
        }


        private void ToggleSearch()
        {
            tsbSearchTextBox.Visible = !tsbSearchTextBox.Visible;
            tsbSearchPerform.Visible = !tsbSearchPerform.Visible;
            tsbSearchClearAndPerform.Visible = !tsbSearchClearAndPerform.Visible;
            tsbSearchTextBox.Focus();
        }

        public void ExecuteSearch()
        {
            CargarGrilla(tsbSearchTextBox.Text);
        }

        private void frmPedido_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode) {
                case Keys.F3:
                    tsbSearch.Checked = !tsbSearch.Checked;
                    ToggleSearch();
                    break;
                case (Keys.Enter):
                    ExecuteSearch();
                    break;

            }
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            GuardarOInsertar();
        }


        public void GuardarOInsertar()
        {
            // Guardar lo que debe guardar es simple, todos los datos del IdProductoDetale elegido.
            var pdv = new PedidoDetalleView
            {
                IdPedido = ucPedido1.IdPedido,
                IdPedidoDetalle = ucPedidoDetalle1.IdPedidoDetalle,
                Cantidad = ucPedidoDetalle1.Cantidad,
                IdProducto = ucPedidoDetalle1.IdProducto,
                IdUnidad = ucPedidoDetalle1.IdUnidad,
                Importe = ucPedidoDetalle1.Importe,
                Notas = ""
            };

            if (pdv.Validate().Equals(false))
                throw new Exception("Errores en validacion!");


            var pd = new PedidoDetalle();
            pd.Cantidad = pdv.Cantidad;
            pd.IdPedidoDetalle = pdv.IdPedidoDetalle;
            pd.IdProducto = pdv.IdProducto;
            pd.IdPedido = pdv.IdPedido;
            pd.IdUnidad = pdv.IdUnidad;
            pd.Importe = pdv.Importe;
            pd.Notas = pdv.Notas;

            // ya se tiene el objeto PedidoDetalle listo para persistir.
            if (_modo == ModoFormulario.Edicion) {
                pdv.IdPedidoDetalle = PedidoDetalleControlador.Update(pd);
            }
            else {
                pdv.IdPedidoDetalle = PedidoDetalleControlador.Insert(pd);

                // modificar el datasource.
                origenDatos.Add(pdv);

                var bindingList = new BindingList<PedidoDetalleView>(origenDatos);
                var source = new BindingSource(bindingList, null);
                dgv.DataSource = source;

                //Calcular _rowIndex
                _rowIndex = dgv.Rows.Count - 1;
            }
            
            dgv.Rows[_rowIndex].Cells[(int)PedidoDetalleView.GridColumn.Cantidad].Value = pdv.Cantidad;
            dgv.Rows[_rowIndex].Cells[(int)PedidoDetalleView.GridColumn.Unidad].Value = ucPedidoDetalle1.Unidad;
            dgv.Rows[_rowIndex].Cells[(int)PedidoDetalleView.GridColumn.Producto].Value = ucPedidoDetalle1.Descripcion;
            dgv.Rows[_rowIndex].Cells[(int)PedidoDetalleView.GridColumn.Importe].Value = pdv.Importe;

            // pasar o mantener _modo Edicion
            _modo = ModoFormulario.Edicion;

            ////TODO: Ver esto, antes sin esto editaba ok. Tengo duda con el agregar uno nuevo.
            dgv.Rows[_rowIndex].Selected = true;
        }


        public void Eliminar()
        {
            //if (!Util.ConfirmarEliminar())
            //    return;

            ////crear objeto cascara
            //var m = new Pedido { IdPedido = Convert.ToInt32(txtIdPedido.Text.Trim()) };

            //var result = PedidoControlador.Delete(m);

            //// Remover visualmente el registro del producto.
            //dgv.Rows.Remove(dgv.Rows[_rowIndex]);

            //LimpiarControles();
        }


        private void tsbNew_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            _modo = ModoFormulario.Nuevo;

            //Con este IdProveedor, deberia filtrar por el mismo.
            var f = new FrmSeleccionarProductoProveedor(ucPedidoDetalle1, ucPedido1.IdProveedor);
            f.Show();
        }


        public void LimpiarControles()
        {
            //txtDescripcion.Clear();
            //txtNotas.Clear();
        }


        private void tsbSearchClearAndPerform_Click(object sender, EventArgs e)
        {
            tsbSearchTextBox.Clear();
            tsbSearchTextBox.Focus();
            ExecuteSearch();
        }


        private void tsbDelete_Click(object sender, EventArgs e)
        {
            Eliminar();
        }



        private void ucPedido1_ProveedorChanged(object sender, UserControl.ValueChangedEventArgs e)
        {
            //if (!Util.ConfirmarLimpiarPedido())
            //    return;

            // tiene que cargar la grilla, con el IdProveedor nuevo.
            //var IdProveedor = ucPedido1.IdProveedor;

            //var list = PedidoDetalleControlador.GetByIdPedido(IdProveedor);

            CargarGrilla(tsbSearchTextBox.Text);

        }


        public long IdProducto
        {
            get { return ucPedidoDetalle1.IdProducto; }
            set { ucPedidoDetalle1.IdProducto = value; }
        }
    }
}