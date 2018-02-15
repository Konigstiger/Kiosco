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
    public partial class UcTareaEdit : System.Windows.Forms.UserControl
    {
        [Category("Action")]
        [Description("Es lanzado cuando se selecciona otra Tarea.")]
        public event TareaChangedEventHandler TareaChanged;

        protected virtual void OnTareaChanged(ValueChangedEventArgs e)
        {
            TareaChanged?.Invoke(this, e);
        }


        public UcTareaEdit()
        {
            InitializeComponent();
            if (Program.UsuarioConectado.EsAdmin == false) {
                //labPrecioCosto.Visible = false;
                //nudPrecioCosto.Visible = false;
            }
        }


        [Description("IdTarea. Su evento de cambio genera DataBinding."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public long IdTarea
        {
            get {
                long v = long.TryParse(txtIdTarea.Text.Trim(), out v) ? v : 0;
                return v;
            }
            set {
                txtIdTarea.Text = value.ToString();
                OnTareaChanged(new ValueChangedEventArgs(value));
            }
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


        [Description("Detalle."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string Detalle
        {
            get { return txtDetalle.Text; }
            set { txtDetalle.Text = value; }
        }


        [Description("IdEstadoTarea."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public int IdEstadoTarea
        {
            get {
                int v = int.TryParse(cboEstadoTarea.SelectedValue?.ToString(), out v) ? v : 0;
                return v;
            }
            set { cboEstadoTarea.SelectedValue = value; }
        }


        [Description("IdClaseTarea."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public int IdClaseTarea
        {
            get {
                int v = int.TryParse(cboClaseTarea.SelectedValue?.ToString(), out v) ? v : 0;
                return v;
            }
            set { cboClaseTarea.SelectedValue = value; }
        }


        [Description("IdPrioridad."), Category("Data")]
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


        [Description("IdDificultadTarea."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public int IdDificultadTarea
        {
            get {
                int v = int.TryParse(cboDificultadTarea.SelectedValue?.ToString(), out v) ? v : 0;
                return v;
            }
            set { cboDificultadTarea.SelectedValue = value; }
        }


        [Description("PorcentajeCompleto."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public int PorcentajeCompleto
        {
            get { return (int)nudPorcentajeCompleto.Value; }
            set { nudPorcentajeCompleto.Value = value; }
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



        [Description("IdUsuario."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public int IdUsuario
        {
            get {
                int v = int.TryParse(txtIdUsuario.Text.Trim(), out v) ? v : 0;
                return v;
            }
            set {
                txtIdUsuario.Text = value.ToString();
                //OnTareaChanged(new ValueChangedEventArgs(value));
            }
        }


        [Description("IdTareaPadre."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public long IdPadre
        {
            get {
                long v = long.TryParse(txtIdTareaPadre.Text.Trim(), out v) ? v : 0;
                return v;
            }
            set {
                txtIdTareaPadre.Text = value.ToString();
                //OnTareaChanged(new ValueChangedEventArgs(value));
            }
        }


        public void CargarTarea(long idTarea)
        {
            if (DesignMode)
                return;

            var p = TareaControlador.GetByPrimaryKey(idTarea);

            CargarEstadoTarea();
            //CargarPrioridad();
            //CargarHoraEntrega();

            //Descripcion = p.Descripcion;
            //Util.CheckDateNullable(p.Fecha, dtpFecha);
            //Util.CheckDateNullable(p.FechaEntrega, dtpFechaEntrega);
            //Total = p.Total;
            //IdProveedor = p.IdProveedor;
            //IdEstadoPedido = p.IdEstadoPedido;
            //Notas = p.Notas;
            //EstaPago = p.EstaPago;
            //Archivado = p.Archivado;
            //Fiscal = p.Fiscal;
            //IdPrioridad = p.IdPrioridad;
            //IdHoraEntrega = p.IdHoraEntrega;

        }

        public void Clear()
        {
            //TODO
            txtDescripcion.Clear();
        }

        private void CargarEstadoTarea()
        {
            //TODO
        }

        private void UcTareaEdit_Load(object sender, EventArgs e)
        {
            SetControles();
            CargarControles();
        }

        private void CargarControles()
        {
            //TODO
        }


        private void SetControles()
        {
            txtIdTarea.Visible = false;
            txtDescripcion.MaxLength = 100;

            //Util.SetNumericBounds(nudPrecio);
            //Util.SetNumericBounds(nudPrecioVentaPremium);
            //Util.SetNumericBounds(nudPrecioCosto);
            //Util.SetNumericBounds(nudStockActual);
            //Util.SetNumericBounds(nudStockMaximo);
            //Util.SetNumericBounds(nudStockMinimo);
            //Util.SetNumericBounds(nudCapacidad);
            //Util.SetNumericBounds(nudStockActual);
            //nudStockActual.Increment = 1;
            //nudStockMaximo.Increment = 1;
            //nudStockMinimo.Increment = 1;
            //nudCapacidad.Increment = 250;
            //txtIdMarca.Visible = false;

            txtNotas.MaxLength = 255;
        }

    }
}
