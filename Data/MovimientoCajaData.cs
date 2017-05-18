using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace Data
{
    public class MovimientoCajaData
    {
        public static List<MovimientoCajaView> GetAll()
        {
            var list = new List<MovimientoCajaView>();
            var conn = new SqlConnection(GeneralData.CadenaConexion);
            SqlDataReader rdr = null;
            var cmd = new SqlCommand("MovimientoCaja_GetAll", conn) { CommandType = CommandType.StoredProcedure };

            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    var p = new MovimientoCajaView
                    {
                        IdMovimientoCaja = (long)rdr["IdMovimientoCaja"],
                        Fecha = (string)rdr["Fecha"],
                        Hora = rdr["Hora"] != DBNull.Value ? (string)rdr["Hora"] : "12:00",
                        Monto = (decimal)rdr["Monto"],
                        IdClaseMovimientoCaja = rdr["IdClaseMovimientoCaja"] != DBNull.Value ? (int)rdr["IdClaseMovimientoCaja"] : 0,
                        IdUsuario = rdr["IdUsuario"] != DBNull.Value ? (int)rdr["IdUsuario"] : 0
                    };

                    list.Add(p);
                }
            }
            finally
            {
                rdr?.Close();
                conn.Close();
            }

            return list;
        }


        public static MovimientoCajaView GetByPrimaryKey(long idMovimientoCaja)
        {
            var c = new MovimientoCajaView();
            var conn = new SqlConnection(GeneralData.CadenaConexion);
            SqlDataReader rdr = null;
            var cmd = new SqlCommand("MovimientoCaja_GetByPrimaryKey", conn) { CommandType = CommandType.StoredProcedure };

            var p1 = new SqlParameter("IdMovimientoCaja", SqlDbType.Int) { Value = idMovimientoCaja };
            cmd.Parameters.Add(p1);

            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    c.IdMovimientoCaja = (long)rdr["IdMovimientoCaja"];
                    c.Fecha = (string)rdr["Fecha"];
                    c.Hora = rdr["Hora"] != DBNull.Value ? (string)rdr["Hora"] : "12:00";
                    c.Monto = (decimal)rdr["Monto"];
                    c.IdClaseMovimientoCaja = rdr["IdClaseMovimientoCaja"] != DBNull.Value
                        ? (int)rdr["IdClaseMovimientoCaja"]
                        : 0;
                    c.IdUsuario = rdr["IdUsuario"] != DBNull.Value ? (int)rdr["IdUsuario"] : 0;
                }
            }
            finally
            {
                rdr?.Close();
                conn.Close();
            }

            return c;
        }



        public static long Insert(MovimientoCaja model)
        {
            long idMovimientoCaja;

            var c = new MovimientoCajaView();
            var conn = new SqlConnection(GeneralData.CadenaConexion);

            var cmd = new SqlCommand("MovimientoCaja_Insert", conn) { CommandType = CommandType.StoredProcedure };

            var p1 = new SqlParameter("Fecha", SqlDbType.Date) { Value = model.Fecha.Date };
            var p2 = new SqlParameter("Hora", SqlDbType.Time) { Value = model.Hora };
            var p3 = new SqlParameter("Monto", SqlDbType.Decimal) { Value = model.Monto };
            var p4 = new SqlParameter("IdClaseMovimientoCaja", SqlDbType.Int) { Value = model.IdClaseMovimientoCaja };
            var p5 = new SqlParameter("IdUsuario", SqlDbType.Int) { Value = model.IdUsuario };

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);

            try
            {
                conn.Open();
                idMovimientoCaja = (long)cmd.ExecuteScalar();

            }
            finally
            {
                conn.Close();
            }

            return idMovimientoCaja;
        }




    }
}