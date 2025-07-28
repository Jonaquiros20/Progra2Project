using System;
using System.Windows.Forms;

namespace Progra2Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btniniciarjuego_Click(object sender, EventArgs e)
        {
            // Crear y mostrar el formulario del juego
            Juego juego = new Juego();
            juego.Show();

            // Llamar al método HabilitarPreguntas para iniciar el juego
            juego.HabilitarPreguntas();

            // Ocultar el formulario de login sin cerrar la aplicación
            this.Hide();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
