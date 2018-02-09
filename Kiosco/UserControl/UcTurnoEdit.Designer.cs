namespace Heimdall.UserControl
{
    partial class UcTurnoEdit
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
            this.txtIdTurno = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.nudCantidadHoras = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudMonto = new System.Windows.Forms.NumericUpDown();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdPagoEmpleado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdTurno
            // 
            this.txtIdTurno.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtIdTurno.Location = new System.Drawing.Point(3, 2);
            this.txtIdTurno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdTurno.Name = "txtIdTurno";
            this.txtIdTurno.Size = new System.Drawing.Size(16, 27);
            this.txtIdTurno.TabIndex = 75;
            this.txtIdTurno.Text = "0";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtDescripcion.Location = new System.Drawing.Point(120, 12);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(393, 27);
            this.txtDescripcion.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(32, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 77;
            this.label2.Text = "Descripción:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(120, 45);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.ShowCheckBox = true;
            this.dtpFecha.Size = new System.Drawing.Size(128, 25);
            this.dtpFecha.TabIndex = 108;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(67, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 107;
            this.label1.Text = "Fecha:";
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.Location = new System.Drawing.Point(120, 76);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.ShowCheckBox = true;
            this.dtpHoraInicio.Size = new System.Drawing.Size(128, 25);
            this.dtpHoraInicio.TabIndex = 110;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(36, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 109;
            this.label3.Text = "Hora Inicio:";
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFin.Location = new System.Drawing.Point(385, 75);
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.ShowCheckBox = true;
            this.dtpHoraFin.Size = new System.Drawing.Size(128, 25);
            this.dtpHoraFin.TabIndex = 112;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(315, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 111;
            this.label4.Text = "Hora Fin:";
            // 
            // nudCantidadHoras
            // 
            this.nudCantidadHoras.BackColor = System.Drawing.Color.White;
            this.nudCantidadHoras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudCantidadHoras.DecimalPlaces = 2;
            this.nudCantidadHoras.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudCantidadHoras.Location = new System.Drawing.Point(120, 107);
            this.nudCantidadHoras.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudCantidadHoras.Name = "nudCantidadHoras";
            this.nudCantidadHoras.Size = new System.Drawing.Size(68, 25);
            this.nudCantidadHoras.TabIndex = 113;
            this.nudCantidadHoras.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(7, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 19);
            this.label5.TabIndex = 114;
            this.label5.Text = "Cantidad Horas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(60, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 116;
            this.label6.Text = "Monto:";
            // 
            // nudMonto
            // 
            this.nudMonto.BackColor = System.Drawing.SystemColors.Menu;
            this.nudMonto.DecimalPlaces = 2;
            this.nudMonto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudMonto.Location = new System.Drawing.Point(120, 138);
            this.nudMonto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudMonto.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudMonto.Name = "nudMonto";
            this.nudMonto.Size = new System.Drawing.Size(128, 25);
            this.nudMonto.TabIndex = 115;
            this.nudMonto.TabStop = false;
            // 
            // txtNotas
            // 
            this.txtNotas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNotas.Location = new System.Drawing.Point(120, 169);
            this.txtNotas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(393, 25);
            this.txtNotas.TabIndex = 117;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.Location = new System.Drawing.Point(66, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 19);
            this.label7.TabIndex = 118;
            this.label7.Text = "Notas:";
            // 
            // txtIdPagoEmpleado
            // 
            this.txtIdPagoEmpleado.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtIdPagoEmpleado.Location = new System.Drawing.Point(11, 39);
            this.txtIdPagoEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdPagoEmpleado.Name = "txtIdPagoEmpleado";
            this.txtIdPagoEmpleado.Size = new System.Drawing.Size(16, 27);
            this.txtIdPagoEmpleado.TabIndex = 119;
            this.txtIdPagoEmpleado.Text = "0";
            this.txtIdPagoEmpleado.Visible = false;
            // 
            // UcTurnoEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtIdPagoEmpleado);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudMonto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudCantidadHoras);
            this.Controls.Add(this.dtpHoraFin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpHoraInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdTurno);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UcTurnoEdit";
            this.Size = new System.Drawing.Size(535, 203);
            this.Load += new System.EventHandler(this.UcTurnoEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdTurno;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpHoraFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudCantidadHoras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudMonto;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdPagoEmpleado;
    }
}
