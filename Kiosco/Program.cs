using System;
using System.Windows.Forms;
using Model;
using NLog;

namespace Heimdall
{
    static class Program
    {
        public static Usuario UsuarioConectado { get; set; } = new Usuario();


        private static Logger logger = LogManager.GetCurrentClassLogger();

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
                logger.Debug(String.Format("Usuario conectado: {0}", Program.UsuarioConectado.Descripcion));
                Application.Run(new FrmMain());
            }
            else
            {
                logger.Debug("Cierre de Aplicacion.");

                Application.Exit();
            }
            
        }
    }
}
