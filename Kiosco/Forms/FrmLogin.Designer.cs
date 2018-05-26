using System.Windows.Forms;

namespace Heimdall
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.labTitulo = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.labelControl1 = new System.Windows.Forms.Label();
            this.labelControl2 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ILLogin = new System.Windows.Forms.ImageList(this.components);
            this.chkToggleShowPwd = new System.Windows.Forms.CheckBox();
            this.cboUser = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labTitulo
            // 
            this.labTitulo.AutoSize = true;
            this.labTitulo.Font = new System.Drawing.Font("Teko", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labTitulo.Location = new System.Drawing.Point(101, 24);
            this.labTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.Size = new System.Drawing.Size(503, 91);
            this.labTitulo.TabIndex = 0;
            this.labTitulo.Text = "Autenticación de Usuario";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(191, 183);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '•';
            this.txtPwd.Size = new System.Drawing.Size(304, 29);
            this.txtPwd.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSize = true;
            this.labelControl1.Font = new System.Drawing.Font("Caviar Dreams", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(102, 138);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(83, 24);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Usuario:";
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSize = true;
            this.labelControl2.Font = new System.Drawing.Font("Caviar Dreams", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(86, 185);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(99, 24);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Password:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(191, 242);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(112, 40);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancelar.Location = new System.Drawing.Point(383, 242);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 40);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ILLogin
            // 
            this.ILLogin.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ILLogin.ImageStream")));
            this.ILLogin.TransparentColor = System.Drawing.Color.Transparent;
            this.ILLogin.Images.SetKeyName(0, "turn-visibility-off-button.png");
            this.ILLogin.Images.SetKeyName(1, "visibility-button.png");
            // 
            // chkToggleShowPwd
            // 
            this.chkToggleShowPwd.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkToggleShowPwd.Checked = true;
            this.chkToggleShowPwd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkToggleShowPwd.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkToggleShowPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkToggleShowPwd.ImageIndex = 0;
            this.chkToggleShowPwd.ImageList = this.ILLogin;
            this.chkToggleShowPwd.Location = new System.Drawing.Point(501, 183);
            this.chkToggleShowPwd.Name = "chkToggleShowPwd";
            this.chkToggleShowPwd.Size = new System.Drawing.Size(30, 29);
            this.chkToggleShowPwd.TabIndex = 14;
            this.chkToggleShowPwd.UseVisualStyleBackColor = true;
            this.chkToggleShowPwd.CheckedChanged += new System.EventHandler(this.chkToggleShowPwd_CheckedChanged);
            // 
            // cboUser
            // 
            this.cboUser.FormattingEnabled = true;
            this.cboUser.Items.AddRange(new object[] {
            "Admin",
            "Operador"});
            this.cboUser.Location = new System.Drawing.Point(191, 133);
            this.cboUser.Name = "cboUser";
            this.cboUser.Size = new System.Drawing.Size(304, 29);
            this.cboUser.TabIndex = 15;
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnAceptar;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(673, 329);
            this.Controls.Add(this.cboUser);
            this.Controls.Add(this.chkToggleShowPwd);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labTitulo);
            this.Controls.Add(this.txtPwd);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Heimdall // Autenticación";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTitulo;
        private TextBox txtPwd;
        private Label labelControl1;
        private Label labelControl2;
        private Button btnAceptar;
        private Button btnCancelar;
        private ImageList ILLogin;
        private CheckBox chkToggleShowPwd;
        private ComboBox cboUser;
    }
}