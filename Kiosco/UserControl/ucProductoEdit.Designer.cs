namespace Heimdall.UserControl
{
    partial class ucProductoEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProductoEdit));
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtIdMarca = new System.Windows.Forms.TextBox();
            this.btnAbmMarca = new System.Windows.Forms.Button();
            this.btnSeleccionarMarca = new System.Windows.Forms.Button();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.cboUnidad = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nudPrecioCosto = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.gbStock = new System.Windows.Forms.GroupBox();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.nudStockActual = new System.Windows.Forms.NumericUpDown();
            this.labStockActual = new System.Windows.Forms.Label();
            this.nudStockMaximo = new System.Windows.Forms.NumericUpDown();
            this.nudStockMinimo = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboRubro = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkSoloAdultos = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nudCapacidad = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            this.gbStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMaximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMinimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(148, 133);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(309, 24);
            this.txtMarca.TabIndex = 76;
            // 
            // txtIdMarca
            // 
            this.txtIdMarca.BackColor = System.Drawing.SystemColors.Info;
            this.txtIdMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdMarca.Location = new System.Drawing.Point(26, 133);
            this.txtIdMarca.Name = "txtIdMarca";
            this.txtIdMarca.Size = new System.Drawing.Size(18, 24);
            this.txtIdMarca.TabIndex = 75;
            this.txtIdMarca.Text = "0";
            this.txtIdMarca.TextChanged += new System.EventHandler(this.txtIdMarca_TextChanged);
            // 
            // btnAbmMarca
            // 
            this.btnAbmMarca.Image = ((System.Drawing.Image)(resources.GetObject("btnAbmMarca.Image")));
            this.btnAbmMarca.Location = new System.Drawing.Point(494, 133);
            this.btnAbmMarca.Name = "btnAbmMarca";
            this.btnAbmMarca.Size = new System.Drawing.Size(25, 25);
            this.btnAbmMarca.TabIndex = 74;
            this.btnAbmMarca.UseVisualStyleBackColor = true;
            this.btnAbmMarca.Click += new System.EventHandler(this.btnAbmMarca_Click);
            // 
            // btnSeleccionarMarca
            // 
            this.btnSeleccionarMarca.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarMarca.Image")));
            this.btnSeleccionarMarca.Location = new System.Drawing.Point(463, 133);
            this.btnSeleccionarMarca.Name = "btnSeleccionarMarca";
            this.btnSeleccionarMarca.Size = new System.Drawing.Size(25, 25);
            this.btnSeleccionarMarca.TabIndex = 73;
            this.btnSeleccionarMarca.UseVisualStyleBackColor = true;
            this.btnSeleccionarMarca.Click += new System.EventHandler(this.btnSeleccionarMarca_Click);
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProducto.Location = new System.Drawing.Point(7, 4);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(18, 24);
            this.txtIdProducto.TabIndex = 72;
            this.txtIdProducto.Text = "0";
            this.txtIdProducto.TextChanged += new System.EventHandler(this.txtIdProducto_TextChanged);
            // 
            // cboUnidad
            // 
            this.cboUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cboUnidad.FormattingEnabled = true;
            this.cboUnidad.Location = new System.Drawing.Point(659, 199);
            this.cboUnidad.Name = "cboUnidad";
            this.cboUnidad.Size = new System.Drawing.Size(240, 26);
            this.cboUnidad.TabIndex = 70;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(595, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 18);
            this.label10.TabIndex = 71;
            this.label10.Text = "Unidad:";
            // 
            // txtNotas
            // 
            this.txtNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotas.Location = new System.Drawing.Point(148, 199);
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(371, 24);
            this.txtNotas.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(86, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 18);
            this.label7.TabIndex = 69;
            this.label7.Text = "Notas:";
            // 
            // nudPrecioCosto
            // 
            this.nudPrecioCosto.DecimalPlaces = 2;
            this.nudPrecioCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.nudPrecioCosto.Location = new System.Drawing.Point(148, 99);
            this.nudPrecioCosto.Name = "nudPrecioCosto";
            this.nudPrecioCosto.Size = new System.Drawing.Size(141, 24);
            this.nudPrecioCosto.TabIndex = 59;
            this.nudPrecioCosto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPrecioCosto.Enter += new System.EventHandler(this.nudPrecioCosto_Enter);
            this.nudPrecioCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudPrecioCosto_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 68;
            this.label6.Tag = "Costo Promedio";
            this.label6.Text = "Costo:";
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.nudPrecio.Location = new System.Drawing.Point(148, 67);
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(141, 24);
            this.nudPrecio.TabIndex = 57;
            this.nudPrecio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPrecio.Enter += new System.EventHandler(this.nudPrecio_Enter);
            this.nudPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudPrecio_KeyPress);
            // 
            // gbStock
            // 
            this.gbStock.Controls.Add(this.btnUpdateStock);
            this.gbStock.Controls.Add(this.nudStockActual);
            this.gbStock.Controls.Add(this.labStockActual);
            this.gbStock.Controls.Add(this.nudStockMaximo);
            this.gbStock.Controls.Add(this.nudStockMinimo);
            this.gbStock.Controls.Add(this.label9);
            this.gbStock.Controls.Add(this.label8);
            this.gbStock.Location = new System.Drawing.Point(540, 7);
            this.gbStock.Name = "gbStock";
            this.gbStock.Size = new System.Drawing.Size(360, 133);
            this.gbStock.TabIndex = 67;
            this.gbStock.TabStop = false;
            this.gbStock.Text = "Parámetros de Stock";
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.Location = new System.Drawing.Point(204, 91);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(111, 25);
            this.btnUpdateStock.TabIndex = 26;
            this.btnUpdateStock.Text = "Actualizar";
            this.btnUpdateStock.UseVisualStyleBackColor = true;
            this.btnUpdateStock.Click += new System.EventHandler(this.btnUpdateStock_Click);
            // 
            // nudStockActual
            // 
            this.nudStockActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.nudStockActual.Location = new System.Drawing.Point(119, 91);
            this.nudStockActual.Name = "nudStockActual";
            this.nudStockActual.Size = new System.Drawing.Size(79, 24);
            this.nudStockActual.TabIndex = 24;
            // 
            // labStockActual
            // 
            this.labStockActual.AutoSize = true;
            this.labStockActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labStockActual.Location = new System.Drawing.Point(6, 91);
            this.labStockActual.Name = "labStockActual";
            this.labStockActual.Size = new System.Drawing.Size(95, 18);
            this.labStockActual.TabIndex = 25;
            this.labStockActual.Text = "Stock Actual:";
            // 
            // nudStockMaximo
            // 
            this.nudStockMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.nudStockMaximo.Location = new System.Drawing.Point(119, 60);
            this.nudStockMaximo.Name = "nudStockMaximo";
            this.nudStockMaximo.Size = new System.Drawing.Size(79, 24);
            this.nudStockMaximo.TabIndex = 1;
            // 
            // nudStockMinimo
            // 
            this.nudStockMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.nudStockMinimo.Location = new System.Drawing.Point(119, 29);
            this.nudStockMinimo.Name = "nudStockMinimo";
            this.nudStockMinimo.Size = new System.Drawing.Size(79, 24);
            this.nudStockMinimo.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 18);
            this.label9.TabIndex = 23;
            this.label9.Text = "Máximo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Mínimo:";
            // 
            // cboRubro
            // 
            this.cboRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cboRubro.FormattingEnabled = true;
            this.cboRubro.Location = new System.Drawing.Point(148, 165);
            this.cboRubro.Name = "cboRubro";
            this.cboRubro.Size = new System.Drawing.Size(371, 26);
            this.cboRubro.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 66;
            this.label5.Text = "Rubro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 65;
            this.label4.Text = "Marca:";
            // 
            // chkSoloAdultos
            // 
            this.chkSoloAdultos.AutoSize = true;
            this.chkSoloAdultos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.chkSoloAdultos.Location = new System.Drawing.Point(659, 141);
            this.chkSoloAdultos.Name = "chkSoloAdultos";
            this.chkSoloAdultos.Size = new System.Drawing.Size(144, 22);
            this.chkSoloAdultos.TabIndex = 63;
            this.chkSoloAdultos.Text = "Solo para Adultos";
            this.chkSoloAdultos.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 64;
            this.label3.Text = "Precio:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(148, 35);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(371, 24);
            this.txtDescripcion.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 60;
            this.label2.Text = "Descripción:";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoBarras.Location = new System.Drawing.Point(148, 3);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(143, 24);
            this.txtCodigoBarras.TabIndex = 55;
            this.txtCodigoBarras.TextChanged += new System.EventHandler(this.txtCodigoBarras_TextChanged);
            this.txtCodigoBarras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoBarras_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 58;
            this.label1.Text = "Código:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(571, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 18);
            this.label11.TabIndex = 78;
            this.label11.Text = "Capacidad:";
            // 
            // nudCapacidad
            // 
            this.nudCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.nudCapacidad.Location = new System.Drawing.Point(659, 169);
            this.nudCapacidad.Name = "nudCapacidad";
            this.nudCapacidad.Size = new System.Drawing.Size(141, 24);
            this.nudCapacidad.TabIndex = 79;
            this.nudCapacidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ucProductoEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.nudCapacidad);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtIdMarca);
            this.Controls.Add(this.btnAbmMarca);
            this.Controls.Add(this.btnSeleccionarMarca);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.cboUnidad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudPrecioCosto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudPrecio);
            this.Controls.Add(this.gbStock);
            this.Controls.Add(this.cboRubro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkSoloAdultos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigoBarras);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucProductoEdit";
            this.Size = new System.Drawing.Size(911, 230);
            this.Load += new System.EventHandler(this.ucProductoEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            this.gbStock.ResumeLayout(false);
            this.gbStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMaximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMinimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtIdMarca;
        private System.Windows.Forms.Button btnAbmMarca;
        private System.Windows.Forms.Button btnSeleccionarMarca;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.ComboBox cboUnidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudPrecioCosto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.GroupBox gbStock;
        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.NumericUpDown nudStockActual;
        private System.Windows.Forms.Label labStockActual;
        private System.Windows.Forms.NumericUpDown nudStockMaximo;
        private System.Windows.Forms.NumericUpDown nudStockMinimo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboRubro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkSoloAdultos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudCapacidad;
    }
}
