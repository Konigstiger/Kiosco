using System;
using System.Collections.Generic;

using Data;
using Model;
using Model.View;

namespace Controlador
{
    public class ClaseUsuarioControlador
    {
        public static List<ClaseUsuarioView> GetAll()
        {
            return ClaseUsuarioData.GetAll();
        }

        public static ClaseUsuario GetByPrimaryKey(int idClaseUsuario)
        {
            return ClaseUsuarioData.GetByPrimaryKey(idClaseUsuario);
        }

        
        public static int Insert(ClaseUsuario c)
        {
            var idClaseUsuario = ClaseUsuarioData.Insert(c);
            return idClaseUsuario;
        }

        /*

        public static bool Delete(ClaseUsuario c)
        {
            return ClaseUsuarioData.Delete(c);
        }

        public static void Update(ClaseUsuario c)
        {
            ClaseUsuarioData.Update(c);
        }
        */

    }
}

