using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace Data
{
    public class StockData
    {
        public static List<StockView> GetAll()
        {
            var list = new List<StockView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Stock_GetAll", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new StockView {
                                IdStock = (long)rdr["IdStock"],
                                Cantidad = (int)rdr["Cantidad"],
                                IdDeposito = (int)rdr["IdDeposito"],
                                IdProducto = (long)rdr["IdProducto"]
                            };
                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }


        public static StockView GetByPrimaryKey(long idStock)
        {
            var c = new StockView();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                var cmd = new SqlCommand("Stock_GetByPrimaryKey", conn) { CommandType = CommandType.StoredProcedure };

                var p1 = new SqlParameter("IdStock", SqlDbType.Int) { Value = idStock };
                cmd.Parameters.Add(p1);

                conn.Open();
                using (var rdr = cmd.ExecuteReader()) {

                    while (rdr.Read()) {
                        c.IdStock = (long)rdr["IdStock"];
                        c.Cantidad = (int)rdr["Cantidad"];
                        c.IdDeposito = (int)rdr["IdDeposito"];
                        c.IdProducto = (long)rdr["IdProducto"];
                    }
                }
            }
            return c;
        }


        public static long Insert(Stock model)
        {
            long idStock;
            var c = new StockView();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Stock_Insert", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("Cantidad", SqlDbType.Int) { Value = model.Cantidad };
                    var p2 = new SqlParameter("IdDeposito", SqlDbType.Int) { Value = model.IdDeposito };
                    var p3 = new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = model.IdProducto };

                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);

                    conn.Open();
                    idStock = (long)cmd.ExecuteScalar();
                }
            }
            return idStock;
        }


        public static long Update(Stock model)
        {
            long idStock;
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Stock_Update", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdDeposito", SqlDbType.Int) { Value = model.IdDeposito };
                    var p2 = new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = model.IdProducto };
                    var p3 = new SqlParameter("Cantidad", SqlDbType.Int) { Value = model.Cantidad };

                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);

                    conn.Open();
                    cmd.ExecuteScalar();
                }
            }
            //TODO: CORREGIR ESTO.
            return 0;
        }


        public static long UpdateDelta(Stock model)
        {
            long idStock;
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Stock_Update_Delta", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdDeposito", SqlDbType.Int) { Value = model.IdDeposito };
                    var p2 = new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = model.IdProducto };
                    var p3 = new SqlParameter("Cantidad", SqlDbType.Int) { Value = model.Cantidad };

                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);

                    conn.Open();
                    cmd.ExecuteScalar();
                }
            }
            //TODO: CORREGIR ESTO.
            return 0;
        }

        public static Stock GetByParameters(Stock producto)
        {
            var c = new Stock();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Stock_GetByParameters", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = producto.IdProducto };
                    var p2 = new SqlParameter("IdDeposito", SqlDbType.Int) { Value = producto.IdDeposito };

                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            c.IdStock = (long)rdr["IdStock"];
                            c.Cantidad = (int)rdr["Cantidad"];
                            c.IdProducto = (long)rdr["IdProducto"];
                            c.IdDeposito = (int)rdr["IdDeposito"];
                        }
                    }
                }
            }
            return c;
        }


        public static bool Delete(Stock model)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Stock_Delete", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdProducto", SqlDbType.VarChar) { Value = model.IdProducto };

                    cmd.Parameters.Add(p0);

                    conn.Open();
                    model.IdProducto = (long)cmd.ExecuteScalar();
                    return true;
                }
            }
        }
    }
}