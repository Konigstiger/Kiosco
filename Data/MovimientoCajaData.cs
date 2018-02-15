using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;
using Model.View;

namespace Data
{
    public class MovimientoCajaData
    {
        public static List<MovimientoCajaView> GetAll()
        {
            var list = new List<MovimientoCajaView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("MovimientoCaja_GetAll", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new MovimientoCajaView {
                                IdMovimientoCaja = (long)rdr["IdMovimientoCaja"],
                                Fecha = (string)rdr["Fecha"],
                                Hora = rdr["Hora"] != DBNull.Value ? (string)rdr["Hora"] : "12:00",
                                Monto = (decimal)rdr["Monto"],
                                IdClaseMovimientoCaja =
                                    rdr["IdClaseMovimientoCaja"] != DBNull.Value
                                        ? (int)rdr["IdClaseMovimientoCaja"]
                                        : 0,
                                IdUsuario = rdr["IdUsuario"] != DBNull.Value ? (int)rdr["IdUsuario"] : 0,
                                IdPuntoVenta = (int)rdr["IdPuntoVenta"]
                            };
                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }


        public static MovimientoCajaView GetByPrimaryKey(long idMovimientoCaja)
        {
            var c = new MovimientoCajaView();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("MovimientoCaja_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdMovimientoCaja", SqlDbType.Int) { Value = idMovimientoCaja };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            c.IdMovimientoCaja = (long)rdr["IdMovimientoCaja"];
                            c.Fecha = (string)rdr["Fecha"];
                            c.Hora = rdr["Hora"] != DBNull.Value ? (string)rdr["Hora"] : "12:00";
                            c.Monto = (decimal)rdr["Monto"];
                            c.IdClaseMovimientoCaja = rdr["IdClaseMovimientoCaja"] != DBNull.Value
                                ? (int)rdr["IdClaseMovimientoCaja"]
                                : 0;
                            c.IdUsuario = rdr["IdUsuario"] != DBNull.Value ? (int)rdr["IdUsuario"] : 0;
                            c.IdPuntoVenta = (int) rdr["IdPuntoVenta"];
                        }
                    }
                }
            }
            return c;
        }



        public static long Insert(MovimientoCaja model)
        {
            long idMovimientoCaja;

            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("MovimientoCaja_Insert", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("Fecha", SqlDbType.Date) { Value = model.Fecha.Date };
                    var p2 = new SqlParameter("Hora", SqlDbType.Time) { Value = model.Hora };
                    var p3 = new SqlParameter("Monto", SqlDbType.Decimal) { Value = model.Monto };
                    var p4 = new SqlParameter("IdClaseMovimientoCaja", SqlDbType.Int) {
                        Value = model.IdClaseMovimientoCaja
                    };
                    var p5 = new SqlParameter("IdUsuario", SqlDbType.Int) { Value = model.IdUsuario };
                    var p6 = new SqlParameter("IdPuntoVenta", SqlDbType.Int) { Value = model.IdPuntoVenta};

                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);
                    cmd.Parameters.Add(p4);
                    cmd.Parameters.Add(p5);

                    conn.Open();
                    idMovimientoCaja = (long)cmd.ExecuteScalar();
                }
            }
            return idMovimientoCaja;
        }


    }
}