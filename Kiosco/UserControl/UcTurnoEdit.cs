using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace Heimdall.UserControl
{
    public partial class UcTurnoEdit : System.Windows.Forms.UserControl
    {
        public UcTurnoEdit()
        {
            InitializeComponent();
        }

        [Description("IdTurno. Su evento de cambio genera DataBinding."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public long IdTurno
        {
            get {
                long v = long.TryParse(txtIdTurno.Text.Trim(), out v) ? v : 0;
                return v;
            }
            set {
                txtIdTurno.Text = value.ToString();
                //hacer cosas de bind aqui
                if (value != 0)
                    CargarTurno(value);    //Esta es la unica llamada.
            }
        }


        [Description("IdPagoEmpleado. Su evento de cambio genera DataBinding."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public long IdPagoEmpleado
        {
            get {
                long v = long.TryParse(txtIdPagoEmpleado.Text.Trim(), out v) ? v : 0;
                return v;
            }
            set {
                txtIdPagoEmpleado.Text = value.ToString();
            }
        }


        //TODO: OnCantidadHorasChanged?

        [Description("Fecha."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public DateTime Fecha
        {
            get { return dtpFecha.Value; }
            set { dtpFecha.Value = value; }
        }


        [Description("HoraInicio."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public DateTime HoraInicio
        {
            get { return dtpHoraInicio.Value; }
            set { dtpHoraInicio.Value = value; }
        }


        [Description("HoraFin."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public DateTime HoraFin
        {
            get { return dtpHoraFin.Value; }
            set { dtpHoraFin.Value = value; }
        }

        
        [Description("Descripcion."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string Descripcion
        {
            get { return txtDescripcion.Text.Trim(); }
            set { txtDescripcion.Text = value; }
        }


        [Description("Notas."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string Notas
        {
            get { return txtNotas.Text.Trim(); }
            set { txtNotas.Text = value; }
        }


        [Description("CantidadHoras."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public decimal CantidadHoras
        {
            get { return nudCantidadHoras.Value; }
            set { nudCantidadHoras.Value = value; }
        }


        [Description("Monto."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public decimal Monto
        {
            get { return nudMonto.Value; }
            set { nudMonto.Value = value; }
        }


        public void CargarTurno(long idTurno)
        {
            if (DesignMode)
                return;
            /*
            var p = TurnoControlador.GetByPrimaryKey(idTurno);

            Descripcion = p.Descripcion;
            Util.CheckDateNullable(p.Fecha, dtpFecha);
            Util.CheckDateNullable(p.FechaEntrega, dtpFechaEntrega);
            Total = p.Total;
            IdProveedor = p.IdProveedor;
            IdEstadoTurno = p.IdEstadoTurno;
            Notas = p.Notas;
            EstaPago = p.EstaPago;
            Archivado = p.Archivado;
            Fiscal = p.Fiscal;
            IdPrioridad = p.IdPrioridad;
            IdHoraEntrega = p.IdHoraEntrega;
            */
        }

        private void UcTurnoEdit_Load(object sender, EventArgs e)
        {
            SetControles();
            CargarControles();

        }

        private void CargarControles()
        {
            if (!DesignMode) {
                //CargarEstadoPedido();
            }
        }

        public void SetControles()
        {
            txtIdTurno.Visible = false;
            txtDescripcion.MaxLength = 50;
            txtNotas.MaxLength = 255;
            dtpFecha.Value = DateTime.Today;
            //dtpFecha.Checked = true;

        }

        public void Clear()
        {
            IdTurno = 0;
            Descripcion = string.Empty;
            Fecha = DateTime.Today;
            //..
            CantidadHoras = 0;
            //..
            Notas = string.Empty;
        }
    }
}
