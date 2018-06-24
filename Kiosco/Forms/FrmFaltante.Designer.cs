namespace Heimdall
{
    partial class FrmFaltante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaltante));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ucFaltanteEdit1 = new Heimdall.UserControl.UcFaltanteEdit();
            this.ucAbmToolBar1 = new Heimdall.UserControl.UcAbmToolBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(4, 39);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(998, 455);
            this.dgv.TabIndex = 27;
            this.dgv.TabStop = false;
            this.dgv.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_ColumnHeaderMouseClick);
            this.dgv.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_DataError);
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // ucFaltanteEdit1
            // 
            this.ucFaltanteEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ucFaltanteEdit1.Archivado = false;
            this.ucFaltanteEdit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucFaltanteEdit1.Cantidad = 0;
            this.ucFaltanteEdit1.Descripcion = "";
            this.ucFaltanteEdit1.Fecha = new System.DateTime(2018, 2, 20, 23, 12, 16, 816);
            this.ucFaltanteEdit1.FechaResuelto = new System.DateTime(2018, 2, 20, 23, 12, 16, 809);
            this.ucFaltanteEdit1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ucFaltanteEdit1.IdClaseFaltante = 0;
            this.ucFaltanteEdit1.IdEstadoFaltante = 0;
            this.ucFaltanteEdit1.IdFaltante = ((long)(0));
            this.ucFaltanteEdit1.IdPrioridad = 0;
            this.ucFaltanteEdit1.IdProducto = ((long)(0));
            this.ucFaltanteEdit1.Location = new System.Drawing.Point(4, 502);
            this.ucFaltanteEdit1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucFaltanteEdit1.Name = "ucFaltanteEdit1";
            this.ucFaltanteEdit1.Notas = "";
            this.ucFaltanteEdit1.Size = new System.Drawing.Size(998, 146);
            this.ucFaltanteEdit1.TabIndex = 29;
            // 
            // ucAbmToolBar1
            // 
            this.ucAbmToolBar1.AllowDelete = true;
            this.ucAbmToolBar1.AllowNew = true;
            this.ucAbmToolBar1.AllowSave = true;
            this.ucAbmToolBar1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ucAbmToolBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucAbmToolBar1.Location = new System.Drawing.Point(0, 0);
            this.ucAbmToolBar1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucAbmToolBar1.Name = "ucAbmToolBar1";
            this.ucAbmToolBar1.SearchText = "";
            this.ucAbmToolBar1.Size = new System.Drawing.Size(1008, 33);
            this.ucAbmToolBar1.TabIndex = 28;
            this.ucAbmToolBar1.ButtonClickNew += new System.EventHandler(this.ucAbmToolBar1_ButtonClickNew);
            this.ucAbmToolBar1.ButtonClickUpdate += new System.EventHandler(this.ucAbmToolBar1_ButtonClickUpdate);
            this.ucAbmToolBar1.ButtonClickDelete += new System.EventHandler(this.ucAbmToolBar1_ButtonClickDelete);
            this.ucAbmToolBar1.ButtonClickExecuteSearch += new System.EventHandler(this.ucAbmToolBar1_ButtonClickExecuteSearch);
            // 
            // FrmFaltante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 648);
            this.Controls.Add(this.ucFaltanteEdit1);
            this.Controls.Add(this.ucAbmToolBar1);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmFaltante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faltantes  de Mercadería";
            this.Load += new System.EventHandler(this.FrmFaltante_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmFaltante_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl.UcAbmToolBar ucAbmToolBar1;
        private System.Windows.Forms.DataGridView dgv;
        private UserControl.UcFaltanteEdit ucFaltanteEdit1;
    }
}