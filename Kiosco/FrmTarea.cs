using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using Model.View;

namespace Heimdall
{
    public partial class FrmTarea : Form, IAbmGeneral
    {
        private ModoFormulario _modo = ModoFormulario.Nuevo;

        private int _rowIndex = 0;
        private const int colCount = 2;

        private List<TareaView> origenDatos = null;


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
            SetGrid(dgv);
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


            c[(int)TareaView.GridColumn.IdTarea].Width = 0;
            c[(int)TareaView.GridColumn.IdTarea].Visible = false; //true;
            Util.SetColumn(c[(int)TareaView.GridColumn.IdTarea], "IdTarea", "IdTarea", 0);
            Util.SetColumn(c[(int)TareaView.GridColumn.Descripcion], "Descripcion", "Descripción", 1);
            //Util.SetColumn(c[(int)TareaView.GridColumn.Notas], "Notas", "Notas", 2);
            dgv.Columns.AddRange(c);


            Util.SetColumnsReadOnly(dgv);

            origenDatos = TareaControlador.GetAll();

            //TODO: incluir busqueda
            /*
            origenDatos = searchText.Equals("") ?
                TareaControlador.GetAll() :
                TareaControlador.GetAll_GetByDescripcion(searchText);
            */

            var bindingList = new MySortableBindingList<TareaView>(origenDatos);
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
            throw new NotImplementedException();
        }

        public void Eliminar()
        {
            throw new NotImplementedException();
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
    }
}
