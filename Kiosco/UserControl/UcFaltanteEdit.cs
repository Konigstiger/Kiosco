﻿using System;
using System.ComponentModel;
using System.Windows.Forms;
using Controlador;
using Heimdall.Forms;
using Model;

namespace Heimdall.UserControl
{
    public partial class UcFaltanteEdit : System.Windows.Forms.UserControl, ISelectorProducto
    {
        [Category("Action")]
        [Description("Es lanzado cuando se selecciona otra Faltante.")]
        public event FaltanteChangedEventHandler FaltanteChanged;

        protected virtual void OnFaltanteChanged(ValueChangedEventArgs e)
        {
            FaltanteChanged?.Invoke(this, e);
        }


        public UcFaltanteEdit()
        {
            InitializeComponent();
            if (Program.UsuarioConectado.EsAdmin == false) {
                //labPrecioCosto.Visible = false;
                //nudPrecioCosto.Visible = false;
            }
        }

        /// <summary>
        /// Devuelve un objeto del tipo de la clase editada
        /// </summary>
        /// <returns></returns>
        public Faltante ToModel()
        {
            var model = new Faltante {
                IdFaltante = IdFaltante,
                Descripcion = Descripcion,
                Cantidad = Cantidad,
                IdProducto = IdProducto==-1 ? (long?) null: IdProducto,
                IdEstadoFaltante = IdEstadoFaltante,
                IdClaseFaltante = IdClaseFaltante,
                Fecha = Fecha,
                FechaResuelto = FechaResuelto,
                IdPrioridad = IdPrioridad,
                Archivado = Archivado,
                Notas = Notas
            };
            return model;
        }


        [Description("IdFaltante. Su evento de cambio genera DataBinding."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public long IdFaltante
        {
            get {
                long v = long.TryParse(txtIdFaltante.Text.Trim(), out v) ? v : 0;
                return v;
            }
            set {
                txtIdFaltante.Text = value.ToString();
                OnFaltanteChanged(new ValueChangedEventArgs(value));
                CargarFaltante(value);

            }
        }


        [Description("IdProducto. Su evento de cambio genera DataBinding."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public long IdProducto
        {
            get {
                long v = long.TryParse(txtIdProducto.Text.Trim(), out v) ? v : 0;
                return v;
            }
            set {
                txtIdProducto.Text = value.ToString();
                var p = ProductoControlador.GetByPrimaryKey(value);
                if (p.Descripcion != null) Descripcion = p.Descripcion;
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

        [Description("FechaResuelto."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public DateTime FechaResuelto
        {
            get { return dtpFechaResuelto.Value; }
            set { dtpFechaResuelto.Value = value; }
        }


        [Description("IdEstadoFaltante."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public int IdEstadoFaltante
        {
            get {
                int v = int.TryParse(cboEstadoFaltante.SelectedValue?.ToString(), out v) ? v : 0;
                return v;
            }
            set { cboEstadoFaltante.SelectedValue = value; }
        }


        [Description("EstadoFaltante."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string EstadoFaltante => cboEstadoFaltante.Text.Trim();


        [Description("ClaseFaltante."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string ClaseFaltante => cboClaseFaltante.Text.Trim();



        [Description("Cantidad."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public int Cantidad
        {
            get { return (int)nudCantidad.Value; }
            set { nudCantidad.Value = value; }
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


        [Description("IdClaseFaltante."), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public int IdClaseFaltante
        {
            get {
                int v = int.TryParse(cboClaseFaltante.SelectedValue?.ToString(), out v) ? v : 0;
                return v;
            }
            set {
                cboClaseFaltante.SelectedValue = value;
                DefinirVisualizacionSegunClaseFaltante(value);
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

            var p = FaltanteControlador.GetByPrimaryKey(idFaltante);

            //TODO: Ver los valores predeterminados, ceros. Podrian ser valores 0 -  sin especificar.


            //Este orden de invocacion creo que es importante. Primero producto, y luego descripcion.
            IdProducto = p.IdProducto ?? 0;
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
            //DefinirVisualizacionSegunClaseFaltante(IdClaseFaltante);
        }

        public void Clear()
        {
            txtDescripcion.Clear();
            nudCantidad.Value = 0;
            chkArchivado.Checked = false;
            dtpFecha.Value = DateTime.Today;
            dtpFechaResuelto.Value = DateTime.Today;
            txtNotas.Clear();
        }


        private void CargarControles()
        {
            CargarEstadoFaltante();
            CargarClaseFaltante();
            CargarPrioridad();
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

        private void CargarClaseFaltante()
        {
            if (DesignMode)
                return;

            cboClaseFaltante.DropDownStyle = ComboBoxStyle.DropDownList;
            var list = ClaseFaltanteControlador.GetAll();
            cboClaseFaltante.DataSource = list;
            cboClaseFaltante.ValueMember = "IdClaseFaltante";
            cboClaseFaltante.DisplayMember = "Descripcion";
        }


        private void CargarEstadoFaltante()
        {
            if (DesignMode)
                return;

            cboEstadoFaltante.DropDownStyle = ComboBoxStyle.DropDownList;
            var list = EstadoFaltanteControlador.GetAll();
            cboEstadoFaltante.DataSource = list;
            cboEstadoFaltante.ValueMember = "IdEstadoFaltante";
            cboEstadoFaltante.DisplayMember = "Descripcion";
        }


        private void SetControles()
        {
            txtIdFaltante.Visible = false;
            txtIdProducto.Visible = false;
            txtDescripcion.MaxLength = 100;
            txtNotas.MaxLength = 255;
            nudCantidad.Maximum = 999;
            nudCantidad.Minimum = 0;
            nudCantidad.Increment = 1;
            nudCantidad.DecimalPlaces = 0;

            //Util.SetNumericBounds(nudPrecio);
        }


        private void UcFaltanteEdit_Load(object sender, EventArgs e)
        {
            SetControles();
            CargarControles();
        }


        private void btnSeleccionarProducto_Click(object sender, EventArgs e)
        {
            var f = new FrmSeleccionarProducto(this);
            f.Show();
        }


        private void btnAbmProducto_Click(object sender, EventArgs e)
        {
            var f = new FrmProducto();
            f.Show();
        }


        private void cboClaseFaltante_SelectedValueChanged(object sender, EventArgs e)
        {
            DefinirVisualizacionSegunClaseFaltante(IdClaseFaltante);
        }


        private void DefinirVisualizacionSegunClaseFaltante(int idClaseFaltante)
        {
            //TODO: esto es sumamente refactorizable. No dejar deuda tecnica.
            switch (idClaseFaltante) {
                case 1:
                    //generico

                    btnAbmProducto.Visible = false;
                    btnSeleccionarProducto.Visible = false;
                    //txtDescripcion.ReadOnly = false;
                    //IdProducto = 0; // todo: deberia ser null.
                    //IdProducto = -1; // todo: deberia ser null.
                    break;

                case 2:
                    //producto especifico
                    btnAbmProducto.Visible = true;
                    btnSeleccionarProducto.Visible = true;
                    //txtDescripcion.ReadOnly = true;
                    btnSeleccionarProducto.Focus();
                    //IdProducto = -1;

                    break;

                default:
                    break;
            }
            IdProducto = -1; // todo: deberia ser null.
        }


    }
}
