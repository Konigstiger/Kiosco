using System;
using System.Windows.Forms;
using Model;

namespace Heimdall
{
    static class Program
    {
        public static Usuario UsuarioConectado { get; set; } = new Usuario();


        /// <summary>
        /// Punto de entrada de la aplicacion.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //desactivo esto para que tome colores oscuros. En teoria.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DialogResult result;
            using (var loginForm = new FrmLogin())
                result = loginForm.ShowDialog();

            if (result == DialogResult.OK) {
                Application.Run(new FrmMain());
            }
            else
            {
                Application.Exit();
            }
            
        }
    }
}
