using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Model;
using Model.View;

namespace Controlador
{
    public class ProductoControlador
    {
        public static string GetText(List<Producto> list)
        {
            var sb = new StringBuilder();
            foreach (var s in list) {
                sb.Append(s.Descripcion);
                sb.Append("\n");
            }

            return sb.ToString();
        }


        public static string GetText(List<ProductoView> list)
        {
            var sb = new StringBuilder();
            foreach (var s in list) {
                sb.Append(s.Descripcion);
                sb.Append("\n");
            }

            return sb.ToString();
        }

        public static List<ProductoView> GetAllView()
        {
            return ProductoData.GetAllView();
        }

        public static List<Producto> GetAll()
        {
            return ProductoData.GetAll();
        }

        public static List<Producto> GetAll_AutoComplete()
        {
            return ProductoData.GetAll_AutoComplete();
        }


        public static Producto GetByPrimaryKey(long id)
        {
            return ProductoData.GetByPrimaryKey(id);
        }

        public static int GetCantidadProducto_ByRubro(int idRubro)
        {
            return ProductoData.GetCantidadProducto_ByRubro(idRubro);
        }

        public static ProductoView GetByPrimaryKeyView(long id)
        {
            return ProductoData.GetByPrimaryKeyView(id);
        }


        public static Producto GetByCodigoBarras(string codigo)
        {
            return ProductoData.GetByCodigoBarras(codigo);
        }

        public static ProductoView GetByCodigoBarrasView(string codigo)
        {
            return ProductoData.GetByCodigoBarrasView(codigo);
        }


        public static List<ProductoView> GetAllByDeposito_GetByPrimaryKey(long idProducto, int idDeposito)
        {
            return ProductoData.GetAllByDepositoGetByPrimaryKey(idProducto, idDeposito);
        }


        public static List<ProductoView> GetAllByDeposito_GetAll(int idDeposito, bool modoArchivo)
        {
            return ProductoData.GetAllByDeposito(idDeposito, modoArchivo);
        }


        public static List<ProductoView> GetAllByDeposito_GetByDescripcion(int idDeposito, string descripcion, bool modoArchivo)
        {
            return ProductoData.GetAllByDeposito_GetByDescripcion(idDeposito, descripcion, modoArchivo);
        }


        public static long Insert(Producto p)
        {
            var idProducto = ProductoData.Insert(p);

            //TODO: Finalmente una oportunidad de aprovechar bien a la capa de controladores:
            //Validar, si existe un registro de Stock para este IdProducto, IdDeposito 1.
            //Se supone que si se inserta, deberia NO existir.
            //en caso de no existir, crearlo al registro de Stock. Su numero no es importante.

            return idProducto;
        }


        public static bool Delete(Producto p)
        {
            return ProductoData.Delete(p);
        }


        public static long Update(Producto p)
        {
            return ProductoData.Update(p);
        }

        public static bool CambiarEstadoArchivo(long idProducto, bool archivar)
        {
            return ProductoData.CambiarEstadoArchivo(idProducto, archivar);
        }


    }
}