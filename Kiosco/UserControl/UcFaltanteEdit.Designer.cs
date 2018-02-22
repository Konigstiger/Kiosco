namespace Heimdall.UserControl
{
    partial class UcFaltanteEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcFaltanteEdit));
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.chkArchivado = new System.Windows.Forms.CheckBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFechaResuelto = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboEstadoFaltante = new System.Windows.Forms.ComboBox();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdFaltante = new System.Windows.Forms.TextBox();
            this.btnAbmProducto = new System.Windows.Forms.Button();
            this.btnSeleccionarProducto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboClaseFaltante = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtIdProducto.Location = new System.Drawing.Point(503, 12);
            this.txtIdProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(26, 27);
            this.txtIdProducto.TabIndex = 177;
            this.txtIdProducto.Text = "0";
            // 
            // chkArchivado
            // 
            this.chkArchivado.AutoSize = true;
            this.chkArchivado.Location = new System.Drawing.Point(590, 107);
            this.chkArchivado.Name = "chkArchivado";
            this.chkArchivado.Size = new System.Drawing.Size(101, 23);
            this.chkArchivado.TabIndex = 176;
            this.chkArchivado.Text = "¿Archivado?";
            this.chkArchivado.UseVisualStyleBackColor = true;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudCantidad.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudCantidad.Location = new System.Drawing.Point(102, 46);
            this.nudCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(61, 25);
            this.nudCantidad.TabIndex = 173;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.Location = new System.Drawing.Point(29, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 19);
            this.label9.TabIndex = 172;
            this.label9.Text = "Cantidad:";
            // 
            // dtpFechaResuelto
            // 
            this.dtpFechaResuelto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFechaResuelto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaResuelto.Location = new System.Drawing.Point(367, 76);
            this.dtpFechaResuelto.Name = "dtpFechaResuelto";
            this.dtpFechaResuelto.ShowCheckBox = true;
            this.dtpFechaResuelto.Size = new System.Drawing.Size(128, 25);
            this.dtpFechaResuelto.TabIndex = 167;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(297, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 166;
            this.label4.Text = "Resuelto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(531, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 165;
            this.label3.Text = "Estado:";
            // 
            // cboEstadoFaltante
            // 
            this.cboEstadoFaltante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoFaltante.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboEstadoFaltante.FormattingEnabled = true;
            this.cboEstadoFaltante.Location = new System.Drawing.Point(590, 49);
            this.cboEstadoFaltante.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboEstadoFaltante.Name = "cboEstadoFaltante";
            this.cboEstadoFaltante.Size = new System.Drawing.Size(162, 25);
            this.cboEstadoFaltante.TabIndex = 164;
            // 
            // txtNotas
            // 
            this.txtNotas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNotas.Location = new System.Drawing.Point(102, 106);
            this.txtNotas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(393, 25);
            this.txtNotas.TabIndex = 159;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.Location = new System.Drawing.Point(48, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 19);
            this.label7.TabIndex = 160;
            this.label7.Text = "Notas:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(102, 76);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.ShowCheckBox = true;
            this.dtpFecha.Size = new System.Drawing.Size(128, 25);
            this.dtpFecha.TabIndex = 158;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(49, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 157;
            this.label1.Text = "Fecha:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtDescripcion.Location = new System.Drawing.Point(102, 13);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(324, 27);
            this.txtDescripcion.TabIndex = 155;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(14, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 156;
            this.label2.Text = "Descripción:";
            // 
            // txtIdFaltante
            // 
            this.txtIdFaltante.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtIdFaltante.Location = new System.Drawing.Point(3, 4);
            this.txtIdFaltante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdFaltante.Name = "txtIdFaltante";
            this.txtIdFaltante.Size = new System.Drawing.Size(16, 27);
            this.txtIdFaltante.TabIndex = 154;
            this.txtIdFaltante.Text = "0";
            this.txtIdFaltante.Visible = false;
            // 
            // btnAbmProducto
            // 
            this.btnAbmProducto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAbmProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnAbmProducto.Image")));
            this.btnAbmProducto.Location = new System.Drawing.Point(467, 11);
            this.btnAbmProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAbmProducto.Name = "btnAbmProducto";
            this.btnAbmProducto.Size = new System.Drawing.Size(30, 30);
            this.btnAbmProducto.TabIndex = 179;
            this.btnAbmProducto.UseVisualStyleBackColor = true;
            this.btnAbmProducto.Click += new System.EventHandler(this.btnAbmProducto_Click);
            // 
            // btnSeleccionarProducto
            // 
            this.btnSeleccionarProducto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSeleccionarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarProducto.Image")));
            this.btnSeleccionarProducto.Location = new System.Drawing.Point(432, 11);
            this.btnSeleccionarProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSeleccionarProducto.Name = "btnSeleccionarProducto";
            this.btnSeleccionarProducto.Size = new System.Drawing.Size(30, 30);
            this.btnSeleccionarProducto.TabIndex = 178;
            this.btnSeleccionarProducto.UseVisualStyleBackColor = true;
            this.btnSeleccionarProducto.Click += new System.EventHandler(this.btnSeleccionarProducto_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(540, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 19);
            this.label5.TabIndex = 181;
            this.label5.Text = "Clase:";
            // 
            // cboClaseFaltante
            // 
            this.cboClaseFaltante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClaseFaltante.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboClaseFaltante.FormattingEnabled = true;
            this.cboClaseFaltante.Location = new System.Drawing.Point(590, 13);
            this.cboClaseFaltante.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboClaseFaltante.Name = "cboClaseFaltante";
            this.cboClaseFaltante.Size = new System.Drawing.Size(162, 25);
            this.cboClaseFaltante.TabIndex = 180;
            this.cboClaseFaltante.SelectedValueChanged += new System.EventHandler(this.cboClaseFaltante_SelectedValueChanged);
            // 
            // UcFaltanteEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboClaseFaltante);
            this.Controls.Add(this.btnAbmProducto);
            this.Controls.Add(this.btnSeleccionarProducto);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.chkArchivado);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpFechaResuelto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboEstadoFaltante);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdFaltante);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UcFaltanteEdit";
            this.Size = new System.Drawing.Size(771, 146);
            this.Load += new System.EventHandler(this.UcFaltanteEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.CheckBox chkArchivado;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpFechaResuelto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboEstadoFaltante;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdFaltante;
        private System.Windows.Forms.Button btnAbmProducto;
        private System.Windows.Forms.Button btnSeleccionarProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboClaseFaltante;
    }
}
