namespace Heimdall
{
    partial class FrmProducto2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcProductoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCapacidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcGanancia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcRubro = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Darkroom";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(34, 35);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1074, 544);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
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
            this.gcProductoId.FieldName = "IdProducto";
            this.gcProductoId.Name = "gcProductoId";
            this.gcProductoId.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.gcProductoId.Visible = true;
            this.gcProductoId.VisibleIndex = 0;
            this.gcProductoId.Width = 41;
            // 
            // gcCodigo
            // 
            this.gcCodigo.Caption = "Código";
            this.gcCodigo.FieldName = "CodigoBarras";
            this.gcCodigo.Name = "gcCodigo";
            this.gcCodigo.Visible = true;
            this.gcCodigo.VisibleIndex = 1;
            this.gcCodigo.Width = 57;
            // 
            // gcDescripcion
            // 
            this.gcDescripcion.Caption = "Descripción";
            this.gcDescripcion.FieldName = "Descripcion";
            this.gcDescripcion.Name = "gcDescripcion";
            this.gcDescripcion.Visible = true;
            this.gcDescripcion.VisibleIndex = 2;
            this.gcDescripcion.Width = 57;
            // 
            // gcCapacidad
            // 
            this.gcCapacidad.Caption = "Capacidad";
            this.gcCapacidad.FieldName = "Capacidad";
            this.gcCapacidad.Name = "gcCapacidad";
            this.gcCapacidad.Visible = true;
            this.gcCapacidad.VisibleIndex = 3;
            this.gcCapacidad.Width = 57;
            // 
            // gcPrecio
            // 
            this.gcPrecio.Caption = "Precio";
            this.gcPrecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gcPrecio.FieldName = "Precio";
            this.gcPrecio.Name = "gcPrecio";
            this.gcPrecio.Visible = true;
            this.gcPrecio.VisibleIndex = 4;
            this.gcPrecio.Width = 57;
            // 
            // gcGanancia
            // 
            this.gcGanancia.Caption = "Ganancia";
            this.gcGanancia.FieldName = "Ganancia";
            this.gcGanancia.Name = "gcGanancia";
            this.gcGanancia.Visible = true;
            this.gcGanancia.VisibleIndex = 5;
            this.gcGanancia.Width = 57;
            // 
            // gcMarca
            // 
            this.gcMarca.Caption = "Marca";
            this.gcMarca.FieldName = "Marca";
            this.gcMarca.Name = "gcMarca";
            this.gcMarca.Visible = true;
            this.gcMarca.VisibleIndex = 6;
            this.gcMarca.Width = 57;
            // 
            // gcStock
            // 
            this.gcStock.Caption = "Stock";
            this.gcStock.FieldName = "Stock";
            this.gcStock.Name = "gcStock";
            this.gcStock.Visible = true;
            this.gcStock.VisibleIndex = 7;
            this.gcStock.Width = 57;
            // 
            // gcRubro
            // 
            this.gcRubro.Caption = "Rubro";
            this.gcRubro.FieldName = "Rubro";
            this.gcRubro.Name = "gcRubro";
            this.gcRubro.Visible = true;
            this.gcRubro.VisibleIndex = 8;
            this.gcRubro.Width = 68;
            // 
            // FrmProducto2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 728);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmProducto2";
            this.Text = "FrmProducto2";
            this.Load += new System.EventHandler(this.FrmProducto2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gcProductoId;
        private DevExpress.XtraGrid.Columns.GridColumn gcCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn gcDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn gcCapacidad;
        private DevExpress.XtraGrid.Columns.GridColumn gcPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn gcGanancia;
        private DevExpress.XtraGrid.Columns.GridColumn gcMarca;
        private DevExpress.XtraGrid.Columns.GridColumn gcStock;
        private DevExpress.XtraGrid.Columns.GridColumn gcRubro;
    }
}