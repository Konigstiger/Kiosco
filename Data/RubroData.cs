using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace Data
{
    public class RubroData
    {
        public static List<RubroView> GetAll()
        {
            var list = new List<RubroView>();

            var conn = new SqlConnection(GeneralData.CadenaConexion);
            SqlDataReader rdr = null;

            var cmd = new SqlCommand("Rubro_GetAll", conn) { CommandType = CommandType.StoredProcedure };

            try {
                conn.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    var p = new RubroView {
                        IdRubro = (int)rdr["IdRubro"],
                        Descripcion = (string)rdr["Descripcion"]
                    };

                    // Obtener los resultados de cada columna

                    list.Add(p);
                }
            }
            finally {
                rdr?.Close();
                conn.Close();
            }

            return list;
        }


        public static List<RubroView> SearchByParameters(string Nombre)
        {
            var list = new List<RubroView>();

            // create a connection object
            var conn = new SqlConnection(GeneralData.CadenaConexion);

            // declare the SqlDataReader, which is used in both the try block and the finally block
            //Contiene los datos
            SqlDataReader rdr = null;

            //contiene los detalles de que tabla / sp se leerá.
            var cmd = new SqlCommand("Rubro_SearchByParameters", conn) { CommandType = CommandType.StoredProcedure };

            var p1 = new SqlParameter("Nombre", SqlDbType.VarChar) { Value = Nombre };
            var p2 = new SqlParameter("IdProvincia", SqlDbType.Int) { Value = null };

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);

            try {
                conn.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    var p = new RubroView {
                        IdRubro = (int)rdr["IdRubro"],
                        Descripcion = (string)rdr["Descripcion"]
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

        public static int Insert(Rubro c)
        {
            var conn = new SqlConnection(GeneralData.CadenaConexion);

            //contiene los detalles de que tabla / sp se ejecutará.
            var cmd = new SqlCommand("Rubro_Insert", conn) { CommandType = CommandType.StoredProcedure };

            var p0 = new SqlParameter("IdRubro", SqlDbType.Int) { Direction = ParameterDirection.Output };
            var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = c.Descripcion };

            cmd.Parameters.Add(p0);
            cmd.Parameters.Add(p1);

            try {
                conn.Open();
                cmd.ExecuteNonQuery();
                c.IdRubro = (int)p0.Value;
            }
            catch {
            }
            finally {
                conn.Close();
            }

            return c.IdRubro;
        }

        public static Rubro GetByPrimaryKey(int idRubro)
        {
            var c = new Rubro();
            var conn = new SqlConnection(GeneralData.CadenaConexion);
            SqlDataReader rdr = null;
            var cmd = new SqlCommand("Rubro_GetByPrimaryKey", conn) {CommandType = CommandType.StoredProcedure};

            var p1 = new SqlParameter("IdRubro", SqlDbType.Int) {Value = idRubro};
            cmd.Parameters.Add(p1);

            try {
                conn.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    c.IdRubro = (int)rdr["IdRubro"];
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
    }
}