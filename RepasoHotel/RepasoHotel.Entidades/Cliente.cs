using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace RepasoHotel.Entidades
{
    [DataContract]
    public class Cliente : Persona
    {
        //Atributos
        protected int _id;
        protected DateTime _fechaAlta;
        protected bool _activo;

        //Constructores
        public Cliente(int dni, string nombre, string apellido, string direccion, long telefono, string mail, DateTime fechaNacimiento, int id, DateTime fechaAlta) : base (dni, nombre, apellido, direccion, telefono, mail, fechaNacimiento)
        {
            _id = id;
            _fechaAlta = fechaAlta;
            _activo = true;
        }

        //Propiedades
        [DataMember(Name = "id")]
        public int Id { get => _id; set => _id = value; }

        [DataMember(Name = "fechaAlta")]
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }

        [DataMember(Name = "activo")]
        public bool Activo { get => _activo; set => _activo = value; }

        //Funciones-Métodos
        public override string GetCredencial()
        {
            return string.Format(
                "Dni: {0}" + Environment.NewLine +
                "Nombre: {1}" + Environment.NewLine +
                "Apellido: {2}" + Environment.NewLine +
                "Fecha de alta: {3}" + Environment.NewLine +
                "Id cliente: {4}" + Environment.NewLine,
                Dni,
                Nombre,
                Apellido,
                this.FechaAlta,
                this.Id
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
