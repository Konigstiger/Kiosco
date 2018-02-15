using System;
using System.Collections.Generic;

using Data;
using Model;
using Model.View;

namespace Controlador
{
    public class StockControlador
    {
        public static List<StockView> GetAll()
        {
            return StockData.GetAll();
        }

        public static StockView GetByPrimaryKey(int idStock)
        {
            return StockData.GetByPrimaryKey(idStock);
        }

       
        public static long Insert(Stock c)
        {
            var idStock = StockData.Insert(c);
            return idStock;
        }

        /*

        public static bool Delete(Stock c)
        {
            return StockData.Delete(c);
        }
        */

        public static long Update(Stock c)
        {
            return StockData.Update(c);
        }

        public static long UpdateDelta(Stock c)
        {
            return StockData.UpdateDelta(c);
        }

        public static Stock GetByParameters(Stock producto)
        {
            return StockData.GetByParameters(producto);
        }

        public static bool Delete(Stock stock)
        {
            return StockData.Delete(stock);
        }
    }
}

