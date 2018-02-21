﻿using System;
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
        }

        private ModoFormulario _modo = ModoFormulario.Nuevo;

        private int _rowIndex = 0;
        private const int colCount = 5;

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

            var c = new DataGridViewColumn[colCount];

            for (var i = 0; i < colCount; i++) {
                c[i] = new DataGridViewTextBoxColumn();
            }

            c[(int)FaltanteView.GridColumn.IdFaltante].Width = 0;
            c[(int)FaltanteView.GridColumn.IdFaltante].Visible = false; //true;
            Util.SetColumn(c[(int)FaltanteView.GridColumn.IdFaltante], "IdFaltante", "IdFaltante", 0);
            Util.SetColumn(c[(int)FaltanteView.GridColumn.Descripcion], "Descripcion", "Descripción", 1);
            Util.SetColumn(c[(int)FaltanteView.GridColumn.Fecha], "Fecha", "Fecha", 2);
            Util.SetColumn(c[(int)FaltanteView.GridColumn.EstadoFaltante], "EstadoFaltante", "Estado", 3);

            dgv.Columns.AddRange(c);


            Util.SetColumnsReadOnly(dgv);

            origenDatos = FaltanteControlador.GetAll();

            //TODO: incluir busqueda
            /*
            origenDatos = searchText.Equals("") ?
                FaltanteControlador.GetAll() :
                FaltanteControlador.GetAll_GetByDescripcion(searchText);
            */

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
                //TODO: Revisar esto!
                dgv.Rows[_rowIndex].Cells[(int)FaltanteView.GridColumn.Descripcion].Value = model.Descripcion;
                dgv.Rows[_rowIndex].Cells[(int)FaltanteView.GridColumn.Fecha].Value = model.Fecha;

                /*
            //Estado (texto)
                 */
                //********************

                //TODO: Ver esto, antes sin esto editaba ok. Tengo duda con el agregar uno nuevo.
                dgv.Rows[_rowIndex].Selected = true;
            }

            _modo = ModoFormulario.Edicion;

            //********************
            dgv.Rows[_rowIndex].Cells[(int)FaltanteView.GridColumn.Descripcion].Value = model.Descripcion;
            dgv.Rows[_rowIndex].Cells[(int)FaltanteView.GridColumn.Fecha].Value = model.Fecha;
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
    }
}