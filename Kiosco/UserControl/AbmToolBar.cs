using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosco
{
    public partial class AbmToolBar : System.Windows.Forms.UserControl
    {
        public AbmToolBar()
        {
            InitializeComponent();
        }

        public event EventHandler ButtonClickNew;

        private void tsbNew_Click(object sender, EventArgs e)
        {
            this.ButtonClickNew?.Invoke(this, e);
        }


        

    }
}
