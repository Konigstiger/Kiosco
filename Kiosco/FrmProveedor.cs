using System;
using System.Collections.Generic;
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
            SetGrid(dgv);
        }


        public void ExecuteSearch()
        {
            CargarGrilla(tsbSearchTextBox.Text);
        }


        public void GuardarOInsertar()
        {
            const int idUsuarioActual = Usuario.IdUsuarioPredeterminado;

            var m = new Proveedor
            {
                IdProveedor = -1,
                RazonSocial = ucProveedorEdit1.RazonSocial,
                Direccion = ucProveedorEdit1.Direccion,
                Telefono = ucProveedorEdit1.Telefono,
                Notas = ucProveedorEdit1.Notas,
                Email = ucProveedorEdit1.Email,
                PersonaContacto = ucProveedorEdit1.PersonaContacto,
                HorarioAtencion = ucProveedorEdit1.HorarioAtencion,
                DiasDeVisita = ucProveedorEdit1.DiasDeVisita,
                IdRubro = ucProveedorEdit1.IdRubro
            };

            //=====================================================================
            if (_modo == ModoFormulario.Nuevo)
            {
                m.IdProveedor = ProveedorControlador.Insert(m);

                var modelView = ProveedorControlador.GetByPrimaryKeyView(m.IdProveedor);

                //modificar el origen de datos
                origenDatos.Add(modelView);

                var bindingList = new MySortableBindingList<ProveedorView>(origenDatos);
                var source = new BindingSource(bindingList, null);
                dgv.DataSource = source;

                //Calcular _rowIndex
                _rowIndex = dgv.Rows.Count - 1;

            }
            else
            {

                if (m.Validate().Equals(false))
                    throw new Exception("Errores en validacion!");

                m.IdProveedor = ucProveedorEdit1.IdProveedor;
                m.RazonSocial = ucProveedorEdit1.RazonSocial;
                m.Direccion = ucProveedorEdit1.Direccion;
                m.Telefono = ucProveedorEdit1.Telefono;
                m.Notas = ucProveedorEdit1.Notas;
                m.Email = ucProveedorEdit1.Email;
                m.PersonaContacto = ucProveedorEdit1.PersonaContacto;
                m.HorarioAtencion = ucProveedorEdit1.HorarioAtencion;
                m.DiasDeVisita = ucProveedorEdit1.DiasDeVisita;
                m.IdRubro = ucProveedorEdit1.IdRubro;

                m.IdProveedor = ProveedorControlador.Update(m);
            }

            // pasar o mantener _modo Edicion
            _modo = ModoFormulario.Edicion;

            //********************
            //meter en subrutina

            dgv.Rows[_rowIndex].Cells[(int) ProveedorView.GridColumn.RazonSocial].Value = m.RazonSocial;
            dgv.Rows[_rowIndex].Cells[(int) ProveedorView.GridColumn.Direccion].Value = m.Direccion;
            dgv.Rows[_rowIndex].Cells[(int) ProveedorView.GridColumn.Telefono].Value = m.Telefono;
            dgv.Rows[_rowIndex].Cells[(int) ProveedorView.GridColumn.Notas].Value = m.Notas;

            //********************

            //TODO: Ver esto, antes sin esto editaba ok. Tengo duda con el agregar uno nuevo.
            dgv.Rows[_rowIndex].Selected = true;
        }


        public void Eliminar()
        {
            if (!Util.ConfirmarEliminar())
                return;

            //crear objeto cascara
            var m = new Proveedor {IdProveedor = ucProveedorEdit1.IdProveedor};

            var result = ProveedorControlador.Delete(m);

            // Remover visualmente el registro del producto.
            dgv.Rows.Remove(dgv.Rows[_rowIndex]);

            LimpiarControles();
        }


        public void LimpiarControles()
        {
            ucProveedorEdit1.Clear();
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
        }


        public void CargarGrilla(string searchText)
        {
            dgv.Columns.Clear();

            const int colCount = 5;

            var c = new DataGridViewColumn[colCount];

            for (var i = 0; i < colCount; i++)
            {
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

            origenDatos = searchText.Equals("")
                ? ProveedorControlador.GetAll()
                : ProveedorControlador.GetAll_GetByDescripcion(searchText);

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
            var id =
                Convert.ToInt32(dgv.SelectedRows[0].Cells[(int) ProveedorView.GridColumn.IdProveedor].Value.ToString());

            _rowIndex = dgv.SelectedRows[0].Index;

            ucProveedorEdit1.IdProveedor = id;
        }


        private void tsbSave_Click(object sender, EventArgs e)
        {
            GuardarOInsertar();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            _modo = ModoFormulario.Nuevo;
            ucProveedorEdit1.Focus();
        }

        private void FrmProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
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

        private void dgv_MouseDown(object sender, MouseEventArgs e)
        {
            //TODO: Adaptar esto.
            cms.Items.Clear();
            //cms.Items.Add("Ordenar Ascendente");
            //cms.Items.Add("Ver Proveedores...");


            if (e.Button == MouseButtons.Right)
            {
                var hti = dgv.HitTest(e.X, e.Y);

                //vodoo: perfect
                dgv.ClearSelection();
                dgv.Rows[hti.RowIndex].Selected = true;
                //end vodoo

                switch (hti.Type)
                {
                    case DataGridViewHitTestType.ColumnHeader:
                        // This positions the menu at the mouse's location.
                        //cms.Items.Add("Ordenar Ascendente");
                        //cms.Items.Add("Ordenar Descendente");

                        //cms.Items[0].Visible = true;
                        //cms.Items[1].Visible = false;
                        break;
                    // See if the user right-clicked over the header of the last column.
                    // (ht.ColumnIndex == dgv.Columns.Count - 1)
                    case DataGridViewHitTestType.Cell:
                        //cms.Items[0].Visible = false;
                        //cms.Items[1].Visible = true;
                        var item = cms.Items.Add("Ver Productos..."); // esto puede abrir una pantalla pasando el IdProducto.
                        item.Image = imageList1.Images[0];
                        break;
                }
                cms.Show(MousePosition);
            }
        }

        private void cms_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //abrir la pantalla de ProductoProveedor
            var f = new FrmProductoProveedor(ucProveedorEdit1.IdProveedor);
            f.Show();
        }
    }
}
