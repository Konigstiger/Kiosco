﻿using System;

namespace Model
{
    public class ProductoProveedorView: IEntidad
    {
        //TODO: Completar esta clase, pensada para actuar con una Vista SP
        public long IdProductoProveedor { get; set; }
        public string Proveedor { get; set; }
        public string Producto { get; set; }
        public decimal PrecioProveedor { get; set; }
        public decimal PrecioVenta { get; set; }
        public int IdUnidad { get; set; }
        public string Notas { get; set; }

        public bool Validate()
        {
            return true;
        }

        public enum GridColumn
        {
            IdProductoProveedor = 0,
            Producto = 1,
            Proveedor = 2,
            PrecioProveedor = 3,
            PrecioVenta = 4
        }

    }
}
