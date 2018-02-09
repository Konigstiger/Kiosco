namespace Heimdall.UserControl
{
    partial class UcConsumoEdit
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
            this.txtIdConsumo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtIdConsumo
            // 
            this.txtIdConsumo.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtIdConsumo.Location = new System.Drawing.Point(3, 2);
            this.txtIdConsumo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdConsumo.Name = "txtIdConsumo";
            this.txtIdConsumo.Size = new System.Drawing.Size(16, 27);
            this.txtIdConsumo.TabIndex = 76;
            this.txtIdConsumo.Text = "0";
            // 
            // UcConsumoEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtIdConsumo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UcConsumoEdit";
            this.Size = new System.Drawing.Size(723, 282);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdConsumo;
    }
}
