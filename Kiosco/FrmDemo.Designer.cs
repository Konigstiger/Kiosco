namespace Heimdall
{
    partial class FrmDemo
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
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.olvColumn1);
            this.objectListView1.AllColumns.Add(this.olvColumn3);
            this.objectListView1.AllColumns.Add(this.olvColumn2);
            this.objectListView1.AllColumns.Add(this.olvColumn4);
            this.objectListView1.CellEditUseWholeCell = false;
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn3,
            this.olvColumn2,
            this.olvColumn4});
            this.objectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView1.GridLines = true;
            this.objectListView1.Location = new System.Drawing.Point(31, 35);
            this.objectListView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.Size = new System.Drawing.Size(1208, 785);
            this.objectListView1.TabIndex = 0;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "IdPedido";
            this.olvColumn1.Groupable = false;
            this.olvColumn1.Text = "IdPedido";
            this.olvColumn1.Width = 62;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Fecha";
            this.olvColumn3.AspectToStringFormat = "{0:d}";
            this.olvColumn3.DisplayIndex = 2;
            this.olvColumn3.Text = "Fecha";
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Descripcion";
            this.olvColumn2.DisplayIndex = 1;
            this.olvColumn2.Text = "Descripcion";
            this.olvColumn2.UseInitialLetterForGroup = true;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "Estado";
            this.olvColumn4.Text = "Estado";
            // 
            // FrmDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 859);
            this.Controls.Add(this.objectListView1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmDemo";
            this.Text = "FrmDemo";
            this.Load += new System.EventHandler(this.FrmDemo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
    }
}