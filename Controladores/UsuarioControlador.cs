using System;
using System.Collections.Generic;

using Data;
using Model;

namespace Controlador
{
    public class UsuarioControlador
    {
        public static List<UsuarioView> GetAll()
        {
            return UsuarioData.GetAll();
        }

        public static Usuario GetByPrimaryKey(int idUsuario)
        {
            return UsuarioData.GetByPrimaryKey(idUsuario);
        }


        
        public static int Insert(Usuario c)
        {
            var idUsuario = UsuarioData.Insert(c);
            return idUsuario;
        }


        public static bool Delete(Usuario c)
        {
            return UsuarioData.Delete(c);
        }
        

        public static void Update(Usuario c)
        {
            UsuarioData.Update(c);
        }
        

    }
}

