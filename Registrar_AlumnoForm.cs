using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Biblioteca_Unimar
{
    public partial class Registrar_AlumnoForm : Form
    {
        public Registrar_AlumnoForm()
        {
            InitializeComponent();

            // Limitar la cantidad de caracteres que se pueden ingresar en los campos de texto.
            textBoxNombre.MaxLength = 50;
            textBoxCedula.MaxLength = 8;

            // Asignar el evento de presionar una tecla a los campos de texto.
            textBoxNombre.KeyPress += Nombre_KeyPress;
            textBoxCedula.KeyPress += Cedula_KeyPress;
        }

        private void Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo caracteres alfabéticos, espacio y control.
            if ((!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)) && e.KeyChar != ' ') 
            {
                e.Handled = true; // Cancelar la pulsación de tecla
            }
        }

        private void Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            // // Permitir solo caracteres numéricos y control.
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancelar la pulsación de tecla
            }
        }
        private void Registrar_AlumnoForm_Load(object sender, EventArgs e)
        {
            // Agrega las carreras al combobox
            comboBoxCarrera.Items.Add("Ingenieria de Sistemas");
            comboBoxCarrera.Items.Add("Idiomas Modernos");
            comboBoxCarrera.Items.Add("Docencia");
            comboBoxCarrera.Items.Add("Psicología");
            comboBoxCarrera.Items.Add("Diseño Gráfico");
            comboBoxCarrera.Items.Add("Derecho");
            comboBoxCarrera.Items.Add("Comunicación Social");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Estudiante NuevoEstudiante = new Estudiante
            {
                Nombre = textBoxNombre.Text, // Asigna el valor del textbox a la propiedad
                Cedula = textBoxCedula.Text, // Asigna el valor del textbox a la propiedad
                Carrera = comboBoxCarrera.SelectedItem.ToString(), // Selecciona el item seleccionado en el combobox
            };
           
            string path = "../../Estudiantes.txt";
                        
            string EstudianteString = $"{NuevoEstudiante.Nombre},{NuevoEstudiante.Cedula},{NuevoEstudiante.Carrera}";

            System.IO.File.AppendAllText(path,EstudianteString + Environment.NewLine);

            MessageBox.Show("El estudiante ha sido registrado correctamente!");
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
