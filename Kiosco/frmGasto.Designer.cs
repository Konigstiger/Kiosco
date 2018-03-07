namespace Heimdall
{
    partial class FrmGasto
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
        /// the contents of this method with the code _editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucAbmToolBar1 = new Heimdall.UserControl.UcAbmToolBar();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ucGastoEdit1 = new Heimdall.UserControl.UcGastoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // ucAbmToolBar1
            // 
            this.ucAbmToolBar1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ucAbmToolBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucAbmToolBar1.Location = new System.Drawing.Point(0, 0);
            this.ucAbmToolBar1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.ucAbmToolBar1.Name = "ucAbmToolBar1";
            this.ucAbmToolBar1.SearchText = "";
            this.ucAbmToolBar1.Size = new System.Drawing.Size(989, 43);
            this.ucAbmToolBar1.TabIndex = 31;
            this.ucAbmToolBar1.ButtonClickNew += new System.EventHandler(this.ucAbmToolBar1_ButtonClickNew);
            this.ucAbmToolBar1.ButtonClickUpdate += new System.EventHandler(this.ucAbmToolBar1_ButtonClickUpdate);
            this.ucAbmToolBar1.ButtonClickDelete += new System.EventHandler(this.ucAbmToolBar1_ButtonClickDelete);
            this.ucAbmToolBar1.ButtonClickExecuteSearch += new System.EventHandler(this.ucAbmToolBar1_ButtonClickExecuteSearch);
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(5, 47);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(978, 464);
            this.dgv.TabIndex = 30;
            this.dgv.TabStop = false;
            this.dgv.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_ColumnHeaderMouseClick);
            this.dgv.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_DataError);
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // ucGastoEdit1
            // 
            this.ucGastoEdit1.Archivado = false;
            this.ucGastoEdit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucGastoEdit1.Descripcion = "";
            this.ucGastoEdit1.FechaPago = new System.DateTime(2018, 3, 6, 23, 7, 53, 10);
            this.ucGastoEdit1.FechaVencimiento = new System.DateTime(2018, 3, 6, 23, 7, 53, 16);
            this.ucGastoEdit1.IdClaseGasto = 0;
            this.ucGastoEdit1.IdEstadoGasto = 0;
            this.ucGastoEdit1.IdGasto = ((long)(0));
            this.ucGastoEdit1.IdPrioridad = 0;
            this.ucGastoEdit1.Location = new System.Drawing.Point(5, 519);
            this.ucGastoEdit1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucGastoEdit1.Monto = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucGastoEdit1.MontoPendiente = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucGastoEdit1.Name = "ucGastoEdit1";
            this.ucGastoEdit1.Notas = "";
            this.ucGastoEdit1.Size = new System.Drawing.Size(978, 188);
            this.ucGastoEdit1.TabIndex = 32;
            // 
            // FrmGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 708);
            this.Controls.Add(this.ucGastoEdit1);
            this.Controls.Add(this.ucAbmToolBar1);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmGasto";
            this.Text = "Gastos";
            this.Load += new System.EventHandler(this.FrmGasto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmGasto_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private UserControl.UcAbmToolBar ucAbmToolBar1;
        private System.Windows.Forms.DataGridView dgv;
        private UserControl.UcGastoEdit ucGastoEdit1;
    }
}