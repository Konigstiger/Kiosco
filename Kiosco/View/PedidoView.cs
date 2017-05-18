using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace Kiosco.View
{
    public partial class PedidoView : Form, IPedidoView
    {
        public event Action PedidoSelected;
        public event Action Closed;

        public PedidoView()
        {
            InitializeComponent();
            BindComponent();
        }

        private void BindComponent()
        {
            this.closeButton.Click += OnCloseButtonClick;

            this.listBox.DisplayMember = "Fecha";
            this.listBox.SelectedIndexChanged += OnPedidoListBoxSelectedIndexChanged;
        }


        private void OnCloseButtonClick(object sender, EventArgs e)
        {
            if (this.Closed != null) {
                this.Closed();
            }
        }

        private void OnPedidoListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.PedidoSelected != null) {
                this.PedidoSelected();
            }
        }


        public IList<Pedido> Pedidos
        {
            get { return this.listBox.DataSource as IList<Pedido>; }
        }

        public Pedido SelectedPedido
        {
            get { return listBox.SelectedItem as Pedido; }
        }


        event Action IPedidoView.Closed
        {
            add {
                throw new NotImplementedException();
            }

            remove {
                throw new NotImplementedException();
            }
        }

        public void LoadPedido(Pedido pedido)
        {
            //throw new NotImplementedException();

            //Fecha, Total

            //dtpFecha.Value = pedido.Fecha;
            nudTotal.Value = pedido.Total;
            /*
             IdPedido
             IdProveedor
             Fecha
             FechaEntrega
             HoraEntrega
             Total
             */
        }

        public void LoadPedidos(IList<Pedido> pedidos)
        {
            listBox.DataSource = pedidos;
            //this.clientsListBox.DataSource = clients;
        }
    }
}
