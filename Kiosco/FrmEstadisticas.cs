using System;
using System.Collections.Generic;

using System.Windows.Forms;
using Controlador;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using Model;

namespace Kiosco
{
    public partial class FrmEstadisticas : Form
    {
        public FrmEstadisticas()
        {
            InitializeComponent();

            //CargarGrafico();
            /*
            Func<ChartPoint, string> labelPoint = chartPoint =>
    string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Bebidas",
                    Values = new ChartValues<double> {3},
                    PushOut = 15,
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Cigarrillos",
                    Values = new ChartValues<double> {4},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Red Bus",
                    Values = new ChartValues<double> {6},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Golosinas",
                    Values = new ChartValues<double> {2},
                    DataLabels = true,
                    LabelPoint = labelPoint
                }
            };

            pieChart1.LegendLocation = LegendLocation.Bottom;
            */
        }

        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            CargarGrafico();
            CargarCantidadProductos();
        }

        private void CargarCantidadProductos()
        {
            int cantidadProductos = ProductoControlador.GetAll().Count;
            txtCantidadProductos.Text = cantidadProductos.ToString();
        }


        private void CargarGrafico()
        {
            List<RubroView> list = RubroControlador.GetAll();
            var serie = new SeriesCollection();

            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);


            foreach (RubroView r in list)
            {
                var cantidad = ProductoControlador.GetCantidadProducto_ByRubro(r.IdRubro);
                var s = new PieSeries
                {
                    Title = r.Descripcion,
                    Values = new ChartValues<int> {cantidad},
                    DataLabels = true,
                    LabelPoint = labelPoint
                };
                serie.Add(s);
            }

            pieChart1.Series = serie;

            pieChart1.LegendLocation = LegendLocation.Bottom;

        }

    }
}
