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
    public partial class Prestamos_ActivosForm : Form
    {
        public Prestamos_ActivosForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cierra el formulario actual y abre el formulario principal
            this.Close();

            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void Prestamos_ActivosForm_Load(object sender, EventArgs e)
        {
            string PrestamosPath = "../../Prestamos.txt"; // Ruta del archivo de préstamos
            if (File.Exists(PrestamosPath)) // Verifica si el archivo existe
            {
                string[] PrestamosLineas = File.ReadAllLines(PrestamosPath); // Lee todas las líneas del archivo
                foreach (string linea in PrestamosLineas) // Recorre cada línea del archivo
                {
                    string[] campos = linea.Split(','); // Divide la línea en campos separados por coma
                    string LineaListBox = $"Cédula del Estudiante: {campos[0]}, Libro: {campos[1]}, Fecha y Hora de Retiro: {campos[2]}"; // Formatea la línea
                    listBoxPrestamosActivos.Items.Add(LineaListBox); // Agrega la línea formateada al ListBox
                }
            }
        }
    }
    
}
