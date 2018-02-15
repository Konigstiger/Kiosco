using System;
using System.Collections.Generic;

using Data;
using Model;
using Model.View;

namespace Controlador
{
    public class MarcaControlador
    {
        public static List<MarcaView> GetAll()
        {
            return MarcaData.GetAll();
        }

        public static Marca GetByPrimaryKey(int idMarca)
        {
            return MarcaData.GetByPrimaryKey(idMarca);
        }


        public static List<MarcaView> SearchByParameters(string nombre)
        {
            return MarcaData.SearchByParameters(nombre);

        }

        
        public static int Insert(Marca c)
        {
            int idMarca = MarcaData.Insert(c);
            return idMarca;
        }


        public static List<MarcaView> GetAll_GetByDescripcion(string searchText)
        {
            return MarcaData.SearchByParameters(searchText);
        }

        public static MarcaView GetByPrimaryKeyView(int idMarca)
        {
            return MarcaData.GetByPrimaryKeyView(idMarca);
        }

        public static int Update(Marca m)
        {
            return MarcaData.Update(m);
        }

        public static bool Delete(Marca m)
        {
            return MarcaData.Delete(m);
        }
    }
}

