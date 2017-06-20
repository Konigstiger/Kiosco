using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Controlador;
using Model;

namespace Kiosco
{
    public partial class FrmRecaudacion : Form, IAbmGeneral
    {
        private ModoFormulario _modo = ModoFormulario.Nuevo;

        private int _rowIndex = 0;
        private const int colCount = 5;

        private List<RecaudacionView> origenDatos = null;


        public FrmRecaudacion()
        {
            InitializeComponent();
        }

        public void SetControles()
        {
            SetGrid(dgv);
            txtIdRecaudacion.Visible = false;
            nudTotal.Maximum = 99999;
            nudTotal.Minimum = 0;
            nudCompras.Maximum = 99999;
            nudCompras.Minimum = 0;
            nudGastos.Maximum = 99999;
            nudGastos.Minimum = 0;
            nudTotal.Increment = 100;
            nudCompras.Increment = 100;
            nudGastos.Increment = 100;
            dtpFecha.Format = DateTimePickerFormat.Short;
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

            c[(int)RecaudacionView.GridColumn.IdRecaudacion].Width = 0;
            c[(int)RecaudacionView.GridColumn.IdRecaudacion].Visible = false; //true;
            Util.SetColumn(c[(int)RecaudacionView.GridColumn.IdRecaudacion], "IdRecaudacion", "IdRecaudacion", 0);
            Util.SetColumn(c[(int)RecaudacionView.GridColumn.Fecha], "Fecha", "Fecha", 1);
            Util.SetColumn(c[(int)RecaudacionView.GridColumn.Total], "Total", "Total", 2);
            Util.SetColumn(c[(int)RecaudacionView.GridColumn.Compras], "Compras", "Compras", 3);
            Util.SetColumn(c[(int)RecaudacionView.GridColumn.Gastos], "Gastos", "Gastos", 4);
            dgv.Columns.AddRange(c);


            Util.SetColumnsReadOnly(dgv);

            origenDatos = searchText.Equals("") ?
                RecaudacionControlador.GetAll() :
                RecaudacionControlador.GetAll();


            var bindingList = new MySortableBindingList<RecaudacionView>(origenDatos);
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
            const int idUsuarioActual = Usuario.IdUsuarioPredeterminado;

            var m = new Recaudacion {
                IdRecaudacion = -1,
                Fecha = dtpFecha.Value,
                IdUsuario = idUsuarioActual,
                Total = nudTotal.Value,
                Compras = nudCompras.Value,
                Gastos = nudGastos.Value,
                Notas = txtNotas.Text.Trim()
            };
            //=====================================================================
            if (_modo == ModoFormulario.Nuevo) {
                m.IdRecaudacion = RecaudacionControlador.Insert(m);

                var modelView = RecaudacionControlador.GetByPrimaryKeyView(m.IdRecaudacion);

                //modificar el origen de datos
                origenDatos.Add(modelView);

                var bindingList = new BindingList<RecaudacionView>(origenDatos);
                var source = new BindingSource(bindingList, null);
                dgv.DataSource = source;

                //Calcular _rowIndex
                _rowIndex = dgv.Rows.Count - 1;

            } else {
                //TODO: Puede usarse m.Validate como validacion ya encapsulada de modelo integro.

                if (m.Validate().Equals(false))
                    throw new Exception("Errores en validacion!");

                var RecaudacionNuevo = new Recaudacion {
                    IdRecaudacion = Convert.ToInt64(txtIdRecaudacion.Text.Trim()),
                    Fecha = dtpFecha.Value,
                    Total = nudTotal.Value,
                    Compras = nudCompras.Value,
                    Gastos = nudGastos.Value,
                    IdUsuario = idUsuarioActual,
                    Notas = txtNotas.Text.Trim()
                };

                m.IdRecaudacion = RecaudacionControlador.Update(RecaudacionNuevo);
            }

            // pasar o mantener _modo Edicion
            _modo = ModoFormulario.Edicion;

            //********************
            //TODO: Revisar esto!
            dgv.Rows[_rowIndex].Cells[(int)RecaudacionView.GridColumn.Fecha].Value = m.Fecha;
            dgv.Rows[_rowIndex].Cells[(int)RecaudacionView.GridColumn.Total].Value = m.Total;
            dgv.Rows[_rowIndex].Cells[(int)RecaudacionView.GridColumn.Compras].Value = m.Compras;
            dgv.Rows[_rowIndex].Cells[(int)RecaudacionView.GridColumn.Gastos].Value = m.Gastos;
            //********************

            //TODO: Ver esto, antes sin esto editaba ok. Tengo duda con el agregar uno nuevo.
            dgv.Rows[_rowIndex].Selected = true;
        }


        public void Eliminar()
        {
            if (!Util.ConfirmarEliminar())
                return;

            //crear objeto cascara
            var m = new Recaudacion { IdRecaudacion = Convert.ToInt64(txtIdRecaudacion.Text.Trim()) };

            var result = RecaudacionControlador.Delete(m);

            // Remover visualmente el registro del producto.
            dgv.Rows.Remove(dgv.Rows[_rowIndex]);

            LimpiarControles();
        }


        public void LimpiarControles()
        {
            dtpFecha.Value = DateTime.Today;
            nudTotal.Value = 0;
            nudCompras.Value = 0;
            txtNotas.Clear();
        }


        private void FrmRecaudacion_Load(object sender, EventArgs e)
        {
            SetControles();
            CargarControles();
            LimpiarControles();
            _modo = ModoFormulario.Edicion;
        }

        private void ToggleSearch()
        {
            tsbSearchTextBox.Visible = !tsbSearchTextBox.Visible;
            tsbSearchPerform.Visible = !tsbSearchPerform.Visible;
            tsbSearchClearAndPerform.Visible = !tsbSearchClearAndPerform.Visible;
            tsbSearchTextBox.Focus();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            GuardarOInsertar();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            _modo = ModoFormulario.Nuevo;
            dtpFecha.Focus();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            ToggleSearch();
        }

        private void tsbSearchPerform_Click(object sender, EventArgs e)
        {
            ExecuteSearch();
        }

        private void tsbSearchClearAndPerform_Click(object sender, EventArgs e)
        {
            tsbSearchTextBox.Clear();
            tsbSearchTextBox.Focus();
            ExecuteSearch();
        }

        private void txtIdRecaudacion_TextChanged(object sender, EventArgs e)
        {
            var id = Convert.ToInt64(txtIdRecaudacion.Text.Trim());

            var c = RecaudacionControlador.GetByPrimaryKey(id);

            dtpFecha.Value = c.Fecha;
            nudTotal.Value = c.Total;
            nudCompras.Value = c.Compras;
            nudGastos.Value = c.Gastos;
            txtNotas.Text = c.Notas.Trim();
        }


        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            //if (_modo == ModoFormulario.Nuevo) return;

            if (dgv.SelectedRows.Count <= 0)
                return;

            // esto funciona, pero con el numero de celda, no con ID.
            var id = Convert.ToInt64(dgv.SelectedRows[0].Cells[(int)RecaudacionView.GridColumn.IdRecaudacion].Value.ToString());

            _rowIndex = dgv.SelectedRows[0].Index;

            txtIdRecaudacion.Text = id.ToString();
        }
    }
}
