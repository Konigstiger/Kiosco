using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Controlador;
using Model;

namespace Kiosco
{
    public partial class FrmPedido : Form
    {
        private ModoFormulario _modo = ModoFormulario.Nuevo;

        private int _rowIndex = 0;
        private const int colCount = 3;

        private List<PedidoView> origenDatos = null;


        private const int ColCount = 7;
        private const int MaxLenghtCodeBar = 13;





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
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            //dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dgv.ColumnHeadersHeight = 20;
            dgv.MultiSelect = false;
            dgv.AllowUserToAddRows = false;

            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure;

            //TODO: Ver mas propiedades del DataGridView.
        }

        public void CargarControles()
        {
            CargarGrilla(tsbSearchTextBox.Text);
        }


        public void CargarGrilla(string searchText)
        {
            //dgv.Columns.Clear();

            //var c = new DataGridViewColumn[colCount];

            //for (var i = 0; i < colCount; i++) {
            //    c[i] = new DataGridViewTextBoxColumn();
            //}


            //c[(int)PedidoGridColumn.IdPedido].Width = 0;
            //c[(int)PedidoGridColumn.IdPedido].Visible = false; //true;
            //Util.SetColumn(c[(int)PedidoGridColumn.IdPedido], "IdPedido", "IdPedido", 0);
            //Util.SetColumn(c[(int)PedidoGridColumn.Descripcion], "Descripcion", "Descripción", 1);
            //Util.SetColumn(c[(int)PedidoGridColumn.Notas], "Notas", "Notas", 2);
            //dgv.Columns.AddRange(c);


            //Util.SetColumnsReadOnly(dgv);

            //origenDatos = searchText.Equals("") ?
            //    PedidoControlador.GetAll() :
            //    PedidoControlador.GetAll_GetByDescripcion(searchText);


            //var bindingList = new BindingList<PedidoView>(origenDatos);
            //var source = new BindingSource(bindingList, null);
            //dgv.DataSource = source;

            //dgv.AllowUserToResizeRows = false;
            //dgv.RowHeadersVisible = false;
        }



        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            //if (_modo == ModoFormulario.Nuevo) return;

            if (dgv.SelectedRows.Count <= 0)
                return;

            // esto funciona, pero con el numero de celda, no con ID.
            var id = Convert.ToInt64(dgv.SelectedRows[0].Cells[(int)PedidoGridColumn.IdPedido].Value.ToString());

            _rowIndex = dgv.SelectedRows[0].Index;

            //TODO: REACTIVAR AQUI, pero apuntando al usercontrol.IdPedido
            //txtIdPedido.Text = id.ToString();
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
            //const int idUsuarioActual = Usuario.IdUsuarioPredeterminado;

            //var m = new Pedido {
            //    IdPedido = -1,
            //    Descripcion = txtDescripcion.Text.Trim(),
            //    Notas = txtNotas.Text.Trim()
            //};
            ////=====================================================================
            //if (_modo == ModoFormulario.Nuevo) {
            //    m.IdPedido = PedidoControlador.Insert(m);

            //    var modelView = PedidoControlador.GetByPrimaryKeyView(m.IdPedido);

            //    //modificar el origen de datos
            //    origenDatos.Add(modelView);

            //    var bindingList = new BindingList<PedidoView>(origenDatos);
            //    var source = new BindingSource(bindingList, null);
            //    dgv.DataSource = source;

            //    //Calcular _rowIndex
            //    _rowIndex = dgv.Rows.Count - 1;

            //} else {
            //    //TODO: Puede usarse m.Validate como validacion ya encapsulada de modelo integro.

            //    if (m.Validate().Equals(false))
            //        throw new Exception("Errores en validacion!");

            //    var PedidoNuevo = new Pedido {
            //        IdPedido = Convert.ToInt32(txtIdPedido.Text.Trim()),
            //        Descripcion = txtDescripcion.Text.Trim(),
            //        Notas = txtNotas.Text.Trim()
            //    };

            //    m.IdPedido = PedidoControlador.Update(PedidoNuevo);


            //}

            //// pasar o mantener _modo Edicion
            //_modo = ModoFormulario.Edicion;

            ////********************
            ////meter en subrutina
            //dgv.Rows[_rowIndex].Cells[(int)PedidoGridColumn.Descripcion].Value = m.Descripcion;
            //dgv.Rows[_rowIndex].Cells[(int)PedidoGridColumn.Notas].Value = m.Notas;
            ////********************

            ////TODO: Ver esto, antes sin esto editaba ok. Tengo duda con el agregar uno nuevo.
            //dgv.Rows[_rowIndex].Selected = true;
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
            //TODO: Ver de reactivar esto.
            //txtDescripcion.Focus();

            var f = new FrmSeleccionarProducto(ucPedidoDetalle1);
            f.Show();
        }


        public void LimpiarControles()
        {
            //txtDescripcion.Clear();
            //txtNotas.Clear();
        }

        //private const int ColCount = 3;

        public enum PedidoGridColumn
        {
            IdPedido = 0,
            Descripcion = 1,
            Notas = 2
        }

        private void txtIdPedido_TextChanged(object sender, EventArgs e)
        {
            //var id = Convert.ToInt32(txtIdPedido.Text.Trim());

            //var c = PedidoControlador.GetByPrimaryKey(id);

            //txtDescripcion.Text = c.Descripcion;
            //txtNotas.Text = c.Notas.Trim();         //TODO: check nulls
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




    }
}