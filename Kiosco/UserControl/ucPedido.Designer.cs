namespace Kiosco.UserControl
{
    partial class ucPedido
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPedido));
            this.label5 = new System.Windows.Forms.Label();
            this.nudImporte = new System.Windows.Forms.NumericUpDown();
            this.dtpHoraEntrega = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.txtProveedorDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboEstadoPedido = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAbmProveedor = new System.Windows.Forms.Button();
            this.btnSeleccionarProveedor = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudImporte)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(445, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 112;
            this.label5.Text = "Total:";
            // 
            // nudImporte
            // 
            this.nudImporte.BackColor = System.Drawing.SystemColors.Menu;
            this.nudImporte.DecimalPlaces = 2;
            this.nudImporte.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudImporte.Location = new System.Drawing.Point(492, 75);
            this.nudImporte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudImporte.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudImporte.Name = "nudImporte";
            this.nudImporte.Size = new System.Drawing.Size(212, 25);
            this.nudImporte.TabIndex = 111;
            this.nudImporte.TabStop = false;
            // 
            // dtpHoraEntrega
            // 
            this.dtpHoraEntrega.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpHoraEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraEntrega.Location = new System.Drawing.Point(492, 107);
            this.dtpHoraEntrega.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpHoraEntrega.Name = "dtpHoraEntrega";
            this.dtpHoraEntrega.ShowCheckBox = true;
            this.dtpHoraEntrega.ShowUpDown = true;
            this.dtpHoraEntrega.Size = new System.Drawing.Size(211, 25);
            this.dtpHoraEntrega.TabIndex = 110;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(393, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 109;
            this.label3.Text = "Hora Entrega:";
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntrega.Location = new System.Drawing.Point(145, 107);
            this.dtpFechaEntrega.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.ShowCheckBox = true;
            this.dtpFechaEntrega.Size = new System.Drawing.Size(170, 25);
            this.dtpFechaEntrega.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(41, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 107;
            this.label2.Text = "Fecha Entrega:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(145, 75);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.ShowCheckBox = true;
            this.dtpFecha.Size = new System.Drawing.Size(170, 25);
            this.dtpFecha.TabIndex = 106;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(92, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 105;
            this.label1.Text = "Fecha:";
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.BackColor = System.Drawing.SystemColors.Info;
            this.txtIdPedido.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtIdPedido.Location = new System.Drawing.Point(3, 4);
            this.txtIdPedido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.Size = new System.Drawing.Size(26, 25);
            this.txtIdPedido.TabIndex = 104;
            this.txtIdPedido.Text = "0";
            this.txtIdPedido.TextChanged += new System.EventHandler(this.txtIdPedido_TextChanged);
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtIdProveedor.Location = new System.Drawing.Point(711, 44);
            this.txtIdProveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.Size = new System.Drawing.Size(34, 25);
            this.txtIdProveedor.TabIndex = 103;
            this.txtIdProveedor.Text = "0";
            this.txtIdProveedor.TextChanged += new System.EventHandler(this.txtIdProveedor_TextChanged);
            // 
            // txtProveedorDescripcion
            // 
            this.txtProveedorDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProveedorDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtProveedorDescripcion.Location = new System.Drawing.Point(145, 43);
            this.txtProveedorDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProveedorDescripcion.Name = "txtProveedorDescripcion";
            this.txtProveedorDescripcion.Size = new System.Drawing.Size(486, 25);
            this.txtProveedorDescripcion.TabIndex = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(64, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 101;
            this.label4.Text = "Proveedor:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescripcion.Location = new System.Drawing.Point(145, 12);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(558, 25);
            this.txtDescripcion.TabIndex = 115;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(57, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 19);
            this.label6.TabIndex = 116;
            this.label6.Text = "Descripcion:";
            // 
            // txtNotas
            // 
            this.txtNotas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNotas.Location = new System.Drawing.Point(145, 136);
            this.txtNotas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(558, 25);
            this.txtNotas.TabIndex = 113;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.Location = new System.Drawing.Point(91, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 19);
            this.label7.TabIndex = 114;
            this.label7.Text = "Notas:";
            // 
            // cboEstadoPedido
            // 
            this.cboEstadoPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoPedido.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboEstadoPedido.FormattingEnabled = true;
            this.cboEstadoPedido.Location = new System.Drawing.Point(820, 12);
            this.cboEstadoPedido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboEstadoPedido.Name = "cboEstadoPedido";
            this.cboEstadoPedido.Size = new System.Drawing.Size(254, 25);
            this.cboEstadoPedido.TabIndex = 117;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.Location = new System.Drawing.Point(744, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 19);
            this.label8.TabIndex = 118;
            this.label8.Text = "Estado:";
            // 
            // btnAbmProveedor
            // 
            this.btnAbmProveedor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAbmProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnAbmProveedor.Image")));
            this.btnAbmProveedor.Location = new System.Drawing.Point(673, 40);
            this.btnAbmProveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAbmProveedor.Name = "btnAbmProveedor";
            this.btnAbmProveedor.Size = new System.Drawing.Size(30, 32);
            this.btnAbmProveedor.TabIndex = 120;
            this.btnAbmProveedor.UseVisualStyleBackColor = true;
            this.btnAbmProveedor.Click += new System.EventHandler(this.btnAbmProveedor_Click);
            // 
            // btnSeleccionarProveedor
            // 
            this.btnSeleccionarProveedor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSeleccionarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarProveedor.Image")));
            this.btnSeleccionarProveedor.Location = new System.Drawing.Point(638, 40);
            this.btnSeleccionarProveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSeleccionarProveedor.Name = "btnSeleccionarProveedor";
            this.btnSeleccionarProveedor.Size = new System.Drawing.Size(30, 32);
            this.btnSeleccionarProveedor.TabIndex = 119;
            this.btnSeleccionarProveedor.UseVisualStyleBackColor = true;
            this.btnSeleccionarProveedor.Click += new System.EventHandler(this.btnSeleccionarProveedor_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnGuardar.Location = new System.Drawing.Point(820, 102);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(254, 59);
            this.btnGuardar.TabIndex = 121;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // ucPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAbmProveedor);
            this.Controls.Add(this.btnSeleccionarProveedor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboEstadoPedido);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudImporte);
            this.Controls.Add(this.dtpHoraEntrega);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFechaEntrega);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdPedido);
            this.Controls.Add(this.txtIdProveedor);
            this.Controls.Add(this.txtProveedorDescripcion);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucPedido";
            this.Size = new System.Drawing.Size(1085, 174);
            this.Load += new System.EventHandler(this.ucPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudImporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudImporte;
        private System.Windows.Forms.DateTimePicker dtpHoraEntrega;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.TextBox txtIdProveedor;
        private System.Windows.Forms.TextBox txtProveedorDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboEstadoPedido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAbmProveedor;
        private System.Windows.Forms.Button btnSeleccionarProveedor;
        private System.Windows.Forms.Button btnGuardar;
    }
}
