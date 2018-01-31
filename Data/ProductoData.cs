using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace Data
{
    public class ProductoData
    {
        public static List<Producto> GetAll()
        {
            var list = new List<Producto>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Producto_GetAll", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new Producto();
                            p.IdProducto = (long)rdr["IdProducto"];
                            p.CodigoBarras = (string)rdr["CodigoBarras"];
                            p.Descripcion = (string)rdr["Descripcion"];
                            p.PrecioVenta = rdr["PrecioVenta"] != DBNull.Value ? (decimal)rdr["PrecioVenta"] : 0;
                            p.PrecioVentaPremium = rdr["PrecioVentaPremium"] != DBNull.Value ? (decimal)rdr["PrecioVentaPremium"] : 0;
                            p.PrecioCostoPromedio = rdr["PrecioCostoPromedio"] != DBNull.Value ? (decimal)rdr["PrecioCostoPromedio"] : 0;
                            p.IdRubro = (int)rdr["IdRubro"];
                            p.IdMarca = (int)rdr["IdMarca"];
                            p.SoloAdultos = rdr["SoloAdultos"] != DBNull.Value ? (bool)rdr["SoloAdultos"] : false;
                            p.StockMinimo = (int)rdr["StockMinimo"];
                            p.StockMaximo = (int)rdr["StockMaximo"];
                            p.IdUnidad = (int)rdr["IdUnidad"];
                            //p.Capacidad = (int)rdr["Capacidad"];

                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }


        public static List<ProductoView> GetAllView()
        {
            var list = new List<ProductoView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Producto_View_GetAll", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new ProductoView {
                                IdProducto = (long)rdr["IdProducto"],
                                CodigoBarras = (string)rdr["CodigoBarras"],
                                Descripcion = (string)rdr["Descripcion"],
                                Capacidad = rdr["Capacidad"] != DBNull.Value ? (int)rdr["Capacidad"] : 0,
                                Marca = (string)rdr["Marca"],
                                Rubro = (string)rdr["Rubro"],
                                Precio = rdr["Precio"] != DBNull.Value ? (decimal)rdr["Precio"] : 0
                            };
                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }


        public static ProductoView GetByPrimaryKeyView(long idProducto)
        {
            var c = new ProductoView();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Producto_View_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdProducto", SqlDbType.Int) { Value = idProducto };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            c.IdProducto = (long)rdr["IdProducto"];
                            c.CodigoBarras = (string)rdr["CodigoBarras"];
                            c.Descripcion = (string)rdr["Descripcion"];
                            c.Capacidad = rdr["Capacidad"] != DBNull.Value ? (int)rdr["Capacidad"] : 0;
                            //c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                            //TODO: Continuar aqui...
                        }
                    }
                }
            }
            return c;
        }


        public static Producto GetByPrimaryKey(long id)
        {
            var c = new Producto();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Producto_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdProducto", SqlDbType.Int) { Value = id };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            c.IdProducto = (long)rdr["IdProducto"];
                            c.CodigoBarras = (string)rdr["CodigoBarras"];
                            c.Descripcion = (string)rdr["Descripcion"];
                            c.Capacidad = rdr["Capacidad"] != DBNull.Value ? (int)rdr["Capacidad"] : 0;
                            c.PrecioVenta = (decimal)rdr["PrecioVenta"];
                            c.PrecioVentaPremium = rdr["PrecioVentaPremium"] != DBNull.Value ? (decimal)rdr["PrecioVentaPremium"] : 0;
                            c.PrecioCostoPromedio = (decimal)rdr["PrecioCostoPromedio"];
                            c.SoloAdultos = rdr["SoloAdultos"] != DBNull.Value ? (bool)rdr["SoloAdultos"] : false;
                            c.StockMinimo = (int)rdr["StockMinimo"];
                            c.StockMaximo = (int)rdr["StockMaximo"];
                            c.IdRubro = (int)rdr["IdRubro"];
                            c.IdMarca = (int)rdr["IdMarca"];
                            c.IdUnidad = (int)rdr["IdUnidad"];
                            c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                        }
                    }
                }
            }
            return c;
        }



        public static List<ProductoView> GetAllByDepositoGetByPrimaryKey(long idProducto, int idDeposito)
        {
            var list = new List<ProductoView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Stock_Producto_ByDeposito_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = idProducto };
                    var p2 = new SqlParameter("IdDeposito", SqlDbType.Int) { Value = idDeposito };

                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {

                        while (rdr.Read()) {
                            var p = new ProductoView {
                                IdProducto = (long)rdr["IdProducto"],
                                CodigoBarras = (string)rdr["CodigoBarras"],
                                Descripcion = (string)rdr["Descripcion"],
                                Precio = rdr["Precio"] != DBNull.Value ? (decimal)rdr["Precio"] : 0,
                                Ganancia = (string)rdr["Ganancia"],
                                Stock = (int)rdr["Stock"],
                                Marca = (string)rdr["Marca"],
                                Rubro = (string)rdr["Rubro"],
                                Capacidad = rdr["Capacidad"] != DBNull.Value ? (int)rdr["Capacidad"] : 0
                            };
                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }


        public static List<ProductoView> GetAllByDeposito(int idDeposito)
        {
            var productoViews = new List<ProductoView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {

                using (var cmd = new SqlCommand("Stock_Producto_ByDeposito_GetAll", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdDeposito", SqlDbType.Int) { Value = idDeposito };

                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {

                        while (rdr.Read()) {
                            var p = new ProductoView {
                                IdProducto = (long)rdr["IdProducto"],
                                CodigoBarras = (string)rdr["CodigoBarras"],
                                Descripcion = (string)rdr["Descripcion"],
                                Capacidad = rdr["Capacidad"] != DBNull.Value ? (int)rdr["Capacidad"] : 0,
                                Precio = rdr["Precio"] != DBNull.Value ? (decimal)rdr["Precio"] : 0,
                                Ganancia = (string)rdr["Ganancia"],
                                Marca = (string)rdr["Marca"],
                                Stock = (int)rdr["Stock"],
                                Rubro = (string)rdr["Rubro"],
                                Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : ""
                            };
                            productoViews.Add(p);
                        }
                    }
                }
            }
            return productoViews;
        }


        public static List<ProductoView> GetAllByDeposito_GetByDescripcion(int idDeposito, string descripcion)
        {
            var list = new List<ProductoView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Producto_GetByDescripcion", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = descripcion };

                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new ProductoView {
                                IdProducto = (long)rdr["IdProducto"],
                                CodigoBarras = (string)rdr["CodigoBarras"],
                                Descripcion = (string)rdr["Descripcion"],
                                Capacidad = rdr["Capacidad"] != DBNull.Value ? (int)rdr["Capacidad"] : 0,
                                Precio = rdr["Precio"] != DBNull.Value ? (decimal)rdr["Precio"] : 0,
                                PrecioVentaPremium = rdr["Premium"] != DBNull.Value ? (decimal)rdr["Premium"] : 0,
                                Ganancia = (string)rdr["Ganancia"],
                                Marca = (string)rdr["Marca"],
                                Stock = rdr["Stock"] != DBNull.Value ? (int)rdr["Stock"] : 0,
                                Rubro = (string)rdr["Rubro"],
                                Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : ""
                            };
                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }


        public static ProductoView GetByCodigoBarrasView(string codigoBarras)
        {
            var c = new ProductoView(-1);

            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Producto_View_GetByCodigoBarras", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("CodigoBarras", SqlDbType.VarChar) { Value = codigoBarras };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            c.IdProducto = (long)rdr["IdProducto"];
                            c.CodigoBarras = (string)rdr["CodigoBarras"];
                            c.Descripcion = (string)rdr["Descripcion"];
                            c.Capacidad = rdr["Capacidad"] != DBNull.Value ? (int)rdr["Capacidad"] : 0;
                            c.Precio = (decimal)rdr["Precio"];
                            c.PrecioVentaPremium = (decimal)rdr["Premium"];
                            c.PrecioCosto = (decimal)rdr["PrecioCosto"];
                            //c.Ganancia = (string)rdr["Ganancia"];
                            c.Marca = (string)rdr["Marca"];
                            c.Rubro = (string)rdr["Rubro"];
                            c.Stock = (int)rdr["Stock"];
                            c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                        }
                    }
                }
            }
            return c;
        }


        public static Producto GetByCodigoBarras(string codigoBarras)
        {
            var c = new Producto(-1);

            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Producto_GetByCodigoBarras", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("CodigoBarras", SqlDbType.VarChar) { Value = codigoBarras };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            c.IdProducto = (long)rdr["IdProducto"];
                            c.CodigoBarras = (string)rdr["CodigoBarras"];
                            c.Descripcion = (string)rdr["Descripcion"];
                            c.Capacidad = rdr["Capacidad"] != DBNull.Value ? (int)rdr["Capacidad"] : 0;
                            c.PrecioVenta = (decimal)rdr["PrecioVenta"];
                            c.PrecioVentaPremium = rdr["PrecioVentaPremium"] != DBNull.Value ? (decimal)rdr["PrecioVentaPremium"] : 0;
                            c.PrecioCostoPromedio = (decimal)rdr["PrecioCostoPromedio"];
                            c.IdRubro = (int)rdr["IdRubro"];
                            c.IdMarca = (int)rdr["IdMarca"];
                            c.SoloAdultos = (bool)rdr["SoloAdultos"];
                            c.StockMinimo = (int)rdr["StockMinimo"];
                            c.StockMaximo = (int)rdr["StockMaximo"];
                            c.IdUnidad = (int)rdr["IdUnidad"];
                            c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                        }
                    }
                }
            }
            return c;
        }


        public static long Insert(Producto model)
        {
            long idProducto;
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Producto_Insert", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("CodigoBarras", SqlDbType.VarChar) { Value = model.CodigoBarras };
                    var p2 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = model.Descripcion };
                    var p3 = new SqlParameter("Capacidad", SqlDbType.Int) { Value = model.Capacidad };
                    var p4 = new SqlParameter("PrecioVenta", SqlDbType.Decimal) { Value = model.PrecioVenta };
                    var p5 = new SqlParameter("PrecioVentaPremium", SqlDbType.Decimal) { Value = model.PrecioVentaPremium };
                    var p6 = new SqlParameter("PrecioCostoPromedio", SqlDbType.Decimal) {
                        Value = model.PrecioCostoPromedio
                    };
                    var p7 = new SqlParameter("IdRubro", SqlDbType.Int) { Value = model.IdRubro };
                    var p8 = new SqlParameter("IdMarca", SqlDbType.Int) { Value = model.IdMarca };
                    var p9 = new SqlParameter("SoloAdultos", SqlDbType.Bit) { Value = model.SoloAdultos };
                    var p10 = new SqlParameter("StockMinimo", SqlDbType.Int) { Value = model.StockMinimo };
                    var p11 = new SqlParameter("StockMaximo", SqlDbType.Int) { Value = model.StockMaximo };
                    var p12 = new SqlParameter("Notas", SqlDbType.VarChar) { Value = model.Notas };

                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);
                    cmd.Parameters.Add(p4);
                    cmd.Parameters.Add(p5);
                    cmd.Parameters.Add(p6);
                    cmd.Parameters.Add(p7);
                    cmd.Parameters.Add(p8);
                    cmd.Parameters.Add(p9);
                    cmd.Parameters.Add(p10);
                    cmd.Parameters.Add(p11);
                    cmd.Parameters.Add(p12);

                    conn.Open();
                    idProducto = (long)cmd.ExecuteScalar();
                }
            }
            return idProducto;
        }


        public static long Update(Producto model)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Producto_Update", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdProducto", SqlDbType.VarChar) { Value = model.IdProducto };
                    var p1 = new SqlParameter("CodigoBarras", SqlDbType.VarChar) { Value = model.CodigoBarras };
                    var p2 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = model.Descripcion };
                    var p3 = new SqlParameter("Capacidad", SqlDbType.Int) { Value = model.Capacidad };

                    var p4 = new SqlParameter("PrecioVenta", SqlDbType.Decimal) { Value = model.PrecioVenta };
                    var p5 = new SqlParameter("PrecioVentaPremium", SqlDbType.Decimal) { Value = model.PrecioVentaPremium };
                    var p6 = new SqlParameter("PrecioCostoPromedio", SqlDbType.Decimal) {
                        Value = model.PrecioCostoPromedio
                    };
                    var p7 = new SqlParameter("IdRubro", SqlDbType.Int) { Value = model.IdRubro };
                    var p8 = new SqlParameter("IdMarca", SqlDbType.Int) { Value = model.IdMarca };
                    var p9 = new SqlParameter("SoloAdultos", SqlDbType.Bit) { Value = model.SoloAdultos };
                    var p10 = new SqlParameter("StockMinimo", SqlDbType.Int) { Value = model.StockMinimo };
                    var p11 = new SqlParameter("StockMaximo", SqlDbType.Int) { Value = model.StockMaximo };
                    var p12 = new SqlParameter("Notas", SqlDbType.VarChar) { Value = model.Notas };

                    cmd.Parameters.Add(p0);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);
                    cmd.Parameters.Add(p4);
                    cmd.Parameters.Add(p5);
                    cmd.Parameters.Add(p6);
                    cmd.Parameters.Add(p7);
                    cmd.Parameters.Add(p8);
                    cmd.Parameters.Add(p9);
                    cmd.Parameters.Add(p10);
                    cmd.Parameters.Add(p11);
                    cmd.Parameters.Add(p12);

                    conn.Open();
                    model.IdProducto = (long)cmd.ExecuteScalar();
                }
            }
            return model.IdProducto;
        }


        public static bool Delete(Producto model)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Producto_Delete", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdProducto", SqlDbType.VarChar) { Value = model.IdProducto };

                    cmd.Parameters.Add(p0);

                    conn.Open();
                    model.IdProducto = (long)cmd.ExecuteScalar();
                    return true;
                }
            }
        }


        public static List<Producto> GetAll_AutoComplete()
        {
            var list = new List<Producto>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Producto_GetDescripcion_GetAll", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {

                        while (rdr.Read()) {
                            var p = new Producto {
                                IdProducto = (long)rdr["IdProducto"],
                                Descripcion = (string)rdr["Descripcion"]
                            };

                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }


        public static int GetCantidadProducto_ByRubro(int idRubro)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Producto_GetCountByIdRubro", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdRubro", SqlDbType.VarChar) { Value = idRubro };

                    cmd.Parameters.Add(p0);
                    var cantidad = 0;
                    conn.Open();
                    cantidad = (int)cmd.ExecuteScalar();

                    return cantidad;
                }
            }
        }
    }
}