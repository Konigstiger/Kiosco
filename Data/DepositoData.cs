using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace Data
{
    public class DepositoData
    {
        public static List<DepositoView> GetAll()
        {
            var list = new List<DepositoView>();
            var conn = new SqlConnection(GeneralData.CadenaConexion);
            SqlDataReader rdr = null;

            var cmd = new SqlCommand("Deposito_GetAll", conn) {CommandType = CommandType.StoredProcedure};

            try {
                conn.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    var p = new DepositoView
                    {
                        IdDeposito = (int) rdr["IdDeposito"],
                        Descripcion = (string) rdr["Descripcion"],
                        Direccion = rdr["Direccion"] != DBNull.Value ? (string) rdr["Direccion"] : "",
                        PuntoVenta = rdr["PuntoVenta"] != DBNull.Value && (bool) rdr["PuntoVenta"],
                        Notas = rdr["Notas"] != DBNull.Value ? (string) rdr["Notas"] : ""
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


        public static List<DepositoView> SearchByParameters(string nombre)
        {
            var list = new List<DepositoView>();
            var conn = new SqlConnection(GeneralData.CadenaConexion);

            SqlDataReader rdr = null;

            var cmd = new SqlCommand("Deposito_SearchByParameters", conn) {CommandType = CommandType.StoredProcedure};

            var p1 = new SqlParameter("nombre", SqlDbType.VarChar) {Value = nombre};

            cmd.Parameters.Add(p1);

            try {
                conn.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    var p = new DepositoView
                    {
                        IdDeposito = (int) rdr["IdDeposito"],
                        Descripcion = (string) rdr["Descripcion"],
                        Direccion = rdr["Direccion"] != DBNull.Value ? (string) rdr["Direccion"] : "",
                        PuntoVenta = rdr["PuntoVenta"] != DBNull.Value && (bool) rdr["PuntoVenta"],
                        Notas = rdr["Notas"] != DBNull.Value ? (string) rdr["Notas"] : ""
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


        public static int Insert(Deposito c)
        {
            var conn = new SqlConnection(GeneralData.CadenaConexion);
            var cmd = new SqlCommand("Deposito_Insert", conn) {CommandType = CommandType.StoredProcedure};

            var p0 = new SqlParameter("IdDeposito", SqlDbType.Int) {Direction = ParameterDirection.Output};
            var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) {Value = c.Descripcion};

            cmd.Parameters.Add(p0);
            cmd.Parameters.Add(p1);

            try {
                conn.Open();

                cmd.ExecuteNonQuery();
                c.IdDeposito = (int) p0.Value;
            }
            finally {
                conn.Close();
            }

            return c.IdDeposito;
        }


        public static Deposito GetByPrimaryKey(int idDeposito)
        {
            var c = new Deposito();
            var conn = new SqlConnection(GeneralData.CadenaConexion);
            SqlDataReader rdr = null;
            var cmd = new SqlCommand("Deposito_GetByPrimaryKey", conn) {CommandType = CommandType.StoredProcedure};

            var p1 = new SqlParameter("IdDeposito", SqlDbType.Int) {Value = idDeposito};
            cmd.Parameters.Add(p1);

            try {
                conn.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    c.IdDeposito = (int) rdr["IdDeposito"];
                    c.Descripcion = (string) rdr["Descripcion"];
                    c.Direccion = rdr["Direccion"] != DBNull.Value ? (string) rdr["Direccion"] : "";
                    c.PuntoVenta = rdr["PuntoVenta"] != DBNull.Value && (bool) rdr["PuntoVenta"];
                    c.Notas = rdr["Notas"] != DBNull.Value ? (string) rdr["Notas"] : "";
                }
            }
            finally {
                rdr?.Close();
                conn.Close();
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