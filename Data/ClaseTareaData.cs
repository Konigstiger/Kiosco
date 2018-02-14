using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;
using Model.View;

namespace Data
{
    public class ClaseTareaData
    {
        public static List<ClaseTareaView> GetAll()
        {
            var list = new List<ClaseTareaView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("ClaseTarea_GetAll", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new ClaseTareaView {
                                IdClaseTarea = (int)rdr["IdClaseTarea"],
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



        public static int Insert(ClaseTarea c)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("ClaseTarea_Insert", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdClaseTarea", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = c.Descripcion };
                    var p2 = new SqlParameter("Notas", SqlDbType.VarChar) { Value = c.Notas };

                    cmd.Parameters.Add(p0);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    c.IdClaseTarea = (int)p0.Value;
                }
            }
            return c.IdClaseTarea;
        }


        public static ClaseTarea GetByPrimaryKey(int idClaseTarea)
        {
            var c = new ClaseTarea();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("ClaseTarea_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdClaseTarea", SqlDbType.Int) { Value = idClaseTarea };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            c.IdClaseTarea = (int)rdr["IdClaseTarea"];
                            c.Descripcion = (string)rdr["Descripcion"];
                            c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                        }
                    }
                }
            }
            return c;
        }

        public static bool Delete(ClaseTarea o)
        {
            throw new NotImplementedException();
        }

        public static void Update(ClaseTarea o)
        {
            throw new NotImplementedException();
        }
    }
}