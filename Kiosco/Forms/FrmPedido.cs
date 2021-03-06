﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Controlador;
using Model;
using Model.View;

namespace Heimdall
{
    public partial class FrmPedido : Form, IAbmGeneral
    {
        private ModoFormulario _modo = ModoFormulario.Nuevo;

        private int _rowIndex = 0;
        private const int ColCount = 9;

        private List<PedidoView> _origenDatos = null;


        public FrmPedido()
        {
            InitializeComponent();
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            SetControles();
            CargarControles();
            LimpiarControles();
            _modo = ModoFormulario.Edicion;
        }


        public void SetControles()
        {
            Util.SetGrid(dgv, DataGridViewAutoSizeColumnsMode.AllCells);
        }


        public void CargarControles()
        {
            CargarGrilla(tsbSearchTextBox.Text);
        }


        public void CargarGrilla(string searchText)
        {
            dgv.Columns.Clear();

            var c = new DataGridViewColumn[ColCount];

            for (var i = 0; i < ColCount; i++) {
                c[i] = new DataGridViewTextBoxColumn();
            }

            c[(int)PedidoView.GridColumn.IdPedido].Width = 0;
            c[(int)PedidoView.GridColumn.IdPedido].Visible = false;
            Util.SetColumn(c[(int)PedidoView.GridColumn.IdPedido], "IdPedido", "IdPedido", 0);
            Util.SetColumn(c[(int)PedidoView.GridColumn.Proveedor], "Proveedor", "Proveedor", 1);
            Util.SetColumn(c[(int)PedidoView.GridColumn.Descripcion], "Descripcion", "Descripcion", 2);
            Util.SetColumn(c[(int)PedidoView.GridColumn.Fecha], "Fecha", "Fecha", 3);
            Util.SetColumn(c[(int)PedidoView.GridColumn.FechaEntrega], "FechaEntrega", "Fecha Entrega", 4);
            Util.SetColumn(c[(int)PedidoView.GridColumn.Estado], "Estado", "Estado", 5);
            Util.SetColumn(c[(int)PedidoView.GridColumn.Total], "Total", "Total", 6);
            Util.SetColumn(c[(int)PedidoView.GridColumn.IdEstadoPedido], "IdEstadoPedido", "IdEstadoPedido", 7);
            Util.SetColumn(c[(int)PedidoView.GridColumn.Prioridad], "Prioridad", "Prioridad", 8);
            c[(int)PedidoView.GridColumn.IdEstadoPedido].Width = 0;
            c[(int)PedidoView.GridColumn.IdEstadoPedido].Visible = false;

            dgv.Columns.AddRange(c);

            Util.SetColumnsReadOnly(dgv);

            bool modoArchivo = !tsbVerArchivo.Checked;

            _origenDatos = searchText.Equals("") ?
                PedidoControlador.GetAll_GetByParameters("", modoArchivo) :
                PedidoControlador.GetAll_GetByParameters(searchText, modoArchivo);

            var bindingList = new MySortableBindingList<PedidoView>(_origenDatos);
            var source = new BindingSource(bindingList, null);
            dgv.DataSource = source;

            dgv.AllowUserToResizeRows = false;
            dgv.RowHeadersVisible = false;

            AplicarColorSegunEstado();
        }


        private void AplicarColorSegunEstado()
        {
            /*

            //TODO: Hacer una enumeracion al menos, o meter en BD el color o estilo a usar.
            foreach (DataGridViewRow row in dgv.Rows)
            {
                switch (Convert.ToInt32(row.Cells[(int) PedidoView.GridColumn.Total + 1].Value))
                {
                    case 1:
                        //Nuevo
                        row.DefaultCellStyle.BackColor = Color.OrangeRed;
                        break;
                    case 2:
                        //En Preparacion
                        row.DefaultCellStyle.BackColor = Color.Orange;
                        break;
                    case 3:
                        //Pedir
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                        break;
                    case 4:
                        //Aceptado
                        row.DefaultCellStyle.BackColor = Color.Aquamarine;
                        break;
                    case 5:
                        //Pedido
                        row.DefaultCellStyle.BackColor = Color.Aquamarine;
                        break;
                    case 6:
                        //Esperando Entrega
                        row.DefaultCellStyle.BackColor = Color.LightYellow;
                        break;
                    case 7:
                        //Entregado
                        row.DefaultCellStyle.BackColor = Color.LightBlue;
                        break;
                    case 8:
                        //Cancelado
                        row.DefaultCellStyle.BackColor = Color.LightGray;
                        break;
                    case 9:
                        //Rechazado
                        row.DefaultCellStyle.BackColor = Color.IndianRed;
                        break;
                }
            }
            */
        }


        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            //if (_modo == ModoFormulario.Nuevo) return;

            if (dgv.SelectedRows.Count <= 0)
                return;

            // esto funciona, pero con el numero de celda, no con ID.
            var id = Convert.ToInt64(dgv.SelectedRows[0].Cells[(int)PedidoView.GridColumn.IdPedido].Value.ToString());

            _rowIndex = dgv.SelectedRows[0].Index;

            ucPedido1.IdPedido = id;
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

        private void frmPedido_KeyDown(object sender, KeyEventArgs e)
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
            var model = ucPedido1.ToModel();

            //=====================================================================
            if (_modo == ModoFormulario.Nuevo) {
                model.IdPedido = PedidoControlador.Insert(model);

                var modelView = PedidoControlador.GetByPrimaryKeyView(model.IdPedido);

                //modificar el origen de datos
                _origenDatos.Add(modelView);

                var bindingList = new BindingList<PedidoView>(_origenDatos);
                var source = new BindingSource(bindingList, null);
                dgv.DataSource = source;

                //Calcular _rowIndex
                _rowIndex = dgv.Rows.Count - 1;

            } else {
                if (model.Validate().Equals(false))
                    throw new Exception("Errores en validacion!");

                model.IdPedido = ucPedido1.IdPedido;
                model.IdPedido = PedidoControlador.Update(model);
            }

            _modo = ModoFormulario.Edicion;

            //********************
            dgv.Rows[_rowIndex].Cells[(int)PedidoView.GridColumn.Descripcion].Value = model.Descripcion;
            dgv.Rows[_rowIndex].Cells[(int)PedidoView.GridColumn.Proveedor].Value = ucPedido1.Proveedor;
            dgv.Rows[_rowIndex].Cells[(int)PedidoView.GridColumn.Fecha].Value = model.Fecha;
            dgv.Rows[_rowIndex].Cells[(int)PedidoView.GridColumn.FechaEntrega].Value = model.FechaEntrega;
            dgv.Rows[_rowIndex].Cells[(int)PedidoView.GridColumn.Estado].Value = ucPedido1.Estado;
            dgv.Rows[_rowIndex].Cells[(int)PedidoView.GridColumn.Total].Value = model.Total;
            dgv.Rows[_rowIndex].Cells[(int)PedidoView.GridColumn.Prioridad].Value = ucPedido1.Prioridad;
            //TODO: VER el tema entre las entidades y sus Vistas.
            //********************

            //TODO: Ver esto, antes sin esto editaba ok. Tengo duda con el agregar uno nuevo.
            dgv.Rows[_rowIndex].Selected = true;

            AplicarColorSegunEstado();
        }


        private void tsbNew_Click(object sender, EventArgs e)
        {
            BotonNuevo();
        }


        private void BotonNuevo()
        {
            LimpiarControles();
            _modo = ModoFormulario.Nuevo;
            ucPedido1.Focus(); //TODO: Pendiente que pase este evento a su control.
        }


        public void LimpiarControles()
        {
            ucPedido1.Clear();
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


            if (e.Button == MouseButtons.Right) {
                var hti = dgv.HitTest(e.X, e.Y);



                switch (hti.Type) {
                    case DataGridViewHitTestType.ColumnHeader:
                        break;
                    // See if the user right-clicked over the header of the last column.
                    // (ht.ColumnIndex == dgv.Columns.Count - 1)
                    case DataGridViewHitTestType.Cell:
                        //vodoo: perfect
                        dgv.ClearSelection();
                        dgv.Rows[hti.RowIndex].Selected = true;
                        //end vodoo

                        //cms.Items[0].Visible = false;
                        //cms.Items[1].Visible = true;
                        var item = cms.Items.Add("Ver Detalles del Pedido...");
                        item.Image = imageList1.Images[0];
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
            var m = new Pedido { IdPedido = ucPedido1.IdPedido };

            var result = PedidoControlador.Delete(m);

            // Remover visualmente el registro del Pedido.
            dgv.Rows.Remove(dgv.Rows[_rowIndex]);

            LimpiarControles();
        }

        private void cms_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            {
                var f = new FrmPedidoDetalle(ucPedido1.IdPedido);
                f.Show();
            }
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

        private void dgv_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //asumo que cuando se lance este evento, es después del ordenamiento...
            AplicarColorSegunEstado();
        }

        private void tsbVerArchivo_Click(object sender, EventArgs e)
        {
            ExecuteSearch();
        }
    }
}
