using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Progra2Project
{
    public partial class Juego : Form
    {
        List<Pregunta> preguntas = new List<Pregunta>();
        List<int> respuestasJugador = new List<int>();
        int preguntaActual = 0;
        int puntaje = 0;
        bool seRespondio = false;
        bool cargandoPregunta = true;

        public Juego()
        {
            InitializeComponent();
        }

        private void Juego_Load(object sender, EventArgs e)
        {
            CargarPreguntas();

            progressBar1.Maximum = preguntas.Count;
            progressBar1.Value = 0;
            btnreiniciar.Visible = false;
            btnsiguiente.Visible = false;

            rb1.CheckedChanged += OpcionSeleccionada;
            rb2.CheckedChanged += OpcionSeleccionada;
            rb3.CheckedChanged += OpcionSeleccionada;
            rb4.CheckedChanged += OpcionSeleccionada;

            MostrarPregunta();
        }

        private void CargarPreguntas()
        {
            preguntas.Add(new Pregunta("¿Cuál es la capital de Francia?", new[] { "Madrid", "Berlín", "París", "Roma" }, 2));
            preguntas.Add(new Pregunta("¿Cuántos planetas tiene el sistema solar?", new[] { "7", "8", "9", "10" }, 1));
            preguntas.Add(new Pregunta("¿Cuál es el río más largo del mundo?", new[] { "Amazonas", "Nilo", "Misisipi", "Yangtsé" }, 1));
            preguntas.Add(new Pregunta("¿Quién pintó la Mona Lisa?", new[] { "Van Gogh", "Da Vinci", "Picasso", "Miguel Ángel" }, 1));
            preguntas.Add(new Pregunta("¿En qué continente está Egipto?", new[] { "Asia", "África", "Europa", "Oceanía" }, 1));
            preguntas.Add(new Pregunta("¿Cuál es el número Pi (aprox)?", new[] { "2.14", "3.14", "4.14", "5.14" }, 1));
            preguntas.Add(new Pregunta("¿Qué gas respiramos?", new[] { "Oxígeno", "Hidrógeno", "Dióxido de carbono", "Helio" }, 0));
            preguntas.Add(new Pregunta("¿Cuántas patas tiene una araña?", new[] { "6", "8", "10", "12" }, 1));
            preguntas.Add(new Pregunta("¿Cuál es el océano más grande?", new[] { "Atlántico", "Pacífico", "Índico", "Ártico" }, 1));
            preguntas.Add(new Pregunta("¿Cuál es la moneda de Japón?", new[] { "Yen", "Won", "Peso", "Dólar" }, 0));
            preguntas.Add(new Pregunta("¿Cuál es el idioma más hablado del mundo?", new[] { "Español", "Inglés", "Chino mandarín", "Hindú" }, 2));
            preguntas.Add(new Pregunta("¿Qué país ganó el Mundial 2018?", new[] { "Alemania", "Brasil", "Francia", "Argentina" }, 2));
            preguntas.Add(new Pregunta("¿Qué animal es conocido como el rey de la selva?", new[] { "Tigre", "León", "Jaguar", "Elefante" }, 1));
            preguntas.Add(new Pregunta("¿Quién escribió 'Don Quijote'?", new[] { "Cervantes", "Shakespeare", "Borges", "García Márquez" }, 0));
            preguntas.Add(new Pregunta("¿Cuál es la fórmula del agua?", new[] { "CO2", "H2O", "O2", "NaCl" }, 1));
            preguntas.Add(new Pregunta("¿Qué órgano bombea sangre?", new[] { "Pulmón", "Hígado", "Cerebro", "Corazón" }, 3));
            preguntas.Add(new Pregunta("¿Cuál es el continente más grande?", new[] { "África", "Europa", "Asia", "América" }, 2));
            preguntas.Add(new Pregunta("¿Cuántos días tiene un año bisiesto?", new[] { "364", "365", "366", "367" }, 2));
            preguntas.Add(new Pregunta("¿Qué instrumento tiene cuerdas?", new[] { "Piano", "Violín", "Trombón", "Flauta" }, 1));
            preguntas.Add(new Pregunta("¿En qué país está la Torre Eiffel?", new[] { "Italia", "Francia", "España", "Inglaterra" }, 1));
        }

        private void MostrarPregunta()
        {
            if (preguntaActual >= preguntas.Count)
            {
                Resultados resultados = new Resultados(preguntas, respuestasJugador, puntaje);
                resultados.Show();
                this.Close();
                return;
            }

            cargandoPregunta = true;

            rb1.CheckedChanged -= OpcionSeleccionada;
            rb2.CheckedChanged -= OpcionSeleccionada;
            rb3.CheckedChanged -= OpcionSeleccionada;
            rb4.CheckedChanged -= OpcionSeleccionada;

            rb1.Checked = rb2.Checked = rb3.Checked = rb4.Checked = false;

            rb1.Text = preguntas[preguntaActual].Opciones[0];
            rb2.Text = preguntas[preguntaActual].Opciones[1];
            rb3.Text = preguntas[preguntaActual].Opciones[2];
            rb4.Text = preguntas[preguntaActual].Opciones[3];

            rb1.ForeColor = rb2.ForeColor = rb3.ForeColor = rb4.ForeColor = Color.Black;
            label1.Text = $"Pregunta {preguntaActual + 1}: {preguntas[preguntaActual].Texto}";

            seRespondio = false;
            btnsiguiente.Visible = false;

            rb1.CheckedChanged += OpcionSeleccionada;
            rb2.CheckedChanged += OpcionSeleccionada;
            rb3.CheckedChanged += OpcionSeleccionada;
            rb4.CheckedChanged += OpcionSeleccionada;

            cargandoPregunta = false;
        }

        private void OpcionSeleccionada(object sender, EventArgs e)
        {
            if (cargandoPregunta || seRespondio) return;

            seRespondio = true;
            int respuestaSeleccionada = -1;

            if (rb1.Checked) respuestaSeleccionada = 0;
            else if (rb2.Checked) respuestaSeleccionada = 1;
            else if (rb3.Checked) respuestaSeleccionada = 2;
            else if (rb4.Checked) respuestaSeleccionada = 3;

            if (respuestaSeleccionada == -1) return;

            respuestasJugador.Add(respuestaSeleccionada);
            int correcta = preguntas[preguntaActual].RespuestaCorrecta;

            if (respuestaSeleccionada == correcta)
            {
                puntaje++;
                progressBar1.Value = Math.Min(progressBar1.Value + 1, preguntas.Count);
                ObtenerRadioButton(respuestaSeleccionada).ForeColor = Color.Green;
                btnsiguiente.Visible = true;
            }
            else
            {
                ObtenerRadioButton(respuestaSeleccionada).ForeColor = Color.Red;
                MessageBox.Show("❌ Respuesta incorrecta.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                preguntaActual++;
                MostrarPregunta();
            }
        }

        private RadioButton ObtenerRadioButton(int index)
        {
            return index switch
            {
                0 => rb1,
                1 => rb2,
                2 => rb3,
                3 => rb4,
                _ => null
            };
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            if (!seRespondio)
            {
                MessageBox.Show("⚠️ Por favor responde la pregunta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            preguntaActual++;
            MostrarPregunta();
        }

        private void btnreiniciar_Click(object sender, EventArgs e)
        {
            preguntaActual = 0;
            puntaje = 0;
            respuestasJugador.Clear();
            progressBar1.Value = 0;
            btnsiguiente.Visible = false;
            btnreiniciar.Visible = false;
            MostrarPregunta();
        }

        private void rb1_CheckedChanged(object sender, EventArgs e) { }
        private void rb2_CheckedChanged(object sender, EventArgs e) { }
        private void rb3_CheckedChanged(object sender, EventArgs e) { }
        private void rb4_CheckedChanged(object sender, EventArgs e) { }
        private void progressBar1_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
    }

    public class Pregunta
    {
        public string Texto { get; set; }
        public string[] Opciones { get; set; }
        public int RespuestaCorrecta { get; set; }

        public Pregunta(string texto, string[] opciones, int respuestaCorrecta)
        {
            Texto = texto;
            Opciones = opciones;
            RespuestaCorrecta = respuestaCorrecta;
        }
    }
}
