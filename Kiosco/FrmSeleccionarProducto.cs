﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Controlador;
using Model;

namespace Kiosco
{
    public partial class FrmSeleccionarProducto : Form
    {
        private ModoFormulario _modo = ModoFormulario.Nuevo;

        private int _rowIndex = 0;
        private const int colCount = 8;

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
            InitializeComponent();
        }


        private void SetControles()
        {
            this.KeyPreview = true;
            txtIdProducto.Visible = false;
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
            Util.SetColumn(c[(int)ProductoView.GridColumn.Precio], "Precio", "Precio", 3);
            Util.SetColumn(c[(int)ProductoView.GridColumn.Ganancia], "Ganancia", "Ganancia", 4);
            Util.SetColumn(c[(int)ProductoView.GridColumn.Marca], "Marca", "Marca", 5);
            Util.SetColumn(c[(int)ProductoView.GridColumn.Stock], "Stock", "Stock", 6);
            Util.SetColumn(c[(int)ProductoView.GridColumn.Rubro], "Rubro", "Rubro", 7);
            dgv.Columns.AddRange(c);


            Util.SetColumnsReadOnly(dgv);

            var idDeposito = 1; //Deposito en negocio

            origenDatos = searchText.Equals("") ?
                ProductoControlador.GetAllByDeposito_GetAll(idDeposito) :
                ProductoControlador.GetAllByDeposito_GetByDescripcion(idDeposito, searchText);

            var bindingList = new MySortableBindingList<ProductoView>(origenDatos);
            var source = new BindingSource(bindingList, null);
            dgv.DataSource = source;



            dgv.AllowUserToResizeRows = false;
            dgv.RowHeadersVisible = false;


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
            //CargarRubro();
            //CargarUnidad();
            CargarGrilla(tsbSearchTextBox.Text);
        }

        public void LimpiarControles()
        {
            txtCodigoBarras.Clear();
            txtDescripcion.Clear();
            txtNotas.Clear();
            nudPrecio.Value = 0;
            nudPrecioCosto.Value = 0;
            nudStockMaximo.Value = 0;
            nudStockMinimo.Value = 0;
            chkSoloAdultos.Checked = false;
            txtNotas.Clear();

            //Para estos controles, se puede poner un valor default.
            //No obstante, es util para el operador, si va a cargar productos similares.
            //cboRubro
            //cboUnidad
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

            txtNotas.Text = messageBoxCs.ToString();

            //obtener el numero de row, y con eso, obtener los demas datos.

            var idProducto = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[0].Value);
            txtNotas.Text = idProducto.ToString();

            //Comunicar las ventanas entre si...
            CallerForm.IdProducto = idProducto;

            CerrarVentana();

        }
    }
}
