﻿using Heimdall.UserControl;

namespace Heimdall
{
    partial class FrmPedidoDetalle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidoDetalle));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tsb = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbSearchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSearchPerform = new System.Windows.Forms.ToolStripButton();
            this.tsbSearchClearAndPerform = new System.Windows.Forms.ToolStripButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ucPedido1 = new Heimdall.UserControl.UcPedido();
            this.ucPedidoDetalle1 = new Heimdall.UserControl.UcPedidoDetalle();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tsb.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(14, 216);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1280, 440);
            this.dgv.TabIndex = 9;
            this.dgv.TabStop = false;
            this.dgv.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_DataError);
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            this.dgv.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgv_MouseDown);
            // 
            // tsb
            // 
            this.tsb.Dock = System.Windows.Forms.DockStyle.None;
            this.tsb.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbSave,
            this.tsbDelete,
            this.toolStripSeparator1,
            this.tsbSearch,
            this.tsbSearchTextBox,
            this.tsbSearchPerform,
            this.tsbSearchClearAndPerform});
            this.tsb.Location = new System.Drawing.Point(14, 184);
            this.tsb.Name = "tsb";
            this.tsb.Size = new System.Drawing.Size(327, 31);
            this.tsb.TabIndex = 23;
            this.tsb.Text = "toolStrip1";
            // 
            // tsbNew
            // 
            this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(86, 28);
            this.tsbNew.Text = "Agregar...";
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(77, 28);
            this.tsbSave.Text = "Guardar";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(67, 28);
            this.tsbDelete.Text = "Borrar";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbSearch
            // 
            this.tsbSearch.CheckOnClick = true;
            this.tsbSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearch.Image")));
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(79, 28);
            this.tsbSearch.Text = "Buscar...";
            this.tsbSearch.Click += new System.EventHandler(this.tsbSearch_Click);
            // 
            // tsbSearchTextBox
            // 
            this.tsbSearchTextBox.Name = "tsbSearchTextBox";
            this.tsbSearchTextBox.Size = new System.Drawing.Size(116, 31);
            this.tsbSearchTextBox.Visible = false;
            // 
            // tsbSearchPerform
            // 
            this.tsbSearchPerform.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSearchPerform.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearchPerform.Image")));
            this.tsbSearchPerform.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearchPerform.Name = "tsbSearchPerform";
            this.tsbSearchPerform.Size = new System.Drawing.Size(28, 28);
            this.tsbSearchPerform.Visible = false;
            this.tsbSearchPerform.Click += new System.EventHandler(this.tsbSearchPerform_Click);
            // 
            // tsbSearchClearAndPerform
            // 
            this.tsbSearchClearAndPerform.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSearchClearAndPerform.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearchClearAndPerform.Image")));
            this.tsbSearchClearAndPerform.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearchClearAndPerform.Name = "tsbSearchClearAndPerform";
            this.tsbSearchClearAndPerform.Size = new System.Drawing.Size(28, 28);
            this.tsbSearchClearAndPerform.Visible = false;
            this.tsbSearchClearAndPerform.Click += new System.EventHandler(this.tsbSearchClearAndPerform_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "highlighter24.png");
            this.imageList1.Images.SetKeyName(1, "eraser.png");
            // 
            // cms
            // 
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(61, 4);
            this.cms.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cms_ItemClicked);
            // 
            // ucPedido1
            // 
            this.ucPedido1.Archivado = false;
            this.ucPedido1.BackColor = System.Drawing.Color.White;
            this.ucPedido1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucPedido1.Descripcion = "";
            this.ucPedido1.EstaPago = false;
            this.ucPedido1.Fecha = new System.DateTime(2018, 2, 20, 0, 0, 0, 0);
            this.ucPedido1.FechaEntrega = new System.DateTime(2018, 2, 20, 0, 0, 0, 0);
            this.ucPedido1.Fiscal = false;
            this.ucPedido1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ucPedido1.IdEstadoPedido = 0;
            this.ucPedido1.IdHoraEntrega = 0;
            this.ucPedido1.IdPedido = ((long)(0));
            this.ucPedido1.IdPrioridad = 0;
            this.ucPedido1.IdProveedor = 0;
            this.ucPedido1.Location = new System.Drawing.Point(14, 6);
            this.ucPedido1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucPedido1.Name = "ucPedido1";
            this.ucPedido1.Notas = "";
            this.ucPedido1.Proveedor = "";
            this.ucPedido1.ShowDetallePedido = false;
            this.ucPedido1.ShowEstadoPedido = true;
            this.ucPedido1.Size = new System.Drawing.Size(1280, 174);
            this.ucPedido1.TabIndex = 91;
            this.ucPedido1.Total = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucPedido1.ProveedorChanged += new Heimdall.UserControl.ValueChangedEventHandler(this.ucPedido1_ProveedorChanged);
            // 
            // ucPedidoDetalle1
            // 
            this.ucPedidoDetalle1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ucPedidoDetalle1.BackColor = System.Drawing.SystemColors.Control;
            this.ucPedidoDetalle1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucPedidoDetalle1.Cantidad = 1;
            this.ucPedidoDetalle1.CodigoBarras = "";
            this.ucPedidoDetalle1.Descripcion = "";
            this.ucPedidoDetalle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucPedidoDetalle1.IdPedidoDetalle = ((long)(0));
            this.ucPedidoDetalle1.IdProducto = ((long)(0));
            this.ucPedidoDetalle1.IdProveedor = ((long)(0));
            this.ucPedidoDetalle1.IdUnidad = 0;
            this.ucPedidoDetalle1.Importe = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucPedidoDetalle1.Location = new System.Drawing.Point(14, 671);
            this.ucPedidoDetalle1.Name = "ucPedidoDetalle1";
            this.ucPedidoDetalle1.Notas = "";
            this.ucPedidoDetalle1.Precio = new decimal(new int[] {
            4000,
            0,
            0,
            131072});
            this.ucPedidoDetalle1.Size = new System.Drawing.Size(1280, 74);
            this.ucPedidoDetalle1.TabIndex = 90;
            // 
            // FrmPedidoDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 771);
            this.Controls.Add(this.ucPedido1);
            this.Controls.Add(this.ucPedidoDetalle1);
            this.Controls.Add(this.tsb);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmPedidoDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de Pedido";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tsb.ResumeLayout(false);
            this.tsb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ToolStrip tsb;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox tsbSearchTextBox;
        private System.Windows.Forms.ToolStripButton tsbSearchClearAndPerform;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripButton tsbSearchPerform;
        private UcPedidoDetalle ucPedidoDetalle1;
        private UcPedido ucPedido1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip cms;
    }
}

