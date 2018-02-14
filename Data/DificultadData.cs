using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;
using Model.View;

namespace Data
{
    public class DificultadData
    {
        public static List<DificultadView> GetAll()
        {
            var list = new List<DificultadView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Dificultad_GetAll", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new DificultadView {
                                IdDificultad = (int)rdr["IdDificultad"],
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



        public static int Insert(Dificultad c)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Dificultad_Insert", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdDificultad", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = c.Descripcion };
                    var p2 = new SqlParameter("Notas", SqlDbType.VarChar) { Value = c.Notas };

                    cmd.Parameters.Add(p0);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    c.IdDificultad = (int)p0.Value;
                }
            }
            return c.IdDificultad;
        }


        public static Dificultad GetByPrimaryKey(int idDificultad)
        {
            var c = new Dificultad();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Dificultad_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdDificultad", SqlDbType.Int) { Value = idDificultad };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            c.IdDificultad = (int)rdr["IdDificultad"];
                            c.Descripcion = (string)rdr["Descripcion"];
                            c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                        }
                    }
                }
            }
            return c;
        }

        public static bool Delete(Dificultad o)
        {
            throw new NotImplementedException();
        }

        public static void Update(Dificultad o)
        {
            throw new NotImplementedException();
        }
    }
}