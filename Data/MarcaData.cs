using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace Data
{
    public class MarcaData
    {
        public static List<MarcaView> GetAll()
        {
            var list = new List<MarcaView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Marca_GetAll", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new MarcaView {
                                IdMarca = (int)rdr["IdMarca"],
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


        public static List<MarcaView> SearchByParameters(string descripcion)
        {
            var list = new List<MarcaView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Marca_GetByParameters", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = descripcion };

                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new MarcaView {
                                IdMarca = (int)rdr["IdMarca"],
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


        public static int Insert(Marca m)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Marca_Insert", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //var p0 = new SqlParameter("IdMarca", SqlDbType.Int) {Direction = ParameterDirection.Output};
                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = m.Descripcion };
                    var p2 = new SqlParameter("Notas", SqlDbType.VarChar) { Value = m.Notas };

                    //cmd.Parameters.Add(p0);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);

                    conn.Open();
                    m.IdMarca = (int)cmd.ExecuteScalar();
                }
            }

            return m.IdMarca;
        }


        public static Marca GetByPrimaryKey(int idMarca)
        {
            var c = new Marca();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Marca_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdMarca", SqlDbType.Int) { Value = idMarca };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            c.IdMarca = (int)rdr["IdMarca"];
                            c.Descripcion = (string)rdr["Descripcion"];
                            c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                        }
                    }
                }
            }

            return c;
        }


        public static MarcaView GetByPrimaryKeyView(int idMarca)
        {
            var c = new MarcaView();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Marca_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdMarca", SqlDbType.Int) { Value = idMarca };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            c.IdMarca = (int)rdr["IdMarca"];
                            c.Descripcion = (string)rdr["Descripcion"];
                            c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                        }
                    }
                }
            }
            return c;
        }


        public static int Update(Marca model)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Marca_Update", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdMarca", SqlDbType.VarChar) { Value = model.IdMarca };
                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = model.Descripcion };
                    var p2 = new SqlParameter("Notas", SqlDbType.VarChar) { Value = model.Notas };

                    cmd.Parameters.Add(p0);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);

                    conn.Open();
                    model.IdMarca = (int)cmd.ExecuteScalar();
                }
            }

            return model.IdMarca;
        }


        public static bool Delete(Marca model)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Marca_Delete", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdMarca", SqlDbType.Int) { Value = model.IdMarca };

                    cmd.Parameters.Add(p0);

                    conn.Open();
                    model.IdMarca = (int)cmd.ExecuteScalar();
                    return true;
                }
            }
        }
    }
}