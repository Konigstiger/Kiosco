using System;
using System.Collections.Generic;

using Data;
using Model;

namespace Controlador
{
    public class HoraEntregaControlador
    {
        public static List<HoraEntregaView> GetAll()
        {
            return HoraEntregaData.GetAll();
        }

        public static HoraEntrega GetByPrimaryKey(int idHoraEntrega)
        {
            return HoraEntregaData.GetByPrimaryKey(idHoraEntrega);
        }

        
        public static int Insert(HoraEntrega c)
        {
            var idHoraEntrega = HoraEntregaData.Insert(c);
            return idHoraEntrega;
        }
        

        public static bool Delete(HoraEntrega c)
        {
            return HoraEntregaData.Delete(c);
        }

        public static void Update(HoraEntrega c)
        {
            HoraEntregaData.Update(c);
        }
        

    }
}

