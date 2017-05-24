namespace Kiosco
{
    partial class FrmProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProveedor));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tsb = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbSearchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSearchPerform = new System.Windows.Forms.ToolStripButton();
            this.tsbSearchClearAndPerform = new System.Windows.Forms.ToolStripButton();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPersonaContacto = new System.Windows.Forms.TextBox();
            this.txtHorarioAtencion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiasDeVisita = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboRubro = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tsb.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 36);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1225, 559);
            this.dgv.TabIndex = 64;
            this.dgv.TabStop = false;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
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
            this.tsb.Size = new System.Drawing.Size(1249, 31);
            this.tsb.TabIndex = 74;
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
            this.tsbSearchTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbSearchTextBox.Name = "tsbSearchTextBox";
            this.tsbSearchTextBox.Size = new System.Drawing.Size(266, 31);
            this.tsbSearchTextBox.Visible = false;
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
            // txtIdProveedor
            // 
            this.txtIdProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProveedor.Location = new System.Drawing.Point(12, 608);
            this.txtIdProveedor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.Size = new System.Drawing.Size(29, 24);
            this.txtIdProveedor.TabIndex = 0;
            this.txtIdProveedor.TabStop = false;
            this.txtIdProveedor.TextChanged += new System.EventHandler(this.txtIdProveedor_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 609);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 67;
            this.label2.Text = "Razón Social:";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.Location = new System.Drawing.Point(159, 607);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(355, 24);
            this.txtRazonSocial.TabIndex = 1;
            // 
            // txtNotas
            // 
            this.txtNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotas.Location = new System.Drawing.Point(699, 710);
            this.txtNotas.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtNotas.MaxLength = 255;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(453, 24);
            this.txtNotas.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(638, 709);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 69;
            this.label7.Text = "Notas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 643);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 71;
            this.label3.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(159, 641);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(355, 24);
            this.txtDireccion.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(619, 612);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 73;
            this.label6.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(699, 605);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(318, 24);
            this.txtTelefono.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 677);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 76;
            this.label1.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(159, 675);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(355, 24);
            this.txtEmail.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(541, 646);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 78;
            this.label4.Text = "Persona de Contacto:";
            // 
            // txtPersonaContacto
            // 
            this.txtPersonaContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonaContacto.Location = new System.Drawing.Point(699, 640);
            this.txtPersonaContacto.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPersonaContacto.Name = "txtPersonaContacto";
            this.txtPersonaContacto.Size = new System.Drawing.Size(318, 24);
            this.txtPersonaContacto.TabIndex = 7;
            // 
            // txtHorarioAtencion
            // 
            this.txtHorarioAtencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorarioAtencion.Location = new System.Drawing.Point(159, 709);
            this.txtHorarioAtencion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtHorarioAtencion.MaxLength = 255;
            this.txtHorarioAtencion.Name = "txtHorarioAtencion";
            this.txtHorarioAtencion.Size = new System.Drawing.Size(355, 24);
            this.txtHorarioAtencion.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 713);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 80;
            this.label5.Text = "Horario de Atencion:";
            // 
            // txtDiasDeVisita
            // 
            this.txtDiasDeVisita.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiasDeVisita.Location = new System.Drawing.Point(699, 675);
            this.txtDiasDeVisita.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDiasDeVisita.MaxLength = 255;
            this.txtDiasDeVisita.Name = "txtDiasDeVisita";
            this.txtDiasDeVisita.Size = new System.Drawing.Size(453, 24);
            this.txtDiasDeVisita.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(587, 677);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 82;
            this.label8.Text = "Días de Visita:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(96, 743);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 18);
            this.label9.TabIndex = 84;
            this.label9.Text = "Rubro:";
            // 
            // cboRubro
            // 
            this.cboRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cboRubro.FormattingEnabled = true;
            this.cboRubro.Location = new System.Drawing.Point(159, 741);
            this.cboRubro.Name = "cboRubro";
            this.cboRubro.Size = new System.Drawing.Size(355, 26);
            this.cboRubro.TabIndex = 5;
            // 
            // FrmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 784);
            this.Controls.Add(this.cboRubro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDiasDeVisita);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHorarioAtencion);
            this.Controls.Add(this.txtPersonaContacto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tsb);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdProveedor);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.FrmProveedores_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmProveedor_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tsb.ResumeLayout(false);
            this.tsb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ToolStrip tsb;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripTextBox tsbSearchTextBox;
        private System.Windows.Forms.ToolStripButton tsbSearchPerform;
        private System.Windows.Forms.ToolStripButton tsbSearchClearAndPerform;
        private System.Windows.Forms.TextBox txtIdProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPersonaContacto;
        private System.Windows.Forms.TextBox txtHorarioAtencion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiasDeVisita;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboRubro;
    }
}