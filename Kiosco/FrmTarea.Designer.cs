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
            this.ucTareaEdit1 = new Heimdall.UserControl.UcTareaEdit();
            this.SuspendLayout();
            // 
            // ucTareaEdit1
            // 
            this.ucTareaEdit1.Archivado = false;
            this.ucTareaEdit1.Descripcion = "";
            this.ucTareaEdit1.Detalle = "";
            this.ucTareaEdit1.Fecha = new System.DateTime(2018, 2, 14, 19, 19, 9, 763);
            this.ucTareaEdit1.FechaVencimiento = new System.DateTime(2018, 2, 14, 19, 19, 9, 754);
            this.ucTareaEdit1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ucTareaEdit1.IdClaseTarea = 0;
            this.ucTareaEdit1.IdDificultadTarea = 0;
            this.ucTareaEdit1.IdEstadoTarea = 0;
            this.ucTareaEdit1.IdPadre = ((long)(0));
            this.ucTareaEdit1.IdPrioridad = 0;
            this.ucTareaEdit1.IdTarea = ((long)(0));
            this.ucTareaEdit1.IdUsuario = 0;
            this.ucTareaEdit1.Location = new System.Drawing.Point(12, 427);
            this.ucTareaEdit1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucTareaEdit1.Name = "ucTareaEdit1";
            this.ucTareaEdit1.Notas = "";
            this.ucTareaEdit1.PorcentajeCompleto = 0;
            this.ucTareaEdit1.Size = new System.Drawing.Size(885, 197);
            this.ucTareaEdit1.TabIndex = 0;
            // 
            // FrmTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 637);
            this.Controls.Add(this.ucTareaEdit1);
            this.Name = "FrmTarea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tareas";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl.UcTareaEdit ucTareaEdit1;
    }
}