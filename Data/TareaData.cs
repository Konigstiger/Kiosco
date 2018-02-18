using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;
using Model.View;

namespace Data
{
    public class TareaData
    {
        public static List<TareaView> GetAll()
        {
            var list = new List<TareaView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Tarea_GetAll", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new TareaView();
                            p.IdTarea = (long)rdr["IdTarea"];
                            p.Descripcion = (string)rdr["Descripcion"];
                            p.IdEstadoTarea = (int)rdr["IdEstadoTarea"];
                            p.Detalle = rdr["Detalle"] != DBNull.Value ? (string)rdr["Detalle"] : string.Empty;
                            p.Fecha = rdr["Fecha"] != DBNull.Value ? (DateTime)rdr["Fecha"] : DateTime.Today;
                            p.FechaVencimiento = rdr["FechaVencimiento"] != DBNull.Value
                                ? (DateTime)rdr["FechaVencimiento"]
                                : DateTime.Today;
                            p.PorcentajeCompleto = (int)rdr["PorcentajeCompleto"];
                            p.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : string.Empty;
                            p.IdClaseTarea = (int)rdr["IdClaseTarea"];
                            p.IdPrioridad = (int)rdr["IdPrioridad"];
                            p.IdDificultad = (int)rdr["IdDificultad"];
                            p.IdUsuario = (int)rdr["IdUsuario"];
                            p.IdTareaPadre = rdr["IdTareaPadre"] != DBNull.Value ? (long)rdr["IdTareaPadre"] : 0;

                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }


        public static long Insert(Tarea m)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Tarea_Insert", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //var p0 = new SqlParameter("IdTarea", SqlDbType.BigInt) { Direction = ParameterDirection.Output };
                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = m.Descripcion };
                    var p2 = new SqlParameter("IdPrioridad", SqlDbType.Int) { Value = m.IdPrioridad };
                    var p3 = new SqlParameter("Fecha", SqlDbType.DateTime) { Value = m.Fecha };
                    var p4 = new SqlParameter("FechaVencimiento", SqlDbType.DateTime) { Value = m.FechaVencimiento };
                    var p5 = new SqlParameter("IdEstadoTarea", SqlDbType.Int) { Value = m.IdEstadoTarea };
                    var p6 = new SqlParameter("IdDificultad", SqlDbType.Int) { Value = m.IdDificultad };
                    var p7 = new SqlParameter("IdClaseTarea", SqlDbType.Int) { Value = m.IdClaseTarea };
                    var p8 = new SqlParameter("IdUsuario", SqlDbType.Int) { Value = m.IdUsuario };
                    var p9 = new SqlParameter("PorcentajeCompleto", SqlDbType.Int) { Value = m.PorcentajeCompleto };
                    var p10 = new SqlParameter("Detalle", SqlDbType.VarChar) { Value = m.Detalle };
                    var p11 = new SqlParameter("Archivado", SqlDbType.Bit) { Value = m.Archivado };
                    var p12 = new SqlParameter("IdTareaPadre", SqlDbType.BigInt) { Value = m.IdTareaPadre != 0 ? (object)m.IdTareaPadre : DBNull.Value };
                    var p13 = new SqlParameter("Notas", SqlDbType.VarChar) { Value = m.Notas };

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
                    cmd.Parameters.Add(p11);
                    cmd.Parameters.Add(p12);
                    cmd.Parameters.Add(p13);

                    conn.Open();
                    m.IdTarea = (long)cmd.ExecuteScalar();
                }
            }
            return m.IdTarea;
        }


        public static Tarea GetByPrimaryKey(long idTarea)
        {
            var c = new Tarea();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Tarea_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdTarea", SqlDbType.BigInt) { Value = idTarea };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            c.IdTarea = (long)rdr["IdTarea"];
                            c.Descripcion = (string)rdr["Descripcion"];
                            c.IdEstadoTarea = (int)rdr["IdEstadoTarea"];
                            c.Fecha = rdr["Fecha"] != DBNull.Value ? (DateTime)rdr["Fecha"] : DateTime.Today;
                            c.FechaVencimiento = rdr["FechaVencimiento"] != DBNull.Value ? (DateTime)rdr["FechaVencimiento"] : DateTime.Today;
                            c.Detalle = rdr["Detalle"] != DBNull.Value ? (string)rdr["Detalle"] : string.Empty;
                            c.PorcentajeCompleto = (int)rdr["PorcentajeCompleto"];
                            c.IdClaseTarea = (int)rdr["IdClaseTarea"];
                            c.IdPrioridad = (int)rdr["IdPrioridad"];
                            c.IdDificultad = (int)rdr["IdDificultad"];
                            c.IdUsuario = (int)rdr["IdUsuario"];
                            c.IdTareaPadre = rdr["IdTareaPadre"] != DBNull.Value ? (long)rdr["IdTareaPadre"] : 0;
                            c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : string.Empty;
                        }
                    }
                }
            }
            return c;
        }


        public static TareaView GetByPrimaryKeyView(long idTarea)
        {
            var c = new TareaView();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Tarea_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdTarea", SqlDbType.BigInt) { Value = idTarea };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            c.IdTarea = (long)rdr["IdTarea"];
                            c.Descripcion = (string)rdr["Descripcion"];
                            c.IdEstadoTarea = (int)rdr["IdEstadoTarea"];
                            c.Fecha = rdr["Fecha"] != DBNull.Value ? (DateTime)rdr["Fecha"] : DateTime.Today;
                            c.FechaVencimiento = rdr["FechaVencimiento"] != DBNull.Value ? (DateTime)rdr["FechaVencimiento"] : DateTime.Today;
                            c.Detalle = rdr["Detalle"] != DBNull.Value ? (string)rdr["Detalle"] : string.Empty;
                            c.PorcentajeCompleto = (int)rdr["PorcentajeCompleto"];
                            c.IdClaseTarea = (int)rdr["IdClaseTarea"];
                            c.IdPrioridad = (int)rdr["IdPrioridad"];
                            c.IdDificultad = (int)rdr["IdDificultad"];
                            c.IdUsuario = (int)rdr["IdUsuario"];
                            c.IdTareaPadre = rdr["IdTareaPadre"] != DBNull.Value ? (long)rdr["IdTareaPadre"] : 0;
                            c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : string.Empty;
                        }
                    }
                }
            }
            return c;
        }


        public static bool Delete(Tarea model)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Tarea_Delete", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdTarea", SqlDbType.BigInt) { Value = model.IdTarea };

                    cmd.Parameters.Add(p0);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
        }


        public static void Update(Tarea m)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Tarea_Update", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdTarea", SqlDbType.BigInt) { Value = m.IdTarea };
                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = m.Descripcion };
                    var p2 = new SqlParameter("IdPrioridad", SqlDbType.Int) { Value = m.IdPrioridad };
                    var p3 = new SqlParameter("Fecha", SqlDbType.DateTime) { Value = m.Fecha };
                    var p4 = new SqlParameter("FechaVencimiento", SqlDbType.DateTime) { Value = m.FechaVencimiento };
                    var p5 = new SqlParameter("IdEstadoTarea", SqlDbType.Int) { Value = m.IdEstadoTarea };
                    var p6 = new SqlParameter("IdDificultad", SqlDbType.Int) { Value = m.IdDificultad };
                    var p7 = new SqlParameter("IdClaseTarea", SqlDbType.Int) { Value = m.IdClaseTarea };
                    var p8 = new SqlParameter("IdUsuario", SqlDbType.Int) { Value = m.IdUsuario };
                    var p9 = new SqlParameter("PorcentajeCompleto", SqlDbType.Int) { Value = m.PorcentajeCompleto };
                    var p10 = new SqlParameter("Detalle", SqlDbType.VarChar) { Value = m.Detalle };
                    var p11 = new SqlParameter("Archivado", SqlDbType.Bit) { Value = m.Archivado };
                    var p12 = new SqlParameter("IdTareaPadre", SqlDbType.BigInt) { Value = m.IdTareaPadre != 0 ? (object) m.IdTareaPadre : DBNull.Value };
                    var p13 = new SqlParameter("Notas", SqlDbType.VarChar) { Value = m.Notas };


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
                    cmd.Parameters.Add(p11);
                    cmd.Parameters.Add(p12);
                    cmd.Parameters.Add(p13);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                }
            }
            //return m.IdTarea;
        }
    }
}