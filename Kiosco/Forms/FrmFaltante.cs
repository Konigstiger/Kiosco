using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Controlador;
using Model;
using Model.View;

namespace Heimdall
{
    public partial class FrmFaltante : Form
    {
        public FrmFaltante()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private ModoFormulario _modo = ModoFormulario.Nuevo;

        private int _rowIndex = 0;
        private readonly int _colCount = 5;

        private List<FaltanteView> origenDatos = null;

        private void FrmFaltante_Load(object sender, EventArgs e)
        {
            SetControles();
            CargarControles();
            //LimpiarControles();
            _modo = ModoFormulario.Edicion;
        }


        public void SetControles()
        {
            Util.SetGrid(dgv, DataGridViewAutoSizeColumnsMode.AllCells);
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

            c[(int)FaltanteView.GridColumn.IdFaltante].Width = 0;
            c[(int)FaltanteView.GridColumn.IdFaltante].Visible = false; //true;
            Util.SetColumn(c[(int)FaltanteView.GridColumn.IdFaltante], "IdFaltante", "IdFaltante", 0);
            Util.SetColumn(c[(int)FaltanteView.GridColumn.Descripcion], "Descripcion", "Descripción", 1);
            Util.SetColumn(c[(int)FaltanteView.GridColumn.Fecha], "Fecha", "Fecha", 2);
            Util.SetColumn(c[(int)FaltanteView.GridColumn.EstadoFaltante], "EstadoFaltante", "Estado", 3);
            Util.SetColumn(c[(int)FaltanteView.GridColumn.Prioridad], "Prioridad", "Prioridad", 4);

            dgv.Columns.AddRange(c);


            Util.SetColumnsReadOnly(dgv);

            //origenDatos = FaltanteControlador.GetAll();

            //TODO: incluir busqueda
            
            origenDatos = searchText.Equals("") ?
                FaltanteControlador.GetAll() :
                FaltanteControlador.GetAll_GetByDescripcion(searchText);
            

            var bindingList = new MySortableBindingList<FaltanteView>(origenDatos);
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

            var model = ucFaltanteEdit1.ToModel();

            //=====================================================================
            if (_modo == ModoFormulario.Nuevo) {
                model.IdFaltante = FaltanteControlador.Insert(model);

                var modelView = FaltanteControlador.GetByPrimaryKeyView(model.IdFaltante);

                origenDatos.Add(modelView);

                var bindingList = new BindingList<FaltanteView>(origenDatos);
                var source = new BindingSource(bindingList, null);
                dgv.DataSource = source;

                //Calcular _rowIndex
                _rowIndex = dgv.Rows.Count - 1;

            } else {
                if (model.Validate().Equals(false))
                    throw new Exception("Errores en validacion!");

                //REFACTOR: Se reusa el modelo. Modificar solo Id (PK)
                model.IdFaltante = ucFaltanteEdit1.IdFaltante;

                FaltanteControlador.Update(model);

                _modo = ModoFormulario.Edicion;

                //********************
                //TODO: POR QUE ESTA DOS VECES ESTO????
                //TODO: Revisar esto!
                dgv.Rows[_rowIndex].Cells[(int)FaltanteView.GridColumn.Descripcion].Value = model.Descripcion;
                dgv.Rows[_rowIndex].Cells[(int)FaltanteView.GridColumn.Fecha].Value = model.Fecha;
                dgv.Rows[_rowIndex].Cells[(int)FaltanteView.GridColumn.EstadoFaltante].Value = ucFaltanteEdit1.EstadoFaltante;
                dgv.Rows[_rowIndex].Cells[(int)FaltanteView.GridColumn.Prioridad].Value = ucFaltanteEdit1.Prioridad;

                //********************

                //TODO: Ver esto, antes sin esto editaba ok. Tengo duda con el agregar uno nuevo.
                dgv.Rows[_rowIndex].Selected = true;
            }

            _modo = ModoFormulario.Edicion;

            //********************
            dgv.Rows[_rowIndex].Cells[(int)FaltanteView.GridColumn.Descripcion].Value = model.Descripcion;
            dgv.Rows[_rowIndex].Cells[(int)FaltanteView.GridColumn.Fecha].Value = model.Fecha;
            dgv.Rows[_rowIndex].Cells[(int)FaltanteView.GridColumn.EstadoFaltante].Value = ucFaltanteEdit1.EstadoFaltante;
            dgv.Rows[_rowIndex].Cells[(int)FaltanteView.GridColumn.Prioridad].Value = ucFaltanteEdit1.Prioridad;
            //********************

            //TODO: Ver esto, antes sin esto editaba ok. Tengo duda con el agregar uno nuevo.
            dgv.Rows[_rowIndex].Selected = true;
        }


        public void Eliminar()
        {
            if (!Util.ConfirmarEliminar())
                return;

            var m = new Faltante { IdFaltante = Convert.ToInt64(ucFaltanteEdit1.IdFaltante) };

            FaltanteControlador.Delete(m);

            // Remover visualmente el registro del producto.
            dgv.Rows.Remove(dgv.Rows[_rowIndex]);

            LimpiarControles();
        }


        public void LimpiarControles()
        {
            ucFaltanteEdit1.Clear();
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            //if (_modo == ModoFormulario.Nuevo) return;

            if (dgv.SelectedRows.Count <= 0)
                return;

            // esto funciona, pero con el numero de celda, no con ID.
            var id = Convert.ToInt64(dgv.SelectedRows[0].Cells[(int)FaltanteView.GridColumn.IdFaltante].Value.ToString());

            _rowIndex = dgv.SelectedRows[0].Index;

            ucFaltanteEdit1.IdFaltante = id;
        }


        private void BotonNuevo()
        {
            LimpiarControles();
            _modo = ModoFormulario.Nuevo;
            ucFaltanteEdit1.Focus();

        }


        private void dgv_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void ucAbmToolBar1_ButtonClickDelete(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void ucAbmToolBar1_ButtonClickUpdate(object sender, EventArgs e)
        {
            GuardarOInsertar();
        }

        private void ucAbmToolBar1_ButtonClickNew(object sender, EventArgs e)
        {
            BotonNuevo();
        }

        private void dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //?? revisar esto bien.
        }

        private void ucAbmToolBar1_ButtonClickExecuteSearch(object sender, EventArgs e)
        {
            CargarGrilla(ucAbmToolBar1.SearchText);
        }

        private void FrmFaltante_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode) {
                case Keys.F3:
                    //como hago para hacer visible y tener foco en el control
                    ucAbmToolBar1.ToggleSearch();
                    break;
            }
        }
    }
}
