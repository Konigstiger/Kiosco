﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Controlador;
using Heimdall.UserControl;
using Model;
using Model.View;

namespace Heimdall
{
    public partial class FrmSeleccionarProducto : Form
    {
        private ModoFormulario _modo = ModoFormulario.Nuevo;

        private int _rowIndex = 0;
        private const int colCount = 9;

        private List<ProductoView> origenDatos = null;



        public FrmSeleccionarProducto()
        {
            InitializeComponent();
        }

        public ISelectorProducto CallerForm { get; } = null;


        public FrmSeleccionarProducto(ISelectorProducto callerForm)
        {
            CallerForm = callerForm;
            InitializeComponent();
        }

        public FrmSeleccionarProducto(ISelectorProducto callerForm, int idProveedor)
        {
            CallerForm = callerForm;
            //Con este IdProveedor, deberia filtrar por el mismo.
            InitializeComponent();
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

            c[(int)ProductoView.GridColumn.IdProducto].Width = 0;
            c[(int)ProductoView.GridColumn.IdProducto].Visible = false; //true;
            Util.SetColumn(c[(int)ProductoView.GridColumn.IdProducto], "IdProducto", "IdProducto", 0);
            Util.SetColumn(c[(int)ProductoView.GridColumn.CodigoBarras], "CodigoBarras", "Código", 1);
            Util.SetColumn(c[(int)ProductoView.GridColumn.Descripcion], "Descripcion", "Descripción", 2);
            Util.SetColumn(c[(int)ProductoView.GridColumn.Capacidad], "Capacidad", "Capacidad", 3);
            Util.SetColumn(c[(int)ProductoView.GridColumn.Precio], "Precio", "Precio", 4);
            Util.SetColumn(c[(int)ProductoView.GridColumn.Ganancia], "Ganancia", "Ganancia", 5);
            Util.SetColumn(c[(int)ProductoView.GridColumn.Marca], "Marca", "Marca", 6);
            Util.SetColumn(c[(int)ProductoView.GridColumn.Stock], "Stock", "Stock", 7);
            Util.SetColumn(c[(int)ProductoView.GridColumn.Rubro], "Rubro", "Rubro", 8);
            dgv.Columns.AddRange(c);

            Util.SetColumnsReadOnly(dgv);

            SetDataSource(searchText);

            dgv.AllowUserToResizeRows = false;
            dgv.RowHeadersVisible = false;
        }

        private void SetDataSource(string searchText)
        {
            var idDeposito = 1; //Deposito en negocio
            //TODO: Revisar que esta logica este bien... y no sea exactamente al reves!
            bool modoArchivo = false;

            origenDatos = searchText.Equals("")
                ? ProductoControlador.GetAllByDeposito_GetAll(idDeposito, modoArchivo)
                : ProductoControlador.GetAllByDeposito_GetByDescripcion(idDeposito, searchText, modoArchivo);

            var bindingList = new MySortableBindingList<ProductoView>(origenDatos);
            var source = new BindingSource(bindingList, null);
            dgv.DataSource = source;
        }


        private void FrmSeleccionarProducto_Load(object sender, EventArgs e)
        {
            SetControles();
            CargarControles();
            LimpiarControles();
            _modo = ModoFormulario.Edicion;

        }

        private void CargarControles()
        {
            CargarGrilla(tsbSearchTextBox.Text);
            //ToggleSearch();
            //tsbSearchTextBox.Focus();
            CargarSearchBoxSuggestions();
        }


        private void CargarSearchBoxSuggestions()
        {
            //obtener origen de datos.
            var list = ProductoControlador.GetAll_AutoComplete();

            var ac = new AutoCompleteStringCollection();
            foreach (var p in list) {
                ac.Add(p.Descripcion);
            }
            //tsbSearchTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tsbSearchTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            tsbSearchTextBox.AutoCompleteCustomSource = ac;
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
            //obtener el numero de row, y con eso, obtener los demas datos.

            var idProducto = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[0].Value);
            ucProductoEdit1.Notas = idProducto.ToString();

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

        private void tsbSearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private bool _ingresandoCodigo = false;

        private void tsbSearchTextBox_Leave(object sender, EventArgs e)
        {
            _ingresandoCodigo = true;
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
            var id = Convert.ToInt64(dgv.SelectedRows[0].Cells[(int)ProductoView.GridColumn.IdProducto].Value.ToString());

            ucProductoEdit1.IdProducto = id;

            _rowIndex = dgv.SelectedRows[0].Index;

            ucProductoEdit1.IdProducto = id;
        }

    }
}
