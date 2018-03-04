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
using Model;

namespace Heimdall.UserControl
{
    public partial class UcGastoEdit : System.Windows.Forms.UserControl
    {
        public UcGastoEdit()
        {
            InitializeComponent();
            if (Program.UsuarioConectado.EsAdmin == false) {
                //labPrecioCosto.Visible = false;
                //nudPrecioCosto.Visible = false;
            }
        }

        [Category("Action")]
        [Description("Es lanzado cuando se selecciona otra Gasto.")]
        public event GastoChangedEventHandler GastoChanged;

        protected virtual void OnGastoChanged(ValueChangedEventArgs e)
        {
            GastoChanged?.Invoke(this, e);
        }


        
        /// <summary>
        /// Devuelve un objeto del tipo de la clase editada
        /// </summary>
        /// <returns></returns>
        public Gasto ToModel()
        {
            var model = new Gasto {
                IdGasto = IdGasto,
                Descripcion = Descripcion,
                Monto = Monto,
                MontoPendiente = MontoPendiente,
                //IdProducto = IdProducto == -1 ? (long?)null : IdProducto,
                IdEstadoGasto = IdEstadoGasto,
                IdClaseGasto = IdClaseGasto,
                FechaVencimiento = FechaVencimiento,
                FechaPago = FechaPago,
                IdPrioridad = IdPrioridad,
                Archivado = Archivado,
                Notas = Notas
            };
            return model;
        }
        

        [Description("IdGasto. Su evento de cambio genera DataBinding."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public long IdGasto
        {
            get {
                long v = long.TryParse(txtIdGasto.Text.Trim(), out v) ? v : 0;
                return v;
            }
            set {
                txtIdGasto.Text = value.ToString();
                OnGastoChanged(new ValueChangedEventArgs(value));
                CargarGasto(value);

            }
        }


        public void CargarGasto(long idGasto)
        {
            //todo
        }

        [Description("Descripcion."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string Descripcion
        {
            get { return txtDescripcion.Text; }
            set { txtDescripcion.Text = value; }
        }


        [Description("Notas."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string Notas
        {
            get { return txtNotas.Text; }
            set { txtNotas.Text = value; }
        }


        [Description("FechaVencimiento."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public DateTime FechaVencimiento
        {
            get { return dtpFechaVencimiento.Value; }
            set { dtpFechaVencimiento.Value = value; }
        }

        [Description("FechaPago."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public DateTime FechaPago
        {
            get { return dtpFechaPago.Value; }
            set { dtpFechaPago.Value = value; }
        }


        [Description("IdEstadoGasto."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public int IdEstadoGasto
        {
            get {
                int v = int.TryParse(cboEstadoGasto.SelectedValue?.ToString(), out v) ? v : 0;
                return v;
            }
            set { cboEstadoGasto.SelectedValue = value; }
        }


        [Description("EstadoGasto."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string EstadoGasto => cboEstadoGasto.Text.Trim();


        [Description("ClaseGasto."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string ClaseGasto => cboClaseGasto.Text.Trim();



        [Description("Monto."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public decimal Monto
        {
            get {
                var v = nudMonto.Value;
                return v;
            }
            set {
                nudMonto.Value = value;
            }
        }


        [Description("MontoPendiente."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public decimal MontoPendiente
        {
            get {
                var v = nudMontoPendiente.Value;
                return v;
            }
            set {
                nudMontoPendiente.Value = value;
            }
        }


        [Description("Archivado."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public bool Archivado
        {
            get { return chkArchivado.Checked; }
            set { chkArchivado.Checked = value; }
        }


        [Description("IdClaseGasto."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public int IdClaseGasto
        {
            get {
                int v = int.TryParse(cboClaseGasto.SelectedValue?.ToString(), out v) ? v : 0;
                return v;
            }
            set {
                cboClaseGasto.SelectedValue = value;
            }
        }


        [Description("IdPrioridad. Su evento de cambio genera DataBinding."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public int IdPrioridad
        {
            get {
                int v = int.TryParse(cboPrioridad.SelectedValue?.ToString(), out v) ? v : 0;
                return v;
            }
            set { cboPrioridad.SelectedValue = value; }
        }


        [Description("Prioridad."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string Prioridad => cboPrioridad.Text.Trim();


        public void CargarFaltante(long idFaltante)
        {
            if (DesignMode)
                return;
            /*
            var p = GastoControlador.GetByPrimaryKey(idFaltante);

            //TODO: Ver los valores predeterminados, ceros. Podrian ser valores 0 -  sin especificar.


            //Este orden de invocacion creo que es importante. Primero producto, y luego descripcion.
            //IdProducto = p.IdProducto ?? 0;
            Descripcion = p.Descripcion;

            Util.CheckDateNullable(p.Fecha, dtpFecha);
            Util.CheckDateNullable(p.FechaResuelto, dtpFechaResuelto);

            if (dtpFechaResuelto.Checked == false)
                p.FechaResuelto = null;

            Archivado = p.Archivado ?? false;

            IdEstadoFaltante = p.IdEstadoFaltante;
            IdClaseFaltante = p.IdClaseFaltante;    //esto llama internamente a DefinirVis...
            Cantidad = p.Cantidad;
            IdPrioridad = p.IdPrioridad;
            Notas = p.Notas;

            //mostrar segun el valor de IdClaseFaltante
            */
        }


        public void Clear()
        {
            txtDescripcion.Clear();
            nudMonto.Value = 0;
            nudMontoPendiente.Value = 0;
            chkArchivado.Checked = false;
            dtpFechaVencimiento.Value = DateTime.Today;
            dtpFechaPago.Value = DateTime.Today;
            txtNotas.Clear();
            //todo: definir valores predeterminados.
            /*
                IdEstadoGasto = IdEstadoGasto,
                IdClaseGasto = IdClaseGasto,
                IdPrioridad = IdPrioridad,
             */
        }



    }
}
