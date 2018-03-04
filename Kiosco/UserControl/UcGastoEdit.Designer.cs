namespace Heimdall.UserControl
{
    partial class UcGastoEdit
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
            this.label6 = new System.Windows.Forms.Label();
            this.cboPrioridad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboClaseGasto = new System.Windows.Forms.ComboBox();
            this.chkArchivado = new System.Windows.Forms.CheckBox();
            this.nudMonto = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboEstadoGasto = new System.Windows.Forms.ComboBox();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdGasto = new System.Windows.Forms.TextBox();
            this.nudMontoPendiente = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontoPendiente)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(517, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 201;
            this.label6.Text = "Prioridad:";
            // 
            // cboPrioridad
            // 
            this.cboPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrioridad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboPrioridad.FormattingEnabled = true;
            this.cboPrioridad.Location = new System.Drawing.Point(590, 86);
            this.cboPrioridad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboPrioridad.Name = "cboPrioridad";
            this.cboPrioridad.Size = new System.Drawing.Size(166, 25);
            this.cboPrioridad.TabIndex = 200;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(540, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 19);
            this.label5.TabIndex = 199;
            this.label5.Text = "Clase:";
            // 
            // cboClaseGasto
            // 
            this.cboClaseGasto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClaseGasto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboClaseGasto.FormattingEnabled = true;
            this.cboClaseGasto.Location = new System.Drawing.Point(590, 17);
            this.cboClaseGasto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboClaseGasto.Name = "cboClaseGasto";
            this.cboClaseGasto.Size = new System.Drawing.Size(166, 25);
            this.cboClaseGasto.TabIndex = 198;
            // 
            // chkArchivado
            // 
            this.chkArchivado.AutoSize = true;
            this.chkArchivado.Location = new System.Drawing.Point(590, 118);
            this.chkArchivado.Name = "chkArchivado";
            this.chkArchivado.Size = new System.Drawing.Size(86, 17);
            this.chkArchivado.TabIndex = 197;
            this.chkArchivado.Text = "¿Archivado?";
            this.chkArchivado.UseVisualStyleBackColor = true;
            // 
            // nudMonto
            // 
            this.nudMonto.DecimalPlaces = 2;
            this.nudMonto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudMonto.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudMonto.Location = new System.Drawing.Point(102, 50);
            this.nudMonto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudMonto.Name = "nudMonto";
            this.nudMonto.Size = new System.Drawing.Size(128, 25);
            this.nudMonto.TabIndex = 196;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.Location = new System.Drawing.Point(45, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 19);
            this.label9.TabIndex = 195;
            this.label9.Text = "Monto:";
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPago.Location = new System.Drawing.Point(367, 80);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.ShowCheckBox = true;
            this.dtpFechaPago.Size = new System.Drawing.Size(128, 25);
            this.dtpFechaPago.TabIndex = 194;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(318, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 193;
            this.label4.Text = "Pago:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(531, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 192;
            this.label3.Text = "Estado:";
            // 
            // cboEstadoGasto
            // 
            this.cboEstadoGasto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoGasto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboEstadoGasto.FormattingEnabled = true;
            this.cboEstadoGasto.Location = new System.Drawing.Point(590, 53);
            this.cboEstadoGasto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboEstadoGasto.Name = "cboEstadoGasto";
            this.cboEstadoGasto.Size = new System.Drawing.Size(166, 25);
            this.cboEstadoGasto.TabIndex = 191;
            // 
            // txtNotas
            // 
            this.txtNotas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNotas.Location = new System.Drawing.Point(102, 110);
            this.txtNotas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(393, 25);
            this.txtNotas.TabIndex = 189;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.Location = new System.Drawing.Point(51, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 19);
            this.label7.TabIndex = 190;
            this.label7.Text = "Notas:";
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(102, 80);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.ShowCheckBox = true;
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(128, 25);
            this.dtpFechaVencimiento.TabIndex = 188;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 187;
            this.label1.Text = "Vencimiento:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtDescripcion.Location = new System.Drawing.Point(102, 17);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(393, 27);
            this.txtDescripcion.TabIndex = 185;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(17, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 186;
            this.label2.Text = "Descripción:";
            // 
            // txtIdGasto
            // 
            this.txtIdGasto.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtIdGasto.Location = new System.Drawing.Point(3, 8);
            this.txtIdGasto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdGasto.Name = "txtIdGasto";
            this.txtIdGasto.Size = new System.Drawing.Size(16, 27);
            this.txtIdGasto.TabIndex = 184;
            this.txtIdGasto.Text = "0";
            this.txtIdGasto.Visible = false;
            // 
            // nudMontoPendiente
            // 
            this.nudMontoPendiente.DecimalPlaces = 2;
            this.nudMontoPendiente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudMontoPendiente.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudMontoPendiente.Location = new System.Drawing.Point(367, 50);
            this.nudMontoPendiente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudMontoPendiente.Name = "nudMontoPendiente";
            this.nudMontoPendiente.Size = new System.Drawing.Size(128, 25);
            this.nudMontoPendiente.TabIndex = 203;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.Location = new System.Drawing.Point(289, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 19);
            this.label8.TabIndex = 202;
            this.label8.Text = "Pendiente:";
            // 
            // UcGastoEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nudMontoPendiente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboPrioridad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboClaseGasto);
            this.Controls.Add(this.chkArchivado);
            this.Controls.Add(this.nudMonto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpFechaPago);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboEstadoGasto);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpFechaVencimiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdGasto);
            this.Name = "UcGastoEdit";
            this.Size = new System.Drawing.Size(769, 149);
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontoPendiente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboPrioridad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboClaseGasto;
        private System.Windows.Forms.CheckBox chkArchivado;
        private System.Windows.Forms.NumericUpDown nudMonto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboEstadoGasto;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdGasto;
        private System.Windows.Forms.NumericUpDown nudMontoPendiente;
        private System.Windows.Forms.Label label8;
    }
}
