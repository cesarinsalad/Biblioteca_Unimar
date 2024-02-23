using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_Unimar
{
    public partial class Registrar_PrestamoForm : Form
    {
        public Registrar_PrestamoForm()
        {
            InitializeComponent();
        }

        List<Libro> libros = new List<Libro>(); // Lista de libros

        private void Registrar_PrestamoForm_Load(object sender, EventArgs e)
        {
            string EstudiantesPath = "../../Estudiantes.txt"; // Ruta del archivo de estudiantes
            if (File.Exists(EstudiantesPath))
            {
                string[] LineasEstudiantes = File.ReadAllLines(EstudiantesPath); // Lee todas las líneas del archivo
                foreach (string linea in LineasEstudiantes) // Recorre cada linea del archivo.
                {
                    string[] fields = linea.Split(','); // Divide la línea en campos separados por coma
                    Estudiante Alumnos = new Estudiante // Crea un nuevo "estudiante" con los campos obtenidos
                    {
                        Nombre = fields[0], // Asigna el primer campo a la propiedad "Nombre"
                        Cedula = fields[1], // Asigna el segundo campo a la propiedad "Cedula"
                        Carrera = fields[2],// Asigna el tercer campo a la propiedad "Carrera"
                    };  
                    comboBoxAlumnos.Items.Add(Alumnos); // Agrega el estudiante al ComboBox
                }
                comboBoxAlumnos.DisplayMember = "NombreyCedula";
            }

            string LibrosPath = "../../Libros.txt"; // Ruta del archivo de libros
            if (File.Exists(LibrosPath)) // Verifica si el archivo existe
            {
                string[] LibrosLineas = File.ReadAllLines(LibrosPath); // Lee todas las líneas del archivo
                foreach (string linea in LibrosLineas) // Recorre cada línea del archivo
                {
                    string[] campos = linea.Split(','); // Divide la línea en campos separados por coma
                    Libro NuevoLibro = new Libro // Crea un nuevo "libro" con los campos obtenidos
                    {
                        Titulo = campos[0], // Asigna el primer campo a la propiedad "Titulo"
                        Autor = campos[1], // Asigna el segundo campo a la propiedad "Autor"
                        Ano = campos[2],  // Asigna el tercer campo a la propiedad "Ano"
                        Unidad = int.Parse(campos[3]) // Asigna el cuarto campo a la propiedad "Unidad"
                    };

                    libros.Add(NuevoLibro); // Agrega el libro a la lista de libros

                    if (NuevoLibro.Unidad > 0) // Verifica si hay unidades disponibles del libro
                    {
                        comboBoxLibros.Items.Add(NuevoLibro); // Agrega el libro al ComboBox
                    }
                }
                comboBoxLibros.DisplayMember = "MostrarTitulo"; // Establece la propiedad "MostrarTitulo" como la que se mostrará en el ComboBox
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Estudiante AlumnoSeleccionado = (Estudiante)comboBoxAlumnos.SelectedItem;

            Prestamo NuevoPrestamo = new Prestamo 
            { 
                Estudiante = (Estudiante)comboBoxAlumnos.SelectedItem, // Este es el estudiante que se selecciona en el ComboBox
                Libro = (Libro)comboBoxLibros.SelectedItem, // Este es el libro que se selecciona en el ComboBox
                Fecha = dateTimePicker1.Value // Esta es la fecha que se selecciona en el DateTimePicker
            };

            // Se resta una unidad al libro seleccionado
            Libro libro = libros.Find(b => b.Titulo == NuevoPrestamo.Libro.Titulo); // Busca el libro en la lista de libros
            if (libro != null) // Verifica si el libro existe
            {
                libro.Unidad--; // Resta una unidad al libro
            }

            string path = "../../Prestamos.txt"; // Ruta del archivo de préstamos
                       
            // Se crea un string con los datos del préstamo
            string StringPrestamo = $"{NuevoPrestamo.Estudiante.Cedula},{NuevoPrestamo.Libro.Titulo},{NuevoPrestamo.Fecha}";

           // Se añade el string al archivo de préstamos
            System.IO.File.AppendAllText(path, StringPrestamo + Environment.NewLine);

            string LibrosPath = "../../Libros.txt"; // Ruta del archivo de libros
            string[] LibroLineas = File.ReadAllLines(LibrosPath); // Lee todas las líneas del archivo
            for (int i = 0; i < LibroLineas.Length; i++) // Recorre cada linea del archivo.
            {
                string[] campos = LibroLineas[i].Split(','); // Divide la línea en campos separados por coma
                if (campos[0] == NuevoPrestamo.Libro.Titulo) // Verifica si el título del libro es igual al título del libro del préstamo
                {
                    LibroLineas[i] = $"{NuevoPrestamo.Libro.Titulo},{NuevoPrestamo.Libro.Autor},{NuevoPrestamo.Libro.Ano},{NuevoPrestamo.Libro.Unidad}"; // Actualiza la línea con la nueva cantidad de unidades
                    break;
                }
            }
            File.WriteAllLines(LibrosPath, LibroLineas); // Escribe todas las líneas en el archivo

            MessageBox.Show("Se ha registrado el préstamo correctamente!");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Cierra el formulario actual y abre el formulario principal
            this.Close();

            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
