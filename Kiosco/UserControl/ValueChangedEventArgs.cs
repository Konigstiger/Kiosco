using System;

namespace Heimdall.UserControl
{
    public class ValueChangedEventArgs : EventArgs
    {
        public long NewValue { get; set; }

        public ValueChangedEventArgs(long newValue)
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

    public delegate void ProductoChangedEventHandler(object sender, ValueChangedEventArgs e);
    public delegate void TareaChangedEventHandler(object sender, ValueChangedEventArgs e);


    //test
    public delegate void AddActionEventHandler(object sender, EventArgs e);
    public delegate void UpdateActionEventHandler(object sender, EventArgs e);
    public delegate void RemoveActionEventHandler(object sender, EventArgs e);
}
