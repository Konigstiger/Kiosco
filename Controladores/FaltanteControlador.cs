using System;
using System.Collections.Generic;

using Data;
using Model;
using Model.View;

namespace Controlador
{
    public class FaltanteControlador
    {
        public static List<FaltanteView> GetAll()
        {
            return FaltanteData.GetAll();
        }

        public static Faltante GetByPrimaryKey(long idFaltante)
        {
            return FaltanteData.GetByPrimaryKey(idFaltante);
        }

        
        public static long Insert(Faltante c)
        {
            var idFaltante = FaltanteData.Insert(c);
            return idFaltante;
        }
        

        public static bool Delete(Faltante c)
        {
            return FaltanteData.Delete(c);
        }

        public static void Update(Faltante c)
        {
            FaltanteData.Update(c);
        }


        public static FaltanteView GetByPrimaryKeyView(long idFaltante)
        {
            return FaltanteData.GetByPrimaryKeyView(idFaltante);
        }
    }
}

