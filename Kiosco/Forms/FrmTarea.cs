using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Controlador;
using Model;
using Model.View;

namespace Heimdall
{
    public partial class FrmTarea : Form, IAbmGeneral
    {
        private ModoFormulario _modo = ModoFormulario.Nuevo;

        private int _rowIndex = 0;
        private readonly int _colCount = 6;

        private List<TareaView> _origenDatos = null;


        public FrmTarea()
        {
            InitializeComponent();
        }

        private void FrmTarea_Load(object sender, EventArgs e)
        {
            SetControles();
            CargarControles();
            //LimpiarControles();
            _modo = ModoFormulario.Edicion;
        }

        public void SetControles()
        {
            Util.SetGrid(dgv, DataGridViewAutoSizeColumnsMode.AllCells);
            ucTareaEdit1.IdUsuario = Program.UsuarioConectado.IdUsuario;
        }


        public void CargarControles()
        {
            CargarGrilla(ucAbmToolBar1.SearchText);
        }

        public void CargarGrilla(string searchText)
        {
            dgv.Columns.Clear();

            var c = new DataGridViewColumn[_colCount];

            for (var i = 0; i < _colCount; i++) {
                c[i] = new DataGridViewTextBoxColumn();
            }


            c[(int)TareaView.GridColumn.IdTarea].Width = 0;
            c[(int)TareaView.GridColumn.IdTarea].Visible = false; //true;
            Util.SetColumn(c[(int)TareaView.GridColumn.IdTarea], "IdTarea", "IdTarea", 0);
            Util.SetColumn(c[(int)TareaView.GridColumn.Descripcion], "Descripcion", "Descripción", 1);
            Util.SetColumn(c[(int)TareaView.GridColumn.Fecha], "Fecha", "Fecha", 2);
            Util.SetColumn(c[(int)TareaView.GridColumn.Estado], "Estado", "Estado", 3);
            Util.SetColumn(c[(int)TareaView.GridColumn.Prioridad], "Prioridad", "Prioridad", 4);
            Util.SetColumn(c[(int)TareaView.GridColumn.Clase], "Clase", "Clase", 5);
            //Dificultad (texto, no mostrar) 
            //Util.SetColumn(c[(int)TareaView.GridColumn.Notas], "Notas", "Notas", 2);
            dgv.Columns.AddRange(c);


            Util.SetColumnsReadOnly(dgv);

            _origenDatos = TareaControlador.GetAllView();

            //TODO: incluir busqueda
            /*
            _origenDatos = searchText.Equals("") ?
                TareaControlador.GetAll() :
                TareaControlador.GetAll_GetByDescripcion(searchText);
            */

            var bindingList = new MySortableBindingList<TareaView>(_origenDatos);
            var source = new BindingSource(bindingList, null);
            dgv.DataSource = source;


            dgv.AllowUserToResizeRows = false;
            dgv.RowHeadersVisible = false;
        }

        public void ExecuteSearch()
        {
            throw new NotImplementedException();
        }

        public void GuardarOInsertar()
        {
            //TODO: ES BUENA IDEA REVISAR Y REFACTOREAR ESTE CODIGO.
            //TODO: Propagar luego los cambios.

            var model = ucTareaEdit1.ToModel();
            
            //=====================================================================
            if (_modo == ModoFormulario.Nuevo) {
                model.IdTarea = TareaControlador.Insert(model);

                var modelView = TareaControlador.GetByPrimaryKeyView(model.IdTarea);

                _origenDatos.Add(modelView);

                var bindingList = new BindingList<TareaView>(_origenDatos);
                var source = new BindingSource(bindingList, null);
                dgv.DataSource = source;

                //Calcular _rowIndex
                _rowIndex = dgv.Rows.Count - 1;

            } else {
                if (model.Validate().Equals(false))
                    throw new Exception("Errores en validacion!");

                //REFACTOR: Se reusa el modelo. Modificar solo Id (PK)
                model.IdTarea = ucTareaEdit1.IdTarea;

                TareaControlador.Update(model);

                // pasar o mantener _modo Edicion
                _modo = ModoFormulario.Edicion;

                //TODO: Ver esto, antes sin esto editaba ok. Tengo duda con el agregar uno nuevo.
                dgv.Rows[_rowIndex].Selected = true;
            }

            _modo = ModoFormulario.Edicion;

            //********************
            //TODO: Revisar esto!
            dgv.Rows[_rowIndex].Cells[(int)TareaView.GridColumn.Descripcion].Value = model.Descripcion;
            dgv.Rows[_rowIndex].Cells[(int)TareaView.GridColumn.Fecha].Value = model.Fecha;
            dgv.Rows[_rowIndex].Cells[(int)TareaView.GridColumn.Estado].Value = ucTareaEdit1.Estado;
            dgv.Rows[_rowIndex].Cells[(int)TareaView.GridColumn.Prioridad].Value = ucTareaEdit1.Prioridad;
            dgv.Rows[_rowIndex].Cells[(int)TareaView.GridColumn.Clase].Value = ucTareaEdit1.Clase;
            //********************

            //TODO: Ver esto, antes sin esto editaba ok. Tengo duda con el agregar uno nuevo.
            dgv.Rows[_rowIndex].Selected = true;
        }


        public void Eliminar()
        {
            if (!Util.ConfirmarEliminar())
                return;

            var m = new Tarea { IdTarea = Convert.ToInt64(ucTareaEdit1.IdTarea) };

            var result = TareaControlador.Delete(m);

            // Remover visualmente el registro del producto.
            dgv.Rows.Remove(dgv.Rows[_rowIndex]);

            LimpiarControles();
        }


        public void LimpiarControles()
        {
            ucTareaEdit1.Clear();
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            //if (_modo == ModoFormulario.Nuevo) return;

            if (dgv.SelectedRows.Count <= 0)
                return;

            // esto funciona, pero con el numero de celda, no con ID.
            var id = Convert.ToInt64(dgv.SelectedRows[0].Cells[(int)TareaView.GridColumn.IdTarea].Value.ToString());

            _rowIndex = dgv.SelectedRows[0].Index;

            ucTareaEdit1.IdTarea = id;
        }


        private void dgv_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //?
        }

        private void ucAbmToolBar1_ButtonClickNew(object sender, EventArgs e)
        {
            BotonNuevo();
        }

        private void BotonNuevo()
        {
            LimpiarControles();
            _modo = ModoFormulario.Nuevo;
            ucTareaEdit1.Focus();

        }

        private void ucAbmToolBar1_ButtonClickDelete(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void ucAbmToolBar1_ButtonClickUpdate(object sender, EventArgs e)
        {
            GuardarOInsertar();
        }

        private void dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //foo.
        }
    }
}
