using System;
using System.Collections.Generic;

using Data;
using Model;
using Model.View;

namespace Controlador
{
    public class RubroControlador
    {
        public static List<RubroView> GetAll()
        {
            return RubroData.GetAll();
        }

        public static Rubro GetByPrimaryKey(int idRubro)
        {
            return RubroData.GetByPrimaryKey(idRubro);
        }

        
        public static int Insert(Rubro c)
        {
            var idRubro = RubroData.Insert(c);
            return idRubro;
        }
        

        public static bool Delete(Rubro c)
        {
            return RubroData.Delete(c);
        }

        public static void Update(Rubro c)
        {
            RubroData.Update(c);
        }
        

    }
}

