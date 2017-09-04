namespace Heimdall.UserControl
{
    partial class UcPrecioGananciaEdit
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
            this.components = new System.ComponentModel.Container();
            this.nudPrecioCosto = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkLockPrecio = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.chkLockCosto = new System.Windows.Forms.CheckBox();
            this.chkLockGanancia = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // nudPrecioCosto
            // 
            this.nudPrecioCosto.DecimalPlaces = 2;
            this.nudPrecioCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.nudPrecioCosto.Location = new System.Drawing.Point(78, 40);
            this.nudPrecioCosto.Name = "nudPrecioCosto";
            this.nudPrecioCosto.Size = new System.Drawing.Size(91, 24);
            this.nudPrecioCosto.TabIndex = 70;
            this.nudPrecioCosto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 72;
            this.label6.Tag = "Costo Promedio";
            this.label6.Text = "Costo:";
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.nudPrecio.Location = new System.Drawing.Point(78, 8);
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(91, 24);
            this.nudPrecio.TabIndex = 69;
            this.nudPrecio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPrecio.ValueChanged += new System.EventHandler(this.nudPrecio_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 71;
            this.label3.Text = "Precio:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.numericUpDown1.Location = new System.Drawing.Point(291, 40);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(91, 24);
            this.numericUpDown1.TabIndex = 74;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.numericUpDown2.Location = new System.Drawing.Point(291, 8);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(91, 24);
            this.numericUpDown2.TabIndex = 73;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 75;
            this.label2.Text = "Ganancia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 18);
            this.label1.TabIndex = 76;
            this.label1.Text = "%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(388, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 18);
            this.label4.TabIndex = 77;
            this.label4.Text = "$";
            // 
            // chkLockPrecio
            // 
            this.chkLockPrecio.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkLockPrecio.AutoSize = true;
            this.chkLockPrecio.ImageList = this.imageList1;
            this.chkLockPrecio.Location = new System.Drawing.Point(175, 9);
            this.chkLockPrecio.Name = "chkLockPrecio";
            this.chkLockPrecio.Size = new System.Drawing.Size(21, 23);
            this.chkLockPrecio.TabIndex = 78;
            this.chkLockPrecio.TabStop = false;
            this.chkLockPrecio.Text = "*";
            this.chkLockPrecio.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 79;
            this.label5.Text = "CheckChangedEvent";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // chkLockCosto
            // 
            this.chkLockCosto.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkLockCosto.AutoSize = true;
            this.chkLockCosto.Checked = true;
            this.chkLockCosto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLockCosto.ImageList = this.imageList1;
            this.chkLockCosto.Location = new System.Drawing.Point(175, 41);
            this.chkLockCosto.Name = "chkLockCosto";
            this.chkLockCosto.Size = new System.Drawing.Size(21, 23);
            this.chkLockCosto.TabIndex = 80;
            this.chkLockCosto.Text = "*";
            this.chkLockCosto.UseVisualStyleBackColor = true;
            // 
            // chkLockGanancia
            // 
            this.chkLockGanancia.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkLockGanancia.AutoSize = true;
            this.chkLockGanancia.Checked = true;
            this.chkLockGanancia.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLockGanancia.ImageList = this.imageList1;
            this.chkLockGanancia.Location = new System.Drawing.Point(414, 10);
            this.chkLockGanancia.Name = "chkLockGanancia";
            this.chkLockGanancia.Size = new System.Drawing.Size(21, 23);
            this.chkLockGanancia.TabIndex = 81;
            this.chkLockGanancia.Text = "*";
            this.chkLockGanancia.UseVisualStyleBackColor = true;
            // 
            // UcPrecioGananciaEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkLockGanancia);
            this.Controls.Add(this.chkLockCosto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkLockPrecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudPrecioCosto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudPrecio);
            this.Controls.Add(this.label3);
            this.Name = "UcPrecioGananciaEdit";
            this.Size = new System.Drawing.Size(438, 81);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudPrecioCosto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkLockPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.CheckBox chkLockCosto;
        private System.Windows.Forms.CheckBox chkLockGanancia;
    }
}
