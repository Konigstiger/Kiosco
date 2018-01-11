namespace Heimdall.UserControl
{
    partial class UcProveedorView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcProveedorView));
            this.btnAbmProveedor = new System.Windows.Forms.Button();
            this.btnSeleccionarProveedor = new System.Windows.Forms.Button();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAbmProveedor
            // 
            this.btnAbmProveedor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAbmProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnAbmProveedor.Image")));
            this.btnAbmProveedor.Location = new System.Drawing.Point(512, 8);
            this.btnAbmProveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAbmProveedor.Name = "btnAbmProveedor";
            this.btnAbmProveedor.Size = new System.Drawing.Size(25, 25);
            this.btnAbmProveedor.TabIndex = 125;
            this.btnAbmProveedor.UseVisualStyleBackColor = true;
            this.btnAbmProveedor.Click += new System.EventHandler(this.btnAbmProveedor_Click);
            // 
            // btnSeleccionarProveedor
            // 
            this.btnSeleccionarProveedor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSeleccionarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarProveedor.Image")));
            this.btnSeleccionarProveedor.Location = new System.Drawing.Point(481, 7);
            this.btnSeleccionarProveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSeleccionarProveedor.Name = "btnSeleccionarProveedor";
            this.btnSeleccionarProveedor.Size = new System.Drawing.Size(25, 25);
            this.btnSeleccionarProveedor.TabIndex = 124;
            this.btnSeleccionarProveedor.UseVisualStyleBackColor = true;
            this.btnSeleccionarProveedor.Click += new System.EventHandler(this.btnSeleccionarProveedor_Click);
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtIdProveedor.Location = new System.Drawing.Point(3, 4);
            this.txtIdProveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.Size = new System.Drawing.Size(26, 25);
            this.txtIdProveedor.TabIndex = 123;
            this.txtIdProveedor.Text = "0";
            this.txtIdProveedor.TextChanged += new System.EventHandler(this.txtIdProveedor_TextChanged);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRazonSocial.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRazonSocial.Location = new System.Drawing.Point(101, 7);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(372, 25);
            this.txtRazonSocial.TabIndex = 121;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(20, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 122;
            this.label4.Text = "Proveedor:";
            // 
            // UcProveedorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAbmProveedor);
            this.Controls.Add(this.btnSeleccionarProveedor);
            this.Controls.Add(this.txtIdProveedor);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.label4);
            this.Name = "UcProveedorView";
            this.Size = new System.Drawing.Size(543, 37);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbmProveedor;
        private System.Windows.Forms.Button btnSeleccionarProveedor;
        private System.Windows.Forms.TextBox txtIdProveedor;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label label4;
    }
}
