using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlador;
using Model;

namespace Heimdall
{
    public static class Security
    {
        /// <summary>
        /// Funcion de validacion de usuarios. Se encarga del proceso en forma transparente.
        /// Deberia tirar excepciones en caso de no poder conectarse, por ejemplo.
        /// </summary>
        /// <returns>True / False segun si encontro y valido al usuario bien.</returns>
        public static bool ValidarUsuario(Usuario u)
        {
            var v = UsuarioControlador.GetByUsr(u);
            if (v.Usr == null) return false;
            return v.Usr.Equals(u.Usr) && v.Pwd.ToLower().Equals(u.Pwd.ToLower());
        }

        public static bool EsAdmin(Usuario u)
        {
            var v = UsuarioControlador.GetByUsr(u);
            if (v.Usr == null)
                return false;
            return (v.IdClaseUsuario == 1);
        }

    }
}
