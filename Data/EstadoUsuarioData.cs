using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace Data
{
    public class EstadoUsuarioData
    {
        public static List<EstadoUsuarioView> GetAll()
        {
            var list = new List<EstadoUsuarioView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("EstadoUsuario_GetAll", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new EstadoUsuarioView {
                                IdEstadoUsuario = (int)rdr["IdEstadoUsuario"],
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


        public static int Insert(EstadoUsuario c)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("EstadoUsuario_Insert", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdEstadoUsuario", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = c.Descripcion };

                    cmd.Parameters.Add(p0);
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    c.IdEstadoUsuario = (int)p0.Value;
                }
            }
            return c.IdEstadoUsuario;
        }


        public static EstadoUsuario GetByPrimaryKey(int idEstadoUsuario)
        {
            var c = new EstadoUsuario();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("EstadoUsuario_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdEstadoUsuario", SqlDbType.Int) { Value = idEstadoUsuario };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            c.IdEstadoUsuario = (int)rdr["IdEstadoUsuario"];
                            c.Descripcion = (string)rdr["Descripcion"];
                            c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                        }
                    }
                }
            }
            return c;
        }
    }
}