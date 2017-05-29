using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace Data
{
    public class PedidoDetalleData
    {
        public static List<PedidoDetalleView> GetAll()
        {
            var list = new List<PedidoDetalleView>();
            var conn = new SqlConnection(GeneralData.CadenaConexion);
            SqlDataReader rdr = null;

            var cmd = new SqlCommand("PedidoDetalle_GetAll", conn) { CommandType = CommandType.StoredProcedure };

            try {
                conn.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    var p = new PedidoDetalleView {
                        IdPedidoDetalle = (long)rdr["IdPedidoDetalle"],
                        IdPedido = (long)rdr["IdProducto"],
                        IdProducto = (long)rdr["IdProducto"],
                        Cantidad = (int)rdr["Cantidad"],
                        Importe = (int)rdr["Importe"],
                        IdUnidad = rdr["IdUnidad"] != DBNull.Value ? (int)rdr["IdUnidad"] : 1,
                        Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : ""
                    };

                    list.Add(p);
                }
            }
            finally {
                rdr?.Close();
                conn.Close();
            }
            return list;
        }


        public static List<PedidoDetalleView> SearchByParameters(string descripcion)
        {
            var list = new List<PedidoDetalleView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("PedidoDetalle_GetByParameters", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = descripcion };

                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new PedidoDetalleView {
                                IdPedidoDetalle = (long)rdr["IdPedidoDetalle"],
                                IdPedido = (long)rdr["IdProducto"],
                                IdProducto = (long)rdr["IdProducto"],
                                Cantidad = (int)rdr["Cantidad"],
                                Importe = (int)rdr["Importe"],
                                IdUnidad = rdr["IdUnidad"] != DBNull.Value ? (int)rdr["IdUnidad"] : 1,
                                Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : ""
                            };
                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }


        public static long Insert(PedidoDetalle m)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("PedidoDetalle_Insert", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //var p0 = new SqlParameter("IdPedidoDetalle", SqlDbType.BigInt) {Direction = ParameterDirection.Output};
                    var p1 = new SqlParameter("IdPedido", SqlDbType.BigInt) { Value = m.IdPedido };
                    var p2 = new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = m.IdProducto };
                    var p3 = new SqlParameter("Cantidad", SqlDbType.Int) { Value = m.Cantidad };
                    var p4 = new SqlParameter("Importe", SqlDbType.Decimal) { Value = m.Importe };
                    var p5 = new SqlParameter("IdUnidad", SqlDbType.Int) { Value = m.IdUnidad };
                    var p6 = new SqlParameter("Notas", SqlDbType.VarChar) { Value = m.Notas };

                    //cmd.Parameters.Add(p0);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);
                    cmd.Parameters.Add(p4);
                    cmd.Parameters.Add(p5);
                    cmd.Parameters.Add(p6);

                    conn.Open();
                    m.IdPedidoDetalle = (long)cmd.ExecuteScalar();

                }
            }
            return m.IdPedidoDetalle;
        }


        public static PedidoDetalle GetByPrimaryKey(long idPedidoDetalle)
        {
            var c = new PedidoDetalle();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("PedidoDetalle_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdPedidoDetalle", SqlDbType.Int) { Value = idPedidoDetalle };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {

                        while (rdr.Read()) {
                            c.IdPedidoDetalle = (long)rdr["IdPedidoDetalle"];
                            c.IdPedido = (long)rdr["IdProducto"];
                            c.IdProducto = (long)rdr["IdProducto"];
                            c.Cantidad = (int)rdr["Cantidad"];
                            c.Importe = (decimal)rdr["Importe"];
                            c.IdUnidad = rdr["IdUnidad"] != DBNull.Value ? (int)rdr["IdUnidad"] : 1;
                            //c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                        }
                    }
                }
            }
            return c;
        }


        public static PedidoDetalleView GetByPrimaryKeyView(long idPedidoDetalle)
        {
            var c = new PedidoDetalleView();

            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("PedidoDetalle_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdPedidoDetalle", SqlDbType.Int) { Value = idPedidoDetalle };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {

                        while (rdr.Read()) {
                            c = new PedidoDetalleView {
                                IdPedidoDetalle = (long)rdr["IdPedidoDetalle"],
                                IdPedido = (long)rdr["IdProducto"],
                                IdProducto = (long)rdr["IdProducto"],
                                Cantidad = (int)rdr["Cantidad"],
                                Importe = (int)rdr["Importe"],
                                IdUnidad = rdr["IdUnidad"] != DBNull.Value ? (int)rdr["IdUnidad"] : 1,
                                Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : ""
                            };
                        }
                    }
                }
            }
            return c;
        }

        public static long Update(PedidoDetalle model)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("PedidoDetalle_Update", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdPedidoDetalle", SqlDbType.BigInt) { Value = model.IdPedidoDetalle };
                    var p1 = new SqlParameter("IdPedido", SqlDbType.BigInt) { Value = model.IdPedido };
                    var p2 = new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = model.IdProducto };
                    var p3 = new SqlParameter("Cantidad", SqlDbType.Int) { Value = model.Cantidad };
                    var p4 = new SqlParameter("Importe", SqlDbType.Decimal) { Value = model.Importe };
                    var p5 = new SqlParameter("IdUnidad", SqlDbType.Int) { Value = model.IdUnidad };
                    var p6 = new SqlParameter("Notas", SqlDbType.VarChar) { Value = model.Notas };

                    cmd.Parameters.Add(p0);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);
                    cmd.Parameters.Add(p4);
                    cmd.Parameters.Add(p5);
                    cmd.Parameters.Add(p6);

                    conn.Open();
                    model.IdPedidoDetalle = (long)cmd.ExecuteScalar();
                }

            }
            return model.IdPedidoDetalle;
        }


        public static bool Delete(PedidoDetalle model)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("PedidoDetalle_Delete", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdPedidoDetalle", SqlDbType.Int) { Value = model.IdPedidoDetalle };

                    cmd.Parameters.Add(p0);

                    try {
                        conn.Open();
                        model.IdPedidoDetalle = (long)cmd.ExecuteScalar();
                        return true;
                    }
                    catch {
                        return false;
                    }
                    finally {
                        conn.Close();
                    }
                }
            }
        }

        public static List<PedidoDetalleView> GetByIdPedido(long idPedido)
        {
            var list = new List<PedidoDetalleView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("PedidoDetalleView_GetByIdPedido", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdPedido", SqlDbType.BigInt) { Value = idPedido };

                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new PedidoDetalleView
                            {
                                IdPedidoDetalle = (long) rdr["IdPedidoDetalle"],
                                IdProducto = (long) rdr["IdProducto"],
                                Producto = (string) rdr["Producto"],
                                Cantidad = (int) rdr["Cantidad"],
                                Importe = (decimal) rdr["Importe"],
                                Unidad = (string) rdr["Unidad"],
                                Notas = rdr["Notas"] != DBNull.Value ? (string) rdr["Notas"] : ""
                            };
                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }
    }
}