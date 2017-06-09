using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace Data
{
    public class RecaudacionData
    {
        public static List<RecaudacionView> GetAll()
        {
            var list = new List<RecaudacionView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Recaudacion_GetAll", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new RecaudacionView {
                                IdRecaudacion = (long)rdr["IdRecaudacion"],
                                Fecha = (DateTime)rdr["Fecha"],
                                Total = (decimal)rdr["Total"],
                                Compras = (decimal)rdr["Compras"],
                                IdUsuario = (int)rdr["IdUsuario"],
                                Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : ""
                            };
                            list.Add(p);
                        }
                    }
                }
                return list;
            }
        }


        public static List<RecaudacionView> SearchByParameters(DateTime fecha1, DateTime fecha2)
        {
            var list = new List<RecaudacionView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Recaudacion_GetByParameters", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("Fecha1", SqlDbType.Date) { Value = fecha1 };
                    var p2 = new SqlParameter("Fecha2", SqlDbType.Date) { Value = fecha2 };

                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new RecaudacionView {
                                IdRecaudacion = (long)rdr["IdRecaudacion"],
                                Fecha = (DateTime)rdr["Fecha"],
                                Total = (decimal)rdr["Total"],
                                Compras = (decimal)rdr["Compras"],
                                IdUsuario = (int)rdr["IdUsuario"],
                                Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : ""
                            };
                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }


        public static long Insert(Recaudacion m)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Recaudacion_Insert", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //var p0 = new SqlParameter("IdRecaudacion", SqlDbType.BigInt) { Value = m.IdRecaudacion };
                    var p1 = new SqlParameter("Fecha", SqlDbType.Date) { Value = m.Fecha };
                    var p2 = new SqlParameter("Total", SqlDbType.Decimal) { Value = m.Total };
                    var p3 = new SqlParameter("Compras", SqlDbType.Decimal) { Value = m.Compras };
                    var p4 = new SqlParameter("IdUsuario", SqlDbType.Int) { Value = m.IdUsuario };
                    var p5 = new SqlParameter("Notas", SqlDbType.VarChar) { Value = m.Notas };

                    //cmd.Parameters.Add(p0);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);
                    cmd.Parameters.Add(p4);
                    cmd.Parameters.Add(p5);

                    conn.Open();
                    m.IdRecaudacion = (long)cmd.ExecuteScalar();
                }
            }

            return m.IdRecaudacion;
        }


        public static Recaudacion GetByPrimaryKey(long idRecaudacion)
        {
            var c = new Recaudacion();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Recaudacion_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdRecaudacion", SqlDbType.Int) { Value = idRecaudacion };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            c.IdRecaudacion = (long)rdr["IdRecaudacion"];
                            c.Fecha = (DateTime)rdr["Fecha"];
                            c.Total = (decimal)rdr["Total"];
                            c.Compras = (decimal)rdr["Compras"];
                            c.IdUsuario = (int) rdr["IdUsuario"];
                            c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                        }
                    }
                }
            }

            return c;
        }


        public static RecaudacionView GetByPrimaryKeyView(long idRecaudacion)
        {
            var c = new RecaudacionView();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Recaudacion_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdRecaudacion", SqlDbType.Int) { Value = idRecaudacion };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            c.IdRecaudacion = (long)rdr["IdRecaudacion"];
                            c.Fecha = (DateTime)rdr["Fecha"];
                            c.Total = (decimal) rdr["Total"];
                            c.Compras = (decimal) rdr["Compras"];
                            c.IdUsuario = (int) rdr["IdUsuario"];
                            c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                        }
                    }
                }
            }
            return c;
        }


        public static long Update(Recaudacion model)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Recaudacion_Update", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdRecaudacion", SqlDbType.BigInt) { Value = model.IdRecaudacion };
                    var p1 = new SqlParameter("Fecha", SqlDbType.Date) { Value = model.Fecha };
                    var p2 = new SqlParameter("Total", SqlDbType.Decimal) { Value = model.Total };
                    var p3 = new SqlParameter("Compras", SqlDbType.Decimal) { Value = model.Compras };
                    var p4 = new SqlParameter("IdUsuario", SqlDbType.Int) { Value = model.IdUsuario };
                    var p5 = new SqlParameter("Notas", SqlDbType.VarChar) { Value = model.Notas };

                    cmd.Parameters.Add(p0);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);
                    cmd.Parameters.Add(p4);
                    cmd.Parameters.Add(p5);

                    conn.Open();
                    model.IdRecaudacion = (long)cmd.ExecuteScalar();
                }
            }
            return model.IdRecaudacion;
        }


        public static bool Delete(Recaudacion model)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Recaudacion_Delete", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdRecaudacion", SqlDbType.BigInt) { Value = model.IdRecaudacion };

                    cmd.Parameters.Add(p0);

                    conn.Open();
                    model.IdRecaudacion = (int)cmd.ExecuteScalar();
                    return true;
                }
            }
        }
    }
}