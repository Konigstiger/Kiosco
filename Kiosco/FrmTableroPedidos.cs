using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Calendar;
using Controlador;
using Model;
using Model.View;
using CalendarItem = System.Windows.Forms.Calendar;

namespace Heimdall
{
    public partial class FrmTableroPedidos : Form
    {
        List<CalendarItem.CalendarItem> _items = new List<CalendarItem.CalendarItem>();
        CalendarItem.CalendarItem contextItem = null;

        public FrmTableroPedidos()
        {
            InitializeComponent();
        }

        private void SetupForm()
        {
            //Monthview colors
            monthView1.MonthTitleColor = monthView1.MonthTitleColorInactive = CalendarColorTable.FromHex("#C2DAFC");
            monthView1.ArrowsColor = CalendarColorTable.FromHex("#77A1D3");
            monthView1.DaySelectedBackgroundColor = CalendarColorTable.FromHex("#F4CC52");
            monthView1.DaySelectedTextColor = monthView1.ForeColor;
        }

        private void FrmTableroPedidos_Load(object sender, EventArgs e)
        {
            List<ItemInfo> lst = new List<ItemInfo>();
            /**/
            var origenDatos = PedidoControlador.GetAll_GetByParameters("", true);
            var source = new List<PedidoView>(origenDatos);
            /**/

            foreach (var p in source)
            {
                var ii = new ItemInfo();
                ii.Text = p.Descripcion;
                ii.StartTime = p.Fecha;
                ii.EndTime = p.FechaEntrega;
                
                lst.Add(ii);
            }


            foreach (ItemInfo item in lst) {
                CalendarItem.CalendarItem cal = new CalendarItem.CalendarItem(calendar1, item.StartTime, item.EndTime, item.Text);

                if (!(item.R == 0 && item.G == 0 && item.B == 0)) {
                    cal.ApplyColor(Color.FromArgb(item.A, item.R, item.G, item.B));
                }

                _items.Add(cal);
            }

            PlaceItems();
        }


        private void PlaceItems()
        {
            foreach (CalendarItem.CalendarItem item in _items) {
                if (calendar1.ViewIntersects(item)) {
                    calendar1.Items.Add(item);
                }
            }
        }

        private void monthView1_SelectionChanged(object sender, EventArgs e)
        {
            calendar1.SetViewRange(monthView1.SelectionStart, monthView1.SelectionEnd);
        }

        private void calendar1_DayHeaderClick(object sender, CalendarDayEventArgs e)
        {
            calendar1.SetViewRange(e.CalendarDay.Date, e.CalendarDay.Date);
        }

        private void calendar1_LoadItems(object sender, CalendarLoadEventArgs e)
        {
            PlaceItems();
        }

        private void calendar1_ItemCreated(object sender, CalendarItemCancelEventArgs e)
        {
            _items.Add(e.Item);
        }

        private void calendar1_ItemMouseHover(object sender, CalendarItemEventArgs e)
        {
            Text = e.Item.Text;
        }

        private void calendar1_ItemClick(object sender, CalendarItemEventArgs e)
        {
            //MessageBox.Show(e.Item.Text);
        }

        private void hourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calendar1.TimeScale = CalendarTimeScale.SixtyMinutes;
        }

        private void minutesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calendar1.TimeScale = CalendarTimeScale.ThirtyMinutes;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            calendar1.TimeScale = CalendarTimeScale.FifteenMinutes;
        }

        private void minutesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            calendar1.TimeScale = CalendarTimeScale.SixMinutes;
        }

        private void minutesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            calendar1.TimeScale = CalendarTimeScale.TenMinutes;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            calendar1.TimeScale = CalendarTimeScale.FiveMinutes;
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            contextItem = calendar1.ItemAt(contextMenuStrip1.Bounds.Location);
        }

        private void redTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem.CalendarItem item in calendar1.GetSelectedItems()) {
                item.ApplyColor(Color.Red);
                calendar1.Invalidate(item);
            }
        }

        private void yellowTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem.CalendarItem item in calendar1.GetSelectedItems()) {
                item.ApplyColor(Color.Gold);
                calendar1.Invalidate(item);
            }
        }

        private void greenTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem.CalendarItem item in calendar1.GetSelectedItems()) {
                item.ApplyColor(Color.Green);
                calendar1.Invalidate(item);
            }
        }

        private void blueTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem.CalendarItem item in calendar1.GetSelectedItems()) {
                item.ApplyColor(Color.DarkBlue);
                calendar1.Invalidate(item);
            }
        }

        private void editItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calendar1.ActivateEditMode();
        }

        private void otherColorTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog()) {
                if (dlg.ShowDialog() == DialogResult.OK) {
                    foreach (CalendarItem.CalendarItem item in calendar1.GetSelectedItems()) {
                        item.ApplyColor(dlg.Color);
                        calendar1.Invalidate(item);
                    }
                }
            }
        }

        private void calendar1_ItemDoubleClick(object sender, CalendarItemEventArgs e)
        {
            MessageBox.Show(@"Double click: " + e.Item.Text);
        }

        private void calendar1_ItemDeleted(object sender, CalendarItemEventArgs e)
        {
            _items.Remove(e.Item);
        }
    }
}
