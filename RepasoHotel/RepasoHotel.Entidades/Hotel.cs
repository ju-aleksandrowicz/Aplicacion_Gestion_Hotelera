using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoHotel.Entidades
{
    public class Hotel
    {
        //Atributos
        private int _id;
        private string _nombre;
        private string _direccion;
        private int _estrellas;
        private bool _amenities;

        //Constructores
        public Hotel (int id, string nombre, string direccion, int estrellas, bool amenities)
        {
            _id = id;
            _nombre = nombre;
            _direccion = direccion;
            _estrellas = estrellas;
            _amenities = amenities;
        }

        //Propiedades
        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public int Estrellas { get => _estrellas; set => _estrellas = value; }
        public bool Amenities { get => _amenities; set => _amenities = value; }

        //Funciones-Métodos
        public string GetCredencial()
        {
            return string.Format(
                "Id Hotel: {0}" + Environment.NewLine +
                "Nombre: {1}" + Environment.NewLine +
                "Dirección: {2}" + Environment.NewLine +
                "Estrellas: {3}" + Environment.NewLine +
                "Amenities: {4}" + Environment.NewLine,
                this.Id,
                this.Nombre,
                this.Direccion,
                this.Estrellas,
                this.Amenities ? "SÍ" : "NO"
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
