namespace Heimdall.UserControl
{
    partial class UcVentaDetalleEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcVentaDetalleEdit));
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.nudImporte = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.btnSeleccionarProducto = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRemoverItem = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.SystemColors.Menu;
            this.txtStock.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(833, 27);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(60, 25);
            this.txtStock.TabIndex = 73;
            this.txtStock.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("WillowBody", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(832, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 18);
            this.label9.TabIndex = 74;
            this.label9.Text = "Stock";
            // 
            // nudCantidad
            // 
            this.nudCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudCantidad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.Location = new System.Drawing.Point(241, 27);
            this.nudCantidad.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(53, 25);
            this.nudCantidad.TabIndex = 64;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.ValueChanged += new System.EventHandler(this.nudCantidad_ValueChanged);
            // 
            // nudImporte
            // 
            this.nudImporte.BackColor = System.Drawing.SystemColors.Menu;
            this.nudImporte.DecimalPlaces = 2;
            this.nudImporte.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudImporte.Location = new System.Drawing.Point(723, 27);
            this.nudImporte.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudImporte.Name = "nudImporte";
            this.nudImporte.Size = new System.Drawing.Size(104, 25);
            this.nudImporte.TabIndex = 71;
            this.nudImporte.TabStop = false;
            this.nudImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudImporte_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("WillowBody", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(722, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 18);
            this.label8.TabIndex = 72;
            this.label8.Text = "Importe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("WillowBody", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(236, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 70;
            this.label6.Text = "Cantidad";
            // 
            // nudPrecio
            // 
            this.nudPrecio.BackColor = System.Drawing.SystemColors.Menu;
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPrecio.Location = new System.Drawing.Point(634, 27);
            this.nudPrecio.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(83, 25);
            this.nudPrecio.TabIndex = 66;
            this.nudPrecio.TabStop = false;
            this.nudPrecio.ValueChanged += new System.EventHandler(this.nudPrecio_ValueChanged);
            this.nudPrecio.Enter += new System.EventHandler(this.nudPrecio_Enter);
            this.nudPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudPrecio_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("WillowBody", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(633, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 69;
            this.label3.Text = "Precio";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(300, 27);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(328, 25);
            this.txtDescripcion.TabIndex = 65;
            this.txtDescripcion.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("WillowBody", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 68;
            this.label2.Text = "Descripción";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoBarras.Location = new System.Drawing.Point(3, 27);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(114, 25);
            this.txtCodigoBarras.TabIndex = 63;
            this.txtCodigoBarras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoBarras_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("WillowBody", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 67;
            this.label1.Text = "Código";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProducto.Location = new System.Drawing.Point(2, 0);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(18, 22);
            this.txtIdProducto.TabIndex = 75;
            this.txtIdProducto.Text = "0";
            this.txtIdProducto.TextChanged += new System.EventHandler(this.txtIdProducto_TextChanged);
            // 
            // btnSeleccionarProducto
            // 
            this.btnSeleccionarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarProducto.Image")));
            this.btnSeleccionarProducto.Location = new System.Drawing.Point(123, 27);
            this.btnSeleccionarProducto.Name = "btnSeleccionarProducto";
            this.btnSeleccionarProducto.Size = new System.Drawing.Size(25, 25);
            this.btnSeleccionarProducto.TabIndex = 96;
            this.btnSeleccionarProducto.UseVisualStyleBackColor = true;
            this.btnSeleccionarProducto.Click += new System.EventHandler(this.btnSeleccionarProducto_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(182, 27);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(24, 24);
            this.btnModificar.TabIndex = 99;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRemoverItem
            // 
            this.btnRemoverItem.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoverItem.Image")));
            this.btnRemoverItem.Location = new System.Drawing.Point(210, 27);
            this.btnRemoverItem.Name = "btnRemoverItem";
            this.btnRemoverItem.Size = new System.Drawing.Size(24, 24);
            this.btnRemoverItem.TabIndex = 98;
            this.btnRemoverItem.UseVisualStyleBackColor = true;
            this.btnRemoverItem.Click += new System.EventHandler(this.btnRemoverItem_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(154, 27);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(24, 24);
            this.btnAgregar.TabIndex = 97;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // UcVentaDetalleEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRemoverItem);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnSeleccionarProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.nudImporte);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCodigoBarras);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UcVentaDetalleEdit";
            this.Size = new System.Drawing.Size(904, 57);
            this.Load += new System.EventHandler(this.UcVentaDetalleEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.NumericUpDown nudImporte;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Button btnSeleccionarProducto;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRemoverItem;
        private System.Windows.Forms.Button btnAgregar;
    }
}
