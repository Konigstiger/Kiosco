using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;
using Model.View;

namespace Data
{
    public class UnidadData
    {
        public static List<UnidadView> GetAll()
        {
            var list = new List<UnidadView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Unidad_GetAll", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new UnidadView {
                                IdUnidad = (int)rdr["IdUnidad"],
                                Descripcion = (string)rdr["Descripcion"],
                                Simbolo = (string)rdr["Simbolo"],
                                Unidades = rdr["Unidades"] != DBNull.Value ? (int)rdr["Unidades"] : 1
                            };
                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }


        public static int Insert(Unidad c)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Unidad_Insert", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdUnidad", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = c.Descripcion };
                    var p2 = new SqlParameter("Simbolo", SqlDbType.VarChar) { Value = c.Simbolo };
                    var p3 = new SqlParameter("Unidades", SqlDbType.Int) { Value = c.Unidades };

                    cmd.Parameters.Add(p0);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    c.IdUnidad = (int)p0.Value;
                }
            }
            return c.IdUnidad;
        }


        public static Unidad GetByPrimaryKey(int idUnidad)
        {
            var c = new Unidad();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Unidad_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdUnidad", SqlDbType.Int) { Value = idUnidad };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            c.IdUnidad = (int)rdr["IdUnidad"];
                            c.Descripcion = (string)rdr["Descripcion"];
                            c.Simbolo = rdr["Simbolo"] != DBNull.Value ? (string)rdr["Simbolo"] : "";
                            c.Unidades = rdr["Unidades"] != DBNull.Value ? (int)rdr["Unidades"] : 1;
                        }
                    }
                }
            }
            return c;
        }


        public static int Update(Unidad model)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Unidad_Update", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdUnidad", SqlDbType.Int) { Value = model.IdUnidad };
                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = model.Descripcion };
                    var p2 = new SqlParameter("Simbolo", SqlDbType.VarChar) { Value = model.Simbolo };
                    var p3 = new SqlParameter("Unidades", SqlDbType.VarChar) { Value = model.Unidades };

                    cmd.Parameters.Add(p0);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);

                    conn.Open();
                    model.IdUnidad = (int)cmd.ExecuteScalar();
                }
            }
            return model.IdUnidad;
        }


    }

}