using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;
using Model.View;

namespace Data
{
    public class ClaseFaltanteData
    {
        public static List<ClaseFaltanteView> GetAll()
        {
            var list = new List<ClaseFaltanteView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("ClaseFaltante_GetAll", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new ClaseFaltanteView {
                                IdClaseFaltante = (int)rdr["IdClaseFaltante"],
                                Descripcion = (string)rdr["Descripcion"]
                            };
                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }
        

        public static int Insert(ClaseFaltante c)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("ClaseFaltante_Insert", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdClaseFaltante", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = c.Descripcion };

                    cmd.Parameters.Add(p0);
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    c.IdClaseFaltante = (int)p0.Value;
                }
            }
            return c.IdClaseFaltante;
        }


        public static ClaseFaltante GetByPrimaryKey(int idClaseFaltante)
        {
            var c = new ClaseFaltante();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("ClaseFaltante_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdClaseFaltante", SqlDbType.Int) { Value = idClaseFaltante };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            c.IdClaseFaltante = (int)rdr["IdClaseFaltante"];
                            c.Descripcion = (string)rdr["Descripcion"];
                            c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                        }
                    }
                }
            }
            return c;
        }

        public static void Update(ClaseFaltante model)
        {
            throw new NotImplementedException();
        }

        public static bool Delete(ClaseFaltante model)
        {
            throw new NotImplementedException();
        }
    }
}