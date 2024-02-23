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
    public partial class Alumnos_SancionadosForm : Form
    {
        public static Alumnos_SancionadosForm Instance { get; private set; }

        public Alumnos_SancionadosForm()
        {
            InitializeComponent();
            Instance = this;
        }
        public ListBox ListBoxSancionados
        {
            get { return listBoxSanciones; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Cierra el formulario actual y abre el formulario principal
            this.Close();

            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
                private void Alumnos_SancionadosForm_Load(object sender, EventArgs e)
        {
            string PrestamosPath = "../../Prestamos.txt"; // Ruta del archivo de préstamos
            if (File.Exists(PrestamosPath)) // Verifica si el archivo existe
            {
                string[] PrestamosLineas = File.ReadAllLines(PrestamosPath); // Lee todas las líneas del archivo
                foreach (string linea in PrestamosLineas) // Recorre cada línea del archivo
                {
                    string[] campos = linea.Split(','); // Divide la línea en campos separados por coma
                    DateTime fecha = DateTime.Parse(campos[2]);
                    if (DateTime.Now > fecha.AddDays(3) && DateTime.Now <= fecha.AddDays(10)) // Verifica si el préstamo está vencido pero no ha pasado más de una semana
                    {
                        string LineaSancion = $"Cedula del Estudiante: {campos[0]}, Libro: {campos[1]}, Fecha de Préstamo: {campos[2]}"; 
                        listBoxSanciones.Items.Add(LineaSancion); // Agrega la línea formateada al ListBox
                    }
                }
            }
        }
    }
}
