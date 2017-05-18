using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace Data
{
    public class VentaDetalleData
    {
        public static List<VentaDetalleView> GetAll()
        {
            var list = new List<VentaDetalleView>();
            var conn = new SqlConnection(GeneralData.CadenaConexion);
            SqlDataReader rdr = null;
            var cmd = new SqlCommand("VentaDetalle_GetAll", conn) { CommandType = CommandType.StoredProcedure };

            try {
                conn.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    var p = new VentaDetalleView {
                        /*
                        [IdVentaDetalle] [bigint] IDENTITY(1,1) NOT NULL,
	                    [IdVenta] [bigint] NOT NULL,
	                    [IdProducto] [bigint] NOT NULL
                        [Cantidad] [int] NOT NULL,
	                    [Importe] [decimal](8, 2) NOT NULL,
	                    [IdMovimientoProducto] [bigint] NULL,
	                     */

                        IdVentaDetalle = (long)rdr["IdVentaDetalle"],
                        IdVenta = (long)rdr["IdVenta"],
                        IdProducto = (long)rdr["Fecha"],
                        Cantidad = (int)rdr["Cantidad"],
                        Importe = (decimal)rdr["Importe"],
                        IdMovimientoProducto = rdr["IdMovimientoProducto"] != DBNull.Value ? (long)rdr["IdMovimientoProducto"] : 1
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


        public static VentaDetalleView GetByPrimaryKey(long idVentaDetalle)
        {
            var c = new VentaDetalleView();
            var conn = new SqlConnection(GeneralData.CadenaConexion);
            SqlDataReader rdr = null;
            var cmd = new SqlCommand("VentaDetalle_GetByPrimaryKey", conn) { CommandType = CommandType.StoredProcedure };

            var p1 = new SqlParameter("IdVentaDetalle", SqlDbType.Int) { Value = idVentaDetalle };
            cmd.Parameters.Add(p1);

            try {
                conn.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    c.IdVentaDetalle = (long)rdr["IdVentaDetalle"];
                    c.IdVenta = (long)rdr["IdVenta"];
                    c.IdProducto = (long)rdr["Fecha"];
                    c.Cantidad = (int)rdr["Cantidad"];
                    c.Importe = (decimal)rdr["Importe"];
                    c.IdMovimientoProducto = rdr["IdMovimientoProducto"] != DBNull.Value
                        ? (long)rdr["IdMovimientoProducto"]
                        : 1;
                }
            }
            finally {
                rdr?.Close();
                conn.Close();
            }

            return c;
        }



        public static long Insert(VentaDetalle model)
        {
            long idVentaDetalle;

            var c = new VentaDetalleView();
            var conn = new SqlConnection(GeneralData.CadenaConexion);

            var cmd = new SqlCommand("VentaDetalle_Insert", conn) { CommandType = CommandType.StoredProcedure };

            /*
            @IdVenta			  bigint
           ,@Cantidad			  int
           ,@Importe			  decimal(8,2)
           ,@IdMovimientoProducto bigint
           ,@IdProducto			  bigint   
             */

            var p1 = new SqlParameter("IdVenta", SqlDbType.BigInt) { Value = model.IdVenta };
            var p2 = new SqlParameter("Cantidad", SqlDbType.Int) { Value = model.Cantidad };
            var p3 = new SqlParameter("Importe", SqlDbType.Decimal) { Value = model.Importe };
            var p4 = new SqlParameter("IdMovimientoProducto", SqlDbType.BigInt) { Value = model.IdMovimientoProducto };
            var p5 = new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = model.IdProducto };

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);

            try {
                conn.Open();
                idVentaDetalle = (long)cmd.ExecuteScalar();

            }
            finally {
                conn.Close();
            }

            return idVentaDetalle;
        }


        public static bool Delete(VentaDetalle ventaDetalle)
        {
            throw new NotImplementedException();
        }

        public static void Update(VentaDetalle ventaDetalle)
        {
            throw new NotImplementedException();
        }
    }
}