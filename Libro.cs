using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Unimar
{
    internal class Libro
    {
        public string Titulo { get; set; } // Propiedad para el título del libro.
        public string Autor { get; set; } // Propiedad para el autor del libro.
        public string Ano { get; set; } // Propiedad para la categoría del libro.
        public int Unidad { get; set; } // Propiedad para la cantidad de unidades del libro.

        public override string ToString() // Método para mostrar el libro en el ComboBox de libros disponibles
        {
            return $"Titulo: {Titulo}, Autor: {Autor}, Año: {Ano}, Unidad: {Unidad}";
        }
        public string MostrarTitulo // Método para mostrar el título del libro en el ComboBox de registro de prestamos
        {
            get { return Titulo; }
        }
    }
    
}