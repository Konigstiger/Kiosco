using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Heimdall.UserControl
{
    public partial class UcAbmToolBar : System.Windows.Forms.UserControl
    {
        public UcAbmToolBar()
        {
            InitializeComponent();
            tsb.ImageList = imageList1;
            tsb.Items[0].ImageKey = @"add";
            tsb.Items[1].ImageKey = @"save";
            tsb.Items[2].ImageKey = @"delete";
            tsb.Items[4].ImageKey = @"search";
        }

        public event EventHandler ButtonClickNew;
        public event EventHandler ButtonClickUpdate;
        public event EventHandler ButtonClickDelete;
        public event EventHandler ButtonClickArchivo;

        public event EventHandler ButtonClickExecuteSearch;

        [Description("AllowNew."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public bool AllowNew
        {
            get { return tsbNew.Enabled; }
            set { tsbNew.Enabled = value; }
        }


        [Description("AllowSave."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public bool AllowSave
        {
            get { return tsbSave.Enabled; }
            set { tsbSave.Enabled = value; }
        }


        [Description("AllowDelete."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public bool AllowDelete
        {
            get { return tsbDelete.Enabled; }
            set { tsbDelete.Enabled = value; }
        }


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

        private void tsbSearchPerform_Click(object sender, EventArgs e)
        {
            this.ButtonClickExecuteSearch?.Invoke(this, e);
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

        //showshit ctrl v



        private void tsbSearch_Click(object sender, EventArgs e)
        {
            ToggleSearch();
        }


        public void ToggleSearch()
        {
            tsbSearchTextBox.Visible = !tsbSearchTextBox.Visible;
            tsbSearchPerform.Visible = !tsbSearchPerform.Visible;
            tsbSearchClearAndPerform.Visible = !tsbSearchClearAndPerform.Visible;
            tsbSearchTextBox.Focus();
        }

        private void tsbSearchTextBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Enter)) {
                this.ButtonClickExecuteSearch?.Invoke(this, e);
            }
            tsbSearchTextBox.Focus();
        }
    }
}
