using System;
using System.Windows.Forms;
using Controlador;
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
            var list = UsuarioControlador.GetAll();
            cboUser.DataSource = list;
            cboUser.DisplayMember = "Usr";
            cboUser.ValueMember = "Usr";
            cboUser.Focus();

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
                Usr = cboUser.Text.Trim(),
                Pwd = txtPwd.Text.Trim()
            };

            //TODO: Revisar muy bien esto y simplificarlo. Resolverlo en papel.
            //hacer una capa de servicio para seguridad.
            if (Security.ValidarUsuario(u)) { 
                Program.UsuarioConectado.EsAdmin = Security.EsAdmin(u);
                DialogResult = DialogResult.OK;
            }
            else
            {
                Util.Shake(this);
            }

        }

        private void chkToggleShowPwd_CheckedChanged(object sender, EventArgs e)
        {
            chkToggleShowPwd.ImageIndex = chkToggleShowPwd.ImageIndex == 1 ? 0 : 1;
            txtPwd.PasswordChar = chkToggleShowPwd.Checked ? '•' : '\0';
        }
    }
}
