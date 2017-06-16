namespace Kiosco
{
    partial class FrmEstadisticas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstadisticas));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpRecaudacion = new System.Windows.Forms.TabPage();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.tpProductoRubro = new System.Windows.Forms.TabPage();
            this.txtCantidadProductos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tpRecaudacion.SuspendLayout();
            this.tpProductoRubro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpRecaudacion);
            this.tabControl1.Controls.Add(this.tpProductoRubro);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(16, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1318, 687);
            this.tabControl1.TabIndex = 6;
            // 
            // tpRecaudacion
            // 
            this.tpRecaudacion.Controls.Add(this.cartesianChart1);
            this.tpRecaudacion.ImageIndex = 2;
            this.tpRecaudacion.Location = new System.Drawing.Point(4, 24);
            this.tpRecaudacion.Name = "tpRecaudacion";
            this.tpRecaudacion.Padding = new System.Windows.Forms.Padding(3);
            this.tpRecaudacion.Size = new System.Drawing.Size(1310, 659);
            this.tpRecaudacion.TabIndex = 1;
            this.tpRecaudacion.Text = "Recaudacion";
            this.tpRecaudacion.UseVisualStyleBackColor = true;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(17, 7);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(1267, 628);
            this.cartesianChart1.TabIndex = 5;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // tpProductoRubro
            // 
            this.tpProductoRubro.Controls.Add(this.txtCantidadProductos);
            this.tpProductoRubro.Controls.Add(this.label2);
            this.tpProductoRubro.Controls.Add(this.pieChart1);
            this.tpProductoRubro.ImageIndex = 5;
            this.tpProductoRubro.Location = new System.Drawing.Point(4, 24);
            this.tpProductoRubro.Name = "tpProductoRubro";
            this.tpProductoRubro.Padding = new System.Windows.Forms.Padding(3);
            this.tpProductoRubro.Size = new System.Drawing.Size(1310, 659);
            this.tpProductoRubro.TabIndex = 0;
            this.tpProductoRubro.Text = "Productos por Rubro";
            this.tpProductoRubro.UseVisualStyleBackColor = true;
            // 
            // txtCantidadProductos
            // 
            this.txtCantidadProductos.Location = new System.Drawing.Point(227, 615);
            this.txtCantidadProductos.Name = "txtCantidadProductos";
            this.txtCantidadProductos.Size = new System.Drawing.Size(116, 23);
            this.txtCantidadProductos.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 613);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad de Productos:";
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(7, 7);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(628, 580);
            this.pieChart1.TabIndex = 1;
            this.pieChart1.Text = "pieChart1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "users.png");
            this.imageList1.Images.SetKeyName(1, "trucking.png");
            this.imageList1.Images.SetKeyName(2, "dollar32.png");
            this.imageList1.Images.SetKeyName(3, "shopping-cart.png");
            this.imageList1.Images.SetKeyName(4, "trolley.png");
            this.imageList1.Images.SetKeyName(5, "bar-chart.png");
            // 
            // FrmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 890);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEstadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.FrmEstadisticas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpRecaudacion.ResumeLayout(false);
            this.tpProductoRubro.ResumeLayout(false);
            this.tpProductoRubro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpRecaudacion;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.TabPage tpProductoRubro;
        private System.Windows.Forms.TextBox txtCantidadProductos;
        private System.Windows.Forms.Label label2;
        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.ImageList imageList1;
    }
}