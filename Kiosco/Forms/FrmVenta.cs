﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Controlador;
using Model.View;

namespace Heimdall
{
    public partial class FrmVenta : Form, IAbmGeneral
    {
        private ModoFormulario _modo = ModoFormulario.Nuevo;

        private int _rowIndex = 0;
        private const int colCount = 7;

        private List<VentaView> origenDatos = null;

        public FrmVenta()
        {
            InitializeComponent();
        }

        private void FrmVenta_Load(object sender, EventArgs e)
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
            ucIntervaloFechaEdit1.FechaInicio = DateTime.Today;
            ucIntervaloFechaEdit1.FechaFin = DateTime.Today;
            CargarGrilla(tsbSearchTextBox.Text);
            txtGanancias.Text = CalcularGanancias().ToString();
            txtVentas.Text = CalcularVentas().ToString();
        }


        public void CargarGrilla(string searchText)
        {
            dgv.Columns.Clear();

            var c = new DataGridViewColumn[colCount];

            for (var i = 0; i < colCount; i++) {
                c[i] = new DataGridViewTextBoxColumn();
            }


            c[(int)VentaView.GridColumn.IdVenta].Width = 0;
            c[(int)VentaView.GridColumn.IdVenta].Visible = false; //true;
            Util.SetColumn(c[(int)VentaView.GridColumn.IdVenta], "IdVenta", "IdVenta", 0);
            Util.SetColumn(c[(int)VentaView.GridColumn.Cliente], "Cliente", "Cliente", 1);
            Util.SetColumn(c[(int)VentaView.GridColumn.Fecha], "Fecha", "Fecha", 2);
            Util.SetColumn(c[(int)VentaView.GridColumn.Hora], "Hora", "Hora", 3);
            Util.SetColumn(c[(int)VentaView.GridColumn.Total], "Total", "Total", 4);
            Util.SetColumn(c[(int)VentaView.GridColumn.Ganancia], "Ganancia", "Ganancia", 5);
            Util.SetColumn(c[(int)VentaView.GridColumn.Notas], "Notas", "Notas", 6);
            dgv.Columns.AddRange(c);


            Util.SetColumnsReadOnly(dgv);

            var idDeposito = 1; //Deposito en negocio

            origenDatos = VentaControlador.GetAll_ByDateInterval(
                ucIntervaloFechaEdit1.FechaInicio,
                ucIntervaloFechaEdit1.FechaFin);

            var bindingList = new MySortableBindingList<VentaView>(origenDatos);
            var source = new BindingSource(bindingList, null);
            dgv.DataSource = source;

            dgv.AllowUserToResizeRows = false;
            dgv.RowHeadersVisible = false;
        }

        public void ExecuteSearch()
        {
            throw new NotImplementedException();
        }

        public void GuardarOInsertar()
        {
            throw new NotImplementedException();
        }

        public void Eliminar()
        {
            throw new NotImplementedException();
        }

        public void LimpiarControles()
        {
            //TODO: Pendiente de limpieza de controles.
        }

        private void ucIntervaloFechaEdit1_FiltrarAction(object sender, EventArgs e)
        {
            //recuperar los datos y mostrar segun las fechas especificadas.
            CargarGrilla("");
            txtGanancias.Text = CalcularGanancias().ToString();
            txtVentas.Text = CalcularVentas().ToString();

        }

        private decimal CalcularGanancias()
        {
            decimal SumImporte = 0;

            foreach (DataGridViewRow item in dgv.Rows) {
                SumImporte += (decimal)item.Cells[(int)VentaView.GridColumn.Ganancia].Value;
            }
            return SumImporte;
        }


        private decimal CalcularVentas()
        {
            decimal SumImporte = 0;

            foreach (DataGridViewRow item in dgv.Rows) {
                SumImporte += (decimal)item.Cells[(int)VentaView.GridColumn.Total].Value;
            }
            return SumImporte;
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            var f = new FrmRegistrarVenta();
            f.Show();
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            //if (_modo == ModoFormulario.Nuevo) return;

            if (dgv.SelectedRows.Count <= 0)
                return;

            // esto funciona, pero con el numero de celda, no con ID.
            var id = Convert.ToInt64(dgv.SelectedRows[0].Cells[(int)VentaView.GridColumn.IdVenta].Value.ToString());

            _rowIndex = dgv.SelectedRows[0].Index;

            ucVentaDetalleList1.IdVenta = id;
        }
    }
}
