using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoHotel.Negocio.Excepciones
{
    public class FechasInvalidasReservaException : Exception
    {
        public FechasInvalidasReservaException(DateTime fechaIngreso, DateTime fechaEgreso) : base ("ERROR! La fecha de egreso de la reserva (" + fechaEgreso + ") no puede ser anterior a la fecha de ingreso (" + fechaIngreso + "), intente nuevamente.")
        {

        }
    }
}
