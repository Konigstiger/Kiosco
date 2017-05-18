using System;
using System.Collections.Generic;


namespace Kiosco.UserControl
{
    public class ValueChangedEventArgs : EventArgs
    {
        public int NewValue { get; set; }

        public ValueChangedEventArgs(int newValue)
        {
            NewValue = newValue;
        }
    }

    public delegate void ValueChangedEventHandler(object sender, ValueChangedEventArgs e);



    public class StockChangedEventArgs : EventArgs
    {
        public int NewStock { get; set; }

        public StockChangedEventArgs(int newStock)
        {
            NewStock = newStock;
        }
    }

    public delegate void StockChangedEventHandler(object sender, ValueChangedEventArgs e);
}
