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
        public static string CadenaConexion => ConfigurationManager.AppSettings["CS"];
        //public const string CadenaConexion = "Data Source=PHANTOM;Initial Catalog=Kiosco;Integrated Security=True";
        //public const string CadenaConexion = "Data Source=NOTEBOOK;Initial Catalog=Kiosco;Integrated Security=True";

    }
}