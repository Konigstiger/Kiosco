using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Kiosco
{
    public partial class UcNotification : System.Windows.Forms.UserControl
    {
        public UcNotification()
        {
            InitializeComponent();
        }


        [Description("Mensaje de notificacion al usuario."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public override string Text
        {
            get {
                return labMensaje.Text;
            }

            set {
                labMensaje.Text = value;
                //timer.Enabled = true;
                //timer.Enabled = false;
                
            }
        }


        public void Ocultar()
        {
            this.Show();
            var t = new Timer { Interval = 2000 };
            t.Tick += (s, e) =>
            {
                this.Hide();
                t.Stop();
            };
            t.Start();
        }


        private void ucNotification_Load(object sender, EventArgs e)
        {
            //timer.Interval = 1500;
        }
    }
}
