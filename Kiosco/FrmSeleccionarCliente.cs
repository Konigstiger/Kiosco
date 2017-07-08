using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Controlador;
using Model;

namespace Kiosco
{
    public partial class FrmSeleccionarCliente : Form
    {


        public FrmSeleccionarCliente()
        {
            InitializeComponent();
        }

        public ISelectorCliente CallerForm { get; } = null;


        public FrmSeleccionarCliente(ISelectorCliente callerForm)
        {
            CallerForm = callerForm;

            // Si hago una interface, que implemente FrmRegistrarVenta (y otras pantallas),
            // ahi puedo definir una propiedad IdCliente, y otros posibles comportamientos,
            // con lo cual tengo polimorfismo y reusabilidad.
            
            InitializeComponent();
        }



        private void FrmSeleccionarCliente_Load(object sender, EventArgs e)
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

            const int colCount = 7;

            var c = new DataGridViewColumn[colCount];

            for (var i = 0; i < colCount; i++)
            {
                c[i] = new DataGridViewTextBoxColumn();
            }

            c[0].Width = 0;
            c[0].Visible = false;
            Util.SetColumn(c[0], "IdCliente", "IdCliente", 0);
            Util.SetColumn(c[1], "Descripcion", "Descripción", 1);
            Util.SetColumn(c[2], "Apellido", "Apellido", 2);
            Util.SetColumn(c[3], "Nombre", "Nombre", 3);
            Util.SetColumn(c[4], "Direccion", "Dirección", 4);
            Util.SetColumn(c[5], "Telefono", "Teléfono", 5);
            Util.SetColumn(c[6], "Notas", "Notas", 6);
            dgv.Columns.AddRange(c);


            Util.SetColumnsReadOnly(dgv);

            var origenDatos = searchText.Equals("") ? 
                ClienteControlador.GetAll() : 
                ClienteControlador.GetAll_GetByDescripcion(searchText);

            var bindingList = new MySortableBindingList<ClienteView>(origenDatos);
            var source = new BindingSource(bindingList, null);
            dgv.DataSource = source;


        }

        private void SetControles()
        {
            this.KeyPreview = true;
            SetGrid(dgv);

        }


        private void SetGrid(DataGridView dataGridView)
        {
            //TODO: Ver si se puede parametrizar dentro de las opciones del programa.
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv.BorderStyle = BorderStyle.None;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersHeight = 20;
            dgv.MultiSelect = false;

            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;

            dgv.AllowUserToResizeRows = false;
            dgv.RowHeadersVisible = false;

            //TODO: Ver mas propiedades del DataGridView.
        }


        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {
            //TODO: Validar. Puede usarse un try/catch
            var codigo = Convert.ToInt64(txtIdCliente.Text.Trim());

            var c = ClienteControlador.GetByPrimaryKey(codigo);

            txtDescripcion.Text = c.Descripcion;
            txtApellido.Text = c.Apellido;
            txtNombre.Text = c.Nombre;
            txtDireccion.Text = c.Direccion;
            txtTelefono.Text = c.Telefono;
            txtNotas.Text = c.Notas;

        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count <= 0) return;

            foreach (DataGridViewRow item in dgv.SelectedRows)
            {
                var IdCliente = (long)item.Cells[0].Value;
                txtIdCliente.Text = IdCliente.ToString();
            }
        }

        private void dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("{0} = {1}", "ColumnIndex", e.ColumnIndex);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "RowIndex", e.RowIndex);
            messageBoxCS.AppendLine();

            txtNotas.Text = messageBoxCS.ToString();

            //obtener el numero de row, y con eso, obtener los demas datos.

            long idCliente = Convert.ToInt64(dgv.Rows[e.RowIndex].Cells[0].Value);
            txtNotas.Text = idCliente.ToString();

            // Ver como hago para comunicar las ventanas entre si...
            CallerForm.IdCliente = idCliente;

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
            if (e.KeyCode == Keys.Enter)
            {
                ExecuteSearch();
            }
        }

        private void FrmSeleccionarCliente_KeyDown(object sender, KeyEventArgs e)
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
