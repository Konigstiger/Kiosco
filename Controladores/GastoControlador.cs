using System;
using System.Collections.Generic;

using Data;
using Model;
using Model.View;

namespace Controlador
{
    public class GastoControlador
    {
        public static List<GastoView> GetAll()
        {
            return GastoData.GetAll();
        }

        public static Gasto GetByPrimaryKey(long idGasto)
        {
            return GastoData.GetByPrimaryKey(idGasto);
        }

        
        public static long Insert(Gasto c)
        {
            var idGasto = GastoData.Insert(c);
            return idGasto;
        }
        

        public static bool Delete(Gasto c)
        {
            return GastoData.Delete(c);
        }

        public static void Update(Gasto c)
        {
            GastoData.Update(c);
        }


        public static GastoView GetByPrimaryKeyView(long idGasto)
        {
            return GastoData.GetByPrimaryKeyView(idGasto);
        }

    }
}

