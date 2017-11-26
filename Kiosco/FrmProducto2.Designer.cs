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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProducto2));
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
            this.tsb = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbSearchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSearchPerform = new System.Windows.Forms.ToolStripButton();
            this.tsbSearchClearAndPerform = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpProducto = new System.Windows.Forms.TabPage();
            this.ucProductoEdit1 = new Heimdall.UserControl.ucProductoEdit();
            this.tpProveedores = new System.Windows.Forms.TabPage();
            this.ucProveedorList1 = new Kiosco.UserControl.ucProveedorList();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tsb.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpProducto.SuspendLayout();
            this.tpProveedores.SuspendLayout();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Seven Classic";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(4, 35);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1145, 544);
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
            // tsb
            // 
            this.tsb.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbSave,
            this.tsbDelete,
            this.toolStripSeparator1,
            this.tsbSearch,
            this.tsbSearchTextBox,
            this.tsbSearchPerform,
            this.tsbSearchClearAndPerform});
            this.tsb.Location = new System.Drawing.Point(0, 0);
            this.tsb.Name = "tsb";
            this.tsb.Size = new System.Drawing.Size(1161, 31);
            this.tsb.TabIndex = 24;
            this.tsb.Text = "toolStrip1";
            // 
            // tsbNew
            // 
            this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(70, 28);
            this.tsbNew.Text = "Nuevo";
            // 
            // tsbSave
            // 
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(77, 28);
            this.tsbSave.Text = "Guardar";
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(67, 28);
            this.tsbDelete.Text = "Borrar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbSearch
            // 
            this.tsbSearch.CheckOnClick = true;
            this.tsbSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearch.Image")));
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(79, 28);
            this.tsbSearch.Text = "Buscar...";
            // 
            // tsbSearchTextBox
            // 
            this.tsbSearchTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tsbSearchTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tsbSearchTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbSearchTextBox.Name = "tsbSearchTextBox";
            this.tsbSearchTextBox.Size = new System.Drawing.Size(200, 31);
            this.tsbSearchTextBox.Visible = false;
            // 
            // tsbSearchPerform
            // 
            this.tsbSearchPerform.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSearchPerform.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearchPerform.Image")));
            this.tsbSearchPerform.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearchPerform.Name = "tsbSearchPerform";
            this.tsbSearchPerform.Size = new System.Drawing.Size(28, 28);
            this.tsbSearchPerform.Visible = false;
            // 
            // tsbSearchClearAndPerform
            // 
            this.tsbSearchClearAndPerform.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSearchClearAndPerform.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearchClearAndPerform.Image")));
            this.tsbSearchClearAndPerform.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearchClearAndPerform.Name = "tsbSearchClearAndPerform";
            this.tsbSearchClearAndPerform.Size = new System.Drawing.Size(28, 28);
            this.tsbSearchClearAndPerform.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tpProducto);
            this.tabControl1.Controls.Add(this.tpProveedores);
            this.tabControl1.Location = new System.Drawing.Point(0, 585);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1149, 260);
            this.tabControl1.TabIndex = 89;
            // 
            // tpProducto
            // 
            this.tpProducto.Controls.Add(this.ucProductoEdit1);
            this.tpProducto.ImageIndex = 5;
            this.tpProducto.Location = new System.Drawing.Point(4, 22);
            this.tpProducto.Name = "tpProducto";
            this.tpProducto.Size = new System.Drawing.Size(1141, 234);
            this.tpProducto.TabIndex = 1;
            this.tpProducto.Text = "Producto";
            this.tpProducto.UseVisualStyleBackColor = true;
            // 
            // ucProductoEdit1
            // 
            this.ucProductoEdit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucProductoEdit1.Capacidad = 1;
            this.ucProductoEdit1.CodigoBarras = "";
            this.ucProductoEdit1.Descripcion = "";
            this.ucProductoEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucProductoEdit1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucProductoEdit1.IdMarca = 0;
            this.ucProductoEdit1.IdProducto = ((long)(0));
            this.ucProductoEdit1.IdRubro = 0;
            this.ucProductoEdit1.IdUnidad = 0;
            this.ucProductoEdit1.Location = new System.Drawing.Point(0, 0);
            this.ucProductoEdit1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucProductoEdit1.Name = "ucProductoEdit1";
            this.ucProductoEdit1.Notas = "";
            this.ucProductoEdit1.PrecioCosto = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ucProductoEdit1.PrecioVenta = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ucProductoEdit1.Size = new System.Drawing.Size(1141, 234);
            this.ucProductoEdit1.SoloAdultos = false;
            this.ucProductoEdit1.StockActual = 0;
            this.ucProductoEdit1.StockMaximo = 0;
            this.ucProductoEdit1.StockMinimo = 0;
            this.ucProductoEdit1.TabIndex = 34;
            // 
            // tpProveedores
            // 
            this.tpProveedores.Controls.Add(this.ucProveedorList1);
            this.tpProveedores.ImageIndex = 0;
            this.tpProveedores.Location = new System.Drawing.Point(4, 22);
            this.tpProveedores.Name = "tpProveedores";
            this.tpProveedores.Padding = new System.Windows.Forms.Padding(3);
            this.tpProveedores.Size = new System.Drawing.Size(911, 234);
            this.tpProveedores.TabIndex = 0;
            this.tpProveedores.Text = "Proveedores";
            this.tpProveedores.UseVisualStyleBackColor = true;
            // 
            // ucProveedorList1
            // 
            this.ucProveedorList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucProveedorList1.IdProducto = ((long)(0));
            this.ucProveedorList1.Location = new System.Drawing.Point(3, 3);
            this.ucProveedorList1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.ucProveedorList1.Name = "ucProveedorList1";
            this.ucProveedorList1.Size = new System.Drawing.Size(905, 228);
            this.ucProveedorList1.TabIndex = 87;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "users.png");
            this.imageList1.Images.SetKeyName(1, "trucking.png");
            this.imageList1.Images.SetKeyName(2, "dollar32.png");
            this.imageList1.Images.SetKeyName(3, "shopping-cart.png");
            this.imageList1.Images.SetKeyName(4, "trolley.png");
            this.imageList1.Images.SetKeyName(5, "package.png");
            // 
            // FrmProducto2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 728);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tsb);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmProducto2";
            this.Text = "FrmProducto2";
            this.Load += new System.EventHandler(this.FrmProducto2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tsb.ResumeLayout(false);
            this.tsb.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpProducto.ResumeLayout(false);
            this.tpProveedores.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ToolStrip tsb;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripTextBox tsbSearchTextBox;
        private System.Windows.Forms.ToolStripButton tsbSearchPerform;
        private System.Windows.Forms.ToolStripButton tsbSearchClearAndPerform;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpProducto;
        private UserControl.ucProductoEdit ucProductoEdit1;
        private System.Windows.Forms.TabPage tpProveedores;
        private Kiosco.UserControl.ucProveedorList ucProveedorList1;
        private System.Windows.Forms.ImageList imageList1;
    }
}