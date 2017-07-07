using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace Data
{
    public class VentaDetalleData
    {
        public static List<VentaDetalleView> GetAll()
        {
            var list = new List<VentaDetalleView>();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("VentaDetalle_GetAll", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            var p = new VentaDetalleView {
                                IdVentaDetalle = (long)rdr["IdVentaDetalle"],
                                IdVenta = (long)rdr["IdVenta"],
                                IdProducto = (long)rdr["Fecha"],
                                Cantidad = (int)rdr["Cantidad"],
                                PrecioUnitario = (decimal)rdr["PrecioUnitario"],
                                Importe = (decimal)rdr["Importe"],
                                IdMovimientoProducto =
                                    rdr["IdMovimientoProducto"] != DBNull.Value ? (long)rdr["IdMovimientoProducto"] : 1
                            };
                            list.Add(p);
                        }
                    }
                }
            }

            return list;
        }


        public static VentaDetalleView GetByPrimaryKey(long idVentaDetalle)
        {
            var c = new VentaDetalleView();
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("VentaDetalle_GetByPrimaryKey", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdVentaDetalle", SqlDbType.Int) { Value = idVentaDetalle };
                    cmd.Parameters.Add(p1);

                    conn.Open();
                    using (var rdr = cmd.ExecuteReader()) {
                        while (rdr.Read()) {
                            c.IdVentaDetalle = (long)rdr["IdVentaDetalle"];
                            c.IdVenta = (long)rdr["IdVenta"];
                            c.IdProducto = (long)rdr["Fecha"];
                            c.Cantidad = (int)rdr["Cantidad"];
                            c.PrecioUnitario = (decimal)rdr["PrecioUnitario"];
                            c.Importe = (decimal)rdr["Importe"];
                            c.IdMovimientoProducto = rdr["IdMovimientoProducto"] != DBNull.Value
                                ? (long)rdr["IdMovimientoProducto"]
                                : 1;
                        }
                    }
                }
            }
            return c;
        }



        public static long Insert(VentaDetalle model)
        {
            long idVentaDetalle;
            using (var conn = new SqlConnection(GeneralData.CadenaConexion)) {
                using (var cmd = new SqlCommand("VentaDetalle_Insert", conn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = new SqlParameter("IdVenta", SqlDbType.BigInt) { Value = model.IdVenta };
                    var p2 = new SqlParameter("Cantidad", SqlDbType.Int) { Value = model.Cantidad };
                    var p3 = new SqlParameter("PrecioUnitario", SqlDbType.Decimal) { Value = model.PrecioUnitario };
                    var p4 = new SqlParameter("Importe", SqlDbType.Decimal) { Value = model.Importe };
                    var p5 = new SqlParameter("Ganancia", SqlDbType.Decimal) { Value = model.Ganancia };
                    var p6 = new SqlParameter("IdMovimientoProducto", SqlDbType.BigInt) {
                        Value = model.IdMovimientoProducto
                    };
                    var p7 = new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = model.IdProducto };

                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);
                    cmd.Parameters.Add(p4);
                    cmd.Parameters.Add(p5);
                    cmd.Parameters.Add(p6);
                    cmd.Parameters.Add(p7);

                    conn.Open();
                    idVentaDetalle = (long)cmd.ExecuteScalar();
                }
            }
            return idVentaDetalle;
        }


        public static bool Delete(VentaDetalle ventaDetalle)
        {
            throw new NotImplementedException();
        }

        public static void Update(VentaDetalle ventaDetalle)
        {
            throw new NotImplementedException();
        }
    }
}