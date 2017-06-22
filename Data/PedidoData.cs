using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace Data
{
    public class PedidoData
    {
        public static List<PedidoView> GetAll()
        {
            var list = new List<PedidoView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Pedido_GetAll", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new PedidoView {
                                IdPedido = (long)rdr["IdPedido"],
                                Descripcion = (string)rdr["Descripcion"],
                                IdProveedor = (int)rdr["IdProveedor"],
                                Fecha = rdr["Fecha"] != DBNull.Value ? (DateTime)rdr["Fecha"] : DateTime.Today,
                                FechaEntrega = rdr["FechaEntrega"] != DBNull.Value ? (DateTime)rdr["FechaEntrega"] : DateTime.MinValue,
                                Total = rdr["Total"] != DBNull.Value ? (decimal)rdr["Total"] : 0,
                                Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : ""
                            };

                            list.Add(p);
                        }
                    }
                }

                return list;
            }
        }


        public static List<PedidoView> GetByParameters(string descripcion)
        {
            var list = new List<PedidoView>();

            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Pedido_View_GetByParameters", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = descripcion };

                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new PedidoView {
                                IdPedido = (long)rdr["IdPedido"],
                                Proveedor = (string)rdr["Proveedor"],
                                Descripcion = (string)rdr["Descripcion"],
                                Fecha = (DateTime)rdr["Fecha"],
                                FechaEntrega = rdr["FechaEntrega"] != DBNull.Value ? (DateTime)rdr["FechaEntrega"] : DateTime.MinValue,
                                Estado = (string)rdr["Estado"],
                                Total = (decimal)rdr["Total"]
                                ,IdEstadoPedido = (int)rdr["IdEstadoPedido"]
                            };
                            list.Add(p);
                        }
                    }
                }
            }

            return list;
        }


        public static long Insert(Pedido m)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Pedido_Insert", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //var p0 = new SqlParameter("IdPedido", SqlDbType.BigInt) {Direction = ParameterDirection.Output};
                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = m.Descripcion };
                    var p2 = new SqlParameter("IdProveedor", SqlDbType.Int) { Value = m.IdProveedor };
                    var p3 = new SqlParameter("Fecha", SqlDbType.Date) { Value = m.Fecha };
                    var p4 = new SqlParameter("IdEstadoPedido", SqlDbType.Int) { Value = m.IdEstadoPedido };
                    var p5 = new SqlParameter("FechaEntrega", SqlDbType.Date) { Value = m.FechaEntrega };
                    var p6 = new SqlParameter("HoraEntrega", SqlDbType.Time) { Value = m.HoraEntrega }; // esto deberia ser 1,2,3, mañana tarde noche.
                    var p7 = new SqlParameter("Total", SqlDbType.Decimal) { Value = m.Total };

                    //cmd.Parameters.Add(p0);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);
                    cmd.Parameters.Add(p4);
                    cmd.Parameters.Add(p5);
                    cmd.Parameters.Add(p6);
                    cmd.Parameters.Add(p7);

                    conn.Open();
                    m.IdPedido = (long)cmd.ExecuteScalar();
                }
            }
            return m.IdPedido;
        }


        public static Pedido GetByPrimaryKey(long idPedido)
        {
            var c = new Pedido();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Pedido_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdPedido", SqlDbType.Int) { Value = idPedido };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            c.IdPedido = (long)rdr["IdPedido"];
                            c.Descripcion = (string)rdr["Descripcion"];
                            c.IdProveedor = (int)rdr["IdProveedor"];
                            c.IdEstadoPedido = (int)rdr["IdEstadoPedido"];
                            c.Fecha = rdr["Fecha"] != DBNull.Value ? (DateTime)rdr["Fecha"] : DateTime.Today;
                            c.FechaEntrega = rdr["FechaEntrega"] != DBNull.Value ? (DateTime)rdr["FechaEntrega"] : DateTime.Today;
                            c.HoraEntrega = rdr["HoraEntrega"] != DBNull.Value ? (DateTime)rdr["HoraEntrega"] : DateTime.Today;
                            c.Total = rdr["Total"] != DBNull.Value ? (decimal)rdr["Total"] : 0;
                            c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                        }
                    }
                }

            }
            return c;
        }


        public static PedidoView GetByPrimaryKeyView(long idPedido)
        {
            var c = new PedidoView();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                var cmd = new SqlCommand("Pedido_GetByPrimaryKey", conn) { CommandType = CommandType.StoredProcedure };

                var p1 = new SqlParameter("IdPedido", SqlDbType.Int) { Value = idPedido };
                cmd.Parameters.Add(p1);

                conn.Open();
                var rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    c.IdPedido = (long)rdr["IdPedido"];
                    c.Descripcion = (string)rdr["Descripcion"];
                    c.IdProveedor = (int)rdr["IdProveedor"];
                    c.Fecha = rdr["Fecha"] != DBNull.Value ? (DateTime)rdr["Fecha"] : DateTime.Today;
                    c.IdEstadoPedido = (int)rdr["IdEstadoPedido"];
                    c.FechaEntrega = rdr["FechaEntrega"] != DBNull.Value ? (DateTime)rdr["FechaEntrega"] : DateTime.Today;
                    c.Total = rdr["Total"] != DBNull.Value ? (decimal)rdr["Total"] : 0;
                    c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                }

            }

            return c;
        }

        public static long Update(Pedido model)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Pedido_Update", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdPedido", SqlDbType.BigInt) { Value = model.IdPedido };
                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = model.Descripcion };
                    var p2 = new SqlParameter("IdProveedor", SqlDbType.Int) { Value = model.IdProveedor };
                    var p3 = new SqlParameter("Fecha", SqlDbType.Date) { Value = model.Fecha };
                    var p4 = new SqlParameter("IdEstadoPedido", SqlDbType.Int) { Value = model.IdEstadoPedido };
                    var p5 = new SqlParameter("FechaEntrega", SqlDbType.Date) { Value = model.FechaEntrega };
                    // var p6 = new SqlParameter("HoraEntrega", SqlDbType.Time) { Value = model.HoraEntrega };
                    var p7 = new SqlParameter("Total", SqlDbType.Decimal) { Value = model.Total };
                    var p8 = new SqlParameter("Notas", SqlDbType.VarChar) { Value = model.Notas };

                    cmd.Parameters.Add(p0);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);
                    cmd.Parameters.Add(p4);
                    cmd.Parameters.Add(p5);
                    // cmd.Parameters.Add(p6);
                    cmd.Parameters.Add(p7);
                    cmd.Parameters.Add(p8);

                    conn.Open();
                    model.IdPedido = (long)cmd.ExecuteScalar();


                }
            }
            return model.IdPedido;
        }


        public static bool Delete(Pedido model)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Pedido_Delete", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdPedido", SqlDbType.Int) { Value = model.IdPedido };

                    cmd.Parameters.Add(p0);

                    conn.Open();
                    model.IdPedido = (int)cmd.ExecuteScalar();
                    return true;
                }
            }
        }
    }
}