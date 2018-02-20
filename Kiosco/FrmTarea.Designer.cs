namespace Heimdall
{
    partial class FrmTarea
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ucTareaEdit1 = new Heimdall.UserControl.UcTareaEdit();
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
            this.dgv.Location = new System.Drawing.Point(7, 34);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(977, 476);
            this.dgv.TabIndex = 24;
            this.dgv.TabStop = false;
            this.dgv.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_ColumnHeaderMouseClick);
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // ucTareaEdit1
            // 
            this.ucTareaEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ucTareaEdit1.Archivado = false;
            this.ucTareaEdit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucTareaEdit1.Descripcion = "";
            this.ucTareaEdit1.Detalle = "";
            this.ucTareaEdit1.Fecha = new System.DateTime(2018, 2, 14, 19, 19, 9, 763);
            this.ucTareaEdit1.FechaVencimiento = new System.DateTime(2018, 2, 14, 19, 19, 9, 754);
            this.ucTareaEdit1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ucTareaEdit1.IdClaseTarea = 0;
            this.ucTareaEdit1.IdDificultadTarea = 0;
            this.ucTareaEdit1.IdEstadoTarea = 0;
            this.ucTareaEdit1.IdPrioridad = 0;
            this.ucTareaEdit1.IdTarea = ((long)(0));
            this.ucTareaEdit1.IdTareaPadre = ((long)(0));
            this.ucTareaEdit1.IdUsuario = 0;
            this.ucTareaEdit1.Location = new System.Drawing.Point(7, 517);
            this.ucTareaEdit1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucTareaEdit1.Name = "ucTareaEdit1";
            this.ucTareaEdit1.Notas = "";
            this.ucTareaEdit1.PorcentajeCompleto = 0;
            this.ucTareaEdit1.Size = new System.Drawing.Size(977, 197);
            this.ucTareaEdit1.TabIndex = 0;
            // 
            // ucAbmToolBar1
            // 
            this.ucAbmToolBar1.Location = new System.Drawing.Point(7, 1);
            this.ucAbmToolBar1.Name = "ucAbmToolBar1";
            this.ucAbmToolBar1.Size = new System.Drawing.Size(977, 32);
            this.ucAbmToolBar1.TabIndex = 25;
            this.ucAbmToolBar1.ButtonClickNew += new System.EventHandler(this.ucAbmToolBar1_ButtonClickNew);
            this.ucAbmToolBar1.ButtonClickUpdate += new System.EventHandler(this.ucAbmToolBar1_ButtonClickUpdate);
            this.ucAbmToolBar1.ButtonClickDelete += new System.EventHandler(this.ucAbmToolBar1_ButtonClickDelete);
            // 
            // FrmTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 721);
            this.Controls.Add(this.ucAbmToolBar1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.ucTareaEdit1);
            this.Name = "FrmTarea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tareas";
            this.Load += new System.EventHandler(this.FrmTarea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl.UcTareaEdit ucTareaEdit1;
        private System.Windows.Forms.DataGridView dgv;
        private UserControl.UcAbmToolBar ucAbmToolBar1;
    }
}