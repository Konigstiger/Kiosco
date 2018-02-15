using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Controlador;
using Model;
using Model.View;

namespace Heimdall
{
    public partial class FrmDemo : Form
    {

        private ModoFormulario _modo = ModoFormulario.Nuevo;

        private int _rowIndex = 0;
        private const int colCount = 8;

        //private List<ProductoView> origenDatos = null;
        private List<PedidoView> origenDatos = null;


        public FrmDemo()
        {
            InitializeComponent();
        }

        private void FrmDemo_Load(object sender, EventArgs e)
        {
            //origenDatos = ProductoControlador.GetAllByDeposito_GetAll(1);
            origenDatos = PedidoControlador.GetAll_GetByParameters("", true);

            //var source = new List<ProductoView>(origenDatos);
            var source = new List<PedidoView>(origenDatos);
            objectListView1.SetObjects(source);
        }
    }
}
