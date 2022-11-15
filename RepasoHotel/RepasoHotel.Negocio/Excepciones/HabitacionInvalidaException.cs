using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoHotel.Negocio.Excepciones
{
    public class HabitacionInvalidaException : Exception
    {
        public HabitacionInvalidaException() : base("ERROR! El hotel indicado no posee habitaciones, intente nuevamente.")
        {

        }
    }
}
