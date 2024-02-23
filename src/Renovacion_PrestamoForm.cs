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
    public partial class Renovacion_PrestamoForm : Form
    {
        private string[] PrestamosLineas;
        private int IndicePrestamo;
        public Renovacion_PrestamoForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string PrestamosPath = "../../Prestamos.txt"; // Ruta del archivo de préstamos
            if (File.Exists(PrestamosPath)) // Verifica si el archivo existe
            {
                PrestamosLineas = File.ReadAllLines(PrestamosPath); // Lee todas las líneas del archivo
                for (int i = 0; i < PrestamosLineas.Length; i++) // Recorre cada línea del archivo
                {
                    string[] campos = PrestamosLineas[i].Split(','); // Divide la línea en campos separados por coma
                    if (campos[0] == textBox1.Text) // Verifica si la cedula del préstamo coincide con la cedula ingresada
                    {
                        IndicePrestamo = i;
                        label2.Text = $"Cédula del estudiante: {campos[0]}, Libro: {campos[1]}, Fecha del Préstamo: {campos[2]}"; // Muestra los detalles del préstamo
                        return;
                    }
                }
                MessageBox.Show("No se encontró ningún préstamo relacionado con esta cédula.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PrestamosLineas != null && IndicePrestamo >= 0 && IndicePrestamo < PrestamosLineas.Length) // Verifica si se ha encontrado un préstamo
            {
                string[] campos = PrestamosLineas[IndicePrestamo].Split(','); // Divide la línea en campos separados por coma
                campos[2] = DateTime.Now.ToString(); // Actualiza la fecha del préstamo
                PrestamosLineas[IndicePrestamo] = string.Join(",", campos); // Combina los campos en una línea
                File.WriteAllLines("../../Prestamos.txt", PrestamosLineas); // Escribe las líneas al archivo
                label2.Text = $"Cédula del estudiante: {campos[0]}, Libro: {campos[1]}, Fecha del Préstamo: {campos[2]}"; // Muestra los detalles del préstamo actualizados
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cierra el formulario actual y abre el formulario principal
            this.Close();

            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}

