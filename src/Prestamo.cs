using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Unimar
{
    internal class Prestamo
    {
        public Estudiante Estudiante { get; set; }
        public Libro Libro { get; set; }
        public DateTime Fecha { get; set; }
        public string MostrarPrestamo
        {
            get { return $"{Estudiante.Nombre} ({Estudiante.Cedula}) - {Libro.Titulo} - {Fecha.ToShortDateString()}"; } // Muestra el nombre del estudiante, la cédula, el título del libro y la fecha de préstamo
        }
    }
}
