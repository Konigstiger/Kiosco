using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;
using Model.View;

namespace Data
{
    public class GastoData
    {
        public static List<GastoView> GetAll()
        {
            var list = new List<GastoView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Gasto_GetAll", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new GastoView();
                            p.IdGasto = (long)rdr["IdGasto"];
                            p.Descripcion = (string)rdr["Descripcion"];
                            p.Monto = (decimal)rdr["Monto"];
                            p.MontoPendiente = (decimal)rdr["Monto"];
                            p.IdEstadoGasto = (int)rdr["IdEstadoGasto"];
                            p.IdClaseGasto = (int)rdr["IdClaseGasto"];
                            p.FechaVencimiento = rdr["FechaVencimiento"] != DBNull.Value ? (DateTime)rdr["FechaVencimiento"] : DateTime.Today;
                            p.FechaPago = rdr["FechaPago"] != DBNull.Value
                                ? (DateTime)rdr["FechaPago"]
                                : (DateTime?)null;
                            p.IdPrioridad = (int)rdr["IdPrioridad"];
                            p.Archivado = rdr["Archivado"] != DBNull.Value ? (bool)rdr["Archivado"] : false;
                            p.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : string.Empty;

                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }


        public static List<GastoView> GetAllView()
        {
            var list = new List<GastoView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Gasto_View_GetAll", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new GastoView {
                                IdGasto = (long)rdr["IdGasto"],
                                Descripcion = (string)rdr["Descripcion"],
                                Monto = (decimal)rdr["Monto"],
                                FechaPago = rdr["FechaPago"] != DBNull.Value ? (DateTime)rdr["FechaPago"] : DateTime.Today,
                                FechaVencimiento = rdr["FechaVencimiento"] != DBNull.Value ? (DateTime)rdr["FechaVencimiento"] : DateTime.Today,
                                Estado = (string)rdr["Estado"],
                                Clase = (string)rdr["Clase"],
                                Prioridad = (string)rdr["Prioridad"]
                            };
                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }


        public static long Insert(Gasto m)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Gasto_Insert", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //TODO: Esto aqui abajo es ideal para parametrizar en una funcion utilitaria.
                    //Value = m.IdGasto > 0 && m.IdGasto != null ? (object)m.IdGasto : DBNull.Value

                    //var p0 = new SqlParameter("IdGasto", SqlDbType.BigInt) { Value = m.IdGasto };
                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = m.Descripcion };
                    //var p2 = new SqlParameter("IdGasto", SqlDbType.BigInt) { Value = (long?)(condicion ? DBNull.Value : (object)m.IdGasto) };
                    var p2 = new SqlParameter("Monto", SqlDbType.Decimal) { Value = m.Monto };
                    var p3 = new SqlParameter("MontoPendiente", SqlDbType.Decimal) { Value = m.MontoPendiente };
                    var p4 = new SqlParameter("IdEstadoGasto", SqlDbType.Int) { Value = m.IdEstadoGasto };
                    var p5 = new SqlParameter("IdClaseGasto", SqlDbType.Int) { Value = m.IdClaseGasto };
                    var p6 = new SqlParameter("FechaVencimiento", SqlDbType.DateTime) { Value = m.FechaVencimiento };
                    var p7 = new SqlParameter("FechaPago", SqlDbType.DateTime) { Value = m.FechaPago };
                    var p8 = new SqlParameter("IdPrioridad", SqlDbType.Int) { Value = m.IdPrioridad };
                    var p9 = new SqlParameter("Archivado", SqlDbType.Bit) { Value = m.Archivado };
                    var p10 = new SqlParameter("Notas", SqlDbType.VarChar) { Value = m.Notas };

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

                    conn.Open();
                    m.IdGasto = (long)cmd.ExecuteScalar();
                }
            }
            return m.IdGasto;
        }


        public static Gasto GetByPrimaryKey(long idGasto)
        {
            var model = new Gasto();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Gasto_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdGasto", SqlDbType.BigInt) { Value = idGasto };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            model.IdGasto = (long)rdr["IdGasto"];
                            model.Descripcion = (string)rdr["Descripcion"];
                            model.Monto = (decimal)rdr["Monto"];
                            model.MontoPendiente = (decimal)rdr["Monto"];
                            model.IdEstadoGasto = (int)rdr["IdEstadoGasto"];
                            model.IdClaseGasto = (int)rdr["IdClaseGasto"];
                            model.FechaVencimiento = rdr["FechaVencimiento"] != DBNull.Value ? (DateTime)rdr["FechaVencimiento"] : DateTime.Today;
                            model.FechaPago = rdr["FechaPago"] != DBNull.Value ? (DateTime)rdr["FechaPago"] : (DateTime?)null;
                            model.IdPrioridad = (int)rdr["IdPrioridad"];
                            model.Archivado = rdr["Archivado"] != DBNull.Value ? (bool)rdr["Archivado"] : false;
                            model.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : string.Empty;
                        }
                    }
                }
            }
            return model;
        }


        public static GastoView GetByPrimaryKeyView(long idGasto)
        {
            var model = new GastoView();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Gasto_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdGasto", SqlDbType.BigInt) { Value = idGasto };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            model.IdGasto = (long)rdr["IdGasto"];
                            model.Descripcion = (string)rdr["Descripcion"];
                            model.Monto = (decimal)rdr["Monto"];
                            model.FechaVencimiento = rdr["FechaVencimiento"] != DBNull.Value
                                ? (DateTime)rdr["FechaVencimiento"]
                                : DateTime.Today;
                            model.Estado = (string)rdr["Estado"];
                            model.Clase = (string)rdr["Clase"];
                            model.Prioridad = (string)rdr["Prioridad"];
                        }
                    }
                }
            }
            return model;
        }


        public static bool Delete(Gasto model)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Gasto_Delete", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdGasto", SqlDbType.BigInt) { Value = model.IdGasto };

                    cmd.Parameters.Add(p0);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
        }


        public static void Update(Gasto m)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Gasto_Update", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdGasto", SqlDbType.BigInt) { Value = m.IdGasto };
                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = m.Descripcion };
                    var p2 = new SqlParameter("Monto", SqlDbType.Decimal) { Value = m.Monto };
                    var p3 = new SqlParameter("MontoPendiente", SqlDbType.Decimal) { Value = m.MontoPendiente };
                    var p4 = new SqlParameter("IdEstadoGasto", SqlDbType.Int) { Value = m.IdEstadoGasto };
                    var p5 = new SqlParameter("IdClaseGasto", SqlDbType.Int) { Value = m.IdClaseGasto };
                    var p6 = new SqlParameter("FechaVencimiento", SqlDbType.DateTime) { Value = m.FechaVencimiento };
                    var p7 = new SqlParameter("FechaPago", SqlDbType.DateTime) { Value = m.FechaPago };
                    var p8 = new SqlParameter("IdPrioridad", SqlDbType.Int) { Value = m.IdPrioridad };
                    var p9 = new SqlParameter("Archivado", SqlDbType.Bit) { Value = m.Archivado };
                    var p10 = new SqlParameter("Notas", SqlDbType.VarChar) { Value = m.Notas };


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

                    conn.Open();
                    cmd.ExecuteNonQuery();

                }
            }
            //return m.IdGasto;
        }
    }
}