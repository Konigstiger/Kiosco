using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;
using Model.View;

namespace Data
{
    public class FaltanteData
    {
        public static List<FaltanteView> GetAll()
        {
            var list = new List<FaltanteView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Faltante_GetAll", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new FaltanteView();
                            p.IdFaltante = (long)rdr["IdFaltante"];
                            p.Descripcion = (string)rdr["Descripcion"];
                            p.IdProducto = rdr["IdProducto"] != DBNull.Value ? (long)rdr["IdProducto"] : (long?)null;
                            p.Cantidad = (int)rdr["Cantidad"];
                            p.IdEstadoFaltante = (int)rdr["IdEstadoFaltante"];
                            p.IdClaseFaltante = (int)rdr["IdClaseFaltante"];
                            p.EstadoFaltante = rdr["Estado"] != DBNull.Value ? (string)rdr["Estado"] : string.Empty;
                            p.Fecha = rdr["Fecha"] != DBNull.Value ? (DateTime)rdr["Fecha"] : DateTime.Today;
                            p.FechaResuelto = rdr["FechaResuelto"] != DBNull.Value
                                ? (DateTime)rdr["FechaResuelto"]
                                : (DateTime?)null;
                            p.Archivado = rdr["Archivado"] != DBNull.Value ? (bool)rdr["Archivado"] : false;
                            p.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : string.Empty;

                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }


        public static long Insert(Faltante m)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Faltante_Insert", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //TODO: Esto aqui abajo es ideal para parametrizar en una funcion utilitaria.
                    //Value = m.IdProducto > 0 && m.IdProducto != null ? (object)m.IdProducto : DBNull.Value

                    //var p0 = new SqlParameter("IdFaltante", SqlDbType.BigInt) { Value = m.IdFaltante };
                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = m.Descripcion };
                    //var p2 = new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = (long?)(condicion ? DBNull.Value : (object)m.IdProducto) };
                    var p2 = new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = m.IdProducto > 0 && m.IdProducto!=null ? (object)m.IdProducto : DBNull.Value };
                    var p3 = new SqlParameter("Cantidad", SqlDbType.Int) { Value = m.Cantidad };
                    var p4 = new SqlParameter("IdEstadoFaltante", SqlDbType.Int) { Value = m.IdEstadoFaltante };
                    var p5 = new SqlParameter("IdClaseFaltante", SqlDbType.Int) { Value = m.IdClaseFaltante };
                    var p6 = new SqlParameter("Fecha", SqlDbType.DateTime) { Value = m.Fecha };
                    var p7 = new SqlParameter("FechaResuelto", SqlDbType.DateTime) { Value = m.FechaResuelto };
                    var p8 = new SqlParameter("Archivado", SqlDbType.Bit) { Value = m.Archivado };
                    var p9 = new SqlParameter("Notas", SqlDbType.VarChar) { Value = m.Notas };

                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);
                    cmd.Parameters.Add(p4);
                    cmd.Parameters.Add(p5);
                    cmd.Parameters.Add(p6);
                    cmd.Parameters.Add(p7);
                    cmd.Parameters.Add(p8);
                    cmd.Parameters.Add(p9);

                    conn.Open();
                    m.IdFaltante = (long)cmd.ExecuteScalar();
                }
            }
            return m.IdFaltante;
        }


        public static Faltante GetByPrimaryKey(long idFaltante)
        {
            var model = new Faltante();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Faltante_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdFaltante", SqlDbType.BigInt) { Value = idFaltante };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            model.IdFaltante = (long)rdr["IdFaltante"];
                            model.Descripcion = (string)rdr["Descripcion"];
                            model.IdProducto = rdr["IdProducto"] != DBNull.Value ? (long)rdr["IdProducto"] : (long?)null;
                            model.Cantidad = (int)rdr["Cantidad"];
                            model.IdEstadoFaltante = (int)rdr["IdEstadoFaltante"];
                            model.IdClaseFaltante = (int)rdr["IdClaseFaltante"];
                            model.Fecha = rdr["Fecha"] != DBNull.Value ? (DateTime)rdr["Fecha"] : DateTime.Today;
                            model.FechaResuelto = rdr["FechaResuelto"] != DBNull.Value
                                ? (DateTime)rdr["FechaResuelto"]
                                : (DateTime?)null;
                            model.Archivado = rdr["Archivado"] != DBNull.Value ? (bool)rdr["Archivado"] : false;
                            model.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : string.Empty;
                        }
                    }
                }
            }
            return model;
        }


        public static FaltanteView GetByPrimaryKeyView(long idFaltante)
        {
            var model = new FaltanteView();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Faltante_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdFaltante", SqlDbType.BigInt) { Value = idFaltante };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            model.IdFaltante = (long)rdr["IdFaltante"];
                            model.Descripcion = (string)rdr["Descripcion"];
                            model.IdProducto = rdr["IdProducto"] != DBNull.Value ? (long)rdr["IdProducto"] : (long?)null;
                            model.Cantidad = (int)rdr["Cantidad"];
                            model.IdEstadoFaltante = (int)rdr["IdEstadoFaltante"];
                            model.IdClaseFaltante = (int)rdr["IdClaseFaltante"];
                            model.Fecha = rdr["Fecha"] != DBNull.Value ? (DateTime)rdr["Fecha"] : DateTime.Today;
                            model.FechaResuelto = rdr["FechaResuelto"] != DBNull.Value
                                ? (DateTime)rdr["FechaResuelto"]
                                : (DateTime?)null;
                            model.Archivado = rdr["Archivado"] != DBNull.Value ? (bool)rdr["Archivado"] : false;
                            model.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : string.Empty;
                        }
                    }
                }
            }
            return model;
        }


        public static bool Delete(Faltante model)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Faltante_Delete", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdFaltante", SqlDbType.BigInt) { Value = model.IdFaltante };

                    cmd.Parameters.Add(p0);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
        }


        public static void Update(Faltante m)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Faltante_Update", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdFaltante", SqlDbType.BigInt) { Value = m.IdFaltante };
                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = m.Descripcion };
                    //var p2 = new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = m.IdProducto };
                    var p2 = new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = m.IdProducto > 0 && m.IdProducto != null ? (object)m.IdProducto : DBNull.Value };
                    var p3 = new SqlParameter("Cantidad", SqlDbType.Int) { Value = m.Cantidad };
                    var p4 = new SqlParameter("IdEstadoFaltante", SqlDbType.Int) { Value = m.IdEstadoFaltante };
                    var p5 = new SqlParameter("IdClaseFaltante", SqlDbType.Int) { Value = m.IdClaseFaltante };
                    var p6 = new SqlParameter("Fecha", SqlDbType.DateTime) { Value = m.Fecha };
                    var p7 = new SqlParameter("FechaResuelto", SqlDbType.DateTime) { Value = m.FechaResuelto };
                    var p8 = new SqlParameter("Archivado", SqlDbType.Bit) { Value = m.Archivado };
                    var p9 = new SqlParameter("Notas", SqlDbType.VarChar) { Value = m.Notas };


                    cmd.Parameters.Add(p0);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);
                    cmd.Parameters.Add(p4);
                    cmd.Parameters.Add(p5);
                    cmd.Parameters.Add(p6);
                    cmd.Parameters.Add(p7);
                    cmd.Parameters.Add(p8);
                    cmd.Parameters.Add(p9);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                }
            }
            //return m.IdFaltante;
        }
    }
}