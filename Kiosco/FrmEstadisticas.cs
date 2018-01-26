using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Controlador;
using LiveCharts;
using LiveCharts.Wpf;
using Model;

//using Brushes = System.Drawing.Brushes;

namespace Heimdall
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
            //Recuperar valores de BD
            var listRec = RecaudacionControlador.GetAll();


            var sc = new SeriesCollection();
            var ls = new LineSeries();
            ls.Title = "Recaudacion";
            ls.LineSmoothness = 0;
            //ls.LineSmoothness = 0.25;
            ls.PointGeometry = DefaultGeometries.Circle;
            //ls.PointGeometry = DefaultGeometries.Square;
            ls.PointGeometrySize = 10;
            //ls.PointForeground


            var ls2 = new LineSeries();
            ls2.Title = "Compras";
            ls2.LineSmoothness = 0;
            ls2.PointGeometry = DefaultGeometries.Circle;
            ls2.PointGeometrySize = 10;
            //ls.PointForeground

            var ls3 = new LineSeries();
            ls3.Title = "Gastos";
            ls3.LineSmoothness = 0;
            ls3.PointGeometry = DefaultGeometries.Circle;
            ls3.PointGeometrySize = 10;
            //ls.PointForeground

            var xAxis = new Axis();
            xAxis.Title = "Tiempo";
            xAxis.Labels = new List<string>();
            ls.Values = new ChartValues<decimal>();
            ls2.Values = new ChartValues<decimal>();
            ls3.Values = new ChartValues<decimal>();

            foreach (var r in listRec) {
                ls.Values.Add(r.Total);
                ls2.Values.Add(r.Compras);
                ls3.Values.Add(r.Gastos);
                xAxis.Labels.Add(r.Fecha.ToShortDateString());
            }

            sc.Add(ls);
            sc.Add(ls2);
            sc.Add(ls3);

            cartesianChart1.Series = sc;
            cartesianChart1.AxisX.Add(xAxis);

            cartesianChart1.LegendLocation = LegendLocation.Right;
        }


        private void CargarCantidadProductos()
        {
            var cantidadProductos = ProductoControlador.GetAll().Count;
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
