using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHotel.Entidades
{
    [DataContract]
    public abstract class Persona
    {
        //Atributos
        private int _dni;
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private long _telefono;
        private string _mail;
        private DateTime _fechaNacimiento;

        //Constructores
        public Persona(int dni, string nombre, string apellido, string direccion, long telefono, string mail, DateTime fechaNacimiento)
        {
            _dni = dni;
            _nombre = nombre;
            _apellido = apellido;
            _direccion = direccion;
            _telefono = telefono;
            _mail = mail;
            _fechaNacimiento = fechaNacimiento;
        }

        //Propiedades

        [DataMember(Name = "dni")]
        public int Dni { get => _dni; set => _dni = value; }

        [DataMember(Name = "nombre")]
        public string Nombre { get => _nombre; set => _nombre = value; }

        [DataMember(Name = "apellido")]
        public string Apellido { get => _apellido; set => _apellido = value; }

        [DataMember(Name = "direccion")]
        public string Direccion { get => _direccion; set => _direccion = value; }

        [DataMember(Name = "telefono")]
        public long Telefono { get => _telefono; set => _telefono = value; }

        [DataMember(Name = "email")]
        public string Mail { get => _mail; set => _mail = value; }

        [DataMember(Name = "fechaNacimiento")]
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }

        //Funciones-Métodos
        public virtual string GetCredencial()
        {
            return string.Format(
                "Dni: {0}" + Environment.NewLine +
                "Nombre: {1}" + Environment.NewLine +
                "Apellido: {2}" + Environment.NewLine +
                "Dirección: {3}" + Environment.NewLine +
                "Teléfono: {4}" + Environment.NewLine +
                "Mail: {5}" + Environment.NewLine,
                Dni,
                Nombre,
                Apellido,
                Direccion,
                Telefono,
                Mail
                )
                ;
        }

        public override string ToString()
        {
            //Declaración de variables
            string resultado;

            resultado = GetCredencial();

            return resultado;
        }
    }
}
