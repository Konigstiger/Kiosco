using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;
using Model.View;

namespace Data
{
    public class EstadoPedidoData
    {
        public static List<EstadoPedidoView> GetAll()
        {
            var list = new List<EstadoPedidoView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("EstadoPedido_GetAll", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new EstadoPedidoView {
                                IdEstadoPedido = (int)rdr["IdEstadoPedido"],
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


        public static List<EstadoPedidoView> SearchByParameters(string descripcion)
        {
            var list = new List<EstadoPedidoView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("EstadoPedido_GetByParameters", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = descripcion };

                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new EstadoPedidoView {
                                IdEstadoPedido = (int)rdr["IdEstadoPedido"],
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


        public static int Insert(EstadoPedido m)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("EstadoPedido_Insert", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //var p0 = new SqlParameter("IdEstadoPedido", SqlDbType.Int) {Direction = ParameterDirection.Output};
                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = m.Descripcion };
                    var p2 = new SqlParameter("Notas", SqlDbType.VarChar) { Value = m.Notas };

                    //cmd.Parameters.Add(p0);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);

                    conn.Open();

                    m.IdEstadoPedido = (int)cmd.ExecuteScalar();
                }
            }
            return m.IdEstadoPedido;
        }


        public static EstadoPedido GetByPrimaryKey(int idEstadoPedido)
        {
            var c = new EstadoPedido();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("EstadoPedido_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdEstadoPedido", SqlDbType.Int) { Value = idEstadoPedido };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            c.IdEstadoPedido = (int)rdr["IdEstadoPedido"];
                            c.Descripcion = (string)rdr["Descripcion"];
                            c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                        }
                    }
                }
            }
            return c;
        }


        public static EstadoPedidoView GetByPrimaryKeyView(int idEstadoPedido)
        {
            var c = new EstadoPedidoView();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("EstadoPedido_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdEstadoPedido", SqlDbType.Int) { Value = idEstadoPedido };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {

                        while (rdr.Read()) {
                            c.IdEstadoPedido = (int)rdr["IdEstadoPedido"];
                            c.Descripcion = (string)rdr["Descripcion"];
                            c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                        }
                    }
                }
            }
            return c;
        }


        public static int Update(EstadoPedido model)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("EstadoPedido_Update", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdEstadoPedido", SqlDbType.VarChar) { Value = model.IdEstadoPedido };
                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = model.Descripcion };
                    var p2 = new SqlParameter("Notas", SqlDbType.VarChar) { Value = model.Notas };

                    cmd.Parameters.Add(p0);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);

                    conn.Open();
                    model.IdEstadoPedido = (int)cmd.ExecuteScalar();
                }
            }
            return model.IdEstadoPedido;
        }


        public static bool Delete(EstadoPedido model)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("EstadoPedido_Delete", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdEstadoPedido", SqlDbType.Int) { Value = model.IdEstadoPedido };

                    cmd.Parameters.Add(p0);

                    conn.Open();
                    model.IdEstadoPedido = (int)cmd.ExecuteScalar();
                    return true;
                }
            }
        }
    }
}