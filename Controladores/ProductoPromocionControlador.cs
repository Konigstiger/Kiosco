using System;
using System.Collections.Generic;

using Data;
using Model;
using Model.View;

namespace Controlador
{
    public class ProductoPromocionControlador
    {
        public static List<ProductoPromocion> GetAll()
        {
            return ProductoPromocionData.GetAll();
        }

        public static List<ProductoPromocionView> GetGrid_GetByIdPromocion(int idPromocion, string descripcion)
        {
            return ProductoPromocionData.GetGrid_GetByIdPromocion(idPromocion, descripcion);
        }

        public static List<ProductoPromocionView> GetGrid_GetByIdPromocion(long idProducto)
        {
            return ProductoPromocionData.GetGrid_GetByIdPromocion(idProducto);
        }

        public static ProductoPromocion GetByPrimaryKey(long idProductoPromocion)
        {
            return ProductoPromocionData.GetByPrimaryKey(idProductoPromocion);
        }


        public static List<ProductoPromocion> SearchByParameters(string nombre)
        {
            return ProductoPromocionData.SearchByParameters(nombre);

        }

        
        public static long Insert(ProductoPromocion c)
        {
            long idProductoPromocion = ProductoPromocionData.Insert(c);
            return idProductoPromocion;
        }


        public static List<ProductoPromocion> GetAll_GetByDescripcion(string searchText)
        {
            return ProductoPromocionData.SearchByParameters(searchText);
        }

        public static ProductoPromocionView GetByPrimaryKeyView(long idProductoPromocion)
        {
            return ProductoPromocionData.GetByPrimaryKeyView(idProductoPromocion);
        }

        public static long Update(ProductoPromocion m)
        {
            return ProductoPromocionData.Update(m);
        }

        public static bool Delete(ProductoPromocion m)
        {
            return ProductoPromocionData.Delete(m);
        }

        public static List<ProductoPromocionView> GetGrid()
        {
            return ProductoPromocionData.GetGrid();
        }

        public static List<ProductoPromocionView> GetGrid_GetByDescripcion(int idPromocion, string searchText)
        {
            return ProductoPromocionData.GetGrid_GetByIdPromocion(idPromocion, searchText);
        }
    }
}

