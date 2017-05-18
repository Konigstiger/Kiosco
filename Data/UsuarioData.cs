﻿using System;
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

            var conn = new SqlConnection(GeneralData.CadenaConexion);
            SqlDataReader rdr = null;

            var cmd = new SqlCommand("Usuario_GetAll", conn) { CommandType = CommandType.StoredProcedure };

            try {
                conn.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    var p = new UsuarioView {
                        IdUsuario = (int)rdr["IdUsuario"],
                        Descripcion = rdr["Descripcion"] != DBNull.Value ? (string)rdr["Descripcion"] : "",
                        Usr = (string)rdr["Usr"],
                        Pwd = (string)rdr["Pwd"],
                        Apellido = rdr["Apellido"] != DBNull.Value ? (string)rdr["Apellido"] : "",
                        Nombre = rdr["Nombre"] != DBNull.Value ? (string)rdr["Nombre"] : "",
                        Telefono = rdr["Telefono"] != DBNull.Value ? (string)rdr["Telefono"] : "",
                        Direccion = rdr["Direccion"] != DBNull.Value ? (string)rdr["Direccion"] : "",
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


        public static int Insert(Usuario c)
        {
            var conn = new SqlConnection(GeneralData.CadenaConexion);

            var cmd = new SqlCommand("Usuario_Insert", conn) { CommandType = CommandType.StoredProcedure };

            var p0 = new SqlParameter("IdUsuario", SqlDbType.Int) { Direction = ParameterDirection.Output };
            var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = c.Descripcion };
            var p2 = new SqlParameter("Usr", SqlDbType.VarChar) { Value = c.Usr };
            var p3 = new SqlParameter("Pwd", SqlDbType.VarChar) { Value = c.Pwd };
            var p4 = new SqlParameter("Apellido", SqlDbType.VarChar) { Value = c.Apellido };
            var p5 = new SqlParameter("Nombre", SqlDbType.VarChar) { Value = c.Nombre };
            var p6 = new SqlParameter("Telefono", SqlDbType.VarChar) { Value = c.Telefono };
            var p7 = new SqlParameter("Direccion", SqlDbType.VarChar) { Value = c.Direccion };
            var p8 = new SqlParameter("Notas", SqlDbType.VarChar) { Value = c.Notas };

            cmd.Parameters.Add(p0);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);
            cmd.Parameters.Add(p8);

            try {
                conn.Open();
                cmd.ExecuteNonQuery();
                c.IdUsuario = (int)p0.Value;
            }
            catch {
            }
            finally {
                conn.Close();
            }

            return c.IdUsuario;
        }


        public static Usuario GetByPrimaryKey(int idUsuario)
        {
            var c = new Usuario();
            var conn = new SqlConnection(GeneralData.CadenaConexion);
            SqlDataReader rdr = null;
            var cmd = new SqlCommand("Usuario_GetByPrimaryKey", conn) { CommandType = CommandType.StoredProcedure };

            var p1 = new SqlParameter("IdUsuario", SqlDbType.Int) { Value = idUsuario };
            cmd.Parameters.Add(p1);

            try {
                conn.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    c.IdUsuario = (int) rdr["IdUsuario"];
                    c.Descripcion = rdr["Descripcion"] != DBNull.Value ? (string)rdr["Descripcion"] : "";
                    c.Usr = (string)rdr["Usr"];
                    c.Pwd = (string)rdr["Pwd"];
                    c.Apellido = rdr["Apellido"] != DBNull.Value ? (string)rdr["Apellido"] : "";
                    c.Nombre = rdr["Nombre"] != DBNull.Value ? (string)rdr["Nombre"] : "";
                    c.Telefono = rdr["Telefono"] != DBNull.Value ? (string)rdr["Telefono"] : "";
                    c.Direccion = rdr["Direccion"] != DBNull.Value ? (string)rdr["Direccion"] : "";
                    c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                }
            }
            finally {
                rdr?.Close();
                conn.Close();
            }

            return c;
        }


        public static void Update(Usuario u)
        {
            throw new NotImplementedException();
        }


        public static bool Delete(Usuario u)
        {
            throw new NotImplementedException();
        }
    }
}