using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;
using Model.View;

namespace Data
{
    public class EstadoTareaData
    {
        public static List<EstadoTareaView> GetAll()
        {
            var list = new List<EstadoTareaView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("EstadoTarea_GetAll", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new EstadoTareaView {
                                IdEstadoTarea = (int)rdr["IdEstadoTarea"],
                                Descripcion = (string)rdr["Descripcion"]
                            };
                            // Obtener los resultados de cada columna
                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }



        public static int Insert(EstadoTarea c)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("EstadoTarea_Insert", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdEstadoTarea", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = c.Descripcion };
                    var p2 = new SqlParameter("Notas", SqlDbType.VarChar) { Value = c.Notas };

                    cmd.Parameters.Add(p0);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    c.IdEstadoTarea = (int)p0.Value;
                }
            }
            return c.IdEstadoTarea;
        }


        public static EstadoTarea GetByPrimaryKey(int idEstadoTarea)
        {
            var c = new EstadoTarea();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("EstadoTarea_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdEstadoTarea", SqlDbType.Int) { Value = idEstadoTarea };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            c.IdEstadoTarea = (int)rdr["IdEstadoTarea"];
                            c.Descripcion = (string)rdr["Descripcion"];
                            c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                        }
                    }
                }
            }
            return c;
        }

        public static bool Delete(EstadoTarea o)
        {
            throw new NotImplementedException();
        }

        public static void Update(EstadoTarea o)
        {
            throw new NotImplementedException();
        }
    }
}