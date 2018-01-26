using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace Data
{
    public class UsuarioData
    {
        public static List<UsuarioView> GetAll()
        {
            var list = new List<UsuarioView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Usuario_GetAll", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new UsuarioView {
                                IdUsuario = (int)rdr["IdUsuario"],
                                Descripcion = rdr["Descripcion"] != DBNull.Value ? (string)rdr["Descripcion"] : "",
                                Usr = (string)rdr["Usr"],
                                Pwd = (string)rdr["Pwd"],
                                Apellido = rdr["Apellido"] != DBNull.Value ? (string)rdr["Apellido"] : "",
                                Nombre = rdr["Nombre"] != DBNull.Value ? (string)rdr["Nombre"] : "",
                                Telefono = rdr["Telefono"] != DBNull.Value ? (string)rdr["Telefono"] : "",
                                Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "",
                                ClaseUsuario = rdr["ClaseUsuario"] != DBNull.Value ? (string)rdr["ClaseUsuario"] : "",
                                EstadoUsuario = rdr["EstadoUsuario"] != DBNull.Value ? (string)rdr["EstadoUsuario"] : ""
                            };
                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }


        public static int Insert(Usuario c)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Usuario_Insert", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdUsuario", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = c.Descripcion };
                    var p2 = new SqlParameter("Usr", SqlDbType.VarChar) { Value = c.Usr };
                    var p3 = new SqlParameter("Pwd", SqlDbType.VarChar) { Value = c.Pwd };
                    var p4 = new SqlParameter("Apellido", SqlDbType.VarChar) { Value = c.Apellido };
                    var p5 = new SqlParameter("Nombre", SqlDbType.VarChar) { Value = c.Nombre };
                    var p6 = new SqlParameter("Telefono", SqlDbType.VarChar) { Value = c.Telefono };
                    var p7 = new SqlParameter("Notas", SqlDbType.VarChar) { Value = c.Notas };
                    var p8 = new SqlParameter("IdClaseUsuario", SqlDbType.Int) { Value = c.IdClaseUsuario };

                    cmd.Parameters.Add(p0);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);
                    cmd.Parameters.Add(p4);
                    cmd.Parameters.Add(p5);
                    cmd.Parameters.Add(p6);
                    cmd.Parameters.Add(p7);
                    cmd.Parameters.Add(p8);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    c.IdUsuario = (int)p0.Value;
                }
            }
            return c.IdUsuario;
        }



        public static void Update(Usuario u)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Usuario_Update", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdUsuario", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = u.Descripcion };
                    var p2 = new SqlParameter("Usr", SqlDbType.VarChar) { Value = u.Usr };
                    var p3 = new SqlParameter("Pwd", SqlDbType.VarChar) { Value = u.Pwd };
                    var p4 = new SqlParameter("Apellido", SqlDbType.VarChar) { Value = u.Apellido };
                    var p5 = new SqlParameter("Nombre", SqlDbType.VarChar) { Value = u.Nombre };
                    var p6 = new SqlParameter("Telefono", SqlDbType.VarChar) { Value = u.Telefono };
                    var p7 = new SqlParameter("Notas", SqlDbType.VarChar) { Value = u.Notas };
                    var p8 = new SqlParameter("IdClaseUsuario", SqlDbType.Int) { Value = u.IdClaseUsuario };

                    cmd.Parameters.Add(p0);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);
                    cmd.Parameters.Add(p4);
                    cmd.Parameters.Add(p5);
                    cmd.Parameters.Add(p6);
                    cmd.Parameters.Add(p7);
                    cmd.Parameters.Add(p8);

                    conn.Open();
                    u.IdUsuario = (int)cmd.ExecuteScalar();
                }
            }

            //return u.IdUsuario;
        }

        public static Usuario GetByPrimaryKey(Usuario u)
        {
            var c = new Usuario();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Usuario_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdUsuario", SqlDbType.Int) { Value = u.IdUsuario };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            c.IdUsuario = (int)rdr["IdUsuario"];
                            c.Descripcion = rdr["Descripcion"] != DBNull.Value ? (string)rdr["Descripcion"] : "";
                            c.Usr = (string)rdr["Usr"];
                            c.Pwd = (string)rdr["Pwd"];
                            c.Apellido = rdr["Apellido"] != DBNull.Value ? (string)rdr["Apellido"] : "";
                            c.Nombre = rdr["Nombre"] != DBNull.Value ? (string)rdr["Nombre"] : "";
                            c.Telefono = rdr["Telefono"] != DBNull.Value ? (string)rdr["Telefono"] : "";
                            c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                        }
                    }
                }
            }
            return c;
        }




        public static bool Delete(Usuario u)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Usuario_Delete", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdUsuario", SqlDbType.Int) { Value = u.IdUsuario };

                    cmd.Parameters.Add(p0);

                    conn.Open();
                    u.IdUsuario = (int)cmd.ExecuteScalar();
                    return true;
                }
            }
        }

        public static Usuario GetByUsr(Usuario u)
        {
            var c = new Usuario();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Usuario_GetByUsr", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("Usr", SqlDbType.VarChar) { Value = u.Usr};
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            c.IdUsuario = (int)rdr["IdUsuario"];
                            c.Descripcion = rdr["Descripcion"] != DBNull.Value ? (string)rdr["Descripcion"] : "";
                            c.Usr = (string)rdr["Usr"];
                            c.Pwd = (string)rdr["Pwd"];
                            c.Apellido = rdr["Apellido"] != DBNull.Value ? (string)rdr["Apellido"] : "";
                            c.Nombre = rdr["Nombre"] != DBNull.Value ? (string)rdr["Nombre"] : "";
                            c.Telefono = rdr["Telefono"] != DBNull.Value ? (string)rdr["Telefono"] : "";
                            c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                            c.IdClaseUsuario = (int)rdr["IdClaseUsuario"];
                        }
                    }
                }
            }
            return c;
        }

        public static List<UsuarioView> GetAll_ByUsr()
        {
            throw new NotImplementedException();
        }

        public static UsuarioView GetByPrimaryKeyView(Usuario u)
        {
            var c = new UsuarioView();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Usuario_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdUsuario", SqlDbType.Int) { Value = u.IdUsuario };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            c.IdUsuario = (int)rdr["IdUsuario"];
                            c.Descripcion = rdr["Descripcion"] != DBNull.Value ? (string)rdr["Descripcion"] : "";
                            c.Usr = (string)rdr["Usr"];
                            c.Pwd = (string)rdr["Pwd"];
                            c.Apellido = rdr["Apellido"] != DBNull.Value ? (string)rdr["Apellido"] : "";
                            c.Nombre = rdr["Nombre"] != DBNull.Value ? (string)rdr["Nombre"] : "";
                            c.Telefono = rdr["Telefono"] != DBNull.Value ? (string)rdr["Telefono"] : "";
                            c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                        }
                    }
                }
            }
            return c;
        }
    }
}