using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RepasoHotel.Entidades
{
    [DataContract]
    public class Reserva
    {
        //Atributos
        private int _id;
        private int _idCliente;
        private int _idHabitacion;
        private int _cantidadHuespedes;
        private DateTime _fechaIngreso;
        private DateTime _fechaEgreso;

        //Constructores
        public Reserva(int id, int idCliente, int idHabitacion, int cantidadHuespedes, DateTime fechaIngreso, DateTime fechaEgreso)
        {
            _id = id;
            _idCliente = idCliente;
            _idHabitacion = idHabitacion;
            _cantidadHuespedes = cantidadHuespedes;
            _fechaIngreso = fechaIngreso;
            _fechaEgreso = fechaEgreso;
        }

        //Propiedades

        [DataMember(Name = "id")]
        public int Id { get => _id; set => _id = value; }

        [DataMember(Name = "idCliente")]
        public int IdCliente { get => _idCliente; set => _idCliente = value; }

        [DataMember(Name = "idHabitacion")]
        public int IdHabitacion { get => _idHabitacion; set => _idHabitacion = value; }

        [DataMember(Name = "cantidadHuespedes")]
        public int CantidadHuespedes { get => _cantidadHuespedes; set => _cantidadHuespedes = value; }

        [DataMember(Name = "fechaIngreso")]
        public DateTime FechaIngreso { get => _fechaIngreso; set => _fechaIngreso = value; }

        [DataMember(Name = "fechaEgreso")]
        public DateTime FechaEgreso { get => _fechaEgreso; set => _fechaEgreso = value; }

        //Funciones-Métodos
        public string GetCredencial()
        {
            return string.Format(
                "Id Reserva: {0}" + Environment.NewLine +
                "Id Cliente: {1}" + Environment.NewLine +
                "Id Habitación: {2}" + Environment.NewLine +
                "Huéspedes: {3}" + Environment.NewLine +
                "Fecha Ingreso: {4}" + Environment.NewLine +
                "Fecha Egreso: {5}" + Environment.NewLine,
                this.Id,
                this.IdCliente,
                this.IdHabitacion,
                this.CantidadHuespedes,
                this.FechaIngreso,
                this.FechaEgreso
                )
                ;
        }

        //public override string ToString()
        //{
        //    //Declaración de variables
        //    string resultado;

        //    resultado = GetCredencial();

        //    return resultado;
        //}
    }
}
