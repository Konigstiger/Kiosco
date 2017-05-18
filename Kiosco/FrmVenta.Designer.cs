namespace Kiosco
{
    partial class FrmVenta
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
            if (disposing && (components != null))
            {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenta));
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.tsb = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.nudImporte = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnRemoverItem = new System.Windows.Forms.Button();
            this.txtClienteDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.nudTotal = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSeleccionarCliente = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaActual = new System.Windows.Forms.DateTimePicker();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nudCantidadEnvases = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarEnvase = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnConfirmation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            this.tsb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadEnvases)).BeginInit();
            this.SuspendLayout();
            // 
            // nudPrecio
            // 
            this.nudPrecio.BackColor = System.Drawing.SystemColors.Menu;
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.nudPrecio.Location = new System.Drawing.Point(556, 442);
            this.nudPrecio.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(141, 24);
            this.nudPrecio.TabIndex = 31;
            this.nudPrecio.TabStop = false;
            this.nudPrecio.ValueChanged += new System.EventHandler(this.nudPrecio_ValueChanged);
            // 
            // tsb
            // 
            this.tsb.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo});
            this.tsb.Location = new System.Drawing.Point(0, 0);
            this.tsb.Name = "tsb";
            this.tsb.Size = new System.Drawing.Size(1134, 31);
            this.tsb.TabIndex = 44;
            this.tsb.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(101, 28);
            this.tsbNuevo.Text = "Nueva Venta";
            this.tsbNuevo.ToolTipText = "Nueva Venta";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(553, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 39;
            this.label3.Text = "Precio:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(257, 442);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(293, 24);
            this.txtDescripcion.TabIndex = 30;
            this.txtDescripcion.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(254, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Descripción:";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoBarras.Location = new System.Drawing.Point(12, 442);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(143, 24);
            this.txtCodigoBarras.TabIndex = 1;
            this.txtCodigoBarras.TextChanged += new System.EventHandler(this.txtCodigoBarras_TextChanged);
            this.txtCodigoBarras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoBarras_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Código:";
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 96);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1110, 322);
            this.dgv.TabIndex = 40;
            this.dgv.TabStop = false;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(158, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 48;
            this.label6.Text = "Cantidad:";
            // 
            // nudImporte
            // 
            this.nudImporte.BackColor = System.Drawing.SystemColors.Menu;
            this.nudImporte.DecimalPlaces = 2;
            this.nudImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.nudImporte.Location = new System.Drawing.Point(703, 442);
            this.nudImporte.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudImporte.Name = "nudImporte";
            this.nudImporte.Size = new System.Drawing.Size(141, 24);
            this.nudImporte.TabIndex = 49;
            this.nudImporte.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(700, 421);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 50;
            this.label8.Text = "Importe:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(863, 435);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 40);
            this.btnAgregar.TabIndex = 51;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnRemoverItem
            // 
            this.btnRemoverItem.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoverItem.Image")));
            this.btnRemoverItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoverItem.Location = new System.Drawing.Point(863, 481);
            this.btnRemoverItem.Name = "btnRemoverItem";
            this.btnRemoverItem.Size = new System.Drawing.Size(94, 40);
            this.btnRemoverItem.TabIndex = 52;
            this.btnRemoverItem.Text = "Remover";
            this.btnRemoverItem.UseVisualStyleBackColor = true;
            this.btnRemoverItem.Click += new System.EventHandler(this.btnRemoverItem_Click);
            // 
            // txtClienteDescripcion
            // 
            this.txtClienteDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteDescripcion.Location = new System.Drawing.Point(12, 66);
            this.txtClienteDescripcion.Name = "txtClienteDescripcion";
            this.txtClienteDescripcion.Size = new System.Drawing.Size(292, 24);
            this.txtClienteDescripcion.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 54;
            this.label4.Text = "Cliente:";
            // 
            // nudCantidad
            // 
            this.nudCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.nudCantidad.Location = new System.Drawing.Point(163, 442);
            this.nudCantidad.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(88, 24);
            this.nudCantidad.TabIndex = 2;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.ValueChanged += new System.EventHandler(this.nudCantidad_ValueChanged);
            this.nudCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudCantidad_KeyDown);
            // 
            // nudTotal
            // 
            this.nudTotal.BackColor = System.Drawing.SystemColors.Info;
            this.nudTotal.DecimalPlaces = 2;
            this.nudTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.nudTotal.Location = new System.Drawing.Point(703, 497);
            this.nudTotal.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudTotal.Name = "nudTotal";
            this.nudTotal.Size = new System.Drawing.Size(141, 24);
            this.nudTotal.TabIndex = 56;
            this.nudTotal.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(700, 477);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 57;
            this.label5.Text = "Total:";
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(963, 435);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(94, 40);
            this.btnModificar.TabIndex = 60;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.SystemColors.Menu;
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(554, 497);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(143, 24);
            this.txtStock.TabIndex = 61;
            this.txtStock.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(551, 476);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 18);
            this.label9.TabIndex = 62;
            this.label9.Text = "Stock:";
            // 
            // btnSeleccionarCliente
            // 
            this.btnSeleccionarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarCliente.Image")));
            this.btnSeleccionarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionarCliente.Location = new System.Drawing.Point(310, 66);
            this.btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            this.btnSeleccionarCliente.Size = new System.Drawing.Size(181, 24);
            this.btnSeleccionarCliente.TabIndex = 63;
            this.btnSeleccionarCliente.Text = "Seleccionar Cliente...";
            this.btnSeleccionarCliente.UseVisualStyleBackColor = true;
            this.btnSeleccionarCliente.Click += new System.EventHandler(this.btnSeleccionarCliente_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label7.Location = new System.Drawing.Point(949, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 18);
            this.label7.TabIndex = 64;
            this.label7.Text = "Fecha:";
            // 
            // dtpFechaActual
            // 
            this.dtpFechaActual.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaActual.Location = new System.Drawing.Point(1008, 64);
            this.dtpFechaActual.Name = "dtpFechaActual";
            this.dtpFechaActual.Size = new System.Drawing.Size(106, 20);
            this.dtpFechaActual.TabIndex = 65;
            this.dtpFechaActual.Value = new System.DateTime(2017, 3, 12, 3, 16, 50, 0);
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCliente.Location = new System.Drawing.Point(497, 66);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(30, 24);
            this.txtIdCliente.TabIndex = 66;
            this.txtIdCliente.Visible = false;
            this.txtIdCliente.TextChanged += new System.EventHandler(this.txtIdCliente_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 499);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 18);
            this.label10.TabIndex = 67;
            this.label10.Text = "Envase:";
            this.label10.Visible = false;
            // 
            // nudCantidadEnvases
            // 
            this.nudCantidadEnvases.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudCantidadEnvases.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.nudCantidadEnvases.Location = new System.Drawing.Point(92, 497);
            this.nudCantidadEnvases.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudCantidadEnvases.Name = "nudCantidadEnvases";
            this.nudCantidadEnvases.Size = new System.Drawing.Size(88, 24);
            this.nudCantidadEnvases.TabIndex = 68;
            this.nudCantidadEnvases.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadEnvases.Visible = false;
            // 
            // btnAgregarEnvase
            // 
            this.btnAgregarEnvase.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarEnvase.Image")));
            this.btnAgregarEnvase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarEnvase.Location = new System.Drawing.Point(186, 492);
            this.btnAgregarEnvase.Name = "btnAgregarEnvase";
            this.btnAgregarEnvase.Size = new System.Drawing.Size(94, 40);
            this.btnAgregarEnvase.TabIndex = 69;
            this.btnAgregarEnvase.Text = "Agregar";
            this.btnAgregarEnvase.UseVisualStyleBackColor = true;
            this.btnAgregarEnvase.Visible = false;
            this.btnAgregarEnvase.Click += new System.EventHandler(this.btnAgregarEnvase_Click);
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(556, 545);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(288, 37);
            this.btnVender.TabIndex = 70;
            this.btnVender.Text = "(F5) Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnConfirmation
            // 
            this.btnConfirmation.Location = new System.Drawing.Point(92, 556);
            this.btnConfirmation.Name = "btnConfirmation";
            this.btnConfirmation.Size = new System.Drawing.Size(188, 23);
            this.btnConfirmation.TabIndex = 71;
            this.btnConfirmation.Text = "button1";
            this.btnConfirmation.UseVisualStyleBackColor = true;
            this.btnConfirmation.Click += new System.EventHandler(this.btnConfirmation_Click);
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 747);
            this.Controls.Add(this.btnConfirmation);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.btnAgregarEnvase);
            this.Controls.Add(this.nudCantidadEnvases);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.dtpFechaActual);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSeleccionarCliente);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.nudTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.txtClienteDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRemoverItem);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.nudImporte);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudPrecio);
            this.Controls.Add(this.tsb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigoBarras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVenta";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            this.tsb.ResumeLayout(false);
            this.tsb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadEnvases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.ToolStrip tsb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudImporte;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnRemoverItem;
        private System.Windows.Forms.TextBox txtClienteDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.NumericUpDown nudTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSeleccionarCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaActual;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudCantidadEnvases;
        private System.Windows.Forms.Button btnAgregarEnvase;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnConfirmation;
    }
}