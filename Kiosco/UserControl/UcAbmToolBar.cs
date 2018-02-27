using System;
using System.ComponentModel;

namespace Heimdall.UserControl
{
    public partial class UcAbmToolBar : System.Windows.Forms.UserControl
    {
        public UcAbmToolBar()
        {
            InitializeComponent();
            tsb.ImageList = imageList1;
            tsb.Items[0].ImageIndex = 0;
            tsb.Items[1].ImageIndex = 1;
            tsb.Items[2].ImageIndex = 2;


        }

        public event EventHandler ButtonClickNew;
        public event EventHandler ButtonClickUpdate;
        public event EventHandler ButtonClickDelete;
        public event EventHandler ButtonClickArchivo;

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

        private void tsbVerArchivo_Click(object sender, EventArgs e)
        {
            this.ButtonClickArchivo?.Invoke(this, e);
        }


        [Description("SearchText."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string SearchText
        {
            get { return tsbSearchTextBox.Text.Trim(); }
            set { tsbSearchTextBox.Text = value; }
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            ToggleSearch();
        }


        private void ToggleSearch()
        {
            tsbSearchTextBox.Visible = !tsbSearchTextBox.Visible;
            tsbSearchPerform.Visible = !tsbSearchPerform.Visible;
            tsbSearchClearAndPerform.Visible = !tsbSearchClearAndPerform.Visible;
            tsbSearchTextBox.Focus();
        }



    }
}
