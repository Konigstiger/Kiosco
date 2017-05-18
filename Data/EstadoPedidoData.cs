using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace Data
{
    public class EstadoPedidoData
    {
        public static List<EstadoPedidoView> GetAll()
        {
            var list = new List<EstadoPedidoView>();
            var conn = new SqlConnection(GeneralData.CadenaConexion);
            SqlDataReader rdr = null;

            var cmd = new SqlCommand("EstadoPedido_GetAll", conn) {CommandType = CommandType.StoredProcedure};

            try {
                conn.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    var p = new EstadoPedidoView
                    {
                        IdEstadoPedido = (int) rdr["IdEstadoPedido"],
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


        public static List<EstadoPedidoView> SearchByParameters(string descripcion)
        {
            var list = new List<EstadoPedidoView>();
            var conn = new SqlConnection(GeneralData.CadenaConexion);

            SqlDataReader rdr = null;

            var cmd = new SqlCommand("EstadoPedido_GetByParameters", conn) {CommandType = CommandType.StoredProcedure};

            var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) {Value = descripcion};

            cmd.Parameters.Add(p1);

            try {
                conn.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    var p = new EstadoPedidoView
                    {
                        IdEstadoPedido = (int) rdr["IdEstadoPedido"],
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


        public static int Insert(EstadoPedido m)
        {
            var conn = new SqlConnection(GeneralData.CadenaConexion);
            var cmd = new SqlCommand("EstadoPedido_Insert", conn) {CommandType = CommandType.StoredProcedure};

            //var p0 = new SqlParameter("IdEstadoPedido", SqlDbType.Int) {Direction = ParameterDirection.Output};
            var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) {Value = m.Descripcion};
            var p2 = new SqlParameter("Notas", SqlDbType.VarChar) { Value = m.Notas};

            //cmd.Parameters.Add(p0);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);

            try {
                conn.Open();

                //cmd.ExecuteNonQuery();
                m.IdEstadoPedido = (int)cmd.ExecuteScalar();
            }
            finally {
                conn.Close();
            }

            return m.IdEstadoPedido;
        }


        public static EstadoPedido GetByPrimaryKey(int idEstadoPedido)
        {
            var c = new EstadoPedido();
            var conn = new SqlConnection(GeneralData.CadenaConexion);
            SqlDataReader rdr = null;
            var cmd = new SqlCommand("EstadoPedido_GetByPrimaryKey", conn) {CommandType = CommandType.StoredProcedure};

            var p1 = new SqlParameter("IdEstadoPedido", SqlDbType.Int) {Value = idEstadoPedido};
            cmd.Parameters.Add(p1);

            try {
                conn.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    c.IdEstadoPedido = (int) rdr["IdEstadoPedido"];
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


        public static EstadoPedidoView GetByPrimaryKeyView(int idEstadoPedido)
        {
            var c = new EstadoPedidoView();
            var conn = new SqlConnection(GeneralData.CadenaConexion);
            SqlDataReader rdr = null;
            var cmd = new SqlCommand("EstadoPedido_GetByPrimaryKey", conn) { CommandType = CommandType.StoredProcedure };

            var p1 = new SqlParameter("IdEstadoPedido", SqlDbType.Int) { Value = idEstadoPedido };
            cmd.Parameters.Add(p1);

            try {
                conn.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    c.IdEstadoPedido = (int)rdr["IdEstadoPedido"];
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

        public static int Update(EstadoPedido model)
        {
            var conn = new SqlConnection(GeneralData.CadenaConexion);

            var cmd = new SqlCommand("EstadoPedido_Update", conn) { CommandType = CommandType.StoredProcedure };

            var p0 = new SqlParameter("IdEstadoPedido", SqlDbType.VarChar) { Value = model.IdEstadoPedido };
            var p1 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = model.Descripcion };
            var p2 = new SqlParameter("Notas", SqlDbType.VarChar) { Value = model.Notas };

            cmd.Parameters.Add(p0);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);

            try {
                conn.Open();
                model.IdEstadoPedido = (int)cmd.ExecuteScalar();

            }
            finally {
                conn.Close();
            }

            return model.IdEstadoPedido;
        }


        public static bool Delete(EstadoPedido model)
        {
            var conn = new SqlConnection(GeneralData.CadenaConexion);

            var cmd = new SqlCommand("EstadoPedido_Delete", conn) { CommandType = CommandType.StoredProcedure };

            var p0 = new SqlParameter("IdEstadoPedido", SqlDbType.Int) { Value = model.IdEstadoPedido };

            cmd.Parameters.Add(p0);

            try {
                conn.Open();
                model.IdEstadoPedido = (int)cmd.ExecuteScalar();
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