using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace Data
{
    public class TurnoData
    {
        public static List<TurnoView> GetAll()
        {
            var list = new List<TurnoView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Turno_GetAll", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new TurnoView {
                                IdTurno = (int)rdr["IdTurno"],
                                Descripcion = (string)rdr["Descripcion"],
                                Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : ""
                            };
                            list.Add(p);
                        }
                    }
                }
                return list;
            }
        }


        public static List<TurnoView> SearchByParameters(string descripcion)
        {
            var list = new List<TurnoView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Turno_GetByParameters", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = descripcion };

                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new TurnoView {
                                IdTurno = (int)rdr["IdTurno"],
                                Descripcion = (string)rdr["Descripcion"],
                                Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : ""
                            };
                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }


        public static long Insert(Turno m)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Turno_Insert", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdTurno", SqlDbType.BigInt) { Direction = ParameterDirection.Output };
                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = m.Descripcion };
                    var p2 = new SqlParameter("Fecha", SqlDbType.Date) { Value = m.Fecha };
                    var p3 = new SqlParameter("HoraInicio", SqlDbType.Time) { Value = m.HoraInicio };
                    var p4 = new SqlParameter("HoraFin", SqlDbType.Time) { Value = m.HoraFin };
                    var p5 = new SqlParameter("CantidadHoras", SqlDbType.Decimal) { Value = m.CantidadHoras };
                    var p6 = new SqlParameter("IdPagoEmpleado", SqlDbType.BigInt) { Value = m.IdPagoEmpleado };
                    var p7 = new SqlParameter("Monto", SqlDbType.Decimal) { Value = m.Monto };
                    var p8 = new SqlParameter("Notas", SqlDbType.VarChar) { Value = m.Notas };

                    cmd.Parameters.Add(p0);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);
                    cmd.Parameters.Add(p4);
                    cmd.Parameters.Add(p5);
                    cmd.Parameters.Add(p6);
                    cmd.Parameters.Add(p7);
                    cmd.Parameters.Add(p8);

                    conn.Open();
                    m.IdTurno = (int)cmd.ExecuteScalar();
                }
            }

            return m.IdTurno;
        }


        public static Turno GetByPrimaryKey(int idTurno)
        {
            var c = new Turno();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Turno_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdTurno", SqlDbType.Int) { Value = idTurno };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            c.IdTurno = (int)rdr["IdTurno"];
                            c.Descripcion = (string)rdr["Descripcion"];
                            c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                        }
                    }
                }
            }

            return c;
        }


        public static TurnoView GetByPrimaryKeyView(int idTurno)
        {
            var c = new TurnoView();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Turno_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdTurno", SqlDbType.Int) { Value = idTurno };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            c.IdTurno = (int)rdr["IdTurno"];
                            c.Descripcion = (string)rdr["Descripcion"];
                            c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                        }
                    }
                }
            }
            return c;
        }


        public static long Update(Turno model)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Turno_Update", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdTurno", SqlDbType.VarChar) { Value = model.IdTurno };
                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = model.Descripcion };
                    var p2 = new SqlParameter("Fecha", SqlDbType.Date) { Value = model.Fecha };
                    var p3 = new SqlParameter("HoraInicio", SqlDbType.Time) { Value = model.HoraInicio };
                    var p4 = new SqlParameter("HoraFin", SqlDbType.Time) { Value = model.HoraFin };
                    var p5 = new SqlParameter("CantidadHoras", SqlDbType.Decimal) { Value = model.CantidadHoras };
                    var p6 = new SqlParameter("IdPagoEmpleado", SqlDbType.BigInt) { Value = model.IdPagoEmpleado };
                    var p7 = new SqlParameter("Monto", SqlDbType.Decimal ) { Value = model.Monto };
                    var p8 = new SqlParameter("Notas", SqlDbType.VarChar) { Value = model.Notas };

                    cmd.Parameters.Add(p0);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);
                    cmd.Parameters.Add(p4);
                    cmd.Parameters.Add(p5);
                    cmd.Parameters.Add(p6);
                    cmd.Parameters.Add(p7);
                    cmd.Parameters.Add(p8);

                    conn.Open();
                    model.IdTurno = (long)cmd.ExecuteScalar();
                }
            }

            return model.IdTurno;
        }


        public static bool Delete(Turno model)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Turno_Delete", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdTurno", SqlDbType.Int) { Value = model.IdTurno };

                    cmd.Parameters.Add(p0);

                    conn.Open();
                    cmd.ExecuteScalar();
                    return true;
                }
            }
        }
    }
}