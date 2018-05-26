
namespace Heimdall
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
            this.btnVentaRegistro = new System.Windows.Forms.Button();
            this.ilMain = new System.Windows.Forms.ImageList(this.components);
            this.btnVentasReporte = new System.Windows.Forms.Button();
            this.btnAbmProducto = new System.Windows.Forms.Button();
            this.btnAbmProveedor = new System.Windows.Forms.Button();
            this.btnAbmMarca = new System.Windows.Forms.Button();
            this.btnPedido = new System.Windows.Forms.Button();
            this.btnProductoProveedor = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnRecaudacion = new System.Windows.Forms.Button();
            this.btnOpciones = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnConsultaProducto = new System.Windows.Forms.Button();
            this.btnTableroDemo = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnTurno = new System.Windows.Forms.Button();
            this.btnTareas = new System.Windows.Forms.Button();
            this.btnFaltante = new System.Windows.Forms.Button();
            this.labTitulo = new System.Windows.Forms.Label();
            this.btnGastos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVentaRegistro
            // 
            this.btnVentaRegistro.Font = new System.Drawing.Font("Metropolis", 14.25F);
            this.btnVentaRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentaRegistro.ImageIndex = 4;
            this.btnVentaRegistro.ImageList = this.ilMain;
            this.btnVentaRegistro.Location = new System.Drawing.Point(491, 115);
            this.btnVentaRegistro.Name = "btnVentaRegistro";
            this.btnVentaRegistro.Size = new System.Drawing.Size(347, 63);
            this.btnVentaRegistro.TabIndex = 3;
            this.btnVentaRegistro.Text = "Registro de Ventas";
            this.btnVentaRegistro.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // ilMain
            // 
            this.ilMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilMain.ImageStream")));
            this.ilMain.TransparentColor = System.Drawing.Color.Transparent;
            this.ilMain.Images.SetKeyName(0, "package.png");
            this.ilMain.Images.SetKeyName(1, "trucking.png");
            this.ilMain.Images.SetKeyName(2, "cigarettes.png");
            this.ilMain.Images.SetKeyName(3, "sale-report32.png");
            this.ilMain.Images.SetKeyName(4, "dollar32.png");
            this.ilMain.Images.SetKeyName(5, "coins.png");
            this.ilMain.Images.SetKeyName(6, "barcode32-1.png");
            this.ilMain.Images.SetKeyName(7, "checklist.png");
            this.ilMain.Images.SetKeyName(8, "pie-chart.png");
            this.ilMain.Images.SetKeyName(9, "safebox.png");
            this.ilMain.Images.SetKeyName(10, "users.png");
            this.ilMain.Images.SetKeyName(11, "shopping-cart.png");
            this.ilMain.Images.SetKeyName(12, "login.png");
            this.ilMain.Images.SetKeyName(13, "power32.png");
            this.ilMain.Images.SetKeyName(14, "settings2.png");
            this.ilMain.Images.SetKeyName(15, "businessman (2).png");
            this.ilMain.Images.SetKeyName(16, "exchange.png");
            this.ilMain.Images.SetKeyName(17, "group (1).png");
            this.ilMain.Images.SetKeyName(18, "clipboard (1).png");
            // 
            // btnVentasReporte
            // 
            this.btnVentasReporte.Font = new System.Drawing.Font("Metropolis", 14.25F);
            this.btnVentasReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentasReporte.ImageIndex = 3;
            this.btnVentasReporte.ImageList = this.ilMain;
            this.btnVentasReporte.Location = new System.Drawing.Point(491, 192);
            this.btnVentasReporte.Name = "btnVentasReporte";
            this.btnVentasReporte.Size = new System.Drawing.Size(347, 63);
            this.btnVentasReporte.TabIndex = 4;
            this.btnVentasReporte.Text = "Reporte de Ventas";
            this.btnVentasReporte.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnAbmProducto
            // 
            this.btnAbmProducto.Font = new System.Drawing.Font("Metropolis", 14.25F);
            this.btnAbmProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbmProducto.ImageIndex = 0;
            this.btnAbmProducto.ImageList = this.ilMain;
            this.btnAbmProducto.Location = new System.Drawing.Point(81, 192);
            this.btnAbmProducto.Name = "btnAbmProducto";
            this.btnAbmProducto.Size = new System.Drawing.Size(347, 63);
            this.btnAbmProducto.TabIndex = 1;
            this.btnAbmProducto.Text = "Productos";
            this.btnAbmProducto.Click += new System.EventHandler(this.btnAbmProducto_Click);
            // 
            // btnAbmProveedor
            // 
            this.btnAbmProveedor.Font = new System.Drawing.Font("Metropolis", 14.25F);
            this.btnAbmProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbmProveedor.ImageIndex = 10;
            this.btnAbmProveedor.ImageList = this.ilMain;
            this.btnAbmProveedor.Location = new System.Drawing.Point(81, 500);
            this.btnAbmProveedor.Name = "btnAbmProveedor";
            this.btnAbmProveedor.Size = new System.Drawing.Size(347, 63);
            this.btnAbmProveedor.TabIndex = 5;
            this.btnAbmProveedor.Text = "Proveedores";
            this.btnAbmProveedor.Click += new System.EventHandler(this.btnAbmProveedor_Click);
            // 
            // btnAbmMarca
            // 
            this.btnAbmMarca.Font = new System.Drawing.Font("Metropolis", 14.25F);
            this.btnAbmMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbmMarca.ImageIndex = 2;
            this.btnAbmMarca.ImageList = this.ilMain;
            this.btnAbmMarca.Location = new System.Drawing.Point(81, 577);
            this.btnAbmMarca.Name = "btnAbmMarca";
            this.btnAbmMarca.Size = new System.Drawing.Size(347, 63);
            this.btnAbmMarca.TabIndex = 6;
            this.btnAbmMarca.Text = "Marcas";
            this.btnAbmMarca.Click += new System.EventHandler(this.btnAbmMarca_Click);
            // 
            // btnPedido
            // 
            this.btnPedido.Font = new System.Drawing.Font("Metropolis", 14.25F);
            this.btnPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedido.ImageIndex = 1;
            this.btnPedido.ImageList = this.ilMain;
            this.btnPedido.Location = new System.Drawing.Point(81, 269);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(347, 63);
            this.btnPedido.TabIndex = 2;
            this.btnPedido.Text = "Pedidos";
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // btnProductoProveedor
            // 
            this.btnProductoProveedor.Font = new System.Drawing.Font("Metropolis", 14.25F);
            this.btnProductoProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductoProveedor.ImageIndex = 11;
            this.btnProductoProveedor.ImageList = this.ilMain;
            this.btnProductoProveedor.Location = new System.Drawing.Point(491, 577);
            this.btnProductoProveedor.Name = "btnProductoProveedor";
            this.btnProductoProveedor.Size = new System.Drawing.Size(347, 63);
            this.btnProductoProveedor.TabIndex = 7;
            this.btnProductoProveedor.Text = "Productos de Proveedores";
            this.btnProductoProveedor.Click += new System.EventHandler(this.btnProductoProveedor_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Font = new System.Drawing.Font("Metropolis", 14.25F);
            this.btnEstadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstadisticas.ImageIndex = 8;
            this.btnEstadisticas.ImageList = this.ilMain;
            this.btnEstadisticas.Location = new System.Drawing.Point(491, 269);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(347, 63);
            this.btnEstadisticas.TabIndex = 8;
            this.btnEstadisticas.Text = "Estadisticas";
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // btnRecaudacion
            // 
            this.btnRecaudacion.Font = new System.Drawing.Font("Metropolis", 14.25F);
            this.btnRecaudacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecaudacion.ImageIndex = 9;
            this.btnRecaudacion.ImageList = this.ilMain;
            this.btnRecaudacion.Location = new System.Drawing.Point(491, 346);
            this.btnRecaudacion.Name = "btnRecaudacion";
            this.btnRecaudacion.Size = new System.Drawing.Size(347, 63);
            this.btnRecaudacion.TabIndex = 9;
            this.btnRecaudacion.Text = "Recaudacion";
            this.btnRecaudacion.Click += new System.EventHandler(this.btnRecaudacion_Click);
            // 
            // btnOpciones
            // 
            this.btnOpciones.Font = new System.Drawing.Font("Metropolis", 14.25F);
            this.btnOpciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpciones.ImageIndex = 14;
            this.btnOpciones.ImageList = this.ilMain;
            this.btnOpciones.Location = new System.Drawing.Point(491, 654);
            this.btnOpciones.Name = "btnOpciones";
            this.btnOpciones.Size = new System.Drawing.Size(347, 63);
            this.btnOpciones.TabIndex = 10;
            this.btnOpciones.Text = "Opciones y Configuracion";
            this.btnOpciones.Visible = false;
            this.btnOpciones.Click += new System.EventHandler(this.btnOpciones_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Metropolis", 14.25F);
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.ImageIndex = 13;
            this.btnSalir.ImageList = this.ilMain;
            this.btnSalir.Location = new System.Drawing.Point(296, 913);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(347, 63);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Font = new System.Drawing.Font("Metropolis", 14.25F);
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.ImageIndex = 16;
            this.btnCerrarSesion.ImageList = this.ilMain;
            this.btnCerrarSesion.Location = new System.Drawing.Point(81, 654);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(347, 63);
            this.btnCerrarSesion.TabIndex = 25;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnConsultaProducto
            // 
            this.btnConsultaProducto.Font = new System.Drawing.Font("Metropolis", 14.25F);
            this.btnConsultaProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaProducto.ImageIndex = 6;
            this.btnConsultaProducto.ImageList = this.ilMain;
            this.btnConsultaProducto.Location = new System.Drawing.Point(81, 115);
            this.btnConsultaProducto.Name = "btnConsultaProducto";
            this.btnConsultaProducto.Size = new System.Drawing.Size(347, 63);
            this.btnConsultaProducto.TabIndex = 0;
            this.btnConsultaProducto.Text = "Consulta de Productos";
            this.btnConsultaProducto.Click += new System.EventHandler(this.btnConsultaProducto_Click);
            // 
            // btnTableroDemo
            // 
            this.btnTableroDemo.Location = new System.Drawing.Point(815, 12);
            this.btnTableroDemo.Name = "btnTableroDemo";
            this.btnTableroDemo.Size = new System.Drawing.Size(292, 58);
            this.btnTableroDemo.TabIndex = 26;
            this.btnTableroDemo.Text = "Tablero Demo";
            this.btnTableroDemo.Visible = false;
            this.btnTableroDemo.Click += new System.EventHandler(this.btnTableroDemo_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Font = new System.Drawing.Font("Metropolis", 14.25F);
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.ImageIndex = 17;
            this.btnUsuarios.ImageList = this.ilMain;
            this.btnUsuarios.Location = new System.Drawing.Point(491, 500);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(347, 63);
            this.btnUsuarios.TabIndex = 27;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnTurno
            // 
            this.btnTurno.Font = new System.Drawing.Font("Metropolis", 14.25F);
            this.btnTurno.Image = ((System.Drawing.Image)(resources.GetObject("btnTurno.Image")));
            this.btnTurno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTurno.Location = new System.Drawing.Point(491, 423);
            this.btnTurno.Name = "btnTurno";
            this.btnTurno.Size = new System.Drawing.Size(347, 63);
            this.btnTurno.TabIndex = 28;
            this.btnTurno.Text = "Turnos de Trabajo";
            this.btnTurno.Click += new System.EventHandler(this.btnTurno_Click);
            // 
            // btnTareas
            // 
            this.btnTareas.Font = new System.Drawing.Font("Metropolis", 14.25F);
            this.btnTareas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTareas.ImageIndex = 18;
            this.btnTareas.ImageList = this.ilMain;
            this.btnTareas.Location = new System.Drawing.Point(81, 346);
            this.btnTareas.Name = "btnTareas";
            this.btnTareas.Size = new System.Drawing.Size(347, 63);
            this.btnTareas.TabIndex = 29;
            this.btnTareas.Text = "Tareas";
            this.btnTareas.Click += new System.EventHandler(this.btnTareas_Click);
            // 
            // btnFaltante
            // 
            this.btnFaltante.Font = new System.Drawing.Font("Metropolis", 14.25F);
            this.btnFaltante.Image = ((System.Drawing.Image)(resources.GetObject("btnFaltante.Image")));
            this.btnFaltante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFaltante.Location = new System.Drawing.Point(81, 423);
            this.btnFaltante.Name = "btnFaltante";
            this.btnFaltante.Size = new System.Drawing.Size(347, 63);
            this.btnFaltante.TabIndex = 30;
            this.btnFaltante.Text = "Faltantes de Mercadería";
            this.btnFaltante.Click += new System.EventHandler(this.btnFaltante_Click);
            // 
            // labTitulo
            // 
            this.labTitulo.AutoSize = true;
            this.labTitulo.Font = new System.Drawing.Font("Teko", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labTitulo.Location = new System.Drawing.Point(200, 9);
            this.labTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.Size = new System.Drawing.Size(313, 91);
            this.labTitulo.TabIndex = 31;
            this.labTitulo.Text = "Menú Principal";
            // 
            // btnGastos
            // 
            this.btnGastos.Font = new System.Drawing.Font("Metropolis", 14.25F);
            this.btnGastos.Image = ((System.Drawing.Image)(resources.GetObject("btnGastos.Image")));
            this.btnGastos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGastos.Location = new System.Drawing.Point(81, 734);
            this.btnGastos.Name = "btnGastos";
            this.btnGastos.Size = new System.Drawing.Size(347, 63);
            this.btnGastos.TabIndex = 32;
            this.btnGastos.Text = "Gastos";
            this.btnGastos.Click += new System.EventHandler(this.btnGastos_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 1045);
            this.Controls.Add(this.btnGastos);
            this.Controls.Add(this.labTitulo);
            this.Controls.Add(this.btnFaltante);
            this.Controls.Add(this.btnTareas);
            this.Controls.Add(this.btnTurno);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnTableroDemo);
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
            this.Controls.Add(this.btnVentasReporte);
            this.Controls.Add(this.btnConsultaProducto);
            this.Controls.Add(this.btnVentaRegistro);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Text = "Heimdall 0.1.4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVentaRegistro;
        private System.Windows.Forms.Button btnConsultaProducto;
        private System.Windows.Forms.Button btnVentasReporte;
        private System.Windows.Forms.Button btnAbmProducto;
        private System.Windows.Forms.Button btnAbmProveedor;
        private System.Windows.Forms.Button btnAbmMarca;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Button btnProductoProveedor;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Button btnRecaudacion;
        private System.Windows.Forms.Button btnOpciones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnTableroDemo;
        private System.Windows.Forms.ImageList ilMain;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnTurno;
        private System.Windows.Forms.Button btnTareas;
        private System.Windows.Forms.Button btnFaltante;
        private System.Windows.Forms.Label labTitulo;
        private System.Windows.Forms.Button btnGastos;
    }
}