using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_Unimar
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void rgst_alum_Click(object sender, EventArgs e) // Evento para registrar un alumno.
        {
            Registrar_AlumnoForm Registrar_AlumnoForm = new Registrar_AlumnoForm(); // Crear una instancia del form para registrar un alumno.
            this.Hide(); // Ocultar el form principal.
            Registrar_AlumnoForm.Show(); // Mostrar el form para registrar un alumno.
        }

        private void rgst_prest_Click(object sender, EventArgs e) // Evento para registrar un préstamo.
        {
            Registrar_PrestamoForm Registrar_PrestamoForm = new Registrar_PrestamoForm(); // Crear una instancia del form para registrar un préstamo.
            this.Hide(); // Ocultar el form principal.
            Registrar_PrestamoForm.Show(); // Mostrar el form para registrar un préstamo.
        }

        private void prest_act_Click(object sender, EventArgs e) // Evento para ver los préstamos activos.
        {
            Prestamos_ActivosForm Prestamos_ActivosForm = new Prestamos_ActivosForm(); // Crear una instancia del form para ver los préstamos activos.
            this.Hide(); // Ocultar el form principal.
            Prestamos_ActivosForm.Show(); // Mostrar el form para ver los préstamos activos.    
        }

        private void libros_dispon_Click(object sender, EventArgs e) // Evento para ver los libros disponibles. 
        {
            Libros_DisponiblesForm Libros_DisponiblesForm = new Libros_DisponiblesForm(); // Crear una instancia del form para ver los libros disponibles.
            this.Hide(); // Ocultar el form principal.
            Libros_DisponiblesForm.Show(); // Mostrar el form para ver los libros disponibles.  
        }

        private void sancion_alumns_Click(object sender, EventArgs e) // Evento para ver los alumnos sancionados.
        {
            Alumnos_SancionadosForm Alumnos_SancionadosForm = new Alumnos_SancionadosForm(); // Crear una instancia del form para ver los alumnos sancionados.
            this.Hide(); // Ocultar el form principal.
            Alumnos_SancionadosForm.Show(); // Mostrar el form para ver los alumnos sancionados.    
        }

        private void renov_prest_Click(object sender, EventArgs e) // Evento para renovar un préstamo.
        {
            Renovacion_PrestamoForm Renovacion_PrestamoForm = new Renovacion_PrestamoForm(); // Crear una instancia del form para renovar un préstamo.
            this.Hide(); // Ocultar el form principal.
            Renovacion_PrestamoForm.Show(); // Mostrar el form para renovar un préstamo.
        }

        private void rgst_devol_Click(object sender, EventArgs e) // Evento para registrar una devolución.
        {
            Registrar_DevolucionForm Registrar_DevolucionForm = new Registrar_DevolucionForm(); // Crear una instancia del form para registrar una devolución.
            this.Hide(); // Ocultar el form principal.
            Registrar_DevolucionForm.Show(); // Mostrar el form para registrar una devolución.
        }

        private void agg_libr_new_Click(object sender, EventArgs e) // Evento para agregar un nuevo libro.
        {
            Nuevo_LibroForm Nuevo_LibroForm = new Nuevo_LibroForm(); // Crear una instancia del form para agregar un nuevo libro.
            this.Hide(); // Ocultar el form principal.
            Nuevo_LibroForm.Show(); // Mostrar el form para agregar un nuevo libro.
        }
    }
}