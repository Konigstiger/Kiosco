﻿using System;
using System.Collections.Generic;

using Data;
using Model;
using Model.View;

namespace Controlador
{
    public class UsuarioControlador
    {
        public static List<UsuarioView> GetAll()
        {
            return UsuarioData.GetAll();
        }

        public static List<UsuarioView> GetAll_ByUsr()
        {
            return UsuarioData.GetAll_ByUsr();
        }


        public static Usuario GetByPrimaryKey(Usuario u)
        {
            return UsuarioData.GetByPrimaryKey(u);
        }

        public static Usuario GetByUsr(Usuario u)
        {
            return UsuarioData.GetByUsr(u);
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


        public static UsuarioView GetByPrimaryKeyView(Usuario c)
        {
            return UsuarioData.GetByPrimaryKeyView(c);
        }
    }
}

