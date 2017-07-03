using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kiosco.View;

//using Presenter;

namespace Kiosco
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());

        }
    }
}
