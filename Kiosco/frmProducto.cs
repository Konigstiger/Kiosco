﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Controlador;
using Heimdall.UserControl;
using Model;

namespace Heimdall
{
    public partial class FrmProducto : Form, IAbmGeneral
    {
        private ModoFormulario _modo = ModoFormulario.Nuevo;

        private int _rowIndex = 0;
        private const int colCount = 9;
        private bool busquedaActiva = false;

        private List<ProductoView> origenDatos = null;


        public FrmProducto()
        {
            InitializeComponent();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            SetControles();
            CargarControles();
            LimpiarControles();
            _modo = ModoFormulario.Edicion;
        }



        public void SetControles()
        {
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
        }


        public void CargarControles()
        {
            CargarGrilla(tsbSearchTextBox.Text);
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


            if (Program.UsuarioConectado.EsAdmin == false) {
                c[(int)ProductoView.GridColumn.Ganancia].Visible = false;
            }

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



        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            //if (_modo == ModoFormulario.Nuevo) return;

            if (dgv.SelectedRows.Count <= 0)
                return;

            // esto funciona, pero con el numero de celda, no con ID.
            var id = Convert.ToInt64(dgv.SelectedRows[0].Cells[(int)ProductoView.GridColumn.IdProducto].Value.ToString());

            _rowIndex = dgv.SelectedRows[0].Index;

            ucProductoEdit1.IdProducto = id;
            _ucProductoProveedorList1.IdProducto = id;
        }


        private void tsbSearchPerform_Click(object sender, EventArgs e)
        {
            ExecuteSearch();
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

        public void ExecuteSearch()
        {
            CargarGrilla(tsbSearchTextBox.Text);
        }

        private void frmProducto_KeyDown(object sender, KeyEventArgs e)
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

        private void tsbSave_Click(object sender, EventArgs e)
        {
            GuardarOInsertar();
        }


        public void GuardarOInsertar()
        {
            var idUsuarioActual = Program.UsuarioConectado.IdUsuario;

            var m = new Producto {
                IdProducto = -1,
                CodigoBarras = ucProductoEdit1.CodigoBarras,
                Descripcion = ucProductoEdit1.Descripcion,
                Capacidad = ucProductoEdit1.Capacidad,
                PrecioVenta = ucProductoEdit1.PrecioVenta,
                PrecioVentaPremium = ucProductoEdit1.PrecioVentaPremium,
                StockMinimo = ucProductoEdit1.StockMinimo,
                StockMaximo = ucProductoEdit1.StockMaximo,
                SoloAdultos = ucProductoEdit1.SoloAdultos,
                PrecioCostoPromedio = ucProductoEdit1.PrecioCosto,
                IdMarca = ucProductoEdit1.IdMarca,
                IdRubro = ucProductoEdit1.IdRubro,
                IdUnidad = ucProductoEdit1.IdUnidad,
                Notas = ucProductoEdit1.Notas
            };
            //=====================================================================
            if (_modo == ModoFormulario.Nuevo) {
                m.IdProducto = ProductoControlador.Insert(m);

                //Agregar su stock, aun en cero, para que aparezca en la grilla...
                var stockObj = new Stock {
                    IdStock = -1,
                    IdProducto = m.IdProducto,
                    Cantidad = ucProductoEdit1.StockActual,
                    IdDeposito = 1
                };

                var idStock = StockControlador.Insert(stockObj);

                var modelView = ProductoControlador.GetByPrimaryKeyView(m.IdProducto);

                //modificar el origen de datos
                origenDatos.Add(modelView);

                var bindingList = new BindingList<ProductoView>(origenDatos);
                var source = new BindingSource(bindingList, null);
                dgv.DataSource = source;

                //Calcular _rowIndex
                _rowIndex = dgv.Rows.Count - 1;

            } else {
                //TODO: Puede usarse m.Validate como validacion ya encapsulada de modelo integro.

                if (m.Validate().Equals(false))
                    throw new Exception("Errores en validacion!");

                var productoNuevo = new Producto {
                    IdProducto = ucProductoEdit1.IdProducto,
                    CodigoBarras = ucProductoEdit1.CodigoBarras,
                    Descripcion = ucProductoEdit1.Descripcion,
                    Capacidad = ucProductoEdit1.Capacidad,
                    PrecioVenta = ucProductoEdit1.PrecioVenta,
                    PrecioVentaPremium = ucProductoEdit1.PrecioVentaPremium,
                    StockMinimo = ucProductoEdit1.StockMinimo,
                    StockMaximo = ucProductoEdit1.StockMaximo,
                    SoloAdultos = ucProductoEdit1.SoloAdultos,
                    PrecioCostoPromedio = ucProductoEdit1.PrecioCosto,
                    IdMarca = ucProductoEdit1.IdMarca,
                    IdRubro = ucProductoEdit1.IdRubro,
                    IdUnidad = ucProductoEdit1.IdUnidad,
                    Notas = ucProductoEdit1.Notas
                };

                m.IdProducto = ProductoControlador.Update(productoNuevo);


            }

            // pasar o mantener _modo Edicion
            _modo = ModoFormulario.Edicion;

            //********************
            //TODO: Revisar esto!
            var cc = Math.Round((1 - (m.PrecioCostoPromedio / m.PrecioVenta)) * 100, 2);

            dgv.Rows[_rowIndex].Cells[(int)ProductoView.GridColumn.CodigoBarras].Value = m.CodigoBarras;
            dgv.Rows[_rowIndex].Cells[(int)ProductoView.GridColumn.Descripcion].Value = m.Descripcion;
            dgv.Rows[_rowIndex].Cells[(int)ProductoView.GridColumn.Capacidad].Value = m.Capacidad;
            dgv.Rows[_rowIndex].Cells[(int)ProductoView.GridColumn.Precio].Value = m.PrecioVenta.ToString("N");
            dgv.Rows[_rowIndex].Cells[(int)ProductoView.GridColumn.Ganancia].Value = cc.ToString() + " %";

            //TODO: Ver algo de esto, temas de alineacion y tipos de datos de las columnas. EyeCandy
            dgv.Rows[_rowIndex].Cells[(int)ProductoView.GridColumn.Marca].Value = ucProductoEdit1.Marca;
            dgv.Rows[_rowIndex].Cells[(int)ProductoView.GridColumn.Rubro].Value = ucProductoEdit1.Rubro;
            //********************

            //TODO: Ver esto, antes sin esto editaba ok. Tengo duda con el agregar uno nuevo.
            dgv.Rows[_rowIndex].Selected = true;
        }


        private void tsbNew_Click(object sender, EventArgs e)
        {
            BotonNuevo();
        }

        private void BotonNuevo()
        {
            LimpiarControles();
            _modo = ModoFormulario.Nuevo;
            ucProductoEdit1.Focus(); //TODO: Pendiente que pase este evento a su control.
        }


        public void LimpiarControles()
        {
            ucProductoEdit1.Clear();
        }

        private void tsbSearchClearAndPerform_Click(object sender, EventArgs e)
        {
            tsbSearchTextBox.Clear();
            tsbSearchTextBox.Focus();
            ExecuteSearch();
        }


        private void dgv_MouseDown(object sender, MouseEventArgs e)
        {
            //TODO: Adaptar esto.
            cms.Items.Clear();
            //cms.Items.Add("Ordenar Ascendente");
            //cms.Items.Add("Ver Proveedores...");


            if (e.Button == MouseButtons.Right) {
                var hti = dgv.HitTest(e.X, e.Y);
                //vodoo: perfect
                dgv.ClearSelection();
                dgv.Rows[hti.RowIndex].Selected = true;
                //end vodoo


                switch (hti.Type) {
                    case DataGridViewHitTestType.ColumnHeader:
                        // This positions the menu at the mouse's location.
                        cms.Items.Add("Ordenar Ascendente");
                        cms.Items.Add("Ordenar Descendente");

                        //cms.Items[0].Visible = true;
                        //cms.Items[1].Visible = false;
                        break;
                    // See if the user right-clicked over the header of the last column.
                    // (ht.ColumnIndex == dgv.Columns.Count - 1)
                    case DataGridViewHitTestType.Cell:
                        //cms.Items[0].Visible = false;
                        //cms.Items[1].Visible = true;
                        cms.Items.Add("Ver Proveedores..."); // esto puede abrir una pantalla pasando el IdProducto.
                        cms.Items.Add("Ver Detalles...");
                        break;

                }
                cms.Show(MousePosition);

            }
        }

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }


        private void FrmProducto_Leave(object sender, EventArgs e)
        {

        }


        private void tsbSearchTextBox_Leave(object sender, EventArgs e)
        {
            busquedaActiva = false;
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            Eliminar();
        }


        public void Eliminar()
        {
            //TODO: Hay algun bug al eliminar en esta subrutina. Ejecutar tests y verificar.
            //Tener presente que se deberia usar Rhino Mocks para hacer pruebas mas avanzadas.

            if (!Util.ConfirmarEliminar())
                return;

            var m = new Producto { IdProducto = ucProductoEdit1.IdProducto };

            ProductoControlador.Delete(m);

            // Ahora eliminar el registro de Stock.
            var s = new Stock { IdProducto = m.IdProducto };

            StockControlador.Delete(s);

            // Remover visualmente el registro del producto.
            dgv.Rows.Remove(dgv.Rows[_rowIndex]);

            LimpiarControles();
        }


        private void ucProductoEdit1_StockChanged(object sender, ValueChangedEventArgs e)
        {
            dgv.Rows[_rowIndex].Cells[(int)ProductoView.GridColumn.Stock].Value = e.NewValue;
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //TODO: Aqui puedo incluir el F3 y el Enter?
            switch (keyData) {
                case (Keys.Control | Keys.G):
                    GuardarOInsertar();
                    break;
                case (Keys.Control | Keys.N):
                    BotonNuevo();
                    break;
                case (Keys.Control | Keys.D):
                    Eliminar();
                    break;
                default:
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void tsbSearchTextBox_Enter(object sender, EventArgs e)
        {
            busquedaActiva = true;
        }

        private void _ucProductoProveedorList1_ProductoProveedorChanged(object sender, ValueChangedEventArgs e)
        {
            //? si entra aqui, deberia hacer bind debajo, o bien, tomar todas las propiedades del control, mas eficiente, y copiarlas.
            var idproductoproveedor = _ucProductoProveedorList1.IdProductoProveedor;
            ucProductoProveedorEdit1.IdProductoProveedor = (long) idproductoproveedor;
            ucProductoProveedorEdit1.Modo = ModoFormulario.Edicion;
        }

        private void _ucProductoProveedorList1_ProductoChanged(object sender, ValueChangedEventArgs e)
        {
            //?
        }

        private void ucAbmToolBar2_ButtonClickUpdate(object sender, EventArgs e)
        {
            //primera fase: guardar lo que esté seleccionado.
            GuardarOInsertarProductoProveedor();
            //recargar list
            _ucProductoProveedorList1.IdProducto = ucProductoProveedorEdit1.IdProducto;


        }

        private void GuardarOInsertarProductoProveedor()
        {
            // todo lo que esta aqui debajo es para tomar de referencia.
            var xx = new ProductoProveedor();
            xx.IdProductoProveedor = ucProductoProveedorEdit1.IdProductoProveedor;
            xx.IdProducto = ucProductoProveedorEdit1.IdProducto;
            xx.IdProveedor = ucProductoProveedorEdit1.IdProveedor;
            xx.FechaModificacion = ucProductoProveedorEdit1.Fecha;
            xx.Notas = ucProductoProveedorEdit1.Notas;
            xx.PrecioProveedor = ucProductoProveedorEdit1.Precio;
            xx.IdUnidad = 1;    //pendiente

            //=====================================================================
            if (ucProductoProveedorEdit1.Modo == ModoFormulario.Nuevo) {
                xx.IdProductoProveedor = ProductoProveedorControlador.Insert(xx);

                //var modelView = ProductoProveedorControlador.GetByPrimaryKeyView(xx.IdProductoProveedor);

            } else {
                //TODO: Puede usarse m.Validate como validacion ya encapsulada de modelo integro.

                if (xx.Validate().Equals(false))
                    throw new Exception("Errores en validacion!");

                var productoProveedorNuevo = new ProductoProveedor();
                productoProveedorNuevo.IdProductoProveedor = ucProductoProveedorEdit1.IdProductoProveedor;
                productoProveedorNuevo.IdProducto = ucProductoProveedorEdit1.IdProducto;
                productoProveedorNuevo.IdProveedor = ucProductoProveedorEdit1.IdProveedor;
                productoProveedorNuevo.FechaModificacion = ucProductoProveedorEdit1.Fecha;
                productoProveedorNuevo.Notas = ucProductoProveedorEdit1.Notas;
                productoProveedorNuevo.PrecioProveedor = ucProductoProveedorEdit1.Precio;
                productoProveedorNuevo.IdUnidad = 1; //pendiente


                xx.IdProducto = ProductoProveedorControlador.Update(productoProveedorNuevo);
            }

            // pasar o mantener _modo Edicion
            ucProductoProveedorEdit1.Modo = ModoFormulario.Edicion;


        }

        private void ucAbmToolBar2_ButtonClickNew(object sender, EventArgs e)
        {
            ucProductoProveedorEdit1.Modo = ModoFormulario.Nuevo;
            //test: esto es para que tenga el codigo de producto que realmente va,
            // y no uno de un producto interior. Es un bug.
            ucProductoProveedorEdit1.IdProducto = ucProductoEdit1.IdProducto;
        }

        private void ucAbmToolBar2_ButtonClickDelete(object sender, EventArgs e)
        {
            EliminarProductoProveedor();
        }

        private void EliminarProductoProveedor()
        {
            if (!Util.ConfirmarEliminar())
                return;

            var m = new ProductoProveedor { IdProductoProveedor = ucProductoProveedorEdit1.IdProductoProveedor };

            var result = ProductoProveedorControlador.Delete(m);

            // esto deberia ocasionar un refresh limpio.
            _ucProductoProveedorList1.CargarProductoProveedorList(ucProductoProveedorEdit1.IdProducto);
        }
    }
}