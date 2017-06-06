namespace Kiosco
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
            this.label6 = new System.Windows.Forms.Label();
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
            this.ucNotification = new Kiosco.UcNotification();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tsb.SuspendLayout();
            this.gbStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
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
            this.chkRequiereEnvase.Location = new System.Drawing.Point(1110, 142);
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
            this.txtPrecio.Location = new System.Drawing.Point(224, 156);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(138, 31);
            this.txtPrecio.TabIndex = 77;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(130, 209);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 70;
            this.label6.Tag = "Costo Promedio";
            this.label6.Text = "Costo:";
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
            this.label5.Location = new System.Drawing.Point(130, 307);
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
            this.label4.Location = new System.Drawing.Point(128, 258);
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
            this.chkSoloAdultos.Location = new System.Drawing.Point(1110, 104);
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
            this.label2.Location = new System.Drawing.Point(72, 110);
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
            this.txtCodigoBarras.TextChanged += new System.EventHandler(this.txtCodigoBarras_TextChanged_1);
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
            this.btnRegistrarVentaRapida.Location = new System.Drawing.Point(931, 406);
            this.btnRegistrarVentaRapida.Name = "btnRegistrarVentaRapida";
            this.btnRegistrarVentaRapida.Size = new System.Drawing.Size(262, 74);
            this.btnRegistrarVentaRapida.TabIndex = 81;
            this.btnRegistrarVentaRapida.Text = "Registrar Venta Rapida";
            this.btnRegistrarVentaRapida.UseVisualStyleBackColor = true;
            this.btnRegistrarVentaRapida.Click += new System.EventHandler(this.button1_Click);
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
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(122, 528);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(666, 178);
            this.dgv.TabIndex = 82;
            this.dgv.TabStop = false;
            // 
            // FrmProductoDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 945);
            this.Controls.Add(this.dgv);
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
            this.Controls.Add(this.label6);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
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
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.DataGridView dgv;
    }
}