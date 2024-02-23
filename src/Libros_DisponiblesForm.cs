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
    public partial class Libros_DisponiblesForm : Form
    {
        public Libros_DisponiblesForm()
        {
            InitializeComponent();
        }
        private void Libros_DisponiblesForm_Load(object sender, EventArgs e)
        {
            string path = "../../Libros.txt"; // Ruta del archivo de texto
            if (!File.Exists(path)) // Verifica si el archivo existe
            {
                MessageBox.Show($"File not found: {path}"); // Mensaje de error si no se encuentra el archivo
                return;
            }

            string[] lineas = System.IO.File.ReadAllLines(path); // Lee todas las líneas del archivo
            foreach (string linea in lineas) // Recorre cada línea del archivo
            {
                string[] campos = linea.Split(','); // Divide la línea en campos separados por coma
                Libro Libro = new Libro // Crea un nuevo "libro" con los campos obtenidos
                {
                    Titulo = campos[0], // Asigna el primer campo a la propiedad "Titulo"
                    Autor = campos[1], // Asigna el segundo campo a la propiedad "Autor"
                    Ano = campos[2], // Asigna el tercer campo a la propiedad "Ano"
                    Unidad = int.Parse(campos[3]) // Asigna el cuarto campo a la propiedad "Unidad"
                };
                listBoxLibrosDisponibles.Items.Add(Libro); // Agrega el libro a la lista de libros disponibles
            }
        }
        private void buttonRegresarLibrDispo_Click(object sender, EventArgs e)
        {
            // Cierra el formulario actual y abre el formulario principal
            this.Close();

            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
