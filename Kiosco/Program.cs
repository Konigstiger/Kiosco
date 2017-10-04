using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Heimdall;
using Kiosco.View;
using Model;

//using Presenter;

namespace Kiosco
{
    static class Program
    {
        public static Usuario UsuarioConectado { get; set; } = new Usuario();


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //desactivo esto para que tome colores oscuros. En teoria.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmLogin());
            //Application.Run(new FrmMain());
            //Application.Run(new FrmCalendario());
            //Application.Run(new FrmProducto2());
            
    
            DialogResult result;
            using (var loginForm = new FrmLogin())
                result = loginForm.ShowDialog();

            //TODO: Agregar validaciones reales aqui.
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
