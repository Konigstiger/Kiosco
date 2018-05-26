using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Controlador;
using Model;
using Model.View;

namespace Heimdall
{
    public partial class FrmProveedor : Form, IAbmGeneral
    {
        private ModoFormulario _modo = ModoFormulario.Nuevo;

        private int _rowIndex = 0;
        private const int ColCount = 6;

        private List<ProveedorView> _origenDatos = null;

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
            Util.SetGrid(dgv, DataGridViewAutoSizeColumnsMode.AllCells);
        }


        public void ExecuteSearch()
        {
            CargarGrilla(tsbSearchTextBox.Text);
        }


        public void GuardarOInsertar()
        {
            var model = ucProveedorEdit1.ToModel();
            //=====================================================================
            if (_modo == ModoFormulario.Nuevo)
            {
                model.IdProveedor = ProveedorControlador.Insert(model);

                var modelView = ProveedorControlador.GetByPrimaryKeyView(model.IdProveedor);

                _origenDatos.Add(modelView);

                var bindingList = new MySortableBindingList<ProveedorView>(_origenDatos);
                var source = new BindingSource(bindingList, null);
                dgv.DataSource = source;

                //Calcular _rowIndex
                _rowIndex = dgv.Rows.Count - 1;
            }
            else
            {
                if (model.Validate().Equals(false))
                    throw new Exception("Errores en validacion!");

                model.IdProveedor = ucProveedorEdit1.IdProveedor;
                model.IdProveedor = ProveedorControlador.Update(model);
            }

            _modo = ModoFormulario.Edicion;

            //********************
            dgv.Rows[_rowIndex].Cells[(int) ProveedorView.GridColumn.RazonSocial].Value = model.RazonSocial;
            dgv.Rows[_rowIndex].Cells[(int) ProveedorView.GridColumn.Direccion].Value = model.Direccion;
            dgv.Rows[_rowIndex].Cells[(int) ProveedorView.GridColumn.Telefono].Value = model.Telefono;
            dgv.Rows[_rowIndex].Cells[(int) ProveedorView.GridColumn.Notas].Value = model.Notas;

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


            var c = new DataGridViewColumn[ColCount];

            for (var i = 0; i < ColCount; i++) {
                c[i] = new DataGridViewTextBoxColumn();
            }

            c[0].Width = 0;
            c[0].Visible = false;
            Util.SetColumn(c[0], "IdProveedor", "IdProveedor", 0);
            Util.SetColumn(c[1], "RazonSocial", "Razon Social", 1);
            Util.SetColumn(c[2], "Direccion", "Direccion", 2);
            Util.SetColumn(c[3], "Telefono", "Telefono", 3);
            Util.SetColumn(c[4], "Estado", "Estado", 4);
            Util.SetColumn(c[5], "Notas", "Notas", 5);
            dgv.Columns.AddRange(c);

            Util.SetColumnsReadOnly(dgv);

            _origenDatos = searchText.Equals("")
                ? ProveedorControlador.GetAll()
                : ProveedorControlador.GetAll_GetByDescripcion(searchText);

            var bindingList = new MySortableBindingList<ProveedorView>(_origenDatos);
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

        private void tsbDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
