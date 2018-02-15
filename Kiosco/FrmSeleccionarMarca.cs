using System;
using System.Drawing;
using System.Windows.Forms;
using Controlador;
using Model;
using Model.View;

namespace Heimdall
{
    public partial class FrmSeleccionarMarca : Form
    {
        public FrmSeleccionarMarca()
        {
            InitializeComponent();
        }

        public ISelectorMarca CallerForm { get; } = null;


        public FrmSeleccionarMarca(ISelectorMarca callerForm)
        {
            CallerForm = callerForm;
            InitializeComponent();
        }



        private void FrmSeleccionarMarca_Load(object sender, EventArgs e)
        {
            SetControles();
            CargarControles();
        }

        private void CargarControles()
        {
            CargarGrilla("");
        }


        private void CargarGrilla(string searchText)
        {
            dgv.Columns.Clear();

            const int colCount = 3;

            var c = new DataGridViewColumn[colCount];

            for (var i = 0; i < colCount; i++) {
                c[i] = new DataGridViewTextBoxColumn();
            }

            c[0].Width = 0;
            c[0].Visible = false;
            Util.SetColumn(c[0], "IdMarca", "IdMarca", 0);
            Util.SetColumn(c[1], "Descripcion", "Descripcion", 1);
            Util.SetColumn(c[2], "Notas", "Notas", 2);
            dgv.Columns.AddRange(c);

            Util.SetColumnsReadOnly(dgv);

            var origenDatos = searchText.Equals("") ?
                MarcaControlador.GetAll() :
                MarcaControlador.GetAll_GetByDescripcion(searchText);

            var bindingList = new MySortableBindingList<MarcaView>(origenDatos);
            var source = new BindingSource(bindingList, null);
            dgv.DataSource = source;

        }

        private void SetControles()
        {
            this.KeyPreview = true;
            txtIdMarca.Visible = false;
            SetGrid(dgv);

        }


        private static void SetGrid(DataGridView dgv)
        {
            //TODO: Ver si se puede parametrizar dentro de las opciones del programa.
            dgv.AutoGenerateColumns = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv.BorderStyle = BorderStyle.None;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersHeight = 20;
            dgv.MultiSelect = false;
            dgv.AllowUserToAddRows = false;

            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure;

            dgv.AllowUserToResizeRows = false;
            dgv.RowHeadersVisible = false;

            //TODO: Ver mas propiedades del DataGridView.
        }


        private void txtIdMarca_TextChanged(object sender, EventArgs e)
        {
            //TODO: Validar. Puede usarse un try/catch
            var codigo = Convert.ToInt32(txtIdMarca.Text.Trim());

            var c = MarcaControlador.GetByPrimaryKey(codigo);

            txtDescripcion.Text = c.Descripcion;
            txtNotas.Text = c.Notas;
        }


        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count <= 0)
                return;
            try {
                foreach (DataGridViewRow item in dgv.SelectedRows) {
                    var idMarca = (long)item.Cells[0].Value;
                    txtIdMarca.Text = idMarca.ToString();
                }
            }
            catch (Exception) {
                //engullir errores por ahora.
                //throw;
            }
        }



        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //obtener el numero de row, y con eso, obtener los demas datos.

            var IdMarca = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[0].Value);

            //Comunicar las ventanas entre si...
            CallerForm.IdMarca = IdMarca;

            CerrarVentana();
        }


        private void CerrarVentana()
        {
            this.Close();
            this.Dispose();
        }



        private void tsbSearch_Click(object sender, EventArgs e)
        {
            ToggleSearch();
        }


        private void ToggleSearch()
        {
            tsbSearchTextBox.Visible = !tsbSearchTextBox.Visible;
            tsbSearchPerform.Visible = !tsbSearchPerform.Visible;
            tsbSearchTextBox.Focus();
        }

        private void tsbSearchPerform_Click(object sender, EventArgs e)
        {
            ExecuteSearch();
        }

        private void ExecuteSearch()
        {
            CargarGrilla(tsbSearchTextBox.Text);
        }

        private void tsbSearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                ExecuteSearch();
            }
        }

        private void FrmSeleccionarMarca_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode) {
                case Keys.F3:
                    tsbSearch.Checked = !tsbSearch.Checked;
                    ToggleSearch();
                    break;
                case Keys.Escape:
                    CerrarVentana();
                    break;
            }
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
