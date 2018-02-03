using Heimdall.UserControl;

namespace Heimdall
{
    partial class FrmProductoDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductoDetalle));
            this.tsb = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.chkRequiereEnvase = new System.Windows.Forms.CheckBox();
            this.txtPrecioCosto = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtRubroDescripcion = new System.Windows.Forms.TextBox();
            this.txtIdRubro = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtIdMarca = new System.Windows.Forms.TextBox();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labPrecioCosto = new System.Windows.Forms.Label();
            this.gbStock = new System.Windows.Forms.GroupBox();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.nudStockActual = new System.Windows.Forms.NumericUpDown();
            this.labStockActual = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkSoloAdultos = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrarVentaRapida = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpProveedores = new System.Windows.Forms.TabPage();
            this._ucProductoProveedorList1 = new Heimdall.UserControl.UcProductoProveedorList();
            this.tpPromociones = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.nudCantidadVenta = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nudImporte = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSeleccionarProducto = new System.Windows.Forms.Button();
            this.btnMProducto = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtPrecioPremium = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ucProductoEdit1 = new Heimdall.UserControl.UcProductoEdit();
            this.ucNotification2 = new Heimdall.UserControl.UcNotification();
            this.ucNotification = new Heimdall.UserControl.UcNotification();
            this.tsb.SuspendLayout();
            this.gbStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // tsb
            // 
            this.tsb.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo});
            this.tsb.Location = new System.Drawing.Point(0, 0);
            this.tsb.Name = "tsb";
            this.tsb.Size = new System.Drawing.Size(1503, 31);
            this.tsb.TabIndex = 45;
            this.tsb.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(119, 28);
            this.tsbNuevo.Text = "Nueva Consulta";
            this.tsbNuevo.ToolTipText = "Nueva Consulta";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // chkRequiereEnvase
            // 
            this.chkRequiereEnvase.AutoSize = true;
            this.chkRequiereEnvase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRequiereEnvase.Location = new System.Drawing.Point(931, 142);
            this.chkRequiereEnvase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkRequiereEnvase.Name = "chkRequiereEnvase";
            this.chkRequiereEnvase.Size = new System.Drawing.Size(173, 28);
            this.chkRequiereEnvase.TabIndex = 79;
            this.chkRequiereEnvase.Text = "Requiere envase";
            this.chkRequiereEnvase.UseVisualStyleBackColor = true;
            // 
            // txtPrecioCosto
            // 
            this.txtPrecioCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCosto.Location = new System.Drawing.Point(224, 206);
            this.txtPrecioCosto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecioCosto.Name = "txtPrecioCosto";
            this.txtPrecioCosto.Size = new System.Drawing.Size(138, 31);
            this.txtPrecioCosto.TabIndex = 78;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(224, 159);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(138, 31);
            this.txtPrecio.TabIndex = 77;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // txtRubroDescripcion
            // 
            this.txtRubroDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRubroDescripcion.Location = new System.Drawing.Point(224, 302);
            this.txtRubroDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRubroDescripcion.Name = "txtRubroDescripcion";
            this.txtRubroDescripcion.Size = new System.Drawing.Size(564, 31);
            this.txtRubroDescripcion.TabIndex = 76;
            // 
            // txtIdRubro
            // 
            this.txtIdRubro.BackColor = System.Drawing.SystemColors.Info;
            this.txtIdRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdRubro.Location = new System.Drawing.Point(41, 307);
            this.txtIdRubro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdRubro.Name = "txtIdRubro";
            this.txtIdRubro.Size = new System.Drawing.Size(25, 24);
            this.txtIdRubro.TabIndex = 75;
            this.txtIdRubro.Visible = false;
            this.txtIdRubro.TextChanged += new System.EventHandler(this.txtIdRubro_TextChanged);
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(224, 255);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(564, 31);
            this.txtMarca.TabIndex = 74;
            // 
            // txtIdMarca
            // 
            this.txtIdMarca.BackColor = System.Drawing.SystemColors.Info;
            this.txtIdMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdMarca.Location = new System.Drawing.Point(41, 255);
            this.txtIdMarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdMarca.Name = "txtIdMarca";
            this.txtIdMarca.Size = new System.Drawing.Size(25, 24);
            this.txtIdMarca.TabIndex = 73;
            this.txtIdMarca.Visible = false;
            this.txtIdMarca.TextChanged += new System.EventHandler(this.txtIdMarca_TextChanged);
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProducto.Location = new System.Drawing.Point(12, 56);
            this.txtIdProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(25, 24);
            this.txtIdProducto.TabIndex = 72;
            this.txtIdProducto.Visible = false;
            this.txtIdProducto.TextChanged += new System.EventHandler(this.txtIdProducto_TextChanged);
            // 
            // txtNotas
            // 
            this.txtNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotas.Location = new System.Drawing.Point(224, 353);
            this.txtNotas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(564, 31);
            this.txtNotas.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(131, 356);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 71;
            this.label7.Text = "Notas:";
            // 
            // labPrecioCosto
            // 
            this.labPrecioCosto.AutoSize = true;
            this.labPrecioCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPrecioCosto.Location = new System.Drawing.Point(131, 209);
            this.labPrecioCosto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPrecioCosto.Name = "labPrecioCosto";
            this.labPrecioCosto.Size = new System.Drawing.Size(74, 25);
            this.labPrecioCosto.TabIndex = 70;
            this.labPrecioCosto.Tag = "Costo Promedio";
            this.labPrecioCosto.Text = "Costo:";
            // 
            // gbStock
            // 
            this.gbStock.Controls.Add(this.btnUpdateStock);
            this.gbStock.Controls.Add(this.nudStockActual);
            this.gbStock.Controls.Add(this.labStockActual);
            this.gbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.gbStock.Location = new System.Drawing.Point(931, 255);
            this.gbStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbStock.Name = "gbStock";
            this.gbStock.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbStock.Size = new System.Drawing.Size(501, 118);
            this.gbStock.TabIndex = 69;
            this.gbStock.TabStop = false;
            this.gbStock.Text = "Parámetros de Stock";
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.Location = new System.Drawing.Point(305, 49);
            this.btnUpdateStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(166, 38);
            this.btnUpdateStock.TabIndex = 26;
            this.btnUpdateStock.Text = "Actualizar";
            this.btnUpdateStock.UseVisualStyleBackColor = true;
            this.btnUpdateStock.Click += new System.EventHandler(this.btnUpdateStock_Click);
            // 
            // nudStockActual
            // 
            this.nudStockActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.nudStockActual.Location = new System.Drawing.Point(179, 54);
            this.nudStockActual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudStockActual.Name = "nudStockActual";
            this.nudStockActual.Size = new System.Drawing.Size(118, 31);
            this.nudStockActual.TabIndex = 24;
            // 
            // labStockActual
            // 
            this.labStockActual.AutoSize = true;
            this.labStockActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.labStockActual.Location = new System.Drawing.Point(27, 56);
            this.labStockActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labStockActual.Name = "labStockActual";
            this.labStockActual.Size = new System.Drawing.Size(138, 25);
            this.labStockActual.TabIndex = 25;
            this.labStockActual.Text = "Stock Actual:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(129, 307);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 68;
            this.label5.Text = "Rubro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 258);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 67;
            this.label4.Text = "Marca:";
            // 
            // chkSoloAdultos
            // 
            this.chkSoloAdultos.AutoSize = true;
            this.chkSoloAdultos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSoloAdultos.Location = new System.Drawing.Point(931, 104);
            this.chkSoloAdultos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkSoloAdultos.Name = "chkSoloAdultos";
            this.chkSoloAdultos.Size = new System.Drawing.Size(177, 28);
            this.chkSoloAdultos.TabIndex = 65;
            this.chkSoloAdultos.Text = "Solo para Adultos";
            this.chkSoloAdultos.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 66;
            this.label3.Text = "Precio:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(224, 107);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(564, 31);
            this.txtDescripcion.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 63;
            this.label2.Text = "Descripción:";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoBarras.Location = new System.Drawing.Point(224, 58);
            this.txtCodigoBarras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(212, 31);
            this.txtCodigoBarras.TabIndex = 60;
            this.txtCodigoBarras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoBarras_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 62;
            this.label1.Text = "Código:";
            // 
            // btnRegistrarVentaRapida
            // 
            this.btnRegistrarVentaRapida.Enabled = false;
            this.btnRegistrarVentaRapida.Location = new System.Drawing.Point(1272, 464);
            this.btnRegistrarVentaRapida.Name = "btnRegistrarVentaRapida";
            this.btnRegistrarVentaRapida.Size = new System.Drawing.Size(216, 33);
            this.btnRegistrarVentaRapida.TabIndex = 81;
            this.btnRegistrarVentaRapida.Text = "Registrar Venta Rapida";
            this.btnRegistrarVentaRapida.UseVisualStyleBackColor = true;
            this.btnRegistrarVentaRapida.Visible = false;
            this.btnRegistrarVentaRapida.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(892, 258);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(892, 101);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 84;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(892, 142);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 85;
            this.pictureBox3.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpProveedores);
            this.tabControl1.Controls.Add(this.tpPromociones);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(77, 494);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(711, 202);
            this.tabControl1.TabIndex = 87;
            // 
            // tpProveedores
            // 
            this.tpProveedores.Controls.Add(this._ucProductoProveedorList1);
            this.tpProveedores.ImageIndex = 0;
            this.tpProveedores.Location = new System.Drawing.Point(4, 29);
            this.tpProveedores.Name = "tpProveedores";
            this.tpProveedores.Padding = new System.Windows.Forms.Padding(3);
            this.tpProveedores.Size = new System.Drawing.Size(703, 169);
            this.tpProveedores.TabIndex = 0;
            this.tpProveedores.Text = "Proveedores";
            this.tpProveedores.UseVisualStyleBackColor = true;
            // 
            // _ucProductoProveedorList1
            // 
            this._ucProductoProveedorList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ucProductoProveedorList1.Fecha = null;
            this._ucProductoProveedorList1.IdProducto = ((long)(0));
            this._ucProductoProveedorList1.IdProductoProveedor = ((long)(0));
            this._ucProductoProveedorList1.IdProveedor = 0;
            this._ucProductoProveedorList1.Location = new System.Drawing.Point(3, 3);
            this._ucProductoProveedorList1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this._ucProductoProveedorList1.Name = "_ucProductoProveedorList1";
            this._ucProductoProveedorList1.Precio = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this._ucProductoProveedorList1.Size = new System.Drawing.Size(697, 163);
            this._ucProductoProveedorList1.TabIndex = 87;
            // 
            // tpPromociones
            // 
            this.tpPromociones.Location = new System.Drawing.Point(4, 29);
            this.tpPromociones.Name = "tpPromociones";
            this.tpPromociones.Size = new System.Drawing.Size(703, 169);
            this.tpPromociones.TabIndex = 1;
            this.tpPromociones.Text = "Promociones";
            this.tpPromociones.UseVisualStyleBackColor = true;
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
            // 
            // nudCantidadVenta
            // 
            this.nudCantidadVenta.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidadVenta.Location = new System.Drawing.Point(932, 464);
            this.nudCantidadVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudCantidadVenta.Name = "nudCantidadVenta";
            this.nudCantidadVenta.Size = new System.Drawing.Size(71, 33);
            this.nudCantidadVenta.TabIndex = 88;
            this.nudCantidadVenta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadVenta.Visible = false;
            this.nudCantidadVenta.ValueChanged += new System.EventHandler(this.nudCantidadVenta_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(928, 436);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 21);
            this.label8.TabIndex = 89;
            this.label8.Text = "Cantidad:";
            this.label8.Visible = false;
            // 
            // nudImporte
            // 
            this.nudImporte.DecimalPlaces = 2;
            this.nudImporte.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.nudImporte.Location = new System.Drawing.Point(1125, 464);
            this.nudImporte.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudImporte.Name = "nudImporte";
            this.nudImporte.Size = new System.Drawing.Size(141, 33);
            this.nudImporte.TabIndex = 92;
            this.nudImporte.TabStop = false;
            this.nudImporte.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.Location = new System.Drawing.Point(1121, 436);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 21);
            this.label9.TabIndex = 93;
            this.label9.Text = "Importe:";
            this.label9.Visible = false;
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.nudPrecio.Location = new System.Drawing.Point(1010, 464);
            this.nudPrecio.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(109, 33);
            this.nudPrecio.TabIndex = 90;
            this.nudPrecio.TabStop = false;
            this.nudPrecio.Visible = false;
            this.nudPrecio.ValueChanged += new System.EventHandler(this.nudPrecio_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label10.Location = new System.Drawing.Point(1006, 436);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 21);
            this.label10.TabIndex = 91;
            this.label10.Text = "Precio:";
            this.label10.Visible = false;
            // 
            // btnSeleccionarProducto
            // 
            this.btnSeleccionarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarProducto.Image")));
            this.btnSeleccionarProducto.Location = new System.Drawing.Point(443, 61);
            this.btnSeleccionarProducto.Name = "btnSeleccionarProducto";
            this.btnSeleccionarProducto.Size = new System.Drawing.Size(25, 25);
            this.btnSeleccionarProducto.TabIndex = 95;
            this.btnSeleccionarProducto.UseVisualStyleBackColor = true;
            this.btnSeleccionarProducto.Click += new System.EventHandler(this.btnSeleccionarProducto_Click);
            // 
            // btnMProducto
            // 
            this.btnMProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnMProducto.Image")));
            this.btnMProducto.Location = new System.Drawing.Point(474, 61);
            this.btnMProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMProducto.Name = "btnMProducto";
            this.btnMProducto.Size = new System.Drawing.Size(25, 25);
            this.btnMProducto.TabIndex = 97;
            this.btnMProducto.UseVisualStyleBackColor = true;
            this.btnMProducto.Click += new System.EventHandler(this.btnMProducto_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(851, 561);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(139, 48);
            this.btnGuardar.TabIndex = 98;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtPrecioPremium
            // 
            this.txtPrecioPremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioPremium.Location = new System.Drawing.Point(650, 159);
            this.txtPrecioPremium.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecioPremium.Name = "txtPrecioPremium";
            this.txtPrecioPremium.Size = new System.Drawing.Size(138, 31);
            this.txtPrecioPremium.TabIndex = 100;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(540, 159);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 99;
            this.label6.Text = "Premium:";
            // 
            // ucProductoEdit1
            // 
            this.ucProductoEdit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucProductoEdit1.Capacidad = 1;
            this.ucProductoEdit1.CodigoBarras = "";
            this.ucProductoEdit1.Descripcion = "";
            this.ucProductoEdit1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucProductoEdit1.IdMarca = 0;
            this.ucProductoEdit1.IdProducto = ((long)(0));
            this.ucProductoEdit1.IdRubro = 0;
            this.ucProductoEdit1.IdUnidad = 0;
            this.ucProductoEdit1.Location = new System.Drawing.Point(827, 275);
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
            this.ucProductoEdit1.PrecioVentaPremium = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ucProductoEdit1.Size = new System.Drawing.Size(912, 343);
            this.ucProductoEdit1.SoloAdultos = false;
            this.ucProductoEdit1.StockActual = 0;
            this.ucProductoEdit1.StockMaximo = 0;
            this.ucProductoEdit1.StockMinimo = 0;
            this.ucProductoEdit1.TabIndex = 96;
            this.ucProductoEdit1.Visible = false;
            // 
            // ucNotification2
            // 
            this.ucNotification2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucNotification2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucNotification2.Location = new System.Drawing.Point(932, 523);
            this.ucNotification2.Margin = new System.Windows.Forms.Padding(6);
            this.ucNotification2.Name = "ucNotification2";
            this.ucNotification2.Size = new System.Drawing.Size(564, 64);
            this.ucNotification2.TabIndex = 94;
            this.ucNotification2.Text = "[Mensaje]";
            this.ucNotification2.Visible = false;
            // 
            // ucNotification
            // 
            this.ucNotification.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucNotification.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucNotification.Location = new System.Drawing.Point(224, 406);
            this.ucNotification.Margin = new System.Windows.Forms.Padding(6);
            this.ucNotification.Name = "ucNotification";
            this.ucNotification.Size = new System.Drawing.Size(564, 64);
            this.ucNotification.TabIndex = 47;
            this.ucNotification.Text = "[Mensaje]";
            this.ucNotification.Visible = false;
            // 
            // FrmProductoDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 945);
            this.Controls.Add(this.txtPrecioPremium);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.ucProductoEdit1);
            this.Controls.Add(this.btnSeleccionarProducto);
            this.Controls.Add(this.ucNotification2);
            this.Controls.Add(this.nudImporte);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nudPrecio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nudCantidadVenta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegistrarVentaRapida);
            this.Controls.Add(this.chkRequiereEnvase);
            this.Controls.Add(this.txtPrecioCosto);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtRubroDescripcion);
            this.Controls.Add(this.txtIdRubro);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtIdMarca);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labPrecioCosto);
            this.Controls.Add(this.gbStock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkSoloAdultos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigoBarras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucNotification);
            this.Controls.Add(this.tsb);
            this.Controls.Add(this.btnMProducto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmProductoDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Producto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmProductoDetalle_Load);
            this.tsb.ResumeLayout(false);
            this.tsb.PerformLayout();
            this.gbStock.ResumeLayout(false);
            this.gbStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpProveedores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip tsb;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private UcNotification ucNotification;
        private System.Windows.Forms.CheckBox chkRequiereEnvase;
        private System.Windows.Forms.TextBox txtPrecioCosto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtRubroDescripcion;
        private System.Windows.Forms.TextBox txtIdRubro;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtIdMarca;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labPrecioCosto;
        private System.Windows.Forms.GroupBox gbStock;
        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.NumericUpDown nudStockActual;
        private System.Windows.Forms.Label labStockActual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkSoloAdultos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrarVentaRapida;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpProveedores;
        private UcProductoProveedorList _ucProductoProveedorList1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.NumericUpDown nudCantidadVenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudImporte;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Label label10;
        private UcNotification ucNotification2;
        private System.Windows.Forms.TabPage tpPromociones;
        private System.Windows.Forms.Button btnSeleccionarProducto;
        private UcProductoEdit ucProductoEdit1;
        private System.Windows.Forms.Button btnMProducto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtPrecioPremium;
        private System.Windows.Forms.Label label6;
    }
}