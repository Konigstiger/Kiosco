using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.View;

namespace Heimdall
{
    public partial class FrmTarea : Form, IAbmGeneral
    {
        private ModoFormulario _modo = ModoFormulario.Nuevo;

        private int _rowIndex = 0;
        private const int colCount = 2;

        private List<TareaView> origenDatos = null;


        public FrmTarea()
        {
            InitializeComponent();
        }

        private void FrmTarea_Load(object sender, EventArgs e)
        {
            SetControles();
            CargarControles();
            LimpiarControles();
            _modo = ModoFormulario.Edicion;
        }

        public void SetControles()
        {
            throw new NotImplementedException();
        }

        public void CargarControles()
        {
            throw new NotImplementedException();
        }

        public void CargarGrilla(string searchText)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
