﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHotel.Negocio.Excepciones
{
    public class ObjetoInvalidoException : Exception
    {
        public ObjetoInvalidoException(string objeto) : base ("ERROR! El " + objeto + " ingresado es inválido y/o no existe, intente nuevamente.")
        {

        }
    }
}
