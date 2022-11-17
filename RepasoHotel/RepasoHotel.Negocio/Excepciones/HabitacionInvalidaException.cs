using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHotel.Negocio.Excepciones
{
    public class HabitacionInvalidaException : Exception
    {
        public HabitacionInvalidaException() : base("ERROR! El hotel indicado no posee habitaciones y/o el número de habitación es inválido, intente nuevamente.")
        {

        }
    }
}
