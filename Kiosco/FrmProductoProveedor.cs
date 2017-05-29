﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Controlador;
using Model;

namespace Kiosco
{
    public partial class FrmProductoProveedor : Form, IAbmGeneral
    {
        private ModoFormulario _modo = ModoFormulario.Nuevo;

        private int _rowIndex = 0;
        private const int colCount = 5;

        private List<ProductoProveedorView> origenDatos = null;

        public FrmProductoProveedor()
        {
            InitializeComponent();
        }

        private void txtIdProductoProveedor_TextChanged(object sender, EventArgs e)
        {
            //TODO: Ir a la tabla y recuperar el registro de ProductoProveedor y actualizar en cascada.
            var id = Convert.ToInt64(txtIdProductoProveedor.Text.Trim());

            var c = ProductoProveedorControlador.GetByPrimaryKey(id);

            ucProductoView1.IdProducto = c.IdProducto;
            nudPrecioCompra.Value = c.PrecioProveedor;



        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            _modo = ModoFormulario.Nuevo;
            //txtDescripcion.Focus();
        }


        public void SetControles()
        {
            SetGrid(dgv);
            tsbSave.Enabled = false;
            txtIdProductoProveedor.Visible = false;
            nudPrecioCompra.Increment = Convert.ToDecimal("0,25");
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


            c[(int)ProductoProveedorView.GridColumn.IdProductoProveedor].Width = 0;
            c[(int)ProductoProveedorView.GridColumn.IdProductoProveedor].Visible = false; //true;
            Util.SetColumn(c[(int)ProductoProveedorView.GridColumn.IdProductoProveedor], "IdProductoProveedor", "IdProductoProveedor", 0);
            Util.SetColumn(c[(int)ProductoProveedorView.GridColumn.Producto], "Producto", "Producto", 1);
            Util.SetColumn(c[(int)ProductoProveedorView.GridColumn.Proveedor], "Proveedor", "Proveedor", 2);
            Util.SetColumn(c[(int)ProductoProveedorView.GridColumn.PrecioProveedor], "PrecioProveedor", "Precio Proveedor", 3);
            Util.SetColumn(c[(int)ProductoProveedorView.GridColumn.PrecioVenta], "PrecioVenta", "Precio Venta", 4);
            dgv.Columns.AddRange(c);


            Util.SetColumnsReadOnly(dgv);

            origenDatos = searchText.Equals("") ?
                ProductoProveedorControlador.GetGrid() :
                ProductoProveedorControlador.GetGrid_GetByDescripcion(searchText);  //TODO: Pendiente el search

            var bindingList = new MySortableBindingList<ProductoProveedorView>(origenDatos);
            var source = new BindingSource(bindingList, null);
            dgv.DataSource = source;

            dgv.AllowUserToResizeRows = false;
            dgv.RowHeadersVisible = false;

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

            //TODO: Ver mas propiedades del DataGridView.
        }


        public void ExecuteSearch()
        {
            CargarGrilla(tsbSearchTextBox.Text);
        }


        public void GuardarOInsertar()
        {
            const int idUsuarioActual = Usuario.IdUsuarioPredeterminado;

            var m = new ProductoProveedor {
                IdProductoProveedor = -1,
                IdProveedor = ucProveedorView1.IdProveedor,
                IdProducto = ucProductoView1.IdProducto,
                PrecioProveedor = nudPrecioCompra.Value,
                IdUnidad = 1
            };

            //=====================================================================
            if (_modo == ModoFormulario.Nuevo) {
                m.IdProductoProveedor = ProductoProveedorControlador.Insert(m);

                var modelView = ProductoProveedorControlador.GetByPrimaryKeyView(m.IdProductoProveedor);

                origenDatos.Add(modelView);

                var bindingList = new BindingList<ProductoProveedorView>(origenDatos);
                var source = new BindingSource(bindingList, null);
                dgv.DataSource = source;

                _rowIndex = dgv.Rows.Count - 1;

            } else {
                //TODO: Puede usarse m.Validate como validacion ya encapsulada de modelo integro.

                if (m.Validate().Equals(false))
                    throw new Exception("Errores en validacion!");

                var ProductoProveedorNuevo = new ProductoProveedor {
                    IdProductoProveedor = Convert.ToInt64(txtIdProductoProveedor.Text.Trim()),
                    IdProveedor = ucProveedorView1.IdProveedor,
                    IdProducto = ucProductoView1.IdProducto,
                    PrecioProveedor = nudPrecioCompra.Value,
                    IdUnidad = 1
                };

                ProductoProveedorNuevo.IdProductoProveedor = ProductoProveedorControlador.Update(ProductoProveedorNuevo);

                //Usar una View?

            }

            // pasar o mantener _modo Edicion
            _modo = ModoFormulario.Edicion;

            //********************
            //meter en subrutina
            //dgv.Rows[_rowIndex].Cells[(int)ProductoProveedorGridColumn.Producto].Value = m.;
            //dgv.Rows[_rowIndex].Cells[(int)ProductoProveedorGridColumn.Proveedor].Value = m.Notas;
            //********************




            //TODO: Ver esto, antes sin esto editaba ok. Tengo duda con el agregar uno nuevo.
            dgv.Rows[_rowIndex].Selected = true;
        }





        public void Eliminar()
        {
        }

        void IAbmGeneral.LimpiarControles()
        {
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            nudPrecioCompra.Value = 0;
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            GuardarOInsertar();
        }

        private void FrmProductoProveedor_Load(object sender, EventArgs e)
        {
            SetControles();
            CargarControles();
            LimpiarControles();
            _modo = ModoFormulario.Edicion;
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            //if (_modo == ModoFormulario.Nuevo) return;

            if (dgv.SelectedRows.Count <= 0)
                return;

            // esto funciona, pero con el numero de celda, no con ID.
            var id = Convert.ToInt64(dgv.SelectedRows[0].Cells[(int)ProductoProveedorView.GridColumn.IdProductoProveedor].Value.ToString());

            _rowIndex = dgv.SelectedRows[0].Index;

            txtIdProductoProveedor.Text = id.ToString();
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

        private void nudPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('.') || e.KeyChar.Equals(',')) {
                e.KeyChar = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
            }
        }

        private void ucProveedorView1_ValueChanged(object sender, UserControl.ValueChangedEventArgs e)
        {
            //tener cuidado con esto.
            tsbSave.Enabled = true;

            //Ha cambiado el proveedor elegido, cargar la grilla con sus productos ofrecidos...
            var idProveedor = ucProveedorView1.IdProveedor;

            dgv.Columns.Clear();

            var c = new DataGridViewColumn[colCount];

            for (var i = 0; i < colCount; i++) {
                c[i] = new DataGridViewTextBoxColumn();
            }


            c[(int)ProductoProveedorView.GridColumn.IdProductoProveedor].Width = 0;
            c[(int)ProductoProveedorView.GridColumn.IdProductoProveedor].Visible = false; //true;
            Util.SetColumn(c[(int)ProductoProveedorView.GridColumn.IdProductoProveedor], "IdProductoProveedor", "IdProductoProveedor", 0);
            Util.SetColumn(c[(int)ProductoProveedorView.GridColumn.Producto], "Producto", "Producto", 1);
            Util.SetColumn(c[(int)ProductoProveedorView.GridColumn.Proveedor], "Proveedor", "Proveedor", 2);
            Util.SetColumn(c[(int)ProductoProveedorView.GridColumn.PrecioProveedor], "PrecioProveedor", "Precio Proveedor", 3);
            Util.SetColumn(c[(int)ProductoProveedorView.GridColumn.PrecioVenta], "PrecioVenta", "Precio Venta", 4);
            dgv.Columns.AddRange(c);


            Util.SetColumnsReadOnly(dgv);

            origenDatos = ProductoProveedorControlador.GetGrid_GetByIdProveedor(idProveedor, "");

            var bindingList = new MySortableBindingList<ProductoProveedorView>(origenDatos);
            var source = new BindingSource(bindingList, null);
            dgv.DataSource = source;

            dgv.AllowUserToResizeRows = false;
            dgv.RowHeadersVisible = false;

        }

        private void ucProveedorView1_Load(object sender, EventArgs e)
        {

        }
    }
}
