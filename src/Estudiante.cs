using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Biblioteca_Unimar
{
    internal class Estudiante
    {
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Carrera { get; set; }

        public string NombreyCedula // Sobreescribe el método ToString
        {
            get { return $"{Nombre} ({Cedula})"; } // Devuelve el nombre del estudiante y su cédula
        }
    }
}
