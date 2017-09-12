using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model;
using System.Configuration;

namespace Data
{
    public static class GeneralData
    {
        private const string cadenaConexion = "Data Source=PHANTOM;Initial Catalog=Kiosco;Integrated Security=True";

        public static string CadenaConexion
        {
            get {
                return ConfigurationManager.AppSettings["CS"] ?? cadenaConexion;
            }
        }

        //public const string CadenaConexion = "Data Source=PHANTOM;Initial Catalog=Kiosco;Integrated Security=True";
        //public const string CadenaConexion = "Data Source=NOTEBOOK;Initial Catalog=Kiosco;Integrated Security=True";

    }
}