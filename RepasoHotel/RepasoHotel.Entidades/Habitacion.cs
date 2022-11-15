using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoHotel.Entidades
{
    public class Habitacion
    {
        //Atributos
        private int _id;
        private int _idHotel;
        private string _categoria;
        private int _cantidadPlazas; //Número de personas que pueden pernoctar (pasar la noche) en las camas instaladas permanentemente de esa habitación
        private bool _cancelacion;
        private double _precio;

        //Constructores
        public Habitacion(int id, int idHotel, string categoria, int cantidadPlazas, bool cancelacion, double precio)
        {
            _id = id;
            _idHotel = idHotel;
            _categoria = categoria;
            _cantidadPlazas = cantidadPlazas;
            _cancelacion = cancelacion;
            _precio = precio;
        }

        //Propiedades
        public int Id { get => _id; set => _id = value; }
        public int IdHotel { get => _idHotel; set => _idHotel = value; }
        public string Categoria { get => _categoria; set => _categoria = value; }
        public int CantidadPlazas { get => _cantidadPlazas; set => _cantidadPlazas = value; }
        public bool Cancelacion { get => _cancelacion; set => _cancelacion = value; }
        public double Precio { get => _precio; set => _precio = value; }

        //Funciones-Métodos
        public string GetCredencial()
        {
            return string.Format(
                "Id Habitación: {0}" + Environment.NewLine +
                "Id Hotel: {1}" + Environment.NewLine +
                "Categoría: {2}" + Environment.NewLine +
                "Cantidad de plazas: {3}" + Environment.NewLine +
                "Precio: {4}" + Environment.NewLine,
                this.Id,
                this.IdHotel,
                this.Categoria,
                this.CantidadPlazas,
                this.Precio
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
