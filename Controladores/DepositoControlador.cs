using System;
using System.Collections.Generic;

using Data;
using Model;
using Model.View;

namespace Controlador
{
    public class DepositoControlador
    {
        public static List<DepositoView> GetAll()
        {
            return DepositoData.GetAll();
        }

        public static Deposito GetByPrimaryKey(int idDeposito)
        {
            return DepositoData.GetByPrimaryKey(idDeposito);
        }


        public static List<DepositoView> SearchByParameters(string nombre)
        {
            return DepositoData.SearchByParameters(nombre);

        }

        
        public static int Insert(Deposito c)
        {
            var idDeposito = DepositoData.Insert(c);
            return idDeposito;
        }

        /*

        public static bool Delete(Deposito c)
        {
            return DepositoData.Delete(c);
        }

        public static void Update(Deposito c)
        {
            DepositoData.Update(c);
        }
        */

    }
}

