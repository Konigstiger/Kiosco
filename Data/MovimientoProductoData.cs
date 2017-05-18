using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace Data
{
    public class MovimientoProductoData
    {
        public static List<MovimientoProductoView> GetAll()
        {
            var list = new List<MovimientoProductoView>();
            var conn = new SqlConnection(GeneralData.CadenaConexion);
            SqlDataReader rdr = null;
            var cmd = new SqlCommand("MovimientoProducto_GetAll", conn) { CommandType = CommandType.StoredProcedure };

            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    var p = new MovimientoProductoView
                    {
                        //=====================================================================
                        // IdMovimientoProducto -1 (identity)
                        // IdProducto
                        // Cantidad
                        // IdClaseMovimientoProducto
                        // Fecha
                        // IdUsuario

                        IdMovimientoProducto = (long)rdr["IdMovimientoProducto"],
                        IdProducto = (long)rdr["Fecha"],
                        Cantidad = (int)rdr["Cantidad"],
                        IdClaseMovimientoProducto = (int)rdr["IdClaseMovimientoProducto"],
                        Fecha = (DateTime)rdr["Fecha"],
                        IdUsuario = (int)rdr["IdUsuario"]
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


        public static MovimientoProductoView GetByPrimaryKey(long idMovimientoProducto)
        {
            var c = new MovimientoProductoView();
            var conn = new SqlConnection(GeneralData.CadenaConexion);
            SqlDataReader rdr = null;
            var cmd = new SqlCommand("MovimientoProducto_GetByPrimaryKey", conn) { CommandType = CommandType.StoredProcedure };

            var p1 = new SqlParameter("IdMovimientoProducto", SqlDbType.Int) { Value = idMovimientoProducto };
            cmd.Parameters.Add(p1);

            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    c.IdMovimientoProducto = (long) rdr["IdMovimientoProducto"];
                    c.IdProducto = (long) rdr["Fecha"];
                    c.Cantidad = (int) rdr["Cantidad"];
                    c.IdClaseMovimientoProducto = (int) rdr["IdClaseMovimientoProducto"];
                    c.Fecha = (DateTime) rdr["Fecha"];
                    c.IdUsuario = (int) rdr["IdUsuario"];
                }
            }
            finally
            {
                rdr?.Close();
                conn.Close();
            }

            return c;
        }



        public static long Insert(MovimientoProducto model)
        {
            long idMovimientoProducto;

            var c = new MovimientoProductoView();
            var conn = new SqlConnection(GeneralData.CadenaConexion);

            var cmd = new SqlCommand("MovimientoProducto_Insert", conn) { CommandType = CommandType.StoredProcedure };

            /*
            @IdProducto					    bigint
            ,@Cantidad						int
            ,@IdClaseMovimientoProducto		int
            ,@Fecha							date
            ,@IdUsuario						int
             */

            var p1 = new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = model.IdProducto };
            var p2 = new SqlParameter("Cantidad", SqlDbType.Int) { Value = model.Cantidad };
            var p3 = new SqlParameter("IdClaseMovimientoProducto", SqlDbType.Int) { Value = model.IdClaseMovimientoProducto };
            var p4 = new SqlParameter("Fecha", SqlDbType.Date) { Value = model.Fecha};
            var p5 = new SqlParameter("IdUsuario", SqlDbType.Int) { Value = model.IdUsuario };

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);

            try
            {
                conn.Open();
                idMovimientoProducto = (long)cmd.ExecuteScalar();

            }
            finally
            {
                conn.Close();
            }

            return idMovimientoProducto;
        }




    }
}