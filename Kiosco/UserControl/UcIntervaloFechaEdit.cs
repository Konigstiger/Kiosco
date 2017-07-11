using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Heimdall.UserControl
{
    public partial class UcIntervaloFechaEdit : System.Windows.Forms.UserControl
    {
        public UcIntervaloFechaEdit()
        {
            InitializeComponent();
        }


        [Category("Action")]
        [Description("Es lanzado cuando se filtra por las fechas definidas.")]
        public event AddActionEventHandler FiltrarAction;

        protected virtual void OnFiltrarAction(EventArgs e)
        {
            FiltrarAction?.Invoke(this, e);
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

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            OnFiltrarAction(new EventArgs());
        }
    }
}
