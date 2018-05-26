namespace Heimdall.UserControl
{
    partial class UcProductoPromocionList
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
            this.txtIdProductoPromocion = new System.Windows.Forms.TextBox();
            this.txtIdPromocion = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdProductoPromocion
            // 
            this.txtIdProductoPromocion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProductoPromocion.Location = new System.Drawing.Point(16, 33);
            this.txtIdProductoPromocion.Name = "txtIdProductoPromocion";
            this.txtIdProductoPromocion.Size = new System.Drawing.Size(18, 24);
            this.txtIdProductoPromocion.TabIndex = 90;
            this.txtIdProductoPromocion.Text = "0";
            this.txtIdProductoPromocion.Visible = false;
            // 
            // txtIdPromocion
            // 
            this.txtIdPromocion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPromocion.Location = new System.Drawing.Point(3, 3);
            this.txtIdPromocion.Name = "txtIdPromocion";
            this.txtIdPromocion.Size = new System.Drawing.Size(18, 24);
            this.txtIdPromocion.TabIndex = 89;
            this.txtIdPromocion.Text = "0";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(510, 231);
            this.dgv.TabIndex = 91;
            this.dgv.TabStop = false;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProducto.Location = new System.Drawing.Point(33, 63);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(18, 24);
            this.txtIdProducto.TabIndex = 92;
            this.txtIdProducto.Text = "0";
            this.txtIdProducto.Visible = false;
            // 
            // UcProductoPromocionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.txtIdProductoPromocion);
            this.Controls.Add(this.txtIdPromocion);
            this.Controls.Add(this.dgv);
            this.Name = "UcProductoPromocionList";
            this.Size = new System.Drawing.Size(510, 231);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdProductoPromocion;
        private System.Windows.Forms.TextBox txtIdPromocion;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtIdProducto;
    }
}
