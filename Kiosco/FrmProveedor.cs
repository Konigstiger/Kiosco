using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Controlador;
using Model;

namespace Kiosco
{
    public partial class FrmProveedor : Form, IAbmGeneral
    {
        private ModoFormulario _modo = ModoFormulario.Nuevo;

        private int _rowIndex = 0;
        private const int colCount = 8;

        private List<ProveedorView> origenDatos = null;

        public FrmProveedor()
        {
            InitializeComponent();
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            SetControles();
            CargarControles();
            LimpiarControles();
            _modo = ModoFormulario.Edicion;
        }

        private void SetControles()
        {
            this.KeyPreview = true;
            txtIdProveedor.Visible = false;
            txtDireccion.MaxLength = 255;
            txtEmail.MaxLength = 50;
            txtPersonaContacto.MaxLength = 50;
            txtRazonSocial.MaxLength = 100;
            txtTelefono.MaxLength = 25;
            txtHorarioAtencion.MaxLength = 100;
            txtDiasDeVisita.MaxLength = 100;
            txtNotas.MaxLength = 255;

            SetGrid(dgv);
        }


        public void ExecuteSearch()
        {
            CargarGrilla(tsbSearchTextBox.Text);
        }


        public void GuardarOInsertar()
        {
            const int idUsuarioActual = Usuario.IdUsuarioPredeterminado;

            var m = new Proveedor();
            m.IdProveedor = -1;
            m.RazonSocial = txtRazonSocial.Text.Trim();
            m.Direccion = txtDireccion.Text.Trim();
            m.Telefono = txtTelefono.Text.Trim();
            m.Notas = txtNotas.Text.Trim();
            m.Email = txtEmail.Text.Trim();
            m.PersonaContacto = txtPersonaContacto.Text.Trim();
            m.HorarioAtencion = txtHorarioAtencion.Text.Trim();
            m.DiasDeVisita = txtDiasDeVisita.Text.Trim();
            m.IdRubro = (int)cboRubro.SelectedValue;

            //=====================================================================
            if (_modo == ModoFormulario.Nuevo) {
                m.IdProveedor = ProveedorControlador.Insert(m);

                var modelView = ProveedorControlador.GetByPrimaryKeyView(m.IdProveedor);

                //modificar el origen de datos
                origenDatos.Add(modelView);

                var bindingList = new MySortableBindingList<ProveedorView>(origenDatos);
                var source = new BindingSource(bindingList, null);
                dgv.DataSource = source;

                //Calcular _rowIndex
                _rowIndex = dgv.Rows.Count - 1;

            } else {

                if (m.Validate().Equals(false))
                    throw new Exception("Errores en validacion!");

                m.IdProveedor = Convert.ToInt32(txtIdProveedor.Text.Trim());
                m.RazonSocial = txtRazonSocial.Text.Trim();
                m.Direccion = txtDireccion.Text.Trim();
                m.Telefono = txtTelefono.Text.Trim();
                m.Notas = txtNotas.Text.Trim();
                m.Email = txtEmail.Text.Trim();
                m.PersonaContacto = txtPersonaContacto.Text.Trim();
                m.HorarioAtencion = txtHorarioAtencion.Text.Trim();
                m.DiasDeVisita = txtDiasDeVisita.Text.Trim();
                m.IdRubro = (int)cboRubro.SelectedValue;

                m.IdProveedor = ProveedorControlador.Update(m);
            }

            // pasar o mantener _modo Edicion
            _modo = ModoFormulario.Edicion;

            //********************
            //meter en subrutina

            dgv.Rows[_rowIndex].Cells[(int)ProveedorView.GridColumn.RazonSocial].Value = m.RazonSocial;
            dgv.Rows[_rowIndex].Cells[(int)ProveedorView.GridColumn.Direccion].Value = m.Direccion;
            dgv.Rows[_rowIndex].Cells[(int)ProveedorView.GridColumn.Telefono].Value = m.Telefono;
            dgv.Rows[_rowIndex].Cells[(int)ProveedorView.GridColumn.Notas].Value = m.Notas;

            //********************

            //TODO: Ver esto, antes sin esto editaba ok. Tengo duda con el agregar uno nuevo.
            dgv.Rows[_rowIndex].Selected = true;
        }


        public void Eliminar()
        {
            if (!Util.ConfirmarEliminar())
                return;

            //crear objeto cascara
            var m = new Proveedor { IdProveedor = Convert.ToInt32(txtIdProveedor.Text.Trim()) };

            var result = ProveedorControlador.Delete(m);

            // Remover visualmente el registro del producto.
            dgv.Rows.Remove(dgv.Rows[_rowIndex]);

            LimpiarControles();
        }


        public void LimpiarControles()
        {
            txtIdProveedor.Clear();
            txtRazonSocial.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtRazonSocial.Clear();
            txtHorarioAtencion.Clear();
            txtPersonaContacto.Clear();
            txtDiasDeVisita.Clear();
            txtNotas.Clear();
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

        void IAbmGeneral.SetControles()
        {
            SetControles();
        }

        public void CargarControles()
        {
            CargarGrilla("");
            CargarRubro();
        }


        private void CargarRubro()
        {
            cboRubro.DropDownStyle = ComboBoxStyle.DropDownList;
            var list = RubroControlador.GetAll();
            cboRubro.DataSource = list;
            cboRubro.ValueMember = "IdRubro";
            cboRubro.DisplayMember = "Descripcion";
        }

        public void CargarGrilla(string searchText)
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

            origenDatos = searchText.Equals("") ?
                ProveedorControlador.GetAll() :
                ProveedorControlador.GetAll_GetByDescripcion(searchText);

            var bindingList = new MySortableBindingList<ProveedorView>(origenDatos);
            var source = new BindingSource(bindingList, null);
            dgv.DataSource = source;

            dgv.AllowUserToResizeRows = false;
            dgv.RowHeadersVisible = false;

        }


        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count <= 0)
                return;

            // esto funciona, pero con el numero de celda, no con ID.
            var id = Convert.ToInt32(dgv.SelectedRows[0].Cells[(int)ProveedorView.GridColumn.IdProveedor].Value.ToString());

            _rowIndex = dgv.SelectedRows[0].Index;

            txtIdProveedor.Text = id.ToString();
        }


        private void tsbSave_Click(object sender, EventArgs e)
        {
            GuardarOInsertar();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            _modo = ModoFormulario.Nuevo;
            txtRazonSocial.Focus();
        }

        private void FrmProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode) {
                case Keys.F3:
                    tsbSearch.Checked = !tsbSearch.Checked;
                    ToggleSearch();
                    break;
                case (Keys.Enter):
                    ExecuteSearch();
                    break;

            }
        }


        private void ToggleSearch()
        {
            tsbSearchTextBox.Visible = !tsbSearchTextBox.Visible;
            tsbSearchPerform.Visible = !tsbSearchPerform.Visible;
            tsbSearchClearAndPerform.Visible = !tsbSearchClearAndPerform.Visible;
            tsbSearchTextBox.Focus();
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

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            ToggleSearch();
        }

        private void txtIdProveedor_TextChanged(object sender, EventArgs e)
        {
            int v;
            var id = int.TryParse(txtIdProveedor.Text.Trim(), out v) ? v : 0;

            var c = ProveedorControlador.GetByPrimaryKey(id);

            txtRazonSocial.Text = c.RazonSocial;
            txtDireccion.Text = c.Direccion;
            txtTelefono.Text = c.Telefono;
            txtEmail.Text = c.Email;
            txtPersonaContacto.Text = c.PersonaContacto;
            txtHorarioAtencion.Text = c.HorarioAtencion;
            txtDiasDeVisita.Text = c.DiasDeVisita;
            txtNotas.Text = c.Notas;

            cboRubro.SelectedValue = c.IdRubro;

        }
    }
}
