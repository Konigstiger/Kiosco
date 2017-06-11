using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace Data
{
    public class VentaData
    {
        public static List<VentaView> GetAll()
        {
            var list = new List<VentaView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Venta_GetAll", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new VentaView {
                                IdVenta = (long)rdr["IdVenta"],
                                IdCliente = (long)rdr["IdCliente"],
                                Total = (decimal)rdr["Total"],
                                IdMovimientoCaja =
                                    rdr["IdMovimientoCaja"] != DBNull.Value ? (long)rdr["IdMovimientoCaja"] : 0,
                                Fecha = (DateTime)rdr["Fecha"],
                                PendientePago =
                                    rdr["PendientePago"] != DBNull.Value ? (bool)rdr["PendientePago"] : false,
                                Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : ""
                            };
                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }


        public static VentaView GetByPrimaryKey(long idVenta)
        {
            var c = new VentaView();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Venta_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdVenta", SqlDbType.Int) { Value = idVenta };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {

                        while (rdr.Read()) {
                            c.IdVenta = (long)rdr["IdVenta"];
                            c.IdCliente = (long)rdr["IdCliente"];
                            c.Total = (decimal)rdr["Total"];
                            c.IdMovimientoCaja = rdr["IdMovimientoCaja"] != DBNull.Value
                                ? (long)rdr["IdMovimientoCaja"]
                                : 0;
                            c.Fecha = (DateTime)rdr["Fecha"];
                            c.PendientePago = rdr["PendientePago"] != DBNull.Value ? (bool)rdr["PendientePago"] : false;
                            c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                        }
                    }
                }
            }
            return c;
        }



        public static long Insert(Venta model)
        {
            long idVenta;
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Venta_Insert", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdCliente", SqlDbType.BigInt) { Value = model.IdCliente };
                    var p2 = new SqlParameter("Total", SqlDbType.Decimal) { Value = model.Total };
                    var p3 = new SqlParameter("Fecha", SqlDbType.Date) { Value = model.Fecha };
                    var p4 = new SqlParameter("IdMovimientoCaja", SqlDbType.BigInt) { Value = model.IdMovimientoCaja };
                    var p5 = new SqlParameter("PendientePago", SqlDbType.Bit) { Value = model.PendientePago };
                    var p6 = new SqlParameter("Notas", SqlDbType.VarChar) { Value = model.Notas };

                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);
                    cmd.Parameters.Add(p4);
                    cmd.Parameters.Add(p5);
                    cmd.Parameters.Add(p6);

                    conn.Open();
                    idVenta = (long)cmd.ExecuteScalar();
                }
            }
            return idVenta;
        }


    }
}