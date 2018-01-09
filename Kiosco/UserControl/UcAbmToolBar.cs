using System;

namespace Heimdall.UserControl
{
    public partial class UcAbmToolBar : System.Windows.Forms.UserControl
    {
        public UcAbmToolBar()
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
