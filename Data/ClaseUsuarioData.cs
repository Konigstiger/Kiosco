using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace Data
{
    public class ClaseUsuarioData
    {
        public static List<ClaseUsuarioView> GetAll()
        {
            var list = new List<ClaseUsuarioView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("ClaseUsuario_GetAll", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new ClaseUsuarioView {
                                IdClaseUsuario = (int)rdr["IdClaseUsuario"],
                                Descripcion = (string)rdr["Descripcion"]
                            };
                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }
        

        public static int Insert(ClaseUsuario c)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("ClaseUsuario_Insert", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdClaseUsuario", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = c.Descripcion };

                    cmd.Parameters.Add(p0);
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    c.IdClaseUsuario = (int)p0.Value;
                }
            }
            return c.IdClaseUsuario;
        }


        public static ClaseUsuario GetByPrimaryKey(int idClaseUsuario)
        {
            var c = new ClaseUsuario();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("ClaseUsuario_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdClaseUsuario", SqlDbType.Int) { Value = idClaseUsuario };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            c.IdClaseUsuario = (int)rdr["IdClaseUsuario"];
                            c.Descripcion = (string)rdr["Descripcion"];
                            c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                        }
                    }
                }
            }
            return c;
        }

        public static void Update(ClaseUsuario ClaseUsuario)
        {
            throw new NotImplementedException();
        }

        public static bool Delete(ClaseUsuario ClaseUsuario)
        {
            throw new NotImplementedException();
        }
    }
}