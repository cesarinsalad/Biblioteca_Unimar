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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Button_login_Click(object sender, EventArgs e)
        {
            if (textBox_usuario.Text == "admin" && textBox_contrasena.Text == "0000") // Verificar si el usuario y la contraseña son correctos.
            {
                // Si el inicio de sesión es correcto, se oculta el form de inicio de sesión y se muestra el form principal.
                this.Hide();
                MainForm mainForm = new MainForm(); // Crear una instancia del form principal.
                mainForm.Closed += (s, args) => this.Close(); // Se asegura de cerrar el form de login en vez de minimizarlo.
                mainForm.Show(); // Mostrar el form principal.
            }
            else
            {
                MessageBox.Show("Usuario o contraseña inválida."); // Mostrar un mensaje de error si el inicio de sesión es incorrecto.
            }
        }
    }
}
