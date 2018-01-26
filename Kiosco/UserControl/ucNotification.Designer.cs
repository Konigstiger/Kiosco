namespace Heimdall.UserControl
{
    partial class UcNotification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcNotification));
            this.labMensaje = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // labMensaje
            // 
            this.labMensaje.AutoSize = true;
            this.labMensaje.Location = new System.Drawing.Point(60, 17);
            this.labMensaje.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labMensaje.Name = "labMensaje";
            this.labMensaje.Size = new System.Drawing.Size(95, 25);
            this.labMensaje.TabIndex = 0;
            this.labMensaje.Text = "[Mensaje]";
            // 
            // pbImagen
            // 
            this.pbImagen.Image = ((System.Drawing.Image)(resources.GetObject("pbImagen.Image")));
            this.pbImagen.Location = new System.Drawing.Point(16, 17);
            this.pbImagen.Margin = new System.Windows.Forms.Padding(6);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(32, 32);
            this.pbImagen.TabIndex = 1;
            this.pbImagen.TabStop = false;
            // 
            // UcNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.labMensaje);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UcNotification";
            this.Size = new System.Drawing.Size(600, 64);
            this.Load += new System.EventHandler(this.ucNotification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labMensaje;
        private System.Windows.Forms.PictureBox pbImagen;
    }
}
