namespace Kiosco
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.button1 = new System.Windows.Forms.Button();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.btnVenta = new DevExpress.XtraEditors.SimpleButton();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.styleController1 = new DevExpress.XtraEditors.StyleController(this.components);
            this.btnVentas = new DevExpress.XtraEditors.SimpleButton();
            this.btnAbmProducto = new DevExpress.XtraEditors.SimpleButton();
            this.btnAbmProveedor = new DevExpress.XtraEditors.SimpleButton();
            this.btnAbmMarca = new DevExpress.XtraEditors.SimpleButton();
            this.btnPedido = new DevExpress.XtraEditors.SimpleButton();
            this.btnProductoProveedor = new DevExpress.XtraEditors.SimpleButton();
            this.btnEstadisticas = new DevExpress.XtraEditors.SimpleButton();
            this.btnRecaudacion = new DevExpress.XtraEditors.SimpleButton();
            this.btnOpciones = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.btnCerrarSesion = new DevExpress.XtraEditors.SimpleButton();
            this.btnConsultaProducto = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "demo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Darkroom";
            // 
            // btnVenta
            // 
            this.btnVenta.ImageOptions.ImageIndex = 0;
            this.btnVenta.ImageOptions.ImageList = this.imageCollection1;
            this.btnVenta.Location = new System.Drawing.Point(81, 96);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(292, 58);
            this.btnVenta.StyleController = this.styleController1;
            this.btnVenta.TabIndex = 13;
            this.btnVenta.Text = "Registro de Ventas";
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(24, 24);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "antivirus32.png");
            this.imageCollection1.Images.SetKeyName(1, "archive.png");
            this.imageCollection1.Images.SetKeyName(2, "bar-chart (1).png");
            this.imageCollection1.Images.SetKeyName(3, "package.png");
            this.imageCollection1.Images.SetKeyName(4, "boss.png");
            this.imageCollection1.Images.SetKeyName(5, "check-mark.png");
            this.imageCollection1.Images.SetKeyName(6, "dollar32.png");
            this.imageCollection1.Images.SetKeyName(7, "trucking.png");
            this.imageCollection1.Images.SetKeyName(8, "cigarettes.png");
            this.imageCollection1.Images.SetKeyName(9, "power32.png");
            this.imageCollection1.Images.SetKeyName(10, "sale-report32.png");
            this.imageCollection1.Images.SetKeyName(11, "settings.png");
            this.imageCollection1.Images.SetKeyName(12, "coins.png");
            this.imageCollection1.Images.SetKeyName(13, "wallet.png");
            // 
            // styleController1
            // 
            this.styleController1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.styleController1.Appearance.Options.UseFont = true;
            this.styleController1.LookAndFeel.SkinName = "Darkroom";
            this.styleController1.LookAndFeel.UseDefaultLookAndFeel = false;
            // 
            // btnVentas
            // 
            this.btnVentas.ImageOptions.ImageIndex = 10;
            this.btnVentas.ImageOptions.ImageList = this.imageCollection1;
            this.btnVentas.Location = new System.Drawing.Point(81, 165);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(292, 58);
            this.btnVentas.StyleController = this.styleController1;
            this.btnVentas.TabIndex = 15;
            this.btnVentas.Text = "Reporte de Ventas";
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnAbmProducto
            // 
            this.btnAbmProducto.ImageOptions.ImageIndex = 3;
            this.btnAbmProducto.ImageOptions.ImageList = this.imageCollection1;
            this.btnAbmProducto.Location = new System.Drawing.Point(81, 234);
            this.btnAbmProducto.Name = "btnAbmProducto";
            this.btnAbmProducto.Size = new System.Drawing.Size(292, 58);
            this.btnAbmProducto.StyleController = this.styleController1;
            this.btnAbmProducto.TabIndex = 16;
            this.btnAbmProducto.Text = "Productos";
            this.btnAbmProducto.Click += new System.EventHandler(this.btnAbmProducto_Click);
            // 
            // btnAbmProveedor
            // 
            this.btnAbmProveedor.ImageOptions.ImageIndex = 4;
            this.btnAbmProveedor.ImageOptions.ImageList = this.imageCollection1;
            this.btnAbmProveedor.Location = new System.Drawing.Point(81, 303);
            this.btnAbmProveedor.Name = "btnAbmProveedor";
            this.btnAbmProveedor.Size = new System.Drawing.Size(292, 58);
            this.btnAbmProveedor.StyleController = this.styleController1;
            this.btnAbmProveedor.TabIndex = 17;
            this.btnAbmProveedor.Text = "Proveedores";
            this.btnAbmProveedor.Click += new System.EventHandler(this.btnAbmProveedor_Click);
            // 
            // btnAbmMarca
            // 
            this.btnAbmMarca.ImageOptions.ImageIndex = 8;
            this.btnAbmMarca.ImageOptions.ImageList = this.imageCollection1;
            this.btnAbmMarca.Location = new System.Drawing.Point(81, 372);
            this.btnAbmMarca.Name = "btnAbmMarca";
            this.btnAbmMarca.Size = new System.Drawing.Size(292, 58);
            this.btnAbmMarca.StyleController = this.styleController1;
            this.btnAbmMarca.TabIndex = 18;
            this.btnAbmMarca.Text = "Marcas";
            this.btnAbmMarca.Click += new System.EventHandler(this.btnAbmMarca_Click);
            // 
            // btnPedido
            // 
            this.btnPedido.ImageOptions.ImageIndex = 7;
            this.btnPedido.ImageOptions.ImageList = this.imageCollection1;
            this.btnPedido.Location = new System.Drawing.Point(81, 441);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(292, 58);
            this.btnPedido.StyleController = this.styleController1;
            this.btnPedido.TabIndex = 19;
            this.btnPedido.Text = "Pedidos";
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // btnProductoProveedor
            // 
            this.btnProductoProveedor.ImageOptions.ImageIndex = 1;
            this.btnProductoProveedor.ImageOptions.ImageList = this.imageCollection1;
            this.btnProductoProveedor.Location = new System.Drawing.Point(81, 510);
            this.btnProductoProveedor.Name = "btnProductoProveedor";
            this.btnProductoProveedor.Size = new System.Drawing.Size(292, 58);
            this.btnProductoProveedor.StyleController = this.styleController1;
            this.btnProductoProveedor.TabIndex = 20;
            this.btnProductoProveedor.Text = "Productos de Proveedores";
            this.btnProductoProveedor.Click += new System.EventHandler(this.btnProductoProveedor_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.ImageOptions.ImageIndex = 2;
            this.btnEstadisticas.ImageOptions.ImageList = this.imageCollection1;
            this.btnEstadisticas.Location = new System.Drawing.Point(81, 579);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(292, 58);
            this.btnEstadisticas.StyleController = this.styleController1;
            this.btnEstadisticas.TabIndex = 21;
            this.btnEstadisticas.Text = "Estadisticas";
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // btnRecaudacion
            // 
            this.btnRecaudacion.ImageOptions.ImageIndex = 6;
            this.btnRecaudacion.ImageOptions.ImageList = this.imageCollection1;
            this.btnRecaudacion.Location = new System.Drawing.Point(81, 648);
            this.btnRecaudacion.Name = "btnRecaudacion";
            this.btnRecaudacion.Size = new System.Drawing.Size(292, 58);
            this.btnRecaudacion.StyleController = this.styleController1;
            this.btnRecaudacion.TabIndex = 22;
            this.btnRecaudacion.Text = "Recaudacion";
            this.btnRecaudacion.Click += new System.EventHandler(this.btnRecaudacion_Click);
            // 
            // btnOpciones
            // 
            this.btnOpciones.ImageOptions.ImageIndex = 11;
            this.btnOpciones.ImageOptions.ImageList = this.imageCollection1;
            this.btnOpciones.Location = new System.Drawing.Point(81, 717);
            this.btnOpciones.Name = "btnOpciones";
            this.btnOpciones.Size = new System.Drawing.Size(292, 58);
            this.btnOpciones.StyleController = this.styleController1;
            this.btnOpciones.TabIndex = 23;
            this.btnOpciones.Text = "Opciones y Configuracion";
            this.btnOpciones.Click += new System.EventHandler(this.btnOpciones_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.ImageOptions.ImageIndex = 9;
            this.btnSalir.ImageOptions.ImageList = this.imageCollection1;
            this.btnSalir.Location = new System.Drawing.Point(81, 855);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(292, 58);
            this.btnSalir.StyleController = this.styleController1;
            this.btnSalir.TabIndex = 24;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.ImageOptions.ImageIndex = 11;
            this.btnCerrarSesion.ImageOptions.ImageList = this.imageCollection1;
            this.btnCerrarSesion.Location = new System.Drawing.Point(81, 786);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(292, 58);
            this.btnCerrarSesion.StyleController = this.styleController1;
            this.btnCerrarSesion.TabIndex = 25;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            // 
            // btnConsultaProducto
            // 
            this.btnConsultaProducto.ImageOptions.Image = global::Heimdall.Properties.Resources.barcode_32x32;
            this.btnConsultaProducto.ImageOptions.ImageIndex = 2;
            this.btnConsultaProducto.ImageOptions.ImageList = this.imageCollection1;
            this.btnConsultaProducto.Location = new System.Drawing.Point(81, 27);
            this.btnConsultaProducto.Name = "btnConsultaProducto";
            this.btnConsultaProducto.Size = new System.Drawing.Size(292, 58);
            this.btnConsultaProducto.StyleController = this.styleController1;
            this.btnConsultaProducto.TabIndex = 14;
            this.btnConsultaProducto.Text = "Consulta de Productos";
            this.btnConsultaProducto.Click += new System.EventHandler(this.btnConsultaProducto_Click);
            // 
            // FrmMain
            // 
            this.Appearance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 961);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnOpciones);
            this.Controls.Add(this.btnRecaudacion);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.btnProductoProveedor);
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.btnAbmMarca);
            this.Controls.Add(this.btnAbmProveedor);
            this.Controls.Add(this.btnAbmProducto);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnConsultaProducto);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Text = "Heimdall 0.1.2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.SimpleButton btnVenta;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.SimpleButton btnConsultaProducto;
        private DevExpress.XtraEditors.StyleController styleController1;
        private DevExpress.XtraEditors.SimpleButton btnVentas;
        private DevExpress.XtraEditors.SimpleButton btnAbmProducto;
        private DevExpress.XtraEditors.SimpleButton btnAbmProveedor;
        private DevExpress.XtraEditors.SimpleButton btnAbmMarca;
        private DevExpress.XtraEditors.SimpleButton btnPedido;
        private DevExpress.XtraEditors.SimpleButton btnProductoProveedor;
        private DevExpress.XtraEditors.SimpleButton btnEstadisticas;
        private DevExpress.XtraEditors.SimpleButton btnRecaudacion;
        private DevExpress.XtraEditors.SimpleButton btnOpciones;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private DevExpress.XtraEditors.SimpleButton btnCerrarSesion;
    }
}