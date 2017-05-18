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
            var conn = new SqlConnection(GeneralData.CadenaConexion);
            SqlDataReader rdr = null;
            var cmd = new SqlCommand("Stock_GetAll", conn) { CommandType = CommandType.StoredProcedure };

            try {
                conn.Open();
                rdr = cmd.ExecuteReader();

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
            finally {
                rdr?.Close();
                conn.Close();
            }

            return list;
        }


        public static StockView GetByPrimaryKey(long idStock)
        {
            var c = new StockView();
            var conn = new SqlConnection(GeneralData.CadenaConexion);
            SqlDataReader rdr = null;
            var cmd = new SqlCommand("Stock_GetByPrimaryKey", conn) { CommandType = CommandType.StoredProcedure };

            var p1 = new SqlParameter("IdStock", SqlDbType.Int) { Value = idStock };
            cmd.Parameters.Add(p1);

            try {
                conn.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    c.IdStock = (long)rdr["IdStock"];
                    c.Cantidad = (int)rdr["Cantidad"];
                    c.IdDeposito = (int)rdr["IdDeposito"];
                    c.IdProducto = (long)rdr["IdProducto"];
                }
            }
            finally {
                rdr?.Close();
                conn.Close();
            }

            return c;
        }



        public static long Insert(Stock model)
        {
            long idStock;

            var c = new StockView();
            var conn = new SqlConnection(GeneralData.CadenaConexion);

            var cmd = new SqlCommand("Stock_Insert", conn) { CommandType = CommandType.StoredProcedure };

            var p1 = new SqlParameter("Cantidad", SqlDbType.Int) { Value = model.Cantidad };
            var p2 = new SqlParameter("IdDeposito", SqlDbType.Int) { Value = model.IdDeposito};
            var p3 = new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = model.IdProducto };
            
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);

            try {
                conn.Open();
                idStock = (long)cmd.ExecuteScalar();

            }
            finally {
                conn.Close();
            }

            return idStock;
        }


        public static long Update(Stock model)
        {
            long idStock;

            var conn = new SqlConnection(GeneralData.CadenaConexion);

            var cmd = new SqlCommand("Stock_Update", conn) { CommandType = CommandType.StoredProcedure };

            var p1 = new SqlParameter("IdDeposito", SqlDbType.Int) { Value = model.IdDeposito };
            var p2 = new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = model.IdProducto };
            var p3 = new SqlParameter("Cantidad", SqlDbType.Int) { Value = model.Cantidad };

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);

            try {
                conn.Open();
                idStock = (long)cmd.ExecuteScalar();

            }
            finally {
                conn.Close();
            }

            return idStock;
        }


        public static Stock GetByParameters(Stock producto)
        {
            var c = new Stock();
            var conn = new SqlConnection(GeneralData.CadenaConexion);
            SqlDataReader rdr = null;
            var cmd = new SqlCommand("Stock_GetByParameters", conn) { CommandType = CommandType.StoredProcedure };

            var p1 = new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = producto.IdProducto };
            var p2 = new SqlParameter("IdDeposito", SqlDbType.Int) { Value = producto.IdDeposito };

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);

            try {
                conn.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    c.IdStock = (long)rdr["IdStock"];
                    c.Cantidad = (int)rdr["Cantidad"];
                    c.IdProducto = (long)rdr["IdProducto"];
                    c.IdDeposito = (int)rdr["IdDeposito"];
                }
            }
            finally {
                rdr?.Close();
                conn.Close();
            }

            return c;
        }

        public static bool Delete(Stock model)
        {
            var conn = new SqlConnection(GeneralData.CadenaConexion);

            var cmd = new SqlCommand("Stock_Delete", conn) { CommandType = CommandType.StoredProcedure };

            var p0 = new SqlParameter("IdProducto", SqlDbType.VarChar) { Value = model.IdProducto };

            cmd.Parameters.Add(p0);

            try {
                conn.Open();
                model.IdProducto = (long)cmd.ExecuteScalar();
                return true;
            }
            catch {
                return false;
            }
            finally {
                conn.Close();
            }
        }
    }
}