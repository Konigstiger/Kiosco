using Heimdall.UserControl;

namespace Heimdall
{
    partial class FrmProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProducto));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tsb = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbSearchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSearchPerform = new System.Windows.Forms.ToolStripButton();
            this.tsbSearchClearAndPerform = new System.Windows.Forms.ToolStripButton();
            this.tsbVerArchivo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExportarTxt = new System.Windows.Forms.ToolStripButton();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabProveedores = new System.Windows.Forms.TabPage();
            this._ucAbmToolBar2 = new Heimdall.UserControl.UcAbmToolBar();
            this.ucProductoProveedorEdit1 = new Heimdall.UserControl.UcProductoProveedorEdit();
            this._ucProductoProveedorList1 = new Heimdall.UserControl.UcProductoProveedorList();
            this.tabPromociones = new System.Windows.Forms.TabPage();
            this.ucProductoPromocionList1 = new Heimdall.UserControl.UcProductoPromocionList();
            this.ucPromocionList1 = new Heimdall.UserControl.UcPromocionList();
            this.ucProductoEdit1 = new Heimdall.UserControl.UcProductoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tsb.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabProveedores.SuspendLayout();
            this.tabPromociones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Location = new System.Drawing.Point(0, 37);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1884, 720);
            this.dgv.TabIndex = 9;
            this.dgv.TabStop = false;
            this.dgv.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_DataError);
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            this.dgv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_KeyDown);
            this.dgv.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgv_MouseDown);
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
            this.tsbSearchClearAndPerform,
            this.tsbVerArchivo,
            this.toolStripSeparator2,
            this.tsbExportarTxt});
            this.tsb.Location = new System.Drawing.Point(0, 0);
            this.tsb.Name = "tsb";
            this.tsb.Size = new System.Drawing.Size(1896, 31);
            this.tsb.TabIndex = 23;
            this.tsb.Text = "toolStrip1";
            // 
            // tsbNew
            // 
            this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(80, 28);
            this.tsbNew.Text = "Nuevo";
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(90, 28);
            this.tsbSave.Text = "Guardar";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(78, 28);
            this.tsbDelete.Text = "Borrar";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
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
            this.tsbSearch.Size = new System.Drawing.Size(89, 28);
            this.tsbSearch.Text = "Buscar...";
            this.tsbSearch.Click += new System.EventHandler(this.tsbSearch_Click);
            // 
            // tsbSearchTextBox
            // 
            this.tsbSearchTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tsbSearchTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tsbSearchTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbSearchTextBox.Name = "tsbSearchTextBox";
            this.tsbSearchTextBox.Size = new System.Drawing.Size(200, 32);
            this.tsbSearchTextBox.Visible = false;
            this.tsbSearchTextBox.Enter += new System.EventHandler(this.tsbSearchTextBox_Enter);
            this.tsbSearchTextBox.Leave += new System.EventHandler(this.tsbSearchTextBox_Leave);
            this.tsbSearchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProducto_KeyDown);
            // 
            // tsbSearchPerform
            // 
            this.tsbSearchPerform.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSearchPerform.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearchPerform.Image")));
            this.tsbSearchPerform.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearchPerform.Name = "tsbSearchPerform";
            this.tsbSearchPerform.Size = new System.Drawing.Size(28, 28);
            this.tsbSearchPerform.Visible = false;
            this.tsbSearchPerform.Click += new System.EventHandler(this.tsbSearchPerform_Click);
            // 
            // tsbSearchClearAndPerform
            // 
            this.tsbSearchClearAndPerform.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSearchClearAndPerform.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearchClearAndPerform.Image")));
            this.tsbSearchClearAndPerform.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearchClearAndPerform.Name = "tsbSearchClearAndPerform";
            this.tsbSearchClearAndPerform.Size = new System.Drawing.Size(28, 28);
            this.tsbSearchClearAndPerform.Visible = false;
            this.tsbSearchClearAndPerform.Click += new System.EventHandler(this.tsbSearchClearAndPerform_Click);
            // 
            // tsbVerArchivo
            // 
            this.tsbVerArchivo.CheckOnClick = true;
            this.tsbVerArchivo.Image = ((System.Drawing.Image)(resources.GetObject("tsbVerArchivo.Image")));
            this.tsbVerArchivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbVerArchivo.Name = "tsbVerArchivo";
            this.tsbVerArchivo.Size = new System.Drawing.Size(87, 28);
            this.tsbVerArchivo.Text = "Archivo";
            this.tsbVerArchivo.Click += new System.EventHandler(this.tsbVerArchivo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbExportarTxt
            // 
            this.tsbExportarTxt.Image = ((System.Drawing.Image)(resources.GetObject("tsbExportarTxt.Image")));
            this.tsbExportarTxt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExportarTxt.Name = "tsbExportarTxt";
            this.tsbExportarTxt.Size = new System.Drawing.Size(93, 28);
            this.tsbExportarTxt.Text = "Exportar";
            this.tsbExportarTxt.Click += new System.EventHandler(this.tsbExportarTxt_Click);
            // 
            // cms
            // 
            this.cms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(61, 4);
            this.cms.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cms_ItemClicked);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "archive3.png");
            this.imageList1.Images.SetKeyName(1, "users.png");
            this.imageList1.Images.SetKeyName(2, "trucking.png");
            this.imageList1.Images.SetKeyName(3, "dollar32.png");
            this.imageList1.Images.SetKeyName(4, "shopping-cart.png");
            this.imageList1.Images.SetKeyName(5, "trolley.png");
            this.imageList1.Images.SetKeyName(6, "package.png");
            this.imageList1.Images.SetKeyName(7, "export.png");
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(505, 349);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(375, 26);
            this.progressBar.Step = 5;
            this.progressBar.TabIndex = 97;
            this.progressBar.Visible = false;
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl2.Controls.Add(this.tabProveedores);
            this.tabControl2.Controls.Add(this.tabPromociones);
            this.tabControl2.Location = new System.Drawing.Point(847, 763);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1037, 284);
            this.tabControl2.TabIndex = 102;
            // 
            // tabProveedores
            // 
            this.tabProveedores.Controls.Add(this._ucAbmToolBar2);
            this.tabProveedores.Controls.Add(this.ucProductoProveedorEdit1);
            this.tabProveedores.Controls.Add(this._ucProductoProveedorList1);
            this.tabProveedores.Location = new System.Drawing.Point(4, 29);
            this.tabProveedores.Name = "tabProveedores";
            this.tabProveedores.Padding = new System.Windows.Forms.Padding(3);
            this.tabProveedores.Size = new System.Drawing.Size(1029, 251);
            this.tabProveedores.TabIndex = 0;
            this.tabProveedores.Text = "Proveedores";
            this.tabProveedores.UseVisualStyleBackColor = true;
            // 
            // _ucAbmToolBar2
            // 
            this._ucAbmToolBar2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this._ucAbmToolBar2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._ucAbmToolBar2.Dock = System.Windows.Forms.DockStyle.Top;
            this._ucAbmToolBar2.Location = new System.Drawing.Point(3, 3);
            this._ucAbmToolBar2.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this._ucAbmToolBar2.Name = "_ucAbmToolBar2";
            this._ucAbmToolBar2.SearchText = "";
            this._ucAbmToolBar2.Size = new System.Drawing.Size(1023, 42);
            this._ucAbmToolBar2.TabIndex = 96;
            // 
            // ucProductoProveedorEdit1
            // 
            this.ucProductoProveedorEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ucProductoProveedorEdit1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucProductoProveedorEdit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucProductoProveedorEdit1.Fecha = new System.DateTime(2018, 1, 9, 15, 37, 10, 842);
            this.ucProductoProveedorEdit1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucProductoProveedorEdit1.IdProducto = ((long)(0));
            this.ucProductoProveedorEdit1.IdProductoProveedor = ((long)(0));
            this.ucProductoProveedorEdit1.IdProveedor = 0;
            this.ucProductoProveedorEdit1.Location = new System.Drawing.Point(6, 138);
            this.ucProductoProveedorEdit1.Modo = Heimdall.ModoFormulario.Nuevo;
            this.ucProductoProveedorEdit1.Name = "ucProductoProveedorEdit1";
            this.ucProductoProveedorEdit1.Notas = "";
            this.ucProductoProveedorEdit1.Precio = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ucProductoProveedorEdit1.Size = new System.Drawing.Size(1016, 140);
            this.ucProductoProveedorEdit1.TabIndex = 94;
            // 
            // _ucProductoProveedorList1
            // 
            this._ucProductoProveedorList1.BackColor = System.Drawing.Color.White;
            this._ucProductoProveedorList1.Fecha = null;
            this._ucProductoProveedorList1.IdProducto = ((long)(0));
            this._ucProductoProveedorList1.IdProductoProveedor = ((long)(0));
            this._ucProductoProveedorList1.IdProveedor = 0;
            this._ucProductoProveedorList1.Location = new System.Drawing.Point(6, 44);
            this._ucProductoProveedorList1.Margin = new System.Windows.Forms.Padding(8, 30, 8, 30);
            this._ucProductoProveedorList1.Name = "_ucProductoProveedorList1";
            this._ucProductoProveedorList1.Precio = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this._ucProductoProveedorList1.Size = new System.Drawing.Size(1016, 92);
            this._ucProductoProveedorList1.TabIndex = 92;
            // 
            // tabPromociones
            // 
            this.tabPromociones.Controls.Add(this.ucProductoPromocionList1);
            this.tabPromociones.Controls.Add(this.ucPromocionList1);
            this.tabPromociones.Location = new System.Drawing.Point(4, 29);
            this.tabPromociones.Name = "tabPromociones";
            this.tabPromociones.Padding = new System.Windows.Forms.Padding(3);
            this.tabPromociones.Size = new System.Drawing.Size(1029, 251);
            this.tabPromociones.TabIndex = 1;
            this.tabPromociones.Text = "Promociones";
            this.tabPromociones.UseVisualStyleBackColor = true;
            // 
            // ucProductoPromocionList1
            // 
            this.ucProductoPromocionList1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ucProductoPromocionList1.IdProducto = ((long)(0));
            this.ucProductoPromocionList1.IdProductoPromocion = 0;
            this.ucProductoPromocionList1.IdPromocion = 0;
            this.ucProductoPromocionList1.Location = new System.Drawing.Point(7, 133);
            this.ucProductoPromocionList1.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.ucProductoPromocionList1.Name = "ucProductoPromocionList1";
            this.ucProductoPromocionList1.Size = new System.Drawing.Size(541, 122);
            this.ucProductoPromocionList1.TabIndex = 100;
            // 
            // ucPromocionList1
            // 
            this.ucPromocionList1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ucPromocionList1.IdProducto = ((long)(0));
            this.ucPromocionList1.IdPromocion = 0;
            this.ucPromocionList1.Location = new System.Drawing.Point(6, 12);
            this.ucPromocionList1.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.ucPromocionList1.Name = "ucPromocionList1";
            this.ucPromocionList1.Size = new System.Drawing.Size(542, 114);
            this.ucPromocionList1.TabIndex = 99;
            this.ucPromocionList1.PromocionChanged += new Heimdall.UserControl.PromocionChangedEventHandler(this.ucPromocionList1_PromocionChanged);
            // 
            // ucProductoEdit1
            // 
            this.ucProductoEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ucProductoEdit1.Archivado = false;
            this.ucProductoEdit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucProductoEdit1.Capacidad = 1;
            this.ucProductoEdit1.CodigoBarras = "";
            this.ucProductoEdit1.Descripcion = "";
            this.ucProductoEdit1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ucProductoEdit1.IdMarca = 0;
            this.ucProductoEdit1.IdProducto = ((long)(0));
            this.ucProductoEdit1.IdRubro = 0;
            this.ucProductoEdit1.IdUnidad = 0;
            this.ucProductoEdit1.Location = new System.Drawing.Point(1, 763);
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
            this.ucProductoEdit1.PrecioVentaPremium = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ucProductoEdit1.Size = new System.Drawing.Size(840, 286);
            this.ucProductoEdit1.SoloAdultos = false;
            this.ucProductoEdit1.StockActual = 0;
            this.ucProductoEdit1.StockMaximo = 0;
            this.ucProductoEdit1.StockMinimo = 0;
            this.ucProductoEdit1.TabIndex = 96;
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1896, 1055);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.ucProductoEdit1);
            this.Controls.Add(this.tsb);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProducto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProducto_KeyDown);
            this.Leave += new System.EventHandler(this.FrmProducto_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tsb.ResumeLayout(false);
            this.tsb.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabProveedores.ResumeLayout(false);
            this.tabPromociones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ToolStrip tsb;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox tsbSearchTextBox;
        private System.Windows.Forms.ToolStripButton tsbSearchClearAndPerform;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripButton tsbSearchPerform;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ToolStripButton tsbVerArchivo;
        private System.Windows.Forms.ToolStripButton tsbExportarTxt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabProveedores;
        private UcAbmToolBar _ucAbmToolBar2;
        private UcProductoProveedorEdit ucProductoProveedorEdit1;
        private UcProductoProveedorList _ucProductoProveedorList1;
        private System.Windows.Forms.TabPage tabPromociones;
        private UcProductoEdit ucProductoEdit1;
        private UcProductoPromocionList ucProductoPromocionList1;
        private UcPromocionList ucPromocionList1;
    }
}

