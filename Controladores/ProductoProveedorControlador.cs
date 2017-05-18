﻿using System;
using System.Collections.Generic;

using Data;
using Model;

namespace Controlador
{
    public class ProductoProveedorControlador
    {
        public static List<ProductoProveedor> GetAll()
        {
            return ProductoProveedorData.GetAll();
        }

        public static List<ProductoProveedorView> GetGrid_GetByIdProveedor(int idProveedor)
        {
            return ProductoProveedorData.GetGrid_GetByIdProveedor(idProveedor);
        }
        

        public static ProductoProveedor GetByPrimaryKey(long idProductoProveedor)
        {
            return ProductoProveedorData.GetByPrimaryKey(idProductoProveedor);
        }


        public static List<ProductoProveedor> SearchByParameters(string nombre)
        {
            return ProductoProveedorData.SearchByParameters(nombre);

        }

        
        public static long Insert(ProductoProveedor c)
        {
            long idProductoProveedor = ProductoProveedorData.Insert(c);
            return idProductoProveedor;
        }


        public static List<ProductoProveedor> GetAll_GetByDescripcion(string searchText)
        {
            return ProductoProveedorData.SearchByParameters(searchText);
        }

        public static ProductoProveedorView GetByPrimaryKeyView(long idProductoProveedor)
        {
            return ProductoProveedorData.GetByPrimaryKeyView(idProductoProveedor);
        }

        public static long Update(ProductoProveedor m)
        {
            return ProductoProveedorData.Update(m);
        }

        public static bool Delete(ProductoProveedor m)
        {
            return ProductoProveedorData.Delete(m);
        }

        public static List<ProductoProveedorView> GetGrid()
        {
            return ProductoProveedorData.GetGrid();
        }

        public static List<ProductoProveedorView> GetGrid_GetByDescripcion(string searchText)
        {
            return ProductoProveedorData.GetGrid_GetByParameters(searchText);
        }
    }
}

