using System;
using System.Windows.Forms;

namespace Kiosco
{
    public class Util
    {
        public static void CenterFormX(Control ctrl, Form form)
        {
            ctrl.Left = (form.ClientSize.Width - ctrl.Width) / 2;
        }


        public static bool ConfirmarEliminar()
        {
            var confirmResult = MessageBox.Show("¿Está seguro que desea eliminar este registro?",
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
