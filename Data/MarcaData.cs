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
            var conn = new SqlConnection(GeneralData.CadenaConexion);
            SqlDataReader rdr = null;

            var cmd = new SqlCommand("Marca_GetAll", conn) {CommandType = CommandType.StoredProcedure};

            try {
                conn.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    var p = new MarcaView
                    {
                        IdMarca = (int) rdr["IdMarca"],
                        Descripcion = (string) rdr["Descripcion"],
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


        public static List<MarcaView> SearchByParameters(string descripcion)
        {
            var list = new List<MarcaView>();
            var conn = new SqlConnection(GeneralData.CadenaConexion);

            SqlDataReader rdr = null;

            var cmd = new SqlCommand("Marca_GetByParameters", conn) {CommandType = CommandType.StoredProcedure};

            var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) {Value = descripcion};

            cmd.Parameters.Add(p1);

            try {
                conn.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    var p = new MarcaView
                    {
                        IdMarca = (int) rdr["IdMarca"],
                        Descripcion = (string) rdr["Descripcion"],
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


        public static int Insert(Marca m)
        {
            var conn = new SqlConnection(GeneralData.CadenaConexion);
            var cmd = new SqlCommand("Marca_Insert", conn) {CommandType = CommandType.StoredProcedure};

            //var p0 = new SqlParameter("IdMarca", SqlDbType.Int) {Direction = ParameterDirection.Output};
            var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) {Value = m.Descripcion};
            var p2 = new SqlParameter("Notas", SqlDbType.VarChar) { Value = m.Notas};

            //cmd.Parameters.Add(p0);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);

            try {
                conn.Open();

                //cmd.ExecuteNonQuery();
                m.IdMarca = (int)cmd.ExecuteScalar();
            }
            finally {
                conn.Close();
            }

            return m.IdMarca;
        }


        public static Marca GetByPrimaryKey(int idMarca)
        {
            var c = new Marca();
            var conn = new SqlConnection(GeneralData.CadenaConexion);
            SqlDataReader rdr = null;
            var cmd = new SqlCommand("Marca_GetByPrimaryKey", conn) {CommandType = CommandType.StoredProcedure};

            var p1 = new SqlParameter("IdMarca", SqlDbType.Int) {Value = idMarca};
            cmd.Parameters.Add(p1);

            try {
                conn.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    c.IdMarca = (int) rdr["IdMarca"];
                    c.Descripcion = (string) rdr["Descripcion"];
                    c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                }
            }
            finally {
                rdr?.Close();
                conn.Close();
            }

            return c;
        }


        public static MarcaView GetByPrimaryKeyView(int idMarca)
        {
            var c = new MarcaView();
            var conn = new SqlConnection(GeneralData.CadenaConexion);
            SqlDataReader rdr = null;
            var cmd = new SqlCommand("Marca_GetByPrimaryKey", conn) { CommandType = CommandType.StoredProcedure };

            var p1 = new SqlParameter("IdMarca", SqlDbType.Int) { Value = idMarca };
            cmd.Parameters.Add(p1);

            try {
                conn.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    c.IdMarca = (int)rdr["IdMarca"];
                    c.Descripcion = (string)rdr["Descripcion"];
                    c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                }
            }
            finally {
                rdr?.Close();
                conn.Close();
            }

            return c;
        }

        public static int Update(Marca model)
        {
            var conn = new SqlConnection(GeneralData.CadenaConexion);

            var cmd = new SqlCommand("Marca_Update", conn) { CommandType = CommandType.StoredProcedure };

            var p0 = new SqlParameter("IdMarca", SqlDbType.VarChar) { Value = model.IdMarca };
            var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = model.Descripcion };
            var p2 = new SqlParameter("Notas", SqlDbType.VarChar) { Value = model.Notas };

            cmd.Parameters.Add(p0);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);

            try {
                conn.Open();
                model.IdMarca = (int)cmd.ExecuteScalar();

            }
            finally {
                conn.Close();
            }

            return model.IdMarca;
        }


        public static bool Delete(Marca model)
        {
            var conn = new SqlConnection(GeneralData.CadenaConexion);

            var cmd = new SqlCommand("Marca_Delete", conn) { CommandType = CommandType.StoredProcedure };

            var p0 = new SqlParameter("IdMarca", SqlDbType.Int) { Value = model.IdMarca };

            cmd.Parameters.Add(p0);

            try {
                conn.Open();
                model.IdMarca = (int)cmd.ExecuteScalar();
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