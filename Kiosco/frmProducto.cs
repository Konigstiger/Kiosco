using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Controlador;
using Model;

namespace Kiosco
{
    public partial class FrmProducto : Form, IAbmGeneral
    {
        private ModoFormulario _modo = ModoFormulario.Nuevo;

        private int _rowIndex = 0;
        private const int colCount = 8;

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



        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            //if (_modo == ModoFormulario.Nuevo) return;

            if (dgv.SelectedRows.Count <= 0)
                return;

            // esto funciona, pero con el numero de celda, no con ID.
            var id = Convert.ToInt64(dgv.SelectedRows[0].Cells[(int)ProductoView.GridColumn.IdProducto].Value.ToString());

            _rowIndex = dgv.SelectedRows[0].Index;

            ucProductoEdit1.IdProducto = id;
            ucProveedorList1.IdProducto = id;
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
                    if (!_ingresandoCodigo)
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
            const int idUsuarioActual = Usuario.IdUsuarioPredeterminado;

            var m = new Producto {
                IdProducto = -1,
                CodigoBarras = ucProductoEdit1.CodigoBarras,
                Descripcion = ucProductoEdit1.Descripcion,
                PrecioVenta = ucProductoEdit1.PrecioVenta,
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
                    PrecioVenta = ucProductoEdit1.PrecioVenta,
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
            var cc = Math.Round(1 - (m.PrecioCostoPromedio / m.PrecioVenta) * 100, 2);

            dgv.Rows[_rowIndex].Cells[(int)ProductoView.GridColumn.CodigoBarras].Value = m.CodigoBarras;
            dgv.Rows[_rowIndex].Cells[(int)ProductoView.GridColumn.Descripcion].Value = m.Descripcion;
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


        private bool _ingresandoCodigo = false;


        private void FrmProducto_Leave(object sender, EventArgs e)
        {
            _ingresandoCodigo = false;
        }


        private void tsbSearchTextBox_Leave(object sender, EventArgs e)
        {
            _ingresandoCodigo = true;
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            Eliminar();
        }


        public void Eliminar()
        {
            if (!Util.ConfirmarEliminar())
                return;

            //crear objeto cascara
            var m = new Producto { IdProducto = ucProductoEdit1.IdProducto };

            var result = ProductoControlador.Delete(m);

            // Ahora eliminar el registro de Stock.
            var s = new Stock { IdProducto = m.IdProducto };

            StockControlador.Delete(s);

            // Remover visualmente el registro del producto.
            dgv.Rows.Remove(dgv.Rows[_rowIndex]);

            LimpiarControles();
        }


        private void ucProductoEdit1_StockChanged(object sender, UserControl.ValueChangedEventArgs e)
        {
            dgv.Rows[_rowIndex].Cells[(int)ProductoView.GridColumn.Stock].Value = e.NewValue;
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
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
    }
}