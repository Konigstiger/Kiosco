using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Controlador;
using Model;

namespace Kiosco
{
    public partial class FrmVenta : Form, ISelectorCliente
    {
        private const int ColCount = 7;
        private const int MaxLenghtCodeBar = 13;

        public long IdCliente
        {
            get { return Convert.ToInt64(txtIdCliente.Text); }
            set { txtIdCliente.Text = value.ToString(); }
        }


        public enum VentaGridColumn
        {
            Item = 0,
            CodigoBarra = 1,
            Cantidad = 2,
            Descripcion = 3,
            Precio = 4,
            Importe = 5,
            Stock = 6
        }

        private int IndexRowItem = -1;

        public decimal SumImporte;


        public FrmVenta()
        {
            InitializeComponent();
        }


        private void FrmVenta_Load(object sender, EventArgs e)
        {
            SetControles();
            CargarControles();
        }


        private void CargarControles()
        {
            CargarGrilla();
        }


        private void SetControles()
        {
            btnAgregar.Enabled = false;
            btnRemoverItem.Enabled = false;
            btnModificar.Enabled = false;
            txtCodigoBarras.MaxLength = MaxLenghtCodeBar;
            dtpFechaActual.Value = DateTime.Today;
            txtClienteDescripcion.Enabled = false;
            txtIdCliente.Text = "1";
            SetGrid(dgv);
        }


        private static void SetGrid(DataGridView dgv)
        {
            //TODO: Ver si se puede parametrizar dentro de las opciones del programa.
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv.BorderStyle = BorderStyle.None;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersHeight = 20;
            dgv.MultiSelect = false;
            dgv.AllowUserToAddRows = false;

            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;

            //TODO: Ver mas propiedades del DataGridView.
        }


        private void txtCodigoBarras_TextChanged(object sender, EventArgs e)
        {
            VerificarVarios();
        }


        private void VerificarVarios()
        {
            var productoEncontrado = false;
            var productoIngresado = false;

            var codigo = txtCodigoBarras.Text.Trim();
            var p = ProductoControlador.GetByCodigoBarrasView(codigo);

            productoEncontrado = p.IdProducto != -1;

            //esto sirve en ambos casos.
            txtDescripcion.Text = p.Descripcion;
            nudPrecio.Value = p.Precio;
            txtStock.Text = p.Stock.ToString();



            var codigoDevuelto = ComprobarExistenciaItem(codigo);

            productoIngresado = !codigoDevuelto.Equals(-1);

            if (productoEncontrado && productoIngresado) {
                btnAgregar.Enabled = false;
                btnRemoverItem.Enabled = true;
            }

            if (productoIngresado) {
                btnAgregar.Enabled = false;
                IndexRowItem = codigoDevuelto;
            } else {
                btnAgregar.Enabled = productoEncontrado;
            }

            //Cual de las dos dejo?
            btnModificar.Enabled = productoIngresado && productoEncontrado;
            btnModificar.Enabled = productoIngresado;

        }


        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            //TODO: Agregar validaciones. O usar controles que solo admitan numeros.
            var precio = nudPrecio.Value;
            var cantidad = (int)nudCantidad.Value;
            nudImporte.Value = CalcularImporte(cantidad, precio);

            VerificarVarios();
        }


        private static decimal CalcularImporte(int cantidad, decimal precio)
        {
            return cantidad * precio;
        }


        private void CargarGrilla()
        {
            dgv.Columns.Clear();

            var c = new DataGridViewColumn[ColCount];

            for (var i = 0; i < ColCount; i++) {
                c[i] = new DataGridViewTextBoxColumn();
            }

            Util.SetColumn(c[(int)VentaGridColumn.Item], "IdItemVenta", "Item", 0);
            Util.SetColumn(c[(int)VentaGridColumn.CodigoBarra], "CodigoBarras", "Código", 1);
            Util.SetColumn(c[(int)VentaGridColumn.Cantidad], "Cantidad", "Cantidad", 2);
            Util.SetColumn(c[(int)VentaGridColumn.Descripcion], "Descripcion", "Descripción", 3);
            Util.SetColumn(c[(int)VentaGridColumn.Precio], "Precio", "Precio", 4);
            Util.SetColumn(c[(int)VentaGridColumn.Importe], "Importe", "Importe", 5);
            Util.SetColumn(c[(int)VentaGridColumn.Stock], "Stock", "Stock", 6);
            dgv.Columns.AddRange(c);

            Util.SetColumnsReadOnly(dgv);
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CodigoBotonAgregar();
            Util.ReordenarNumeros(dgv);
        }

        private void CodigoBotonAgregar()
        {
            //Agrega a la grilla (ya seteada) un Nuevo registro para ser procesado luego.
            var row = new DataGridViewRow();

            var cell = new DataGridViewTextBoxCell[ColCount];

            for (var i = 0; i < ColCount; i++) {
                cell[i] = new DataGridViewTextBoxCell();
            }

            cell[0].Value = dgv.Rows.Count + 1;
            cell[1].Value = txtCodigoBarras.Text.Trim();
            cell[2].Value = (int)nudCantidad.Value;
            cell[3].Value = txtDescripcion.Text.Trim();
            cell[4].Value = nudPrecio.Value;
            cell[5].Value = nudImporte.Value;
            cell[6].Value = txtStock.Text;

            //Esta validacion permite resaltar los colores, o algun otro detalle
            if (Convert.ToInt32(cell[6].Value) <
                Convert.ToInt32(cell[2].Value))
                cell[6].Style.BackColor = Color.Red;

            row.Cells.AddRange(cell);

            SumImporte += nudImporte.Value;

            dgv.Rows.Add(row);

            nudTotal.Value = CalcularTotal();

            txtCodigoBarras.Clear();
            txtCodigoBarras.Focus();

            btnAgregar.Enabled = false;
            btnRemoverItem.Enabled = true;
        }


        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count <= 0)
                return;

            foreach (DataGridViewRow item in dgv.SelectedRows) {
                var codigoBarras = (string)item.Cells[(int)VentaGridColumn.CodigoBarra].Value;
                var cantidad = (int)item.Cells[(int)VentaGridColumn.Cantidad].Value;
                var importe = (decimal)item.Cells[(int)VentaGridColumn.Importe].Value;

                nudCantidad.Value = cantidad;
                txtCodigoBarras.Text = codigoBarras;
                nudImporte.Value = importe;
            }
        }


        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgv.SelectedRows) {
                dgv.Rows.RemoveAt(item.Index);
            }
            nudTotal.Value = CalcularTotal();
            txtCodigoBarras.Focus();

            Util.ReordenarNumeros(dgv);
        }


        private decimal CalcularTotal()
        {
            SumImporte = 0;

            foreach (DataGridViewRow item in dgv.Rows) {
                SumImporte += (decimal)item.Cells[5].Value;
            }
            return SumImporte;
        }


        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }


        private void LimpiarControles()
        {
            dgv.Rows.Clear();
            txtCodigoBarras.Clear();
            txtDescripcion.Clear();
            nudCantidad.Value = 0;
            nudPrecio.Value = 0;
            nudImporte.Value = 0;
            nudTotal.Value = 0;
            txtCodigoBarras.Focus();

            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnRemoverItem.Enabled = false;
        }


        private void nudPrecio_ValueChanged(object sender, EventArgs e)
        {
            //TODO: Agregar validaciones. O usar controles que solo admitan numeros.
            var precio = nudPrecio.Value;
            var cantidad = (int)nudCantidad.Value;
            nudImporte.Value = CalcularImporte(cantidad, precio);
        }


        /// <summary>
        /// Comprueba si un item, a partir de su codigo de barras esta ingresado en la grilla.
        /// </summary>
        /// <param name="codigoBarras"></param>
        /// <returns>Devuelve el indice del DataRow</returns>
        public int ComprobarExistenciaItem(string codigoBarras)
        {
            const int celIndex = 1;
            var found = false;
            var indexValue = -1;

            foreach (DataGridViewRow dr in dgv.Rows) {
                if (dr.Cells[celIndex].Value.Equals(codigoBarras)) {
                    found = true;
                    indexValue = dr.Index;
                    break;
                }
            }
            return indexValue;
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            var codigoBarras = txtCodigoBarras.Text.Trim();
            IndexRowItem = ComprobarExistenciaItem(codigoBarras);

            //Modifica en la grilla un registro existente.
            var row = dgv.Rows[IndexRowItem];

            row.Cells[2].Value = (int)nudCantidad.Value;
            row.Cells[4].Value = nudPrecio.Value;
            row.Cells[5].Value = nudImporte.Value;

            nudTotal.Value = CalcularTotal();

            txtCodigoBarras.Focus();

            btnRemoverItem.Enabled = true;
        }


        private void txtCodigoBarras_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode) {
                case Keys.Enter:
                    if (btnAgregar.Enabled)
                        CodigoBotonAgregar();
                    break;

                default:
                    break;
            }
        }


        private void nudCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                if (btnAgregar.Enabled)
                    CodigoBotonAgregar();
            }
        }

        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            FrmSeleccionarCliente f = new FrmSeleccionarCliente(this);
            f.Show();
        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {
            //TODO: Validar. Puede usarse un try/catch
            var codigo = Convert.ToInt64(txtIdCliente.Text.Trim());

            var c = ClienteControlador.GetByPrimaryKey(codigo);

            txtClienteDescripcion.Text = c.Descripcion;
            //txtApellido.Text = c.Apellido;
            //txtNombre.Text = c.Nombre;
            //txtDireccion.Text = c.Direccion;
            //txtTelefono.Text = c.Telefono;
            //txtNotas.Text = c.Notas;
        }


        private void btnVender_Click(object sender, EventArgs e)
        {
            VenderProductos();
        }


        private void VenderProductos()
        {
            const int idUsuarioActual = Usuario.IdUsuarioPredeterminado;
            //=====================================================================
            var modelMovimientoCaja = new MovimientoCaja {
                IdMovimientoCaja = -1,
                IdUsuario = idUsuarioActual,
                IdClaseMovimientoCaja = MovimientoCaja.IdClaseMovimientoCajaVenta,
                Monto = nudTotal.Value,
                Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                Hora = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second)
            };

            //=====================================================================

            modelMovimientoCaja.IdMovimientoCaja = MovimientoCajaControlador.Insert(modelMovimientoCaja);

            //TODO: Tratar de validar antes de esto.
            //Todo lo que venga de la pantalla es poco confiable.

            //TODO: Tambien deberia validar si la insercion anterior fue exitosa.
            //El proceso puede ser reversible tambien si se han hecho algunas inserciones y no todas.

            var modelVenta = new Venta {
                IdVenta = -1,
                IdCliente = Convert.ToInt64(txtIdCliente.Text.Trim()),
                Total = modelMovimientoCaja.Monto,
                Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                IdMovimientoCaja = modelMovimientoCaja.IdMovimientoCaja,
                PendientePago = false,
                Notas = ""
            };

            modelVenta.IdVenta = VentaControlador.Insert(modelVenta);

            //=====================================================================

            foreach (DataGridViewRow item in dgv.Rows) {
                var codigoBarras = (string)item.Cells[1].Value;
                var cantidad = (int)item.Cells[2].Value;
                var importe = (decimal)item.Cells[5].Value;

                var mp = new MovimientoProducto {
                    IdMovimientoProducto = -1,
                    IdProducto = ProductoControlador.GetByCodigoBarras(codigoBarras).IdProducto,
                    Cantidad = cantidad,
                    Fecha = modelVenta.Fecha,
                    IdClaseMovimientoProducto = MovimientoProducto.IdClaseMovimientoProductoVenta,
                    IdUsuario = idUsuarioActual
                };
                //A partir del codigobarras recuperar el producto, si no tengo su id en grilla.

                //por cada elemento, persistir en BD.
                mp.IdMovimientoProducto = MovimientoProductoControlador.Insert(mp);

                //=====================================================================
                var vd = new VentaDetalle {
                    IdVentaDetalle = -1,
                    IdVenta = modelVenta.IdVenta,
                    Cantidad = cantidad,
                    Importe = importe,
                    IdMovimientoProducto = mp.IdMovimientoProducto,
                    IdProducto = mp.IdProducto
                };

                vd.IdVentaDetalle = VentaDetalleControlador.Insert(vd);

                //=====================================================================
                var s = new Stock {
                    IdStock = -1,
                    Cantidad = -cantidad,
                    IdDeposito = 1,
                    IdProducto = mp.IdProducto
                };

                s.IdStock = StockControlador.Update(s);

                //notificationControl1.Visible = true;

                //que pase un tiempo, y hacer invisible.

            }

            return;

        }

        private void btnConfirmation_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes) {
                // If 'Yes', do something here.
            } else {
                // If 'No', do something here.
            }
        }
    }
}