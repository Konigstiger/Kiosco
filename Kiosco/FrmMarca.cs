using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Controlador;
using Model;

namespace Heimdall
{
    public partial class FrmMarca : Form, IAbmGeneral
    {
        private ModoFormulario _modo = ModoFormulario.Nuevo;

        private int _rowIndex = 0;
        private const int colCount = 3;

        private List<MarcaView> origenDatos = null;

        public FrmMarca()
        {
            InitializeComponent();
        }

        private void frmMarca_Load(object sender, EventArgs e)
        {
            SetControles();
            CargarControles();
            LimpiarControles();
            _modo = ModoFormulario.Edicion;
        }



        public void SetControles()
        {
            SetGrid(dgv);
            txtIdMarca.Visible = false;
            txtDescripcion.MaxLength = 50;
            txtNotas.MaxLength = 100;
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
            dgv.Columns.Clear();

            var c = new DataGridViewColumn[colCount];

            for (var i = 0; i < colCount; i++) {
                c[i] = new DataGridViewTextBoxColumn();
            }


            c[(int)MarcaView.GridColumn.IdMarca].Width = 0;
            c[(int)MarcaView.GridColumn.IdMarca].Visible = false; //true;
            Util.SetColumn(c[(int)MarcaView.GridColumn.IdMarca], "IdMarca", "IdMarca", 0);
            Util.SetColumn(c[(int)MarcaView.GridColumn.Descripcion], "Descripcion", "Descripción", 1);
            Util.SetColumn(c[(int)MarcaView.GridColumn.Notas], "Notas", "Notas", 2);
            dgv.Columns.AddRange(c);


            Util.SetColumnsReadOnly(dgv);

            origenDatos = searchText.Equals("") ?
                MarcaControlador.GetAll() :
                MarcaControlador.GetAll_GetByDescripcion(searchText);


            var bindingList = new MySortableBindingList<MarcaView>(origenDatos);
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
            var id = Convert.ToInt64(dgv.SelectedRows[0].Cells[(int)MarcaView.GridColumn.IdMarca].Value.ToString());

            _rowIndex = dgv.SelectedRows[0].Index;

            txtIdMarca.Text = id.ToString();
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

        private void frmMarca_KeyDown(object sender, KeyEventArgs e)
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
            const int idUsuarioActual = Usuario.IdUsuarioPredeterminado;

            var m = new Marca {
                IdMarca = -1,
                Descripcion = txtDescripcion.Text.Trim(),
                Notas = txtNotas.Text.Trim()
        };
            //=====================================================================
            if (_modo == ModoFormulario.Nuevo) {
                m.IdMarca = MarcaControlador.Insert(m);

                var modelView = MarcaControlador.GetByPrimaryKeyView(m.IdMarca);

                //modificar el origen de datos
                origenDatos.Add(modelView);

                var bindingList = new BindingList<MarcaView>(origenDatos);
                var source = new BindingSource(bindingList, null);
                dgv.DataSource = source;

                //Calcular _rowIndex
                _rowIndex = dgv.Rows.Count - 1;

            } else {
                //TODO: Puede usarse m.Validate como validacion ya encapsulada de modelo integro.

                if (m.Validate().Equals(false))
                    throw new Exception("Errores en validacion!");

                var MarcaNuevo = new Marca {
                    IdMarca = Convert.ToInt32(txtIdMarca.Text.Trim()),
                    Descripcion = txtDescripcion.Text.Trim(),
                    Notas = txtNotas.Text.Trim()
                };

                m.IdMarca = MarcaControlador.Update(MarcaNuevo);

                // pasar o mantener _modo Edicion
                _modo = ModoFormulario.Edicion;

                //********************
                //TODO: Revisar esto!
                dgv.Rows[_rowIndex].Cells[(int)MarcaView.GridColumn.Descripcion].Value = m.Descripcion;
                dgv.Rows[_rowIndex].Cells[(int)MarcaView.GridColumn.Notas].Value = m.Notas;
                //********************

                //TODO: Ver esto, antes sin esto editaba ok. Tengo duda con el agregar uno nuevo.
                dgv.Rows[_rowIndex].Selected = true;
            }

            // pasar o mantener _modo Edicion
            _modo = ModoFormulario.Edicion;

            //********************
            //meter en subrutina
            dgv.Rows[_rowIndex].Cells[(int)MarcaView.GridColumn.Descripcion].Value = m.Descripcion;
            dgv.Rows[_rowIndex].Cells[(int)MarcaView.GridColumn.Notas].Value = m.Notas;
            //********************

            //TODO: Ver esto, antes sin esto editaba ok. Tengo duda con el agregar uno nuevo.
            dgv.Rows[_rowIndex].Selected = true;
        }

        public void Eliminar()
        {
            if (!Util.ConfirmarEliminar())
                return;

            //crear objeto cascara
            var m = new Marca { IdMarca = Convert.ToInt32(txtIdMarca.Text.Trim()) };

            var result = MarcaControlador.Delete(m);

            // Remover visualmente el registro del producto.
            dgv.Rows.Remove(dgv.Rows[_rowIndex]);

            LimpiarControles();
        }


        private void tsbNew_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            _modo = ModoFormulario.Nuevo;
            txtDescripcion.Focus();
        }


        public void LimpiarControles()
        {
            txtDescripcion.Clear();
            txtNotas.Clear();
        }

        private const int ColCount = 3;



        private void txtIdMarca_TextChanged(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(txtIdMarca.Text.Trim());

            var c = MarcaControlador.GetByPrimaryKey(id);

            txtDescripcion.Text = c.Descripcion;
            txtNotas.Text = c.Notas.Trim(); //TODO: check nulls
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