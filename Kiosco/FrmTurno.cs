using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Controlador;
using Model;
using Model.View;

namespace Heimdall
{
    public partial class FrmTurno : Form, IAbmGeneral
    {
        private ModoFormulario _modo = ModoFormulario.Nuevo;

        private int _rowIndex = 0;
        private const int colCount = 5;

        private List<TurnoView> origenDatos = null;


        public FrmTurno()
        {
            InitializeComponent();
        }

        private void FrmTurno_Load(object sender, EventArgs e)
        {
            SetControles();
            CargarControles();
            LimpiarControles();
            _modo = ModoFormulario.Edicion;
        }

        public void SetControles()
        {
            Util.SetGrid(dgv);
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


            c[(int)TurnoView.GridColumn.IdTurno].Width = 0;
            c[(int)TurnoView.GridColumn.IdTurno].Visible = false;
            Util.SetColumn(c[(int)TurnoView.GridColumn.IdTurno], "IdTurno", "IdTurno", 0);
            Util.SetColumn(c[(int)TurnoView.GridColumn.Descripcion], "Descripcion", "Descripción", 1);
            Util.SetColumn(c[(int)TurnoView.GridColumn.Fecha], "Fecha", "Fecha", 2);
            Util.SetColumn(c[(int)TurnoView.GridColumn.CantidadHoras], "CantidadHoras", "Horas", 3);
            Util.SetColumn(c[(int)TurnoView.GridColumn.Notas], "Notas", "Notas", 4);
            dgv.Columns.AddRange(c);


            Util.SetColumnsReadOnly(dgv);

            origenDatos = searchText.Equals("") ?
                TurnoControlador.GetAll() :
                TurnoControlador.GetAll_GetByDescripcion(searchText);

            var bindingList = new MySortableBindingList<TurnoView>(origenDatos);
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
            var model = ucTurnoEdit1.ToModel();
            //=====================================================================
            if (_modo == ModoFormulario.Nuevo) {
                model.IdTurno = TurnoControlador.Insert(model);

                var modelView = TurnoControlador.GetByPrimaryKeyView(model.IdTurno);

                origenDatos.Add(modelView);

                var bindingList = new BindingList<TurnoView>(origenDatos);
                var source = new BindingSource(bindingList, null);
                dgv.DataSource = source;

                //Calcular _rowIndex
                _rowIndex = dgv.Rows.Count - 1;

            } else {
                if (model.Validate().Equals(false))
                    throw new Exception("Errores en validacion!");

                model.IdTurno = ucTurnoEdit1.IdTurno;
                model.IdTurno = TurnoControlador.Update(model);

                _modo = ModoFormulario.Edicion;

                //********************
                dgv.Rows[_rowIndex].Cells[(int)TurnoView.GridColumn.Descripcion].Value = model.Descripcion;
                dgv.Rows[_rowIndex].Cells[(int)TurnoView.GridColumn.Notas].Value = model.Notas;
                //********************

                //TODO: Ver esto, antes sin esto editaba ok. Tengo duda con el agregar uno nuevo.
                dgv.Rows[_rowIndex].Selected = true;
            }

            // pasar o mantener _modo Edicion
            _modo = ModoFormulario.Edicion;

            //********************
            dgv.Rows[_rowIndex].Cells[(int)TurnoView.GridColumn.Descripcion].Value = model.Descripcion;
            dgv.Rows[_rowIndex].Cells[(int)TurnoView.GridColumn.Notas].Value = model.Notas;
            //********************

            //TODO: Ver esto, antes sin esto editaba ok. Tengo duda con el agregar uno nuevo.
            dgv.Rows[_rowIndex].Selected = true;
        }


        public void Eliminar()
        {
            if (!Util.ConfirmarEliminar())
                return;

            var m = new Turno { IdTurno = ucTurnoEdit1.IdTurno };

            TurnoControlador.Delete(m);

            // Remover visualmente el registro del producto.
            dgv.Rows.Remove(dgv.Rows[_rowIndex]);

            LimpiarControles();
        }


        public void LimpiarControles()
        {
            ucTurnoEdit1.Clear();
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            //if (_modo == ModoFormulario.Nuevo) return;

            if (dgv.SelectedRows.Count <= 0)
                return;

            // esto funciona, pero con el numero de celda, no con ID.
            var id = Convert.ToInt64(dgv.SelectedRows[0].Cells[(int)MarcaView.GridColumn.IdMarca].Value.ToString());

            _rowIndex = dgv.SelectedRows[0].Index;

            ucTurnoEdit1.IdTurno = id;
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            _modo = ModoFormulario.Nuevo;
            ucTurnoEdit1.Focus();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            GuardarOInsertar();
        }
    }
}
