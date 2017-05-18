using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Kiosco
{
    internal interface IPedidoDetalle
    {
        int Cantidad { get; set; }

        string CodigoBarras { get; set; }

        string Descripcion { get; set; }

        decimal Importe { get; set; }

        decimal Precio { get; set; }

/*
        // communication/ messaging

        /// <summary>
        /// StatusChange is a simple message that the view can choose to ignore.
        /// I simply print the message to a label on the form (which could also help with debugging). 
        /// </summary>
        string StatusChange { set; }

        /// <summary>
        /// isDirty can be changed by either the presenter or view.The presenter changes it to true when a task has just been saved, or a different one loaded.
        /// The view changes it to false as soon as one of the control's-values has been changed.
        /// </summary>
        bool IsDirty { get; set; }

        event EventHandler<EventArgs> Save;
        event EventHandler<EventArgs> New;
        event EventHandler<EventArgs> Prev;
        event EventHandler<EventArgs> Next;
*/
    }
}
