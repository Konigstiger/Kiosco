using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;
using Model.View;

namespace Data
{
    public class ProductoPromocionData
    {
        public static List<ProductoPromocion> GetAll()
        {
            var list = new List<ProductoPromocion>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("ProductoPromocion_GetAll", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new ProductoPromocion {
                                IdProductoPromocion = (long)rdr["IdProductoPromocion"],
                                IdPromocion = (int)rdr["IdPromocion"],
                                IdProducto = (long)rdr["IdProducto"],
                                Cantidad = (int)rdr["Cantidad"],
                                PrecioPromocion = (decimal)rdr["PrecioPromocion"],
                                PorcentajeDescuento = (decimal)rdr["PorcentajeDescuento"],
                                Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : ""
                            };
                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }


        public static List<ProductoPromocionView> GetGrid()
        {
            var list = new List<ProductoPromocionView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("ProductoPromocion_GetGrid", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new ProductoPromocionView {
                                IdProductoPromocion = (int)rdr["IdProductoPromocion"],
                                IdPromocion = (int)rdr["IdPromocion"],
                                IdProducto = (long)rdr["IdProducto"],
                                Cantidad = (int)rdr["Cantidad"],
                                PrecioPromocion = (decimal)rdr["PrecioPromocion"],
                                PorcentajeDescuento = (decimal)rdr["PorcentajeDescuento"],
                                Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : string.Empty
                            };
                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }


        public static List<ProductoPromocion> SearchByParameters(string descripcion)
        {
            var list = new List<ProductoPromocion>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("ProductoPromocion_GetByParameters", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;
                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = descripcion };

                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new ProductoPromocion {
                                IdProductoPromocion = (int)rdr["IdProductoPromocion"],
                                IdPromocion = (int)rdr["IdPromocion"],
                                IdProducto = (long)rdr["IdProducto"],
                                Cantidad = (int)rdr["Cantidad"],
                                PrecioPromocion = (decimal)rdr["PrecioPromocion"],
                                PorcentajeDescuento = (decimal)rdr["PorcentajeDescuento"],
                                Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : ""
                            };
                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }


        public static long Insert(ProductoPromocion m)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("ProductoPromocion_Insert", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //var p0 = new SqlParameter("IdProductoPromocion", SqlDbType.BigInt ) {Direction = ParameterDirection.Output};
                    var p1 = new SqlParameter("IdPromocion", SqlDbType.Int) { Value = m.IdPromocion };
                    var p2 = new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = m.IdProducto };
                    var p3 = new SqlParameter("Cantidad", SqlDbType.Int) { Value = m.Cantidad };
                    var p4 = new SqlParameter("PrecioPromocion", SqlDbType.Decimal) { Value = m.PrecioPromocion };
                    var p5 = new SqlParameter("PorcentajeDescuento", SqlDbType.Decimal) { Value = m.PorcentajeDescuento };
                    var p6 = new SqlParameter("Notas", SqlDbType.VarChar) { Value = m.Notas };

                    //cmd.Parameters.Add(p0);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);
                    cmd.Parameters.Add(p4);
                    cmd.Parameters.Add(p5);
                    cmd.Parameters.Add(p6);

                    conn.Open();

                    m.IdProductoPromocion = (long)cmd.ExecuteScalar();
                }
            }
            return m.IdProductoPromocion;
        }



        public static ProductoPromocion GetByPrimaryKey(long idProductoPromocion)
        {
            var c = new ProductoPromocion();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("ProductoPromocion_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdProductoPromocion", SqlDbType.BigInt) { Value = idProductoPromocion };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {

                        while (rdr.Read()) {
                            c.IdProductoPromocion = (int)rdr["IdProductoPromocion"];
                            c.IdPromocion = (int)rdr["IdPromocion"];
                            c.IdProducto = (long)rdr["IdProducto"];
                            c.Cantidad = (int)rdr["Cantidad"];
                            c.PrecioPromocion = (decimal)rdr["PrecioPromocion"];
                            c.PorcentajeDescuento = (decimal)rdr["PorcentajeDescuento"];
                            c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                        }
                    }
                }
            }
            return c;
        }


        public static ProductoPromocionView GetByPrimaryKeyView(long idProductoPromocion)
        {
            var c = new ProductoPromocionView();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("ProductoPromocionView_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdProductoPromocion", SqlDbType.Int) { Value = idProductoPromocion };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            c.IdProductoPromocion = (int)rdr["IdProductoPromocion"];
                            c.IdPromocion = (int)rdr["IdPromocion"];
                            c.IdProducto = (long)rdr["IdProducto"];
                            c.Cantidad = (int)rdr["Cantidad"];
                            c.PrecioPromocion = (decimal)rdr["PrecioPromocion"];
                            c.PorcentajeDescuento = (decimal)rdr["PorcentajeDescuento"];
                            c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                        }
                    }
                }
            }
            return c;
        }



        public static long Update(ProductoPromocion m)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("ProductoPromocion_Update", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdProductoPromocion", SqlDbType.BigInt) { Value = m.IdProductoPromocion };
                    var p1 = new SqlParameter("IdPromocion", SqlDbType.Int) { Value = m.IdPromocion };
                    var p2 = new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = m.IdProducto };
                    var p3 = new SqlParameter("Cantidad", SqlDbType.Int) { Value = m.Cantidad };
                    var p4 = new SqlParameter("PrecioPromocion", SqlDbType.Decimal) { Value = m.PrecioPromocion };
                    var p5 = new SqlParameter("PorcentajeDescuento", SqlDbType.Decimal) { Value = m.PorcentajeDescuento };
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
                    m.IdProductoPromocion = (long)cmd.ExecuteScalar();
                }
            }
            return m.IdProductoPromocion;
        }


        public static bool Delete(ProductoPromocion model)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("ProductoPromocion_Delete", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdProductoPromocion", SqlDbType.Int) { Value = model.IdProductoPromocion };

                    cmd.Parameters.Add(p0);

                    conn.Open();
                    cmd.ExecuteScalar();
                    return true;
                }
            }
        }


        public static List<ProductoPromocionView> GetGrid_GetByIdPromocion(int idPromocion, string descripcion)
        {
            var list = new List<ProductoPromocionView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("ProductoPromocion_GetAll_GetByIdPromocion", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdPromocion", SqlDbType.Int) { Value = idPromocion };
                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = descripcion };

                    cmd.Parameters.Add(p0);
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new ProductoPromocionView {
                                IdProductoPromocion = (int)rdr["IdProductoPromocion"],
                                IdPromocion = (int)rdr["IdPromocion"],
                                IdProducto = (long)rdr["IdProducto"],
                                Cantidad = (int)rdr["Cantidad"],
                                PrecioPromocion = (decimal)rdr["PrecioPromocion"],
                                PorcentajeDescuento = (decimal)rdr["PorcentajeDescuento"],
                                Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : ""
                            };
                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }



        public static List<ProductoPromocionView> GetGrid_GetByIdPromocion(long idProducto)
        {
            var list = new List<ProductoPromocionView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("ProductoPromocion_GetBy_IdPromocion", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdPromocion", SqlDbType.BigInt) { Value = idProducto };

                    cmd.Parameters.Add(p0);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new ProductoPromocionView {
                                /*
                                ProductoPromocion.IdProductoPromocion
                                ,ProductoPromocion.IdProducto
                                ,ProductoPromocion.Cantidad
                                ,Producto.Descripcion
                                ,ProductoPromocion.PrecioPromocion
                                --,ProductoPromocion.PorcentajeDescuento
                                ,ProductoPromocion.Notas
                                 */
                                IdProductoPromocion = (int)rdr["IdProductoPromocion"],
                                IdProducto = (long)rdr["IdProducto"],
                                Cantidad = (int)rdr["Cantidad"],
                                Descripcion = (string)rdr["Descripcion"],
                                PrecioPromocion = (decimal)rdr["PrecioPromocion"],
                                //PorcentajeDescuento = rdr["PorcentajeDescuento"] != DBNull.Value ? (decimal)rdr["PorcentajeDescuento"] : 0,
                                Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : string.Empty

                            };
                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }

    }
}