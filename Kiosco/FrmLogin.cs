using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace Kiosco
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //this.BackColor = Color.Gray;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Validar credenciales del usuario.
            var u = new Usuario
            {
                Usr = txtUser.Text.Trim(),
                Pwd = txtPwd.Text.Trim()
            };

            //validar con metodo de ctrl

        }
    }
}
