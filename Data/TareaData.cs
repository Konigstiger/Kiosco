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
                            p.IdTarea = (long) rdr["IdTarea"];
                            p.Descripcion = (string) rdr["Descripcion"];
                            p.IdEstadoTarea = (int) rdr["IdEstadoTarea"];
                            p.Detalle = rdr["Detalle"] != DBNull.Value ? (string) rdr["Detalle"] : string.Empty;
                            p.Fecha = rdr["Fecha"] != DBNull.Value ? (DateTime) rdr["Fecha"] : DateTime.Today;
                            p.FechaVencimiento = rdr["FechaVencimiento"] != DBNull.Value
                                ? (DateTime) rdr["FechaVencimiento"]
                                : DateTime.Today;
                            p.PorcentajeCompleto = (int) rdr["PorcentajeCompleto"];
                            p.Notas = rdr["Notas"] != DBNull.Value ? (string) rdr["Notas"] : string.Empty;
                            p.IdClaseTarea = (int) rdr["IdClaseTarea"];
                            p.IdPrioridad = (int) rdr["IdPrioridad"];
                            p.IdDificultad = (int) rdr["IdDificultad"];
                            p.IdUsuario = (int) rdr["IdUsuario"];
                            p.IdTareaPadre = (long) rdr["IdTareaPadre"];

                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }



        public static long Insert(Tarea c)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Tarea_Insert", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdTarea", SqlDbType.BigInt) { Direction = ParameterDirection.Output };
                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = c.Descripcion };

                    cmd.Parameters.Add(p0);
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    c.IdTarea = (int)p0.Value;
                }
            }
            return c.IdTarea;
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
                            c.Detalle = (string)rdr["Detalle"];
                            c.PorcentajeCompleto = (int) rdr["PorcentajeCompleto"];
                            c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                            c.IdClaseTarea = (int)rdr["IdClaseTarea"];
                            c.IdPrioridad= (int)rdr["IdPrioridad"];
                            c.IdDificultad= (int)rdr["IdDificultad"];
                            c.IdUsuario = (int)rdr["IdUsuario"];
                            c.IdTareaPadre = (long)rdr["IdTareaPadre"];

                            //TODO: importante. Agregar aqui los demas campos. Modificar sql. Y el resto.
                            //all of them!


                        }
                    }
                }
            }
            return c;
        }

        public static bool Delete(Tarea tarea)
        {
            throw new NotImplementedException();
        }

        public static void Update(Tarea tarea)
        {
            throw new NotImplementedException();
        }
    }
}