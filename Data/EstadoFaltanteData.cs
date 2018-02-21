using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;
using Model.View;

namespace Data
{
    public class EstadoFaltanteData
    {
        public static List<EstadoFaltanteView> GetAll()
        {
            var list = new List<EstadoFaltanteView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("EstadoFaltante_GetAll", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new EstadoFaltanteView {
                                IdEstadoFaltante = (int)rdr["IdEstadoFaltante"],
                                Descripcion = (string)rdr["Descripcion"],
                                Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : ""
                            };
                            list.Add(p);
                        }
                    }
                }
                return list;
            }
        }


        public static List<EstadoFaltanteView> SearchByParameters(string descripcion)
        {
            var list = new List<EstadoFaltanteView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("EstadoFaltante_GetByParameters", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = descripcion };

                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new EstadoFaltanteView {
                                IdEstadoFaltante = (int)rdr["IdEstadoFaltante"],
                                Descripcion = (string)rdr["Descripcion"],
                                Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : ""
                            };
                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }


        public static int Insert(EstadoFaltante m)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("EstadoFaltante_Insert", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //var p0 = new SqlParameter("IdEstadoFaltante", SqlDbType.Int) {Direction = ParameterDirection.Output};
                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = m.Descripcion };
                    var p2 = new SqlParameter("Notas", SqlDbType.VarChar) { Value = m.Notas };

                    //cmd.Parameters.Add(p0);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);

                    conn.Open();
                    m.IdEstadoFaltante = (int)cmd.ExecuteScalar();
                }
            }

            return m.IdEstadoFaltante;
        }


        public static EstadoFaltante GetByPrimaryKey(int idEstadoFaltante)
        {
            var c = new EstadoFaltante();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("EstadoFaltante_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdEstadoFaltante", SqlDbType.Int) { Value = idEstadoFaltante };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            c.IdEstadoFaltante = (int)rdr["IdEstadoFaltante"];
                            c.Descripcion = (string)rdr["Descripcion"];
                            c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                        }
                    }
                }
            }

            return c;
        }


        public static EstadoFaltanteView GetByPrimaryKeyView(int idEstadoFaltante)
        {
            var c = new EstadoFaltanteView();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("EstadoFaltante_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdEstadoFaltante", SqlDbType.Int) { Value = idEstadoFaltante };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            c.IdEstadoFaltante = (int)rdr["IdEstadoFaltante"];
                            c.Descripcion = (string)rdr["Descripcion"];
                            c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                        }
                    }
                }
            }
            return c;
        }


        public static int Update(EstadoFaltante model)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("EstadoFaltante_Update", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdEstadoFaltante", SqlDbType.VarChar) { Value = model.IdEstadoFaltante };
                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = model.Descripcion };
                    var p2 = new SqlParameter("Notas", SqlDbType.VarChar) { Value = model.Notas };

                    cmd.Parameters.Add(p0);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);

                    conn.Open();
                    model.IdEstadoFaltante = (int)cmd.ExecuteScalar();
                }
            }

            return model.IdEstadoFaltante;
        }


        public static bool Delete(EstadoFaltante model)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("EstadoFaltante_Delete", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdEstadoFaltante", SqlDbType.Int) { Value = model.IdEstadoFaltante };

                    cmd.Parameters.Add(p0);

                    conn.Open();
                    model.IdEstadoFaltante = (int)cmd.ExecuteScalar();
                    return true;
                }
            }
        }
    }
}