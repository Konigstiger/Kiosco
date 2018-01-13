using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Controlador;
using Kiosco;
using Model;

namespace Heimdall
{
    public partial class FrmSeleccionarProveedor : Form
    {

        public FrmSeleccionarProveedor()
        {
            InitializeComponent();
        }

        public ISelectorProveedor CallerForm { get; } = null;


        public FrmSeleccionarProveedor(ISelectorProveedor callerForm)
        {
            CallerForm = callerForm;
            InitializeComponent();
        }



        private void FrmSeleccionarProveedor_Load(object sender, EventArgs e)
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

            const int colCount = 5;

            var c = new DataGridViewColumn[colCount];

            for (var i = 0; i < colCount; i++) {
                c[i] = new DataGridViewTextBoxColumn();
            }

            c[0].Width = 0;
            c[0].Visible = false;
            Util.SetColumn(c[0], "IdProveedor", "IdProveedor", 0);
            Util.SetColumn(c[1], "RazonSocial", "Razon Social", 1);
            Util.SetColumn(c[2], "Direccion", "Direccion", 2);
            Util.SetColumn(c[3], "Telefono", "Telefono", 3);
            Util.SetColumn(c[4], "Notas", "Notas", 4);
            dgv.Columns.AddRange(c);

            Util.SetColumnsReadOnly(dgv);

            var origenDatos = searchText.Equals("") ?
                ProveedorControlador.GetAll_Activo() :
                ProveedorControlador.GetAll_GetByDescripcion(searchText);

            var bindingList = new MySortableBindingList<ProveedorView>(origenDatos);
            var source = new BindingSource(bindingList, null);
            dgv.DataSource = source;


        }

        private void SetControles()
        {
            this.KeyPreview = true;
            txtIdProveedor.Visible = false;
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

            dgv.AllowUserToResizeRows = false;
            dgv.RowHeadersVisible = false;

            //TODO: Ver mas propiedades del DataGridView.
        }


        private void txtIdProveedor_TextChanged(object sender, EventArgs e)
        {
            //TODO: Validar. Puede usarse un try/catch
            var codigo = Convert.ToInt32(txtIdProveedor.Text.Trim());

            var c = ProveedorControlador.GetByPrimaryKey(codigo);

            txtDescripcion.Text = c.RazonSocial;
            txtDireccion.Text = c.Direccion;
            txtTelefono.Text = c.Telefono;
            txtNotas.Text = c.Notas;

        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count <= 0)
                return;
            try {
                foreach (DataGridViewRow item in dgv.SelectedRows) {
                    var IdProveedor = (long)item.Cells[0].Value;
                    txtIdProveedor.Text = IdProveedor.ToString();
                }
            }
            catch (Exception) {
                //engullir errores por ahora.
                //throw;
            }
        }

        private void dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var messageBoxCs = new StringBuilder();
            messageBoxCs.AppendFormat("{0} = {1}", "ColumnIndex", e.ColumnIndex);
            messageBoxCs.AppendLine();
            messageBoxCs.AppendFormat("{0} = {1}", "RowIndex", e.RowIndex);
            messageBoxCs.AppendLine();

            txtNotas.Text = messageBoxCs.ToString();

            //obtener el numero de row, y con eso, obtener los demas datos.

            var idProveedor = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[0].Value);
            txtNotas.Text = idProveedor.ToString();

            //Comunicar las ventanas entre si...
            CallerForm.IdProveedor = idProveedor;

            CerrarVentana();

        }


        private void CerrarVentana()
        {
            this.Close();
            this.Dispose();
        }


        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void FrmSeleccionarProveedor_KeyDown(object sender, KeyEventArgs e)
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
    }
}
