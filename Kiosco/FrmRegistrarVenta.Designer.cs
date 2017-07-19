namespace Kiosco
{
    partial class FrmRegistrarVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarVenta));
            this.tsb = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtClienteDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudTotal = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaActual = new System.Windows.Forms.DateTimePicker();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.btnVender = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucNotification1 = new Kiosco.UcNotification();
            this.btnSeleccionarCliente = new System.Windows.Forms.Button();
            this.ucVentaDetalleEdit1 = new Heimdall.UserControl.UcVentaDetalleEdit();
            this.tsb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsb
            // 
            this.tsb.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo});
            this.tsb.Location = new System.Drawing.Point(0, 0);
            this.tsb.Name = "tsb";
            this.tsb.Size = new System.Drawing.Size(1178, 31);
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
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 99);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1157, 388);
            this.dgv.TabIndex = 40;
            this.dgv.TabStop = false;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
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
            this.label4.Font = new System.Drawing.Font("WillowBody", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 54;
            this.label4.Text = "Cliente:";
            // 
            // nudTotal
            // 
            this.nudTotal.BackColor = System.Drawing.SystemColors.Info;
            this.nudTotal.DecimalPlaces = 2;
            this.nudTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.nudTotal.Location = new System.Drawing.Point(795, 25);
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
            this.label5.Location = new System.Drawing.Point(744, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 57;
            this.label5.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("WillowBody", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(952, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 64;
            this.label7.Text = "Fecha:";
            // 
            // dtpFechaActual
            // 
            this.dtpFechaActual.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaActual.Location = new System.Drawing.Point(1011, 68);
            this.dtpFechaActual.Name = "dtpFechaActual";
            this.dtpFechaActual.Size = new System.Drawing.Size(106, 20);
            this.dtpFechaActual.TabIndex = 65;
            this.dtpFechaActual.Value = new System.DateTime(2017, 3, 12, 3, 16, 50, 0);
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCliente.Location = new System.Drawing.Point(340, 67);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(30, 24);
            this.txtIdCliente.TabIndex = 66;
            this.txtIdCliente.Visible = false;
            this.txtIdCliente.TextChanged += new System.EventHandler(this.txtIdCliente_TextChanged);
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.SystemColors.Control;
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVender.Font = new System.Drawing.Font("WillowBody", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVender.Location = new System.Drawing.Point(942, 19);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(159, 33);
            this.btnVender.TabIndex = 70;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.nudTotal);
            this.panel1.Controls.Add(this.ucNotification1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnVender);
            this.panel1.Location = new System.Drawing.Point(12, 574);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1157, 76);
            this.panel1.TabIndex = 73;
            // 
            // ucNotification1
            // 
            this.ucNotification1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucNotification1.Location = new System.Drawing.Point(6, 6);
            this.ucNotification1.Margin = new System.Windows.Forms.Padding(6);
            this.ucNotification1.Name = "ucNotification1";
            this.ucNotification1.Size = new System.Drawing.Size(603, 64);
            this.ucNotification1.TabIndex = 72;
            this.ucNotification1.Text = "ucNotification1";
            this.ucNotification1.Visible = false;
            // 
            // btnSeleccionarCliente
            // 
            this.btnSeleccionarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarCliente.Image")));
            this.btnSeleccionarCliente.Location = new System.Drawing.Point(310, 67);
            this.btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            this.btnSeleccionarCliente.Size = new System.Drawing.Size(24, 24);
            this.btnSeleccionarCliente.TabIndex = 63;
            this.btnSeleccionarCliente.UseVisualStyleBackColor = true;
            this.btnSeleccionarCliente.Click += new System.EventHandler(this.btnSeleccionarCliente_Click);
            // 
            // ucVentaDetalleEdit1
            // 
            this.ucVentaDetalleEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucVentaDetalleEdit1.Cantidad = 1;
            this.ucVentaDetalleEdit1.CodigoBarras = "";
            this.ucVentaDetalleEdit1.Descripcion = "";
            this.ucVentaDetalleEdit1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucVentaDetalleEdit1.IdProducto = ((long)(0));
            this.ucVentaDetalleEdit1.Importe = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucVentaDetalleEdit1.Location = new System.Drawing.Point(12, 494);
            this.ucVentaDetalleEdit1.Name = "ucVentaDetalleEdit1";
            this.ucVentaDetalleEdit1.PrecioVenta = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucVentaDetalleEdit1.Size = new System.Drawing.Size(1157, 57);
            this.ucVentaDetalleEdit1.Stock = 0;
            this.ucVentaDetalleEdit1.TabIndex = 74;
            this.ucVentaDetalleEdit1.AddAction += new Heimdall.UserControl.AddActionEventHandler(this.ucVentaDetalleEdit1_AddAction);
            this.ucVentaDetalleEdit1.UpdateAction += new Heimdall.UserControl.UpdateActionEventHandler(this.ucVentaDetalleEdit1_UpdateAction);
            this.ucVentaDetalleEdit1.RemoveAction += new Heimdall.UserControl.RemoveActionEventHandler(this.ucVentaDetalleEdit1_RemoveAction);
            // 
            // FrmRegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 653);
            this.Controls.Add(this.ucVentaDetalleEdit1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.dtpFechaActual);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSeleccionarCliente);
            this.Controls.Add(this.txtClienteDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tsb);
            this.Controls.Add(this.dgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRegistrarVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Venta";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            this.tsb.ResumeLayout(false);
            this.tsb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip tsb;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtClienteDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.NumericUpDown nudTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSeleccionarCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaActual;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Button btnVender;
        private UcNotification ucNotification1;
        private System.Windows.Forms.Panel panel1;
        private Heimdall.UserControl.UcVentaDetalleEdit ucVentaDetalleEdit1;
    }
}