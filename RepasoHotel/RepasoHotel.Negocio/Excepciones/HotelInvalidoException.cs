using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoHotel.Negocio.Excepciones
{
    public class HotelInvalidoException : Exception
    {
        public HotelInvalidoException () : base ("ERROR! El hotel indicado es inválido y/o no existe, intente nuevamente.")
        {

        }
    }
}
