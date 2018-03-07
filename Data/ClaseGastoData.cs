using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;
using Model.View;

namespace Data
{
    public class ClaseGastoData
    {
        public static List<ClaseGastoView> GetAll()
        {
            var list = new List<ClaseGastoView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("ClaseGasto_GetAll", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new ClaseGastoView {
                                IdClaseGasto = (int)rdr["IdClaseGasto"],
                                Descripcion = (string)rdr["Descripcion"]
                            };
                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }
        

        public static int Insert(ClaseGasto c)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("ClaseGasto_Insert", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdClaseGasto", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = c.Descripcion };

                    cmd.Parameters.Add(p0);
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    c.IdClaseGasto = (int)p0.Value;
                }
            }
            return c.IdClaseGasto;
        }


        public static ClaseGasto GetByPrimaryKey(int idClaseGasto)
        {
            var c = new ClaseGasto();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("ClaseGasto_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdClaseGasto", SqlDbType.Int) { Value = idClaseGasto };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            c.IdClaseGasto = (int)rdr["IdClaseGasto"];
                            c.Descripcion = (string)rdr["Descripcion"];
                            c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                        }
                    }
                }
            }
            return c;
        }

        public static void Update(ClaseGasto model)
        {
            throw new NotImplementedException();
        }

        public static bool Delete(ClaseGasto model)
        {
            throw new NotImplementedException();
        }
    }
}