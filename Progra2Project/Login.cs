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
            Juego juego = new Juego(); // Instancia del formulario Juego
            juego.Show();              // Muestra el formulario

            this.Hide();               // Oculta el formulario actual (Inicio)
        }

    }
}
