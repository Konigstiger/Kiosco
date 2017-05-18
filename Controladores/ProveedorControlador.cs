using System.Collections.Generic;
using Data;
using Model;

namespace Controlador
{
    public class ProveedorControlador
    {
        public static List<ProveedorView> GetAll()
        {
            return ProveedorData.GetAll();
        }

        public static Proveedor GetByPrimaryKey(long id)
        {
            return ProveedorData.GetByPrimaryKey(id);
        }


        public static List<ProveedorView> GetAll_GetByDescripcion(string razonSocial)
        {
            return ProveedorData.GetAll_GetByRazonSocial(razonSocial);
        }


        public static int Insert(Proveedor proveedor)
        {
            return ProveedorData.Insert(proveedor);
        }

        public static ProveedorView GetByPrimaryKeyView(int id)
        {
            return ProveedorData.GetByPrimaryKeyView(id);
        }

        public static bool Delete(Proveedor p)
        {
            return ProveedorData.Delete(p);
        }


        public static int Update(Proveedor p)
        {
            return ProveedorData.Update(p);
        }
    }
}