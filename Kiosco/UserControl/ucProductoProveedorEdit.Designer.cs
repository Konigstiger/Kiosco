namespace Heimdall.UserControl
{
    partial class UcProductoProveedorEdit
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
            this.dtpFechaModificacion = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSetPrecioCosto = new System.Windows.Forms.Button();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nudPrecioCompra = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdProductoProveedor = new System.Windows.Forms.TextBox();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.ucProveedorView1 = new Heimdall.UserControl.UcProveedorView();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaModificacion
            // 
            this.dtpFechaModificacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFechaModificacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaModificacion.Location = new System.Drawing.Point(103, 77);
            this.dtpFechaModificacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFechaModificacion.Name = "dtpFechaModificacion";
            this.dtpFechaModificacion.ShowCheckBox = true;
            this.dtpFechaModificacion.Size = new System.Drawing.Size(170, 25);
            this.dtpFechaModificacion.TabIndex = 126;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 125;
            this.label1.Text = "Fecha:";
            // 
            // btnSetPrecioCosto
            // 
            this.btnSetPrecioCosto.Location = new System.Drawing.Point(297, 46);
            this.btnSetPrecioCosto.Name = "btnSetPrecioCosto";
            this.btnSetPrecioCosto.Size = new System.Drawing.Size(176, 24);
            this.btnSetPrecioCosto.TabIndex = 124;
            this.btnSetPrecioCosto.Text = "Definir como Precio de Costo";
            this.btnSetPrecioCosto.UseVisualStyleBackColor = true;
            this.btnSetPrecioCosto.Visible = false;
            this.btnSetPrecioCosto.Click += new System.EventHandler(this.btnSetPrecioCosto_Click);
            // 
            // txtNotas
            // 
            this.txtNotas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNotas.Location = new System.Drawing.Point(103, 110);
            this.txtNotas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(370, 25);
            this.txtNotas.TabIndex = 122;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 123;
            this.label7.Text = "Notas:";
            // 
            // nudPrecioCompra
            // 
            this.nudPrecioCompra.DecimalPlaces = 2;
            this.nudPrecioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.nudPrecioCompra.Location = new System.Drawing.Point(103, 46);
            this.nudPrecioCompra.Name = "nudPrecioCompra";
            this.nudPrecioCompra.Size = new System.Drawing.Size(170, 24);
            this.nudPrecioCompra.TabIndex = 120;
            this.nudPrecioCompra.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudPrecioCompra_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 121;
            this.label3.Text = "Precio:";
            // 
            // txtIdProductoProveedor
            // 
            this.txtIdProductoProveedor.BackColor = System.Drawing.SystemColors.Info;
            this.txtIdProductoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProductoProveedor.Location = new System.Drawing.Point(3, 3);
            this.txtIdProductoProveedor.Name = "txtIdProductoProveedor";
            this.txtIdProductoProveedor.Size = new System.Drawing.Size(18, 24);
            this.txtIdProductoProveedor.TabIndex = 127;
            this.txtIdProductoProveedor.Visible = false;
            this.txtIdProductoProveedor.TextChanged += new System.EventHandler(this.txtIdProductoProveedor_TextChanged);
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.BackColor = System.Drawing.SystemColors.Info;
            this.txtIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProducto.Location = new System.Drawing.Point(14, 40);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(18, 24);
            this.txtIdProducto.TabIndex = 129;
            this.txtIdProducto.Visible = false;
            // 
            // ucProveedorView1
            // 
            this.ucProveedorView1.IdProveedor = 0;
            this.ucProveedorView1.Location = new System.Drawing.Point(0, 0);
            this.ucProveedorView1.Name = "ucProveedorView1";
            this.ucProveedorView1.Size = new System.Drawing.Size(549, 40);
            this.ucProveedorView1.TabIndex = 128;
            // 
            // UcProductoProveedorEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.txtIdProductoProveedor);
            this.Controls.Add(this.dtpFechaModificacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSetPrecioCosto);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudPrecioCompra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ucProveedorView1);
            this.Name = "UcProductoProveedorEdit";
            this.Size = new System.Drawing.Size(552, 140);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaModificacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSetPrecioCosto;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudPrecioCompra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdProductoProveedor;
        private UcProveedorView ucProveedorView1;
        private System.Windows.Forms.TextBox txtIdProducto;
    }
}
