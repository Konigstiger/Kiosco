using System;
using System.Collections.Generic;

using Data;
using Model;
using Model.View;

namespace Controlador
{
    public class EstadoUsuarioControlador
    {
        public static List<EstadoUsuarioView> GetAll()
        {
            return EstadoUsuarioData.GetAll();
        }

        public static EstadoUsuario GetByPrimaryKey(int idEstadoUsuario)
        {
            return EstadoUsuarioData.GetByPrimaryKey(idEstadoUsuario);
        }


        
        public static int Insert(EstadoUsuario c)
        {
            var idEstadoUsuario = EstadoUsuarioData.Insert(c);
            return idEstadoUsuario;
        }

        /*

        public static bool Delete(EstadoUsuario c)
        {
            return EstadoUsuarioData.Delete(c);
        }

        public static void Update(EstadoUsuario c)
        {
            EstadoUsuarioData.Update(c);
        }
        */

    }
}

