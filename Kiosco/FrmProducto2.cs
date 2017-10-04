using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using DevExpress.XtraEditors;

namespace Heimdall
{
    public partial class FrmProducto2 : DevExpress.XtraEditors.XtraForm
    {
        public FrmProducto2()
        {
            InitializeComponent();
        }

        private void FrmProducto2_Load(object sender, EventArgs e)
        {
            const int idDeposito = 1;
            var list = ProductoControlador.GetAllByDeposito_GetByDescripcion(idDeposito, "");

            /*
              this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcProductoId,
            this.gcCodigo,
            this.gcDescripcion,
            this.gcCapacidad,
            this.gcPrecio,
            this.gcGanancia,
            this.gcMarca,
            this.gcStock,
            this.gcRubro});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gcProductoId
            // 
            this.gcProductoId.Caption = "ProductoId";
            this.gcProductoId.FieldName = "ProductoId";
            this.gcProductoId.Name = "gcProductoId";
            this.gcProductoId.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.gcProductoId.Visible = true;
            this.gcProductoId.VisibleIndex = 0;
            this.gcProductoId.Width = 41;
             */

            gridControl1.DataSource = list;
            

        }
    }
}