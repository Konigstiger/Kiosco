using System;
using System.Collections.Generic;

using Data;
using Model;
using Model.View;

namespace Controlador
{
    public class DificultadControlador
    {
        public static List<DificultadView> GetAll()
        {
            return DificultadData.GetAll();
        }

        public static Dificultad GetByPrimaryKey(int idDificultad)
        {
            return DificultadData.GetByPrimaryKey(idDificultad);
        }

        
        public static int Insert(Dificultad c)
        {
            var idDificultad = DificultadData.Insert(c);
            return idDificultad;
        }

        /*

        public static bool Delete(Dificultad c)
        {
            return DificultadData.Delete(c);
        }

        public static void Update(Dificultad c)
        {
            DificultadData.Update(c);
        }
        */

    }
}

