namespace Kiosco
{
    partial class FrmPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedido));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tsb = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbSearchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSearchPerform = new System.Windows.Forms.ToolStripButton();
            this.tsbSearchClearAndPerform = new System.Windows.Forms.ToolStripButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ucPedido1 = new Kiosco.UserControl.ucPedido();
            this.tsb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tsb
            // 
            this.tsb.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbSave,
            this.tsbDelete,
            this.toolStripSeparator1,
            this.tsbSearch,
            this.tsbSearchTextBox,
            this.tsbSearchPerform,
            this.tsbSearchClearAndPerform});
            this.tsb.Location = new System.Drawing.Point(0, 0);
            this.tsb.Name = "tsb";
            this.tsb.Size = new System.Drawing.Size(1082, 31);
            this.tsb.TabIndex = 35;
            this.tsb.Text = "toolStrip1";
            // 
            // tsbNew
            // 
            this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(70, 28);
            this.tsbNew.Text = "Nuevo";
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(77, 28);
            this.tsbSave.Text = "Guardar";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(67, 28);
            this.tsbDelete.Text = "Borrar";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
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
            this.tsbSearchTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tsbSearchTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tsbSearchTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbSearchTextBox.Name = "tsbSearchTextBox";
            this.tsbSearchTextBox.Size = new System.Drawing.Size(200, 31);
            this.tsbSearchTextBox.Visible = false;
            this.tsbSearchTextBox.Leave += new System.EventHandler(this.tsbSearchTextBox_Leave);
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
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(0, 34);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1082, 484);
            this.dgv.TabIndex = 34;
            this.dgv.TabStop = false;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            this.dgv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_KeyDown);
            // 
            // cms
            // 
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(61, 4);
            // 
            // ucPedido1
            // 
            this.ucPedido1.Descripcion = "";
            this.ucPedido1.Fecha = new System.DateTime(2017, 5, 29, 0, 0, 0, 0);
            this.ucPedido1.FechaEntrega = new System.DateTime(2017, 5, 29, 0, 0, 0, 0);
            this.ucPedido1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ucPedido1.IdPedido = ((long)(0));
            this.ucPedido1.IdProveedor = 0;
            this.ucPedido1.Location = new System.Drawing.Point(0, 525);
            this.ucPedido1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucPedido1.Name = "ucPedido1";
            this.ucPedido1.Notas = "";
            this.ucPedido1.Proveedor = "";
            this.ucPedido1.Size = new System.Drawing.Size(1085, 174);
            this.ucPedido1.TabIndex = 36;
            this.ucPedido1.Total = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 724);
            this.Controls.Add(this.ucPedido1);
            this.Controls.Add(this.tsb);
            this.Controls.Add(this.dgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos a Provedores";
            this.Load += new System.EventHandler(this.frmPedido_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPedido_KeyDown);
            this.tsb.ResumeLayout(false);
            this.tsb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsb;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripTextBox tsbSearchTextBox;
        private System.Windows.Forms.ToolStripButton tsbSearchPerform;
        private System.Windows.Forms.ToolStripButton tsbSearchClearAndPerform;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ContextMenuStrip cms;
        private UserControl.ucPedido ucPedido1;
    }
}