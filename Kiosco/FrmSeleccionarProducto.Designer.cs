using Heimdall.UserControl;

namespace Heimdall
{
    partial class FrmSeleccionarProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeleccionarProducto));
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tsb = new System.Windows.Forms.ToolStrip();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbSearchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSearchPerform = new System.Windows.Forms.ToolStripButton();
            this.tsbSearchClearAndPerform = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCloseOnSelect = new System.Windows.Forms.ToolStripButton();
            this.ucProductoEdit1 = new ucProductoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tsb.SuspendLayout();
            this.SuspendLayout();
            // 
            // cms
            // 
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(61, 4);
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 34);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(911, 399);
            this.dgv.TabIndex = 33;
            this.dgv.TabStop = false;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseDoubleClick);
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // tsb
            // 
            this.tsb.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSearch,
            this.tsbSearchTextBox,
            this.tsbSearchPerform,
            this.tsbSearchClearAndPerform,
            this.toolStripSeparator1,
            this.tsbCloseOnSelect});
            this.tsb.Location = new System.Drawing.Point(0, 0);
            this.tsb.Name = "tsb";
            this.tsb.Size = new System.Drawing.Size(930, 31);
            this.tsb.TabIndex = 34;
            this.tsb.Text = "toolStrip1";
            // 
            // tsbSearch
            // 
            this.tsbSearch.CheckOnClick = true;
            this.tsbSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearch.Image")));
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(79, 28);
            this.tsbSearch.Text = "Buscar...";
            this.tsbSearch.Click += new System.EventHandler(this.tsbSearch_Click);
            // 
            // tsbSearchTextBox
            // 
            this.tsbSearchTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbSearchTextBox.Name = "tsbSearchTextBox";
            this.tsbSearchTextBox.Size = new System.Drawing.Size(116, 31);
            this.tsbSearchTextBox.Visible = false;
            this.tsbSearchTextBox.Leave += new System.EventHandler(this.tsbSearchTextBox_Leave);
            this.tsbSearchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tsbSearchTextBox_KeyDown);
            // 
            // tsbSearchPerform
            // 
            this.tsbSearchPerform.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSearchPerform.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearchPerform.Image")));
            this.tsbSearchPerform.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearchPerform.Name = "tsbSearchPerform";
            this.tsbSearchPerform.Size = new System.Drawing.Size(28, 28);
            this.tsbSearchPerform.Visible = false;
            this.tsbSearchPerform.Click += new System.EventHandler(this.tsbSearchPerform_Click);
            // 
            // tsbSearchClearAndPerform
            // 
            this.tsbSearchClearAndPerform.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSearchClearAndPerform.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearchClearAndPerform.Image")));
            this.tsbSearchClearAndPerform.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearchClearAndPerform.Name = "tsbSearchClearAndPerform";
            this.tsbSearchClearAndPerform.Size = new System.Drawing.Size(28, 28);
            this.tsbSearchClearAndPerform.Visible = false;
            this.tsbSearchClearAndPerform.Click += new System.EventHandler(this.tsbSearchClearAndPerform_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbCloseOnSelect
            // 
            this.tsbCloseOnSelect.Checked = true;
            this.tsbCloseOnSelect.CheckOnClick = true;
            this.tsbCloseOnSelect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsbCloseOnSelect.Image = ((System.Drawing.Image)(resources.GetObject("tsbCloseOnSelect.Image")));
            this.tsbCloseOnSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCloseOnSelect.Name = "tsbCloseOnSelect";
            this.tsbCloseOnSelect.Size = new System.Drawing.Size(142, 28);
            this.tsbCloseOnSelect.Text = "Cerrar al Seleccionar";
            // 
            // ucProductoEdit1
            // 
            this.ucProductoEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ucProductoEdit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucProductoEdit1.CodigoBarras = "";
            this.ucProductoEdit1.Descripcion = "";
            this.ucProductoEdit1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucProductoEdit1.IdMarca = 0;
            this.ucProductoEdit1.IdProducto = ((long)(0));
            this.ucProductoEdit1.IdRubro = 0;
            this.ucProductoEdit1.IdUnidad = 0;
            this.ucProductoEdit1.Location = new System.Drawing.Point(12, 440);
            this.ucProductoEdit1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucProductoEdit1.Name = "ucProductoEdit1";
            this.ucProductoEdit1.Notas = "";
            this.ucProductoEdit1.PrecioCosto = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ucProductoEdit1.PrecioVenta = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ucProductoEdit1.Size = new System.Drawing.Size(911, 230);
            this.ucProductoEdit1.SoloAdultos = false;
            this.ucProductoEdit1.StockActual = 0;
            this.ucProductoEdit1.StockMaximo = 0;
            this.ucProductoEdit1.StockMinimo = 0;
            this.ucProductoEdit1.TabIndex = 35;
            this.ucProductoEdit1.StockChanged += new ProductoChangedEventHandler(this.ucProductoEdit1_StockChanged);
            // 
            // FrmSeleccionarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 683);
            this.Controls.Add(this.ucProductoEdit1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.tsb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSeleccionarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Producto...";
            this.Load += new System.EventHandler(this.FrmSeleccionarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tsb.ResumeLayout(false);
            this.tsb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ToolStrip tsb;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripTextBox tsbSearchTextBox;
        private System.Windows.Forms.ToolStripButton tsbSearchPerform;
        private System.Windows.Forms.ToolStripButton tsbSearchClearAndPerform;
        private ucProductoEdit ucProductoEdit1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbCloseOnSelect;
    }
}