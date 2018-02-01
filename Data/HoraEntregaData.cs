using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace Data
{
    public class HoraEntregaData
    {
        public static List<HoraEntregaView> GetAll()
        {
            var list = new List<HoraEntregaView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("HoraEntrega_GetAll", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new HoraEntregaView {
                                IdHoraEntrega = (int)rdr["IdHoraEntrega"],
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



        public static int Insert(HoraEntrega c)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("HoraEntrega_Insert", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdHoraEntrega", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = c.Descripcion };

                    cmd.Parameters.Add(p0);
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    c.IdHoraEntrega = (int)p0.Value;
                }
            }
            return c.IdHoraEntrega;
        }


        public static HoraEntrega GetByPrimaryKey(int idHoraEntrega)
        {
            var c = new HoraEntrega();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("HoraEntrega_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdHoraEntrega", SqlDbType.Int) { Value = idHoraEntrega };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            c.IdHoraEntrega = (int)rdr["IdHoraEntrega"];
                            c.Descripcion = (string)rdr["Descripcion"];
                            c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                        }
                    }
                }
            }
            return c;
        }

        public static bool Delete(HoraEntrega o)
        {
            throw new NotImplementedException();
        }

        public static void Update(HoraEntrega o)
        {
            throw new NotImplementedException();
        }
    }
}