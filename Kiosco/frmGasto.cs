using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Windows.Forms;
using Controlador;
using Model;
using Model.View;

namespace Heimdall
{
    public partial class FrmGasto : Form
    {
        //TODO: ref a _editor control
        //mas que ser una referencia a usercontrol, podria ser a una interface, 
        //que tenga definicion de metodos. Por ejemplo: Clear();
        private readonly System.Windows.Forms.UserControl _editor = null;

        private ModoFormulario _modo = ModoFormulario.Nuevo;

        private int _rowIndex = 0;
        private readonly int _colCount = 7;

        private List<GastoView> _origenDatos = null;

        public FrmGasto()
        {
            InitializeComponent();
            this.KeyPreview = true;
            _editor = ucGastoEdit1;
        }

        private void ucAbmToolBar1_ButtonClickNew(object sender, EventArgs e)
        {
            BotonNuevo();
        }

        private void BotonNuevo()
        {
            LimpiarControles();
            _modo = ModoFormulario.Nuevo;
            _editor.Focus();
        }

        public void LimpiarControles()
        {
            //TODO: activar esto.
            //_editor.Clear();
            ucGastoEdit1.Clear();
        }

        private void ucAbmToolBar1_ButtonClickDelete(object sender, EventArgs e)
        {
            Eliminar();
        }

        public void Eliminar()
        {
            if (!Util.ConfirmarEliminar())
                return;

            var model = new Gasto { IdGasto = Convert.ToInt64(ucGastoEdit1.IdGasto) };

            GastoControlador.Delete(model);

            // Remover visualmente el registro del producto.
            dgv.Rows.Remove(dgv.Rows[_rowIndex]);

            LimpiarControles();
        }

        private void FrmGasto_Load(object sender, EventArgs e)
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

            c[(int)GastoView.GridColumn.IdGasto].Width = 0;
            c[(int)GastoView.GridColumn.IdGasto].Visible = false; //true;
            Util.SetColumn(c[(int)GastoView.GridColumn.IdGasto], "IdGasto", "IdGasto", 0);
            Util.SetColumn(c[(int)GastoView.GridColumn.Descripcion], "Descripcion", "Descripción", 1);
            Util.SetColumn(c[(int)GastoView.GridColumn.Monto], "Monto", "Monto", 2);
            Util.SetColumn(c[(int)GastoView.GridColumn.FechaPago], "FechaPago", "Fecha de Pago", 3);
            Util.SetColumn(c[(int)GastoView.GridColumn.FechaVencimiento], "FechaVencimiento", "Fecha de Vencimiento", 4);
            Util.SetColumn(c[(int)GastoView.GridColumn.Estado], "Estado", "Estado", 5);
            Util.SetColumn(c[(int)GastoView.GridColumn.Clase], "Clase", "Clase", 6);
            Util.SetColumn(c[(int)GastoView.GridColumn.Prioridad], "Prioridad", "Prioridad", 7);

            dgv.Columns.AddRange(c);

            Util.SetColumnsReadOnly(dgv);

            _origenDatos = GastoControlador.GetAll();

            //TODO: incluir busqueda
            /*
            _origenDatos = searchText.Equals("") ?
                GastoControlador.GetAll() :
                GastoControlador.GetAll_GetByDescripcion(searchText);
            */

            var bindingList = new MySortableBindingList<GastoView>(_origenDatos);
            var source = new BindingSource(bindingList, null);
            dgv.DataSource = source;

            dgv.AllowUserToResizeRows = false;
            dgv.RowHeadersVisible = false;
        }



        public void ExecuteSearch()
        {
            throw new NotImplementedException();
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            //if (_modo == ModoFormulario.Nuevo) return;

            if (dgv.SelectedRows.Count <= 0)
                return;

            // esto funciona, pero con el numero de celda, no con ID.
            var id = Convert.ToInt64(dgv.SelectedRows[0].Cells[(int)GastoView.GridColumn.IdGasto].Value.ToString());

            _rowIndex = dgv.SelectedRows[0].Index;

            ucGastoEdit1.IdGasto = id;
        }

        private void dgv_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //foo.
        }

        private void dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //foo.
        }

        private void ucAbmToolBar1_ButtonClickExecuteSearch(object sender, EventArgs e)
        {
            CargarGrilla(ucAbmToolBar1.SearchText);
        }

        private void FrmGasto_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode) {
                case Keys.F3:
                    //como hago para hacer visible y tener foco en el control
                    ucAbmToolBar1.ToggleSearch();
                    break;
            }
        }

        private void ucAbmToolBar1_ButtonClickUpdate(object sender, EventArgs e)
        {
            GuardarOInsertar();
        }


        public void GuardarOInsertar()
        {
            //TODO: ES BUENA IDEA REVISAR Y REFACTOREAR ESTE CODIGO.
            //TODO: Propagar luego los cambios.

            var model = ucGastoEdit1.ToModel();

            //=====================================================================
            if (_modo == ModoFormulario.Nuevo) {
                model.IdGasto = GastoControlador.Insert(model);

                var modelView = GastoControlador.GetByPrimaryKeyView(model.IdGasto);

                _origenDatos.Add(modelView);

                var bindingList = new BindingList<GastoView>(_origenDatos);
                var source = new BindingSource(bindingList, null);
                dgv.DataSource = source;

                //Calcular _rowIndex
                _rowIndex = dgv.Rows.Count - 1;

            } else {
                if (model.Validate().Equals(false))
                    throw new Exception("Errores en validacion!");

                //REFACTOR: Se reusa el modelo. Modificar solo Id (PK)
                model.IdGasto = ucGastoEdit1.IdGasto;

                GastoControlador.Update(model);

                _modo = ModoFormulario.Edicion;

                //TODO: Ver esto, antes sin esto editaba ok. Tengo duda con el agregar uno nuevo.
                dgv.Rows[_rowIndex].Selected = true;
            }

            _modo = ModoFormulario.Edicion;

            //********************
            dgv.Rows[_rowIndex].Cells[(int)GastoView.GridColumn.Descripcion].Value = model.Descripcion;
            dgv.Rows[_rowIndex].Cells[(int)GastoView.GridColumn.FechaPago].Value = model.FechaPago;
            dgv.Rows[_rowIndex].Cells[(int)GastoView.GridColumn.FechaVencimiento].Value = model.FechaVencimiento;
            dgv.Rows[_rowIndex].Cells[(int)GastoView.GridColumn.Clase].Value = ucGastoEdit1.ClaseGasto;
            dgv.Rows[_rowIndex].Cells[(int)GastoView.GridColumn.Estado].Value = ucGastoEdit1.EstadoGasto;
            dgv.Rows[_rowIndex].Cells[(int)GastoView.GridColumn.Prioridad].Value = ucGastoEdit1.Prioridad;
            //********************

            //TODO: Ver esto, antes sin esto editaba ok. Tengo duda con el agregar uno nuevo.
            dgv.Rows[_rowIndex].Selected = true;
        }

    }
}
