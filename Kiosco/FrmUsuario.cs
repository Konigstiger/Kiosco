using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Controlador;
using Heimdall.UserControl;
using Model;

namespace Heimdall
{
    public partial class FrmUsuario : Form, IAbmGeneral
    {
        private ModoFormulario _modo = ModoFormulario.Nuevo;

        private int _rowIndex = 0;
        private const int colCount = 9;
        private bool busquedaActiva = false;

        private List<UsuarioView> origenDatos = null;

        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {

        }

        private void tsbSave_Click(object sender, EventArgs e)
        {

        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {

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
            Util.SetColumn(c[(int)UsuarioView.GridColumn.Estado], "Estado", "Estado", 4);
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
            var m = new Usuario {
                IdUsuario = -1,
                Descripcion = ucUsuarioEdit1.Descripcion,
                Usr = ucUsuarioEdit1.Usr,
                Pwd = ucUsuarioEdit1.Pwd,
                IdClaseUsuario = ucUsuarioEdit1.IdClaseUsuario,
                IdEstadoUsuario = ucUsuarioEdit1.IdEstadoUsuario,
                Notas = ucUsuarioEdit1.Notas
            };
            //=====================================================================
            if (_modo == ModoFormulario.Nuevo) {
                m.IdUsuario = UsuarioControlador.Insert(m);

                var modelView = UsuarioControlador.GetByPrimaryKeyView(m);

                //modificar el origen de datos
                origenDatos.Add(modelView);

                var bindingList = new BindingList<UsuarioView>(origenDatos);
                var source = new BindingSource(bindingList, null);
                dgv.DataSource = source;

                //Calcular _rowIndex
                _rowIndex = dgv.Rows.Count - 1;

            } else {
                //TODO: Puede usarse m.Validate como validacion ya encapsulada de modelo integro.

                if (m.Validate().Equals(false))
                    throw new Exception("Errores en validacion!");

                var UsuarioNuevo = new Usuario {
                    IdUsuario = ucUsuarioEdit1.IdUsuario,
                    Descripcion = ucUsuarioEdit1.Descripcion,
                    IdClaseUsuario = ucUsuarioEdit1.IdClaseUsuario,
                    IdEstadoUsuario = ucUsuarioEdit1.IdEstadoUsuario,
                    Notas = ucUsuarioEdit1.Notas
                };

                UsuarioControlador.Update(UsuarioNuevo);

            }

            // pasar o mantener _modo Edicion
            _modo = ModoFormulario.Edicion;

            //********************
            dgv.Rows[_rowIndex].Cells[(int)UsuarioView.GridColumn.Descripcion].Value = m.Descripcion;

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
            throw new NotImplementedException();
        }
    }
}
