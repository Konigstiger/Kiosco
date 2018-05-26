using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Controlador;
using Model;
using Model.View;

namespace Heimdall
{
    public partial class FrmUsuario : Form, IAbmGeneral
    {
        private ModoFormulario _modo = ModoFormulario.Nuevo;

        private int _rowIndex = 0;
        private const int colCount = 5;
        //private bool busquedaActiva = false;

        private List<UsuarioView> origenDatos = null;

        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            _modo = ModoFormulario.Nuevo;
            ucUsuarioEdit1.Focus();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            GuardarOInsertar();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            Eliminar();
        }


        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            SetControles();
            CargarControles();
            LimpiarControles();
            _modo = ModoFormulario.Edicion;
        }

        public void SetControles()
        {
            Util.SetGrid(dgv, DataGridViewAutoSizeColumnsMode.AllCells);
        }


        public void CargarControles()
        {
            CargarGrilla(tsbSearchTextBox.Text);
            //CargarSearchBoxSuggestions();
        }


        public void CargarGrilla(string searchText)
        {
            dgv.Columns.Clear();

            var c = new DataGridViewColumn[colCount];

            for (var i = 0; i < colCount; i++) {
                c[i] = new DataGridViewTextBoxColumn();
            }

            c[(int)UsuarioView.GridColumn.IdUsuario].Width = 0;
            c[(int)UsuarioView.GridColumn.IdUsuario].Visible = false; //true;
            Util.SetColumn(c[(int)UsuarioView.GridColumn.IdUsuario], "IdUsuario", "IdUsuario", 0);
            Util.SetColumn(c[(int)UsuarioView.GridColumn.Descripcion], "Descripcion", "Descripción", 1);
            Util.SetColumn(c[(int)UsuarioView.GridColumn.Usr], "Usr", "Usr", 2);
            Util.SetColumn(c[(int)UsuarioView.GridColumn.ClaseUsuario], "ClaseUsuario", "Clase", 3);
            Util.SetColumn(c[(int)UsuarioView.GridColumn.Estado], "EstadoUsuario", "Estado", 4);
            dgv.Columns.AddRange(c);

            Util.SetColumnsReadOnly(dgv);

            origenDatos = searchText.Equals("") ?
                UsuarioControlador.GetAll() :
                UsuarioControlador.GetAll();

            //origenDatos = searchText.Equals("") ?
            //    UsuarioControlador.GetAll() :
            //    UsuarioControlador.GetAll_ByUsr(searchText);

            var bindingList = new MySortableBindingList<UsuarioView>(origenDatos);
            var source = new BindingSource(bindingList, null);
            dgv.DataSource = source;

            dgv.AllowUserToResizeRows = false;
            dgv.RowHeadersVisible = false;
        }

        public void ExecuteSearch()
        {
            CargarGrilla(tsbSearchTextBox.Text);
        }

        public void GuardarOInsertar()
        {
            var model = ucUsuarioEdit1.ToModel();
            //=====================================================================
            if (_modo == ModoFormulario.Nuevo) {
                model.IdUsuario = UsuarioControlador.Insert(model);

                var modelView = UsuarioControlador.GetByPrimaryKeyView(model);

                origenDatos.Add(modelView);

                var bindingList = new BindingList<UsuarioView>(origenDatos);
                var source = new BindingSource(bindingList, null);
                dgv.DataSource = source;

                //Calcular _rowIndex
                _rowIndex = dgv.Rows.Count - 1;

            } else {
                if (model.Validate().Equals(false))
                    throw new Exception("Errores en validacion!");

                model.IdUsuario = ucUsuarioEdit1.IdUsuario;
                UsuarioControlador.Update(model);
            }
            _modo = ModoFormulario.Edicion;

            //********************
            dgv.Rows[_rowIndex].Cells[(int)UsuarioView.GridColumn.Descripcion].Value = model.Descripcion;

            //TODO: Ver algo de esto, temas de alineacion y tipos de datos de las columnas. EyeCandy
            dgv.Rows[_rowIndex].Cells[(int)UsuarioView.GridColumn.ClaseUsuario].Value = ucUsuarioEdit1.ClaseUsuario;
            dgv.Rows[_rowIndex].Cells[(int)UsuarioView.GridColumn.Estado].Value = ucUsuarioEdit1.EstadoUsuario;
            //********************

            //TODO: Ver esto, antes sin esto editaba ok. Tengo duda con el agregar uno nuevo.
            dgv.Rows[_rowIndex].Selected = true;
            
        }

        public void Eliminar()
        {
            throw new NotImplementedException();
        }

        public void LimpiarControles()
        {
            ucUsuarioEdit1.LimpiarControles();
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            //if (_modo == ModoFormulario.Nuevo) return;

            if (dgv.SelectedRows.Count <= 0)
                return;

            // esto funciona, pero con el numero de celda, no con ID.
            var id = Convert.ToInt32(dgv.SelectedRows[0].Cells[(int)UsuarioView.GridColumn.IdUsuario].Value.ToString());

            _rowIndex = dgv.SelectedRows[0].Index;

            ucUsuarioEdit1.IdUsuario = id;
        }
    }
}
