using System;
using System.Drawing;
using System.Windows.Forms;
using Kiosco;
using Model;

namespace Heimdall
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            SetControles();
        }


        private void SetControles()
        {
            txtUser.Focus();
            txtUser.Text = @"Admin";

            Util.CenterFormX(labTitulo, this);
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Validar credenciales del usuario.
            var u = new Usuario {
                Usr = txtUser.Text.Trim(),
                Pwd = txtPwd.Text.Trim()
            };

            if (Security.ValidarUsuario(u)) { 
                Program.UsuarioConectado = u;
                Program.UsuarioConectado.EsAdmin = Security.EsAdmin(u);
                DialogResult = DialogResult.OK;
            }
            else
            {
                Util.Shake(this);
            }

        }

    }
}
