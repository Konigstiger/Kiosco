using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;
using Model.View;

namespace Data
{
    public class DepositoData
    {
        public static List<DepositoView> GetAll()
        {
            var list = new List<DepositoView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Deposito_GetAll", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new DepositoView {
                                IdDeposito = (int)rdr["IdDeposito"],
                                Descripcion = (string)rdr["Descripcion"],
                                Direccion = rdr["Direccion"] != DBNull.Value ? (string)rdr["Direccion"] : "",
                                IdPuntoVenta = (int)rdr["IdPuntoVenta"],
                                Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : ""
                            };
                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }


        public static List<DepositoView> SearchByParameters(string nombre)
        {
            var list = new List<DepositoView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Deposito_SearchByParameters", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("nombre", SqlDbType.VarChar) { Value = nombre };

                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new DepositoView {
                                IdDeposito = (int)rdr["IdDeposito"],
                                Descripcion = (string)rdr["Descripcion"],
                                Direccion = rdr["Direccion"] != DBNull.Value ? (string)rdr["Direccion"] : "",
                                IdPuntoVenta = (int)rdr["IdPuntoVenta"],
                                Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : ""
                            };

                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }


        public static int Insert(Deposito c)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Deposito_Insert", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdDeposito", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = c.Descripcion };
                    var p2 = new SqlParameter("Direccion", SqlDbType.VarChar) { Value = c.Direccion };
                    var p3 = new SqlParameter("IdPuntoVenta", SqlDbType.Int) { Value = c.IdPuntoVenta };

                    cmd.Parameters.Add(p0);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);

                    conn.Open();

                    cmd.ExecuteNonQuery();
                    c.IdDeposito = (int)p0.Value;
                }
            }
            return c.IdDeposito;
        }


        public static Deposito GetByPrimaryKey(int idDeposito)
        {
            var c = new Deposito();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Deposito_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdDeposito", SqlDbType.Int) { Value = idDeposito };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            c.IdDeposito = (int)rdr["IdDeposito"];
                            c.Descripcion = (string)rdr["Descripcion"];
                            c.Direccion = rdr["Direccion"] != DBNull.Value ? (string)rdr["Direccion"] : "";
                            c.IdPuntoVenta = (int)rdr["PuntoVenta"];
                            c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                        }
                    }
                }
            }
            return c;
        }

        /*
            public static void Update(Canal c)
            {
            }
        */

        /*
            public static bool Delete(Canal c)
            {
            }
        */
    }
}