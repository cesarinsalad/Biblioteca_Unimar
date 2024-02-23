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
    public partial class Registrar_DevolucionForm : Form
    {
        private string[] PrestamosLineas;
        private string[] LibrosLineas;
        private int IndicePrestamo;
        public Registrar_DevolucionForm()
        {
            InitializeComponent();
        }
        private void Registrar_DevolucionForm_Load(object sender, EventArgs e)
        {
            string PrestamosPath = "../../Prestamos.txt"; // Ruta del archivo de préstamos
            if (File.Exists(PrestamosPath)) // Verifica si el archivo existe
            {
                PrestamosLineas = File.ReadAllLines(PrestamosPath); // Lee todas las líneas del archivo
                foreach (string linea in PrestamosLineas) // Recorre cada línea del archivo
                {
                    string[] campos = linea.Split(','); // Divide la línea en campos separados por coma
                    comboBox1.Items.Add(campos[0]); // Agrega la cedula del estudiante que hizo el préstamo al ComboBox
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // Evento que sucede al seleccionar un elemento del ComboBox
        {
            IndicePrestamo = comboBox1.SelectedIndex;
            string[] campos = PrestamosLineas[IndicePrestamo].Split(','); // Divide la línea en campos separados por coma
            label2.Text = $"Cédula Estudiante: {campos[0]}, Libro: {campos[1]}, Fecha del Préstamo: {campos[2]}"; // Muestra los detalles del préstamo
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PrestamosLineas != null && IndicePrestamo >= 0 && IndicePrestamo < PrestamosLineas.Length)
            {
                string[] campos = PrestamosLineas[IndicePrestamo].Split(','); // Divide la línea en campos separados por coma
                string LibroNombre = campos[1]; // Obtiene el nombre del libro prestado

                // Remover el préstamo del archivo de préstamos
                List<string> PrestamosList = new List<string>(PrestamosLineas);
                PrestamosList.RemoveAt(IndicePrestamo);
                File.WriteAllLines("../../Prestamos.txt", PrestamosList.ToArray());

                // Agregar de vuelta el libro al archivo de libros
                string LibrosPath = "../../Libros.txt"; // Ruta del archivo de libros
                if (File.Exists(LibrosPath)) // Verifica si el archivo existe
                {
                    LibrosLineas = File.ReadAllLines(LibrosPath); // Lee todas las líneas del archivo
                    for (int i = 0; i < LibrosLineas.Length; i++) // Recorre cada línea del archivo
                    {
                        string[] camposLibro = LibrosLineas[i].Split(','); // Divide la línea en campos separados por coma
                        if (camposLibro[0] == LibroNombre) // Verifica si el libro es el mismo que se prestó
                        {
                            int cantidad = int.Parse(camposLibro[1]); // Obtiene la cantidad de libros
                            cantidad++; // Incrementa la cantidad de libros
                            camposLibro[1] = cantidad.ToString(); // Actualiza la cantidad de libros
                            LibrosLineas[i] = string.Join(",", camposLibro); // Combina los campos en una línea
                            File.WriteAllLines("../../Libros.txt", LibrosLineas); // Escribe las líneas al archivo
                            break;
                        }
                    }
                }

                // Actualizar el ComboBox y el Label
                comboBox1.Items.RemoveAt(IndicePrestamo);
                label2.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            // Muestra el menú principal
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
