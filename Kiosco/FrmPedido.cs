using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;

using System.Windows.Forms;
using Controlador;
using Model;

namespace Kiosco
{
    public partial class FrmPedido : Form, IAbmGeneral
    {
        private ModoFormulario _modo = ModoFormulario.Nuevo;

        private int _rowIndex = 0;
        private const int colCount = 6;

        private List<PedidoView> origenDatos = null;


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


            c[(int)PedidoView.GridColumn.IdPedido].Width = 0;
            c[(int)PedidoView.GridColumn.IdPedido].Visible = false;
            Util.SetColumn(c[(int)PedidoView.GridColumn.IdPedido], "IdPedido", "IdPedido", 0);
            Util.SetColumn(c[(int)PedidoView.GridColumn.Proveedor], "Proveedor", "Proveedor", 1);
            Util.SetColumn(c[(int)PedidoView.GridColumn.Descripcion], "Descripcion", "Descripcion", 2);
            Util.SetColumn(c[(int)PedidoView.GridColumn.Fecha], "Fecha", "Fecha", 3);
            Util.SetColumn(c[(int)PedidoView.GridColumn.Estado], "Estado", "Estado", 4);
            Util.SetColumn(c[(int)PedidoView.GridColumn.Total], "Total", "Total", 5);
            dgv.Columns.AddRange(c);

            Util.SetColumnsReadOnly(dgv);

            origenDatos = searchText.Equals("") ?
                PedidoControlador.GetAll_GetByParameters("") :
                PedidoControlador.GetAll_GetByParameters(searchText);

            var bindingList = new MySortableBindingList<PedidoView>(origenDatos);
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
            var id = Convert.ToInt64(dgv.SelectedRows[0].Cells[(int)PedidoView.GridColumn.IdPedido].Value.ToString());

            _rowIndex = dgv.SelectedRows[0].Index;

            ucPedido1.IdPedido = id;
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
                    if (!_ingresandoCodigo)
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
            const int idUsuarioActual = Usuario.IdUsuarioPredeterminado;

            var m = new Pedido {
                IdPedido = -1,
                IdProveedor = ucPedido1.IdProveedor,
                Descripcion = ucPedido1.Descripcion,
                Total = ucPedido1.Total,
                Fecha = ucPedido1.Fecha,
                IdEstadoPedido = ucPedido1.IdEstadoPedido,
                Notas = ucPedido1.Notas
            };

            //=====================================================================
            if (_modo == ModoFormulario.Nuevo) {
                m.IdPedido = PedidoControlador.Insert(m);

                var modelView = PedidoControlador.GetByPrimaryKeyView(m.IdPedido);

                //modificar el origen de datos
                origenDatos.Add(modelView);

                var bindingList = new BindingList<PedidoView>(origenDatos);
                var source = new BindingSource(bindingList, null);
                dgv.DataSource = source;

                //Calcular _rowIndex
                _rowIndex = dgv.Rows.Count - 1;

            } else {
                //TODO: Puede usarse m.Validate como validacion ya encapsulada de modelo integro.

                if (m.Validate().Equals(false))
                    throw new Exception("Errores en validacion!");

                var mNuevo = new Pedido {
                    IdPedido = ucPedido1.IdPedido,
                    IdProveedor = ucPedido1.IdProveedor,
                    Descripcion = ucPedido1.Descripcion,
                    Total = ucPedido1.Total,
                    Fecha = ucPedido1.Fecha,
                    IdEstadoPedido = ucPedido1.IdEstadoPedido,
                    Notas = ucPedido1.Notas
                };

                m.IdPedido = PedidoControlador.Update(mNuevo);
            }

            // pasar o mantener _modo Edicion
            _modo = ModoFormulario.Edicion;

            //********************
            //meter en subrutina
            dgv.Rows[_rowIndex].Cells[(int)PedidoView.GridColumn.Descripcion].Value = m.Descripcion;
            dgv.Rows[_rowIndex].Cells[(int)PedidoView.GridColumn.Proveedor].Value = ucPedido1.Proveedor;
            dgv.Rows[_rowIndex].Cells[(int)PedidoView.GridColumn.Fecha].Value = m.Fecha;
            dgv.Rows[_rowIndex].Cells[(int)PedidoView.GridColumn.Estado].Value = ucPedido1.Estado;
            dgv.Rows[_rowIndex].Cells[(int)PedidoView.GridColumn.Total].Value = m.Total;

            //********************

            //TODO: Ver esto, antes sin esto editaba ok. Tengo duda con el agregar uno nuevo.
            dgv.Rows[_rowIndex].Selected = true;
        }


        private void tsbNew_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            _modo = ModoFormulario.Nuevo;
            ucPedido1.Focus();  //TODO: Pendiente que pase este evento a su control.
        }


        public void LimpiarControles()
        {
            ucPedido1.Clear();
        }

        private void tsbSearchClearAndPerform_Click(object sender, EventArgs e)
        {
            tsbSearchTextBox.Clear();
            tsbSearchTextBox.Focus();
            ExecuteSearch();
        }


        private void dgv_MouseDown(object sender, MouseEventArgs e)
        {
            //TODO: Adaptar esto.
            cms.Items.Clear();
            //cms.Items.Add("Ordenar Ascendente");
            //cms.Items.Add("Ver Proveedores...");


            if (e.Button == MouseButtons.Right) {
                var ht = dgv.HitTest(e.X, e.Y);

                switch (ht.Type) {
                    case DataGridViewHitTestType.ColumnHeader:
                        // This positions the menu at the mouse's location.
                        cms.Items.Add("Ordenar Ascendente");
                        cms.Items.Add("Ordenar Descendente");

                        //cms.Items[0].Visible = true;
                        //cms.Items[1].Visible = false;
                        break;
                    // See if the user right-clicked over the header of the last column.
                    // (ht.ColumnIndex == dgv.Columns.Count - 1)
                    case DataGridViewHitTestType.Cell:
                        //cms.Items[0].Visible = false;
                        //cms.Items[1].Visible = true;
                        cms.Items.Add("Ver Proveedores..."); // esto puede abrir una pantalla pasando el IdPedido.
                        cms.Items.Add("Ver Detalles...");
                        break;

                }
                cms.Show(MousePosition);



            }
        }

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }


        private bool _ingresandoCodigo = false;


        private void FrmPedido_Leave(object sender, EventArgs e)
        {
            _ingresandoCodigo = false;
        }


        private void tsbSearchTextBox_Leave(object sender, EventArgs e)
        {
            _ingresandoCodigo = true;
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            Eliminar();
        }


        public void Eliminar()
        {
            if (!Util.ConfirmarEliminar())
                return;

            //crear objeto cascara
            var m = new Pedido { IdPedido = ucPedido1.IdPedido };

            var result = PedidoControlador.Delete(m);

            // Remover visualmente el registro del Pedido.
            dgv.Rows.Remove(dgv.Rows[_rowIndex]);

            LimpiarControles();
        }


    }
}
