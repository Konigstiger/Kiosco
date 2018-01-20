using System;
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


            string user = u.Usr.ToLower();
            string pwd = u.Pwd.ToLower();

            if (user.Equals("admin") && pwd.ToLower().Equals("crazyfucker")) {

                Program.UsuarioConectado = u;

                DialogResult = DialogResult.OK;
            }

            //redirigir.
            //Application.Run(new FrmMain());

            //this.Close();

            //validar con metodo de ctrl
            //if(!u.Usr.Equals("Admin"))

            //var snapshot = cameraControl1.TakeSnapshot();
            //snapshot.Save();

        }
    }
}
