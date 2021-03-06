﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Controlador;
using Heimdall.UserControl;
using Model;
using Model.View;

namespace Heimdall
{
    public partial class FrmSeleccionarProductoProveedor : Form
    {
        private bool busquedaActiva = false;
        private ModoFormulario _modo = ModoFormulario.Nuevo;

        private int _rowIndex = 0;
        private const int colCount = 6;

        private List<ProductoProveedorView> origenDatos = null;

        public int IdProveedor { get; set; }

        public ISelectorProducto CallerForm { get; } = null;


        public FrmSeleccionarProductoProveedor(ISelectorProducto callerForm, int idProveedor)
        {
            CallerForm = callerForm;
            //Con este IdProveedor, deberia filtrar por el mismo.
            InitializeComponent();
            IdProveedor = idProveedor;
        }

        private void SetControles()
        {
            Util.SetGrid(dgv, DataGridViewAutoSizeColumnsMode.AllCells);
        }


        public void CargarGrilla(string searchText)
        {
            dgv.Columns.Clear();

            var c = new DataGridViewColumn[colCount];

            for (var i = 0; i < colCount; i++) {
                c[i] = new DataGridViewTextBoxColumn();
            }

            c[(int)ProductoProveedorView.GridColumn.IdProductoProveedor].Width = 0;
            c[(int)ProductoProveedorView.GridColumn.IdProductoProveedor].Visible = false;
            c[(int)ProductoProveedorView.GridColumn.IdProducto].Width = 0;
            c[(int)ProductoProveedorView.GridColumn.IdProducto].Visible = false;
            Util.SetColumn(c[(int)ProductoProveedorView.GridColumn.IdProductoProveedor], "IdProductoProveedor", "IdProductoProveedor", 0);
            Util.SetColumn(c[(int)ProductoProveedorView.GridColumn.IdProducto], "IdProducto", "IdProducto", 1);
            Util.SetColumn(c[(int)ProductoProveedorView.GridColumn.Producto], "Producto", "Producto", 2);
            Util.SetColumn(c[(int)ProductoProveedorView.GridColumn.Proveedor], "Proveedor", "Proveedor", 3);
            Util.SetColumn(c[(int)ProductoProveedorView.GridColumn.PrecioProveedor], "PrecioProveedor", "PrecioProveedor", 4);
            Util.SetColumn(c[5], "PrecioVenta", "PrecioVenta", 5);
            dgv.Columns.AddRange(c);

            Util.SetColumnsReadOnly(dgv);

            //TODO: Pendiente fix para busqueda.
            origenDatos = searchText.Equals("")
                ? ProductoProveedorControlador.GetGrid_GetByIdProveedor(IdProveedor, null)
                : ProductoProveedorControlador.GetGrid_GetByIdProveedor(IdProveedor, searchText);
            
            var bindingList = new MySortableBindingList<ProductoProveedorView>(origenDatos);
            var source = new BindingSource(bindingList, null);
            dgv.DataSource = source;

            dgv.AllowUserToResizeRows = false;
            dgv.RowHeadersVisible = false;
        }



        private void FrmSeleccionarProductoProveedor_Load(object sender, EventArgs e)
        {
            SetControles();
            CargarControles();
            LimpiarControles();
            _modo = ModoFormulario.Edicion;
        }

        private void CargarControles()
        {
            CargarGrilla(tsbSearchTextBox.Text);
        }

        public void LimpiarControles()
        {
            ucProductoEdit1.Clear();
        }


        private void CerrarVentana()
        {
            this.Close();
            this.Dispose();
        }


        private void dgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var messageBoxCs = new StringBuilder();
            messageBoxCs.AppendFormat("{0} = {1}", "ColumnIndex", e.ColumnIndex);
            messageBoxCs.AppendLine();
            messageBoxCs.AppendFormat("{0} = {1}", "RowIndex", e.RowIndex);
            messageBoxCs.AppendLine();

            ucProductoEdit1.Notas = messageBoxCs.ToString();

            //obtener el numero de row, y con eso, obtener los demas datos.

            var idProducto = Convert.ToInt64(dgv.Rows[e.RowIndex].Cells[1].Value);
            ucProductoEdit1.IdProducto = idProducto;

            //Comunicar las ventanas entre si...
            CallerForm.IdProducto = idProducto;

            if (tsbCloseOnSelect.Checked) {
                CerrarVentana();
            }

        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            ToggleSearch();
        }

        private void ToggleSearch()
        {
            tsbSearchTextBox.Visible = !tsbSearchTextBox.Visible;
            tsbSearchPerform.Visible = !tsbSearchPerform.Visible;
            tsbSearchClearAndPerform.Visible = !tsbSearchClearAndPerform.Visible;
            tsbSearchTextBox.Focus();
        }

        private void ucProductoEdit1_StockChanged(object sender, ValueChangedEventArgs e)
        {
            dgv.Rows[_rowIndex].Cells[(int)ProductoView.GridColumn.Stock].Value = e.NewValue;
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

        public void ExecuteSearch()
        {
            CargarGrilla(tsbSearchTextBox.Text);
        }


        private void tsbSearchTextBox_Leave(object sender, EventArgs e)
        {
            busquedaActiva = false;
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            //if (_modo == ModoFormulario.Nuevo) return;

            if (dgv.SelectedRows.Count <= 0)
                return;

            // esto funciona, pero con el numero de celda, no con ID.
            var id = Convert.ToInt64(dgv.SelectedRows[0].Cells[(int)ProductoProveedorView.GridColumn.IdProducto].Value.ToString());

            ucProductoEdit1.IdProducto = id;

            _rowIndex = dgv.SelectedRows[0].Index;

            ucProductoEdit1.IdProducto = id;
        }

        private void FrmSeleccionarProductoProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode) {
                case Keys.F3:
                    tsbSearch.Checked = !tsbSearch.Checked;
                    ToggleSearch();
                    break;
                case (Keys.Enter):
                    if (busquedaActiva)
                        ExecuteSearch();
                    break;

            }
        }

        private void tsbSearchTextBox_Enter(object sender, EventArgs e)
        {
            busquedaActiva = true;
        }
    }
}
