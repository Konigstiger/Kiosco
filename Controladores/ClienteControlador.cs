using System.Collections.Generic;
using Data;
using Model;
using Model.View;

namespace Controlador
{
    public class ClienteControlador
    {
        public static List<ClienteView> GetAll()
        {
            return ClienteData.GetAll();
        }

        public static Cliente GetByPrimaryKey(long id)
        {
            return ClienteData.GetByPrimaryKey(id);
        }


        public static List<ClienteView> GetAll_GetByDescripcion(string descripcion)
        {
            return ClienteData.GetAll_GetByDescripcion(descripcion);
        }


    }
}