﻿using System;
using Model.View;

namespace Model
{
    public class Faltante : IEntidad
    {
        public long IdFaltante { get; set; }

        public string Descripcion { get; set; }

        public long? IdProducto { get; set; }

        public int Cantidad { get; set; }

        public int IdEstadoFaltante { get; set; }

        public DateTime Fecha { get; set; }

        public DateTime? FechaResuelto { get; set; }

        public int IdPrioridad { get; set; }

        public bool? Archivado { get; set; }

        public string Notas { get; set; }

        public int IdClaseFaltante { get; set; }
        


        public bool Validate()
        {
            //TODO: Este metodo, tiene como objetivo realizar validaciones basicas.
            //por ejemplo, ver si su codigo es -1. De ser asi, retornar false.
            //se pueden agregar muchas mas validaciones. Tambien podrian ir en el Controlador. 
            //Pero creo que me gustan aqui.

            if (Fecha > FechaResuelto)
                return false;
            //TODO: Pensar y agregar mas posibles validaciones de cosas que podrian estar mal en el modelo.           

            return true;
        }

    }
}
