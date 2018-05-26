using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;
using Model.View;

namespace Data
{
    public class PromocionData
    {

        /*
    [IdPromocion] [int] NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Importe] [decimal](8, 2) NOT NULL,
	[FechaInicio] [date] NOT NULL,
	[FechaFin] [date] NOT NULL,
	[Notas] [varchar](255) NULL
             */


        public static List<Promocion> GetAll()
        {
            var list = new List<Promocion>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Promocion_GetAll", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new Promocion {
                                IdPromocion = (int)rdr["IdPromocion"],
                                Descripcion = (string)rdr["Descripcion"],
                                Importe = (decimal)rdr["Importe"],
                                FechaInicio = rdr["FechaInicio"] != DBNull.Value ? (DateTime)rdr["FechaInicio"] : DateTime.MinValue,
                                FechaFin = rdr["FechaFin"] != DBNull.Value ? (DateTime)rdr["FechaFin"] : DateTime.MinValue,
                                Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : ""
                            };

                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }


        public static List<PromocionView> GetAllView()
        {
            var list = new List<PromocionView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Promocion_View_GetAll", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new PromocionView {
                                IdPromocion = (int)rdr["IdPromocion"],
                                Descripcion = (string)rdr["Descripcion"],
                                Importe = (decimal)rdr["Importe"],
                                FechaInicio = rdr["FechaInicio"] != DBNull.Value ? (DateTime)rdr["FechaInicio"] : DateTime.MinValue,
                                FechaFin = rdr["FechaFin"] != DBNull.Value ? (DateTime)rdr["FechaFin"] : DateTime.MinValue,
                                Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : ""
                            };
                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }

        public static List<PromocionView> GetGrid_GetByIdProducto(long idProducto)
        {
            var list = new List<PromocionView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Promocion_GetAll_GetByIdProducto", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = idProducto };

                    cmd.Parameters.Add(p0);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new PromocionView {
                                IdPromocion = (int)rdr["IdPromocion"],
                                Descripcion = (string)rdr["Descripcion"],
                                Importe = (decimal)rdr["Importe"],
                                FechaInicio =
                                    rdr["FechaInicio"] != DBNull.Value
                                        ? (DateTime)rdr["FechaInicio"]
                                        : DateTime.MinValue,
                                FechaFin =
                                    rdr["FechaFin"] != DBNull.Value ? (DateTime)rdr["FechaFin"] : DateTime.MinValue,
                                Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : string.Empty
                            };
                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }

        public static PromocionView GetByPrimaryKeyView(long idPromocion)
        {
            var c = new PromocionView();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Promocion_View_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdPromocion", SqlDbType.Int) { Value = idPromocion };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            c.IdPromocion = (int)rdr["IdPromocion"];
                            c.Descripcion = (string)rdr["Descripcion"];
                            c.Importe = (decimal)rdr["Importe"];
                            c.FechaInicio = rdr["FechaInicio"] != DBNull.Value ? (DateTime)rdr["FechaInicio"] : DateTime.MinValue;
                            c.FechaFin = rdr["FechaFin"] != DBNull.Value ? (DateTime)rdr["FechaFin"] : DateTime.MinValue;
                            c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                        }
                    }
                }
            }
            return c;
        }


        public static Promocion GetByPrimaryKey(int id)
        {
            var c = new Promocion();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Promocion_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdPromocion", SqlDbType.Int) { Value = id };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            c.IdPromocion = (int)rdr["IdPromocion"];
                            c.Descripcion = (string)rdr["Descripcion"];
                            c.Importe = (decimal)rdr["Importe"];
                            c.FechaInicio = rdr["FechaInicio"] != DBNull.Value ? (DateTime)rdr["FechaInicio"] : DateTime.MinValue;
                            c.FechaFin = rdr["FechaFin"] != DBNull.Value ? (DateTime)rdr["FechaFin"] : DateTime.MinValue;
                            c.Notas = rdr["Notas"] != DBNull.Value ? (string)rdr["Notas"] : "";
                        }
                    }
                }
            }
            return c;
        }



        public static long Insert(Promocion model)
        {
            /*
            (<IdPromocion, int,>
           ,<Descripcion, varchar(50),>
           ,<Importe, decimal(8,2),>
           ,<FechaInicio, date,>
           ,<FechaFin, date,>
           ,<Notas, varchar(255),>)
             */
            int idPromocion;
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Promocion_Insert", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //var p1 = new SqlParameter("IdPromocion", SqlDbType.Int) { Value = model.IdPromocion };
                    var p2 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = model.Descripcion };
                    var p3 = new SqlParameter("Importe", SqlDbType.Decimal) { Value = model.Importe };
                    var p4 = new SqlParameter("FechaInicio", SqlDbType.Date) { Value = model.FechaInicio };
                    var p5 = new SqlParameter("FechaFin", SqlDbType.Date) { Value = model.FechaFin };
                    var p6 = new SqlParameter("Notas", SqlDbType.VarChar) { Value = model.Notas };

                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);
                    cmd.Parameters.Add(p4);
                    cmd.Parameters.Add(p5);
                    cmd.Parameters.Add(p6);

                    conn.Open();
                    idPromocion = (int)cmd.ExecuteScalar();
                }
            }
            return idPromocion;
        }


        public static long Update(Promocion model)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Promocion_Update", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdPromocion", SqlDbType.Int) { Value = model.IdPromocion };
                    var p2 = new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = model.Descripcion };
                    var p3 = new SqlParameter("Importe", SqlDbType.Decimal) { Value = model.Importe };
                    var p4 = new SqlParameter("FechaInicio", SqlDbType.Date) { Value = model.FechaInicio };
                    var p5 = new SqlParameter("FechaFin", SqlDbType.Date) { Value = model.FechaFin };
                    var p6 = new SqlParameter("Notas", SqlDbType.VarChar) { Value = model.Notas };

                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);
                    cmd.Parameters.Add(p4);
                    cmd.Parameters.Add(p5);
                    cmd.Parameters.Add(p6);


                    conn.Open();
                    model.IdPromocion = (int)cmd.ExecuteScalar();
                }
            }
            return model.IdPromocion;
        }


        public static bool Delete(Promocion model)
        {
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Promocion_Delete", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdPromocion", SqlDbType.BigInt) { Value = model.IdPromocion };

                    cmd.Parameters.Add(p0);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
        }


        public static List<Promocion> GetAll_AutoComplete()
        {
            var list = new List<Promocion>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Promocion_GetDescripcion_GetAll", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {

                        while (rdr.Read()) {
                            var p = new Promocion {
                                IdPromocion = (int)rdr["IdPromocion"],
                                Descripcion = (string)rdr["Descripcion"]
                            };

                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }


        public static bool CambiarEstadoArchivo(long idPromocion, bool archivar)
        {
            //TODO: Probar esto
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("Promocion_CambiarEstadoArchivo", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p0 = new SqlParameter("IdPromocion", SqlDbType.BigInt) { Value = idPromocion };
                    var p1 = new SqlParameter("Archivar", SqlDbType.Bit) { Value = archivar };

                    cmd.Parameters.Add(p0);
                    cmd.Parameters.Add(p1);
                    conn.Open();
                    cmd.ExecuteScalar();
                    //TODO: ver si es adecuada esta devolucion tautologica teutonica tectonica.
                    return true;
                }
            }
        }
    }
}