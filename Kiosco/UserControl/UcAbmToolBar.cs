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
        public event EventHandler ButtonClickUpdate;
        public event EventHandler ButtonClickDelete;

        private void tsbNew_Click(object sender, EventArgs e)
        {
            this.ButtonClickNew?.Invoke(this, e);
        }


        private void tsbSave_Click(object sender, EventArgs e)
        {
            this.ButtonClickUpdate?.Invoke(this, e);
        }


        private void tsbDelete_Click(object sender, EventArgs e)
        {
            this.ButtonClickDelete?.Invoke(this, e);
        }
    }
}
