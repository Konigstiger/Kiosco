using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;
using Model.View;

namespace Data
{
    public class ClienteData
    {
        public static List<ClienteView> GetAll()
        {
            var list = new List<ClienteView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Cliente_GetAll", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new ClienteView {
                                IdCliente = (long)rdr["IdCliente"],
                                Descripcion = (string)rdr["Descripcion"],
                                Apellido = rdr["Apellido"] != DBNull.Value ? (string)rdr["Apellido"] : "",
                                Nombre = rdr["Nombre"] != DBNull.Value ? (string)rdr["Nombre"] : "",
                                Direccion = rdr["Direccion"] != DBNull.Value ? (string)rdr["Direccion"] : "",
                                Telefono = rdr["Telefono"] != DBNull.Value ? (string)rdr["Telefono"] : "",
                                Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : ""
                            };
                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }


        public static Cliente GetByPrimaryKey(long idCliente)
        {
            var c = new Cliente();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Cliente_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdCliente", SqlDbType.BigInt) { Value = idCliente };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            c.IdCliente = (long)rdr["IdCliente"];
                            c.Descripcion = (string)rdr["Descripcion"];
                            c.Apellido = rdr["Apellido"] != DBNull.Value ? (string)rdr["Apellido"] : "";
                            c.Nombre = rdr["Nombre"] != DBNull.Value ? (string)rdr["Nombre"] : "";
                            c.Direccion = rdr["Direccion"] != DBNull.Value ? (string)rdr["Direccion"] : "";
                            c.Telefono = rdr["Telefono"] != DBNull.Value ? (string)rdr["Telefono"] : "";
                            c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                        }
                    }
                }
            }
            return c;
        }


        public static List<ClienteView> GetAll_GetByDescripcion(string descripcion)
        {
            var list = new List<ClienteView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Cliente_GetByDescripcion", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = descripcion };

                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new ClienteView {
                                IdCliente = (long)rdr["IdCliente"],
                                Descripcion = (string)rdr["Descripcion"],
                                Apellido = rdr["Apellido"] != DBNull.Value ? (string)rdr["Apellido"] : "",
                                Nombre = rdr["Nombre"] != DBNull.Value ? (string)rdr["Nombre"] : "",
                                Direccion = rdr["Direccion"] != DBNull.Value ? (string)rdr["Direccion"] : "",
                                Telefono = rdr["Telefono"] != DBNull.Value ? (string)rdr["Telefono"] : "",
                                Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : ""
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