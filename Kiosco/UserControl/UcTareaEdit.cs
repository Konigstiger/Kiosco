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
                CargarTarea(value);

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
        public long? IdTareaPadre
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

            //TODO: Ver los valores predeterminados, ceros. Podrian ser valores 0 -  sin especificar.

            Descripcion = p.Descripcion;
            Util.CheckDateNullable(p.Fecha, dtpFecha);
            Util.CheckDateNullable(p.FechaVencimiento, dtpFechaVencimiento);
            Archivado = p.Archivado ?? false;
            Detalle = p.Detalle;
            IdClaseTarea = p.IdClaseTarea ?? 0;
            IdEstadoTarea = p.IdEstadoTarea;
            IdDificultadTarea = p.IdDificultad ?? 0;
            IdPrioridad = p.IdPrioridad ?? 0;
            PorcentajeCompleto = p.PorcentajeCompleto;
            IdUsuario = p.IdUsuario ?? 1;
            Notas = p.Notas;
        }

        public void Clear()
        {
            txtDescripcion.Clear();
            txtDetalle.Clear();
            nudPorcentajeCompleto.Value = 0;
            dtpFecha.Value = DateTime.Today;

        }


        private void UcTareaEdit_Load(object sender, EventArgs e)
        {
            SetControles();
            CargarControles();
        }

        private void CargarControles()
        {
            CargarEstadoTarea();
            CargarPrioridad();
            CargarClaseTarea();
            CargarDificultad();
        }


        private void CargarEstadoTarea()
        {
            if (DesignMode)
                return;

            cboEstadoTarea.DropDownStyle = ComboBoxStyle.DropDownList;
            var list = EstadoTareaControlador.GetAll();
            cboEstadoTarea.DataSource = list;
            cboEstadoTarea.ValueMember = "IdEstadoTarea";
            cboEstadoTarea.DisplayMember = "Descripcion";
        }


        private void CargarDificultad()
        {
            if (DesignMode)
                return;

            cboDificultadTarea.DropDownStyle = ComboBoxStyle.DropDownList;
            var list = DificultadControlador.GetAll();
            cboDificultadTarea.DataSource = list;
            cboDificultadTarea.ValueMember = "IdDificultad";
            cboDificultadTarea.DisplayMember = "Descripcion";
        }

        private void CargarClaseTarea()
        {
            if (DesignMode)
                return;

            cboClaseTarea.DropDownStyle = ComboBoxStyle.DropDownList;
            var list = ClaseTareaControlador.GetAll();
            cboClaseTarea.DataSource = list;
            cboClaseTarea.ValueMember = "IdClaseTarea";
            cboClaseTarea.DisplayMember = "Descripcion";
        }

        private void CargarPrioridad()
        {
            if (DesignMode)
                return;

            cboPrioridad.DropDownStyle = ComboBoxStyle.DropDownList;
            var list = PrioridadControlador.GetAll();
            cboPrioridad.DataSource = list;
            cboPrioridad.ValueMember = "IdPrioridad";
            cboPrioridad.DisplayMember = "Descripcion";
        }


        private void SetControles()
        {
            txtIdTarea.Visible = false;
            txtIdUsuario.Visible = false;
            txtIdTareaPadre.Visible = false;
            txtDescripcion.MaxLength = 100;
            txtDetalle.MaxLength = 400;
            txtNotas.MaxLength = 255;
            nudPorcentajeCompleto.Maximum = 100;
            nudPorcentajeCompleto.Minimum = 0;
            nudPorcentajeCompleto.Increment = 25;
            nudPorcentajeCompleto.DecimalPlaces = 0;

            //Util.SetNumericBounds(nudPrecio);
        }

    }
}
