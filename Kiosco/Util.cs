using System;
using System.Windows.Forms;

namespace Heimdall
{
    public static class Util
    {
        public static void CheckDateNullable(DateTime? d, DateTimePicker ctrl)
        {
            if (d == null || d == DateTime.MinValue) {
                ctrl.Checked = false;
                ctrl.Value = DateTime.Today;
            } else {
                ctrl.Checked = true;
                ctrl.Value = (DateTime)d;
            }
        }

        public static void CenterFormX(Control ctrl, Form form)
        {
            ctrl.Left = (form.ClientSize.Width - ctrl.Width) / 2;
        }


        public static void SetNumericBounds(NumericUpDown nud)
        {
            nud.Minimum = 0;
            nud.Maximum = 9999;
            nud.Increment = Convert.ToDecimal("0,25");
        }


        public static bool ConfirmarEliminar()
        {
            var confirmResult = MessageBox.Show("¿Está seguro que desea eliminar este registro?",
                                     "Confirmar Eliminar",
                                     MessageBoxButtons.YesNo);

            return confirmResult == DialogResult.Yes;
        }

        public static bool ConfirmarLimpiarPedido()
        {
            var confirmResult = MessageBox.Show("Proveedor Cambiado. Se eliminarán los productos ingresados. ¿Está seguro?",
                                     "Confirmar Eliminar",
                                     MessageBoxButtons.YesNo);

            return confirmResult == DialogResult.Yes;
        }


        public static void SetColumnsReadOnly(DataGridView dgv)
        {
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.ReadOnly = true;
            }
        }


        public static void SetColumn(DataGridViewColumn column, string propertyName, string headerText, int displayIndex)
        {
            column.DataPropertyName = propertyName;
            column.HeaderText = headerText;
            column.DisplayIndex = displayIndex;
        }


        public static void ReordenarNumeros(DataGridView dgv)
        {
            var i = 1;

            foreach (DataGridViewRow item in dgv.Rows)
            {
                item.Cells[0].Value = i;
                i++;
            }
        }



    }
}
