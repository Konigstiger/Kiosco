using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace Data
{
    public class ProductoProveedorData
    {
        public static List<ProductoProveedor> GetAll()
        {
            var list = new List<ProductoProveedor>();
            var conn = new SqlConnection(GeneralData.CadenaConexion);
            SqlDataReader rdr = null;

            var cmd = new SqlCommand("ProductoProveedor_GetAll", conn) { CommandType = CommandType.StoredProcedure };

            try {
                conn.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    var p = new ProductoProveedor {
                        IdProductoProveedor = (long)rdr["IdProductoProveedor"],
                        IdProveedor = (int)rdr["IdProveedor"],
                        IdProducto = (long)rdr["IdProducto"],
                        PrecioProveedor = (decimal)rdr["PrecioProveedor"],
                        IdUnidad = rdr["IdUnidad"] != DBNull.Value ? (int)rdr["IdUnidad"] : 0,
                        Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : ""
                    };

                    list.Add(p);
                }
            }
            finally {
                rdr?.Close();
                conn.Close();
            }
            return list;
        }


        public static List<ProductoProveedorView> GetGrid()
        {
            var list = new List<ProductoProveedorView>();
            var conn = new SqlConnection(GeneralData.CadenaConexion);
            SqlDataReader rdr = null;

            var cmd = new SqlCommand("ProductoProveedor_GetGrid", conn) { CommandType = CommandType.StoredProcedure };
            //[ProductoProveedor_GetByIdProveedor]
            try {
                conn.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    var p = new ProductoProveedorView {
                        IdProductoProveedor = (long)rdr["IdProductoProveedor"],
                        Proveedor = (string)rdr["Proveedor"],
                        Producto = (string)rdr["Producto"],
                        PrecioProveedor = (decimal)rdr["PrecioProveedor"],
                        PrecioVenta = (decimal)rdr["PrecioVenta"]//,
                        //IdUnidad = rdr["IdUnidad"] != DBNull.Value ? (int)rdr["IdUnidad"] : 0
                    };

                    list.Add(p);
                }
            }
            finally {
                rdr?.Close();
                conn.Close();
            }
            return list;
        }


        public static List<ProductoProveedor> SearchByParameters(string descripcion)
        {
            var list = new List<ProductoProveedor>();
            var conn = new SqlConnection(GeneralData.CadenaConexion);

            SqlDataReader rdr = null;

            var cmd = new SqlCommand("ProductoProveedor_GetByParameters", conn) { CommandType = CommandType.StoredProcedure };

            var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = descripcion };

            cmd.Parameters.Add(p1);

            try {
                conn.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    var p = new ProductoProveedor {
                        IdProductoProveedor = (long)rdr["IdProductoProveedor"],
                        IdProveedor = (int)rdr["IdProveedor"],
                        IdProducto = (long)rdr["IdProducto"],
                        PrecioProveedor = (decimal)rdr["PrecioProveedor"],
                        IdUnidad = rdr["IdUnidad"] != DBNull.Value ? (int)rdr["IdUnidad"] : 0,
                        Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : ""
                    };

                    list.Add(p);
                }
            }
            finally {
                rdr?.Close();
                conn.Close();
            }

            return list;
        }


        public static long Insert(ProductoProveedor m)
        {
            var conn = new SqlConnection(GeneralData.CadenaConexion);
            var cmd = new SqlCommand("ProductoProveedor_Insert", conn) { CommandType = CommandType.StoredProcedure };

            //var p0 = new SqlParameter("IdProductoProveedor", SqlDbType.BigInt ) {Direction = ParameterDirection.Output};
            var p1 = new SqlParameter("IdProveedor", SqlDbType.Int) { Value = m.IdProveedor };
            var p2 = new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = m.IdProducto };
            var p3 = new SqlParameter("PrecioProveedor", SqlDbType.Decimal) { Value = m.PrecioProveedor };
            var p4 = new SqlParameter("IdUnidad", SqlDbType.Decimal) { Value = m.IdUnidad };
            var p5 = new SqlParameter("Notas", SqlDbType.VarChar) { Value = m.Notas };

            //cmd.Parameters.Add(p0);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);

            try {
                conn.Open();

                m.IdProductoProveedor = (long)cmd.ExecuteScalar();
            }
            finally {
                conn.Close();
            }

            return m.IdProductoProveedor;
        }


        public static ProductoProveedor GetByPrimaryKey(long idProductoProveedor)
        {
            var c = new ProductoProveedor();
            var conn = new SqlConnection(GeneralData.CadenaConexion);
            SqlDataReader rdr = null;
            var cmd = new SqlCommand("ProductoProveedor_GetByPrimaryKey", conn) { CommandType = CommandType.StoredProcedure };

            var p1 = new SqlParameter("IdProductoProveedor", SqlDbType.BigInt) { Value = idProductoProveedor };
            cmd.Parameters.Add(p1);

            try {
                conn.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    c.IdProductoProveedor = (long)rdr["IdProductoProveedor"];
                    c.IdProveedor = (int)rdr["IdProveedor"];
                    c.IdProducto = (long)rdr["IdProducto"];
                    c.PrecioProveedor = (decimal)rdr["PrecioProveedor"];
                    c.IdUnidad = rdr["IdUnidad"] != DBNull.Value ? (int)rdr["IdUnidad"] : 0;
                    c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";

                }
            }
            finally {
                rdr?.Close();
                conn.Close();
            }

            return c;
        }


        public static ProductoProveedorView GetByPrimaryKeyView(long idProductoProveedor)
        {
            var c = new ProductoProveedorView();
            var conn = new SqlConnection(GeneralData.CadenaConexion);
            SqlDataReader rdr = null;
            var cmd = new SqlCommand("ProductoProveedorView_GetByPrimaryKey", conn) { CommandType = CommandType.StoredProcedure };

            var p1 = new SqlParameter("IdProductoProveedor", SqlDbType.Int) { Value = idProductoProveedor };
            cmd.Parameters.Add(p1);

            try {
                conn.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    c.IdProductoProveedor = (long)rdr["IdProductoProveedor"];
                    c.Proveedor = (string)rdr["Proveedor"];
                    c.Producto = (string)rdr["Producto"];
                    c.PrecioProveedor = (decimal)rdr["PrecioProveedor"];
                    c.IdUnidad = rdr["IdUnidad"] != DBNull.Value ? (int)rdr["IdUnidad"] : 0;
                    c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                }

            }
            finally {
                rdr?.Close();
                conn.Close();
            }

            return c;
        }

        public static long Update(ProductoProveedor m)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("ProductoProveedor_Update", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdProductoProveedor", SqlDbType.BigInt) { Value = m.IdProductoProveedor };
                    var p1 = new SqlParameter("IdProveedor", SqlDbType.Int) { Value = m.IdProveedor };
                    var p2 = new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = m.IdProducto };
                    var p3 = new SqlParameter("PrecioProveedor", SqlDbType.Decimal) { Value = m.PrecioProveedor };
                    var p4 = new SqlParameter("IdUnidad", SqlDbType.Decimal) { Value = m.IdUnidad };
                    var p5 = new SqlParameter("Notas", SqlDbType.VarChar) { Value = m.Notas };

                    cmd.Parameters.Add(p0);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);
                    cmd.Parameters.Add(p4);
                    cmd.Parameters.Add(p5);

                    if (conn.State != ConnectionState.Open)
                        conn.Open();
                    m.IdProductoProveedor = (long)cmd.ExecuteScalar();
                }
            }
            return m.IdProductoProveedor;
        }


        public static bool Delete(ProductoProveedor model)
        {
            var conn = new SqlConnection(GeneralData.CadenaConexion);

            var cmd = new SqlCommand("ProductoProveedor_Delete", conn) { CommandType = CommandType.StoredProcedure };

            var p0 = new SqlParameter("IdProductoProveedor", SqlDbType.BigInt) { Value = model.IdProductoProveedor };

            cmd.Parameters.Add(p0);

            try {
                conn.Open();
                model.IdProductoProveedor = (int)cmd.ExecuteScalar();
                return true;
            }
            catch {
                return false;
            }
            finally {
                conn.Close();
            }
        }

        public static List<ProductoProveedorView> GetGrid_GetByParameters(string searchText)
        {
            throw new NotImplementedException();
        }


        public static List<ProductoProveedorView> GetGrid_GetByIdProveedor(int idProveedor, string descripcion)
        {
            var list = new List<ProductoProveedorView>();
            var conn = new SqlConnection(GeneralData.CadenaConexion);
            SqlDataReader rdr = null;

            var cmd = new SqlCommand("ProductoProveedor_GetAll_GetByIdProveedor", conn) { CommandType = CommandType.StoredProcedure };

            var p0 = new SqlParameter("IdProveedor", SqlDbType.Int) { Value = idProveedor };
            var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = descripcion };

            cmd.Parameters.Add(p0);
            cmd.Parameters.Add(p1);

            try {
                conn.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    var p = new ProductoProveedorView {
                        IdProductoProveedor = (long)rdr["IdProductoProveedor"],
                        IdProducto = (long)rdr["IdProducto"],
                        Producto = (string)rdr["Producto"],
                        Proveedor = (string)rdr["Proveedor"],
                        PrecioProveedor = (decimal)rdr["PrecioProveedor"],
                        PrecioVenta = (decimal)rdr["PrecioVenta"]
                    };

                    list.Add(p);
                }
            }
            finally {
                rdr?.Close();
                conn.Close();
            }
            return list;
        }

    }
}