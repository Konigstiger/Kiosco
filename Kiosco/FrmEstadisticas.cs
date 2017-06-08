using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Media;
using Controlador;
using LiveCharts;
using System.Windows.Media;
using LiveCharts.Wpf;
using Model;
//using Brushes = System.Drawing.Brushes;

namespace Kiosco
{
    public partial class FrmEstadisticas : Form
    {
        public FrmEstadisticas()
        {
            InitializeComponent();
        }


        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            CargarGrafico();
            CargarCantidadProductos();
            CargarGrafico2();
        }


        private void CargarGrafico2()
        {
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Series 1",
                    Values = new ChartValues<double> {4, 6, 5, 2, 7}
                },
                new LineSeries
                {
                    Title = "Series 2",
                    Values = new ChartValues<double> {6, 7, 3, 4, 6},
                    PointGeometry = null
                }
                //,
                //new LineSeries
                //{
                //    Title = "Series 2",
                //    Values = new ChartValues<double> {5, 2, 8, 3},
                //    PointGeometry = DefaultGeometries.Square,
                //    PointGeometrySize = 15
                //}
            };

            cartesianChart1.AxisX.Add(new Axis {
                Title = "Mes",
                Labels = new[] { "Ene", "Feb", "Mar", "Abr", "May" }
            });

            cartesianChart1.AxisY.Add(new Axis {
                Title = "Sales",
                LabelFormatter = value => value.ToString("C")
            });

            cartesianChart1.LegendLocation = LegendLocation.Right;

            //modifying the series collection will animate and update the chart
            cartesianChart1.Series.Add(new LineSeries {
                Values = new ChartValues<double> { 5, 3, 2, 4, 5 },
                LineSmoothness = 0, //straight lines, 1 really smooth lines
                PointGeometry = Geometry.Parse("m 25 70.36218 20 -28 -20 22 -8 -6 z"),
                PointGeometrySize = 15,
                PointForeground = Brushes.Gray
            });

            //modifying any series values will also animate and update the chart
            cartesianChart1.Series[2].Values.Add(5d);


            //cartesianChart1.DataClick += CartesianChart1OnDataClick;
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


            foreach (RubroView r in list) {
                var cantidad = ProductoControlador.GetCantidadProducto_ByRubro(r.IdRubro);
                var s = new PieSeries {
                    Title = r.Descripcion,
                    Values = new ChartValues<int> { cantidad },
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
