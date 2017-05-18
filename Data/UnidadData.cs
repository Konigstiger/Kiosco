using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace Data
{
    public class UnidadData
    {
        public static List<UnidadView> GetAll()
        {
            var list = new List<UnidadView>();

            var conn = new SqlConnection(GeneralData.CadenaConexion);
            SqlDataReader rdr = null;

            var cmd = new SqlCommand("Unidad_GetAll", conn) { CommandType = CommandType.StoredProcedure };

            try {
                conn.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    var p = new UnidadView {
                        IdUnidad = (int)rdr["IdUnidad"],
                        Descripcion = (string)rdr["Descripcion"],
                        Simbolo = (string)rdr["Simbolo"],
                        Unidades = rdr["Unidades"] != DBNull.Value ? (int)rdr["Unidades"] : 1
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


        public static int Insert(Unidad c)
        {
            var conn = new SqlConnection(GeneralData.CadenaConexion);

            //contiene los detalles de que tabla / sp se ejecutará.
            var cmd = new SqlCommand("Unidad_Insert", conn) { CommandType = CommandType.StoredProcedure };

            var p0 = new SqlParameter("IdUnidad", SqlDbType.Int) { Direction = ParameterDirection.Output };
            var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = c.Descripcion };
            var p2 = new SqlParameter("Simbolo", SqlDbType.VarChar) { Value = c.Simbolo };
            var p3 = new SqlParameter("Unidades", SqlDbType.Int) { Value = c.Unidades };

            cmd.Parameters.Add(p0);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);

            try {
                conn.Open();
                cmd.ExecuteNonQuery();
                c.IdUnidad = (int)p0.Value;
            }
            catch {
            }
            finally {
                conn.Close();
            }

            return c.IdUnidad;
        }


        public static Unidad GetByPrimaryKey(int idUnidad)
        {
            var c = new Unidad();
            var conn = new SqlConnection(GeneralData.CadenaConexion);
            SqlDataReader rdr = null;
            var cmd = new SqlCommand("Unidad_GetByPrimaryKey", conn) {CommandType = CommandType.StoredProcedure};

            var p1 = new SqlParameter("IdUnidad", SqlDbType.Int) {Value = idUnidad};
            cmd.Parameters.Add(p1);

            try {
                conn.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    c.IdUnidad = (int)rdr["IdUnidad"];
                    c.Descripcion = (string)rdr["Descripcion"];
                    c.Simbolo = rdr["Simbolo"] != DBNull.Value ? (string)rdr["Simbolo"] : "";
                    c.Unidades = rdr["Unidades"] != DBNull.Value ? (int)rdr["Unidades"] : 1;
                }
            }
            finally {
                rdr?.Close();
                conn.Close();
            }

            return c;
        }

        public static int Update(Unidad model)
        {
            var conn = new SqlConnection(GeneralData.CadenaConexion);

            var cmd = new SqlCommand("Unidad_Update", conn) { CommandType = CommandType.StoredProcedure };

            var p0 = new SqlParameter("IdUnidad", SqlDbType.Int) { Value = model.IdUnidad};
            var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = model.Descripcion };
            var p2 = new SqlParameter("Simbolo", SqlDbType.VarChar) { Value = model.Simbolo };
            var p3 = new SqlParameter("Unidades", SqlDbType.VarChar) { Value = model.Unidades };

            cmd.Parameters.Add(p0);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);

            try {
                conn.Open();
                model.IdUnidad = (int)cmd.ExecuteScalar();

            }
            finally {
                conn.Close();
            }

            return model.IdUnidad;
        }
    }
}