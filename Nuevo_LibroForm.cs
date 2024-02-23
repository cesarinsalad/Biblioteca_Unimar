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
    public partial class Nuevo_LibroForm : Form
    {
        public Nuevo_LibroForm()
        {
            InitializeComponent();

            // Limitar la cantidad de caracteres que se pueden ingresar en los campos de texto.
            textBox1.MaxLength = 50;
            textBox2.MaxLength = 50;
            textBox3.MaxLength = 4;
            textBox4.MaxLength = 2;

            // Asignar el evento de presionar una tecla a los campos de texto.
            textBox3.KeyPress += PublicacionFecha_KeyPress;
            textBox4.KeyPress += Unidades_KeyPress;
        }
        private static void PublicacionFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // Si el caracter ingresado no es un número.
            {
                e.Handled = true; // No permitir que el caracter se muestre en el campo de texto.
            }
        }
        private static void Unidades_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // Si el caracter ingresado no es un número.
            {
                e.Handled = true; // No permitir que el caracter se muestre en el campo de texto.
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Agg_Libro_Click(object sender, EventArgs e)
        {
            Libro NuevoLibro = new Libro // Crear una instancia de la clase Libro.
            {
                Titulo = textBox1.Text, // Asignar el valor del campo de texto del título al atributo de la clase.
                Autor = textBox2.Text, // Asignar el valor del campo de texto del autor al atributo de la clase.
                Ano = textBox3.Text, // Asignar el valor del campo de texto de la categoría al atributo de la clase.
                Unidad = int.Parse(textBox4.Text) // Asignar el valor del campo de texto de la unidad al atributo de la clase.
            };

            string path = "../../Libros.txt"; // Ruta del archivo de texto.

            // Verificar si el archivo de texto existe.
            if (!File.Exists(path)) 
            {
                MessageBox.Show($"Archivo no encontrado: {path}");
                return;
            }
            string bookString = $"{NuevoLibro.Titulo},{NuevoLibro.Autor},{NuevoLibro.Ano},{NuevoLibro.Unidad}"; // Crear un string con los atributos del libro.
            System.IO.File.AppendAllText(path, bookString + Environment.NewLine); // Agregar el string a un archivo de texto.
            MessageBox.Show("El libro ha sido agregado correctamente a la libreria!"); // Mostrar un mensaje de éxito al presionar el botón.
        }
        private void buttonAtrasAggLibro_Click(object sender, EventArgs e)
        {
            // Cierra el form
            this.Close();

            // Muestra el menú principal
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}