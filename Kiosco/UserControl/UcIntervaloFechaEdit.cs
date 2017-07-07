using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heimdall.UserControl
{
    public partial class UcIntervaloFechaEdit : System.Windows.Forms.UserControl
    {
        public UcIntervaloFechaEdit()
        {
            InitializeComponent();
        }


        [Description("Fecha Inicio."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public DateTime FechaInicio
        {
            get { return dtpFechaInicio.Value; }
            set { dtpFechaInicio.Value = value; }
        }


        [Description("Fecha Fin."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public DateTime FechaFin
        {
            get { return dtpFechaFin.Value; }
            set { dtpFechaFin.Value = value; }
        }
    }
}
