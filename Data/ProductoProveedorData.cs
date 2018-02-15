using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;
using Model.View;

namespace Data
{
    public class ProductoProveedorData
    {
        public static List<ProductoProveedor> GetAll()
        {
            var list = new List<ProductoProveedor>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("ProductoProveedor_GetAll", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new ProductoProveedor {
                                IdProductoProveedor = (long)rdr["IdProductoProveedor"],
                                IdProveedor = (int)rdr["IdProveedor"],
                                IdProducto = (long)rdr["IdProducto"],
                                PrecioProveedor = (decimal)rdr["PrecioProveedor"],
                                FechaModificacion = rdr["FechaModificacion"] != DBNull.Value ? (DateTime)rdr["FechaModificacion"] : DateTime.MinValue,
                                IdUnidad = rdr["IdUnidad"] != DBNull.Value ? (int)rdr["IdUnidad"] : 0,
                                Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : ""
                            };
                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }


        public static List<ProductoProveedorView> GetGrid()
        {
            var list = new List<ProductoProveedorView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("ProductoProveedor_GetGrid", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new ProductoProveedorView {
                                IdProductoProveedor = (long)rdr["IdProductoProveedor"],
                                Proveedor = (string)rdr["Proveedor"],
                                Producto = (string)rdr["Producto"],
                                PrecioProveedor = (decimal)rdr["PrecioProveedor"],
                                PrecioVenta = (decimal)rdr["PrecioVenta"],
                                FechaModificacion = rdr["FechaModificacion"] != DBNull.Value ? (DateTime)rdr["FechaModificacion"] : DateTime.MinValue
                            };
                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }


        public static List<ProductoProveedor> SearchByParameters(string descripcion)
        {
            var list = new List<ProductoProveedor>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("ProductoProveedor_GetByParameters", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;
                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = descripcion };

                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new ProductoProveedor {
                                IdProductoProveedor = (long)rdr["IdProductoProveedor"],
                                IdProveedor = (int)rdr["IdProveedor"],
                                IdProducto = (long)rdr["IdProducto"],
                                PrecioProveedor = (decimal)rdr["PrecioProveedor"],
                                FechaModificacion = rdr["FechaModificacion"] != DBNull.Value ? (DateTime)rdr["FechaModificacion"] : DateTime.MinValue,
                                IdUnidad = rdr["IdUnidad"] != DBNull.Value ? (int)rdr["IdUnidad"] : 0,
                                Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : ""
                            };
                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }


        public static long Insert(ProductoProveedor m)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("ProductoProveedor_Insert", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //var p0 = new SqlParameter("IdProductoProveedor", SqlDbType.BigInt ) {Direction = ParameterDirection.Output};
                    var p1 = new SqlParameter("IdProveedor", SqlDbType.Int) { Value = m.IdProveedor };
                    var p2 = new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = m.IdProducto };
                    var p3 = new SqlParameter("PrecioProveedor", SqlDbType.Decimal) { Value = m.PrecioProveedor };
                    var p4 = new SqlParameter("FechaModificacion", SqlDbType.Date) { Value = m.FechaModificacion };
                    var p5 = new SqlParameter("IdUnidad", SqlDbType.Decimal) { Value = m.IdUnidad };
                    var p6 = new SqlParameter("Notas", SqlDbType.VarChar) { Value = m.Notas };

                    //cmd.Parameters.Add(p0);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);
                    cmd.Parameters.Add(p4);
                    cmd.Parameters.Add(p5);
                    cmd.Parameters.Add(p6);

                    conn.Open();

                    m.IdProductoProveedor = (long)cmd.ExecuteScalar();
                }
            }
            return m.IdProductoProveedor;
        }



        public static ProductoProveedor GetByPrimaryKey(long idProductoProveedor)
        {
            var c = new ProductoProveedor();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("ProductoProveedor_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdProductoProveedor", SqlDbType.BigInt) { Value = idProductoProveedor };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {

                        while (rdr.Read()) {
                            c.IdProductoProveedor = (long)rdr["IdProductoProveedor"];
                            c.IdProveedor = (int)rdr["IdProveedor"];
                            c.IdProducto = (long)rdr["IdProducto"];
                            c.PrecioProveedor = (decimal)rdr["PrecioProveedor"];
                            c.FechaModificacion = rdr["FechaModificacion"] != DBNull.Value
                                ? (DateTime)rdr["FechaModificacion"]
                                : DateTime.MinValue;
                            c.IdUnidad = rdr["IdUnidad"] != DBNull.Value ? (int)rdr["IdUnidad"] : 0;
                            c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                        }
                    }
                }
            }
            return c;
        }


        public static ProductoProveedorView GetByPrimaryKeyView(long idProductoProveedor)
        {
            var c = new ProductoProveedorView();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("ProductoProveedorView_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdProductoProveedor", SqlDbType.Int) { Value = idProductoProveedor };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            c.IdProductoProveedor = (long)rdr["IdProductoProveedor"];
                            c.Proveedor = (string)rdr["Proveedor"];
                            c.Producto = (string)rdr["Producto"];
                            c.PrecioProveedor = (decimal)rdr["PrecioProveedor"];
                            c.FechaModificacion = rdr["FechaModificacion"] != DBNull.Value
                               ? (DateTime)rdr["FechaModificacion"]
                               : DateTime.MinValue;
                            c.IdUnidad = rdr["IdUnidad"] != DBNull.Value ? (int)rdr["IdUnidad"] : 0;
                            c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                        }
                    }
                }
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
                    var p4 = new SqlParameter("FechaModificacion", SqlDbType.Date) { Value = m.FechaModificacion };
                    var p5 = new SqlParameter("IdUnidad", SqlDbType.Decimal) { Value = m.IdUnidad };
                    var p6 = new SqlParameter("Notas", SqlDbType.VarChar) { Value = m.Notas };

                    cmd.Parameters.Add(p0);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);
                    cmd.Parameters.Add(p4);
                    cmd.Parameters.Add(p5);
                    cmd.Parameters.Add(p6);

                    if (conn.State != ConnectionState.Open)
                        conn.Open();
                    m.IdProductoProveedor = (long)cmd.ExecuteScalar();
                }
            }
            return m.IdProductoProveedor;
        }


        public static bool Delete(ProductoProveedor model)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("ProductoProveedor_Delete", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdProductoProveedor", SqlDbType.BigInt) { Value = model.IdProductoProveedor };

                    cmd.Parameters.Add(p0);

                    conn.Open();
                    cmd.ExecuteScalar();
                    return true;
                }
            }
        }


        public static List<ProductoProveedorView> GetGrid_GetByIdProveedor(int idProveedor, string descripcion)
        {
            var list = new List<ProductoProveedorView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("ProductoProveedor_GetAll_GetByIdProveedor", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdProveedor", SqlDbType.Int) { Value = idProveedor };
                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = descripcion };

                    cmd.Parameters.Add(p0);
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new ProductoProveedorView();
                            p.IdProductoProveedor = (long)rdr["IdProductoProveedor"];
                            p.IdProducto = (long)rdr["IdProducto"];
                            p.Producto = (string)rdr["Producto"];
                            p.Proveedor = (string)rdr["Proveedor"];
                            p.PrecioProveedor = (decimal)rdr["PrecioProveedor"];
                            p.FechaModificacion = rdr["FechaModificacion"] != DBNull.Value ? (DateTime)rdr["FechaModificacion"] : DateTime.MinValue;
                            p.PrecioVenta = (decimal)rdr["PrecioVenta"];
                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }



        public static List<ProductoProveedorView> GetGrid_GetByIdProducto(long idProducto)
        {
            var list = new List<ProductoProveedorView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("ProductoProveedor_GetAll_GetByIdProducto", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = idProducto };

                    cmd.Parameters.Add(p0);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new ProductoProveedorView();
                            p.IdProductoProveedor = (long)rdr["IdProductoProveedor"];
                            p.IdProducto = (long)rdr["IdProducto"];
                            p.IdProveedor = rdr["IdProveedor"] != DBNull.Value ? (int)rdr["IdProveedor"] : 0;
                            p.Producto = (string)rdr["Producto"];
                            p.Proveedor = (string)rdr["Proveedor"];
                            p.PrecioProveedor = (decimal)rdr["PrecioProveedor"];
                            p.FechaModificacion = rdr["FechaModificacion"] != DBNull.Value ? (DateTime)rdr["FechaModificacion"] : DateTime.MinValue;
                            p.PrecioVenta = (decimal)rdr["PrecioVenta"];
                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }

    }
}