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
    public delegate void PromocionChangedEventHandler(object sender, ValueChangedEventArgs e);
    public delegate void ProductoPromocionChangedEventHandler(object sender, ValueChangedEventArgs e);
    public delegate void TareaChangedEventHandler(object sender, ValueChangedEventArgs e);
    public delegate void FaltanteChangedEventHandler(object sender, ValueChangedEventArgs e);
    public delegate void GastoChangedEventHandler(object sender, ValueChangedEventArgs e);

    //evento para notificar el cambio de validez del estado de un modelo
    public delegate void ModelStateChangedEventHandler(object sender, ValueChangedEventArgs e);


    //test
    public delegate void AddActionEventHandler(object sender, EventArgs e);
    public delegate void UpdateActionEventHandler(object sender, EventArgs e);
    public delegate void RemoveActionEventHandler(object sender, EventArgs e);
}
