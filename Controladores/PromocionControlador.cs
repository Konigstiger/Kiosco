using System;
using System.Collections.Generic;
using Data;
using Model;
using Model.View;

namespace Controlador
{
    public class PromocionControlador
    {
        public static List<PromocionView> GetAllView()
        {
            return PromocionData.GetAllView();
        }

        public static List<Promocion> GetAll()
        {
            return PromocionData.GetAll();
        }

        public static List<Promocion> GetAll_AutoComplete()
        {
            return PromocionData.GetAll_AutoComplete();
        }


        public static Promocion GetByPrimaryKey(int id)
        {
            return PromocionData.GetByPrimaryKey(id);
        }


        public static PromocionView GetByPrimaryKeyView(long id)
        {
            return PromocionData.GetByPrimaryKeyView(id);
        }


        public static long Insert(Promocion p)
        {
            var idPromocion = PromocionData.Insert(p);

            //TODO: Finalmente una oportunidad de aprovechar bien a la capa de controladores:
            //Validar, si existe un registro de Stock para este IdPromocion, IdDeposito 1.
            //Se supone que si se inserta, deberia NO existir.
            //en caso de no existir, crearlo al registro de Stock. Su numero no es importante.

            return idPromocion;
        }


        public static bool Delete(Promocion p)
        {
            return PromocionData.Delete(p);
        }


        public static long Update(Promocion p)
        {
            return PromocionData.Update(p);
        }

        public static bool CambiarEstadoArchivo(long idPromocion, bool archivar)
        {
            return PromocionData.CambiarEstadoArchivo(idPromocion, archivar);
        }
    }
}