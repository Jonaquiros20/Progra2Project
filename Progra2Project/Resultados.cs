using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Progra2Project
{
    public partial class Resultados : Form
    {
        private List<Pregunta> preguntas;
        private List<int> respuestasJugador;
        private int puntaje;

        public Resultados(List<Pregunta> preguntas, List<int> respuestasJugador, int puntaje)
        {
            InitializeComponent();
            this.preguntas = preguntas;
            this.respuestasJugador = respuestasJugador;
            this.puntaje = puntaje;
        }

        private void Resultados_Load(object sender, EventArgs e)
        {
            if (preguntas == null || respuestasJugador == null)
            {
                lblPuntaje.Text = "Datos incompletos.";
                return;
            }

            lblPuntaje.Text = $"Tu puntaje: {puntaje} de {preguntas.Count}";

            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Pregunta", 300);
            listView1.Columns.Add("Tu Respuesta", 200);
            listView1.Columns.Add("Respuesta Correcta", 200);

            for (int i = 0; i < preguntas.Count; i++)
            {
                string preguntaTexto = preguntas[i].Texto;
                string respuestaJugadorTexto = respuestasJugador[i] >= 0 && respuestasJugador[i] < preguntas[i].Opciones.Length
                    ? preguntas[i].Opciones[respuestasJugador[i]]
                    : "(No respondida)";
                string respuestaCorrectaTexto = preguntas[i].Opciones[preguntas[i].RespuestaCorrecta];

                var item = new ListViewItem(preguntaTexto);
                item.SubItems.Add(respuestaJugadorTexto);
                item.SubItems.Add(respuestaCorrectaTexto);

                item.ForeColor = (respuestasJugador[i] == preguntas[i].RespuestaCorrecta)
                    ? Color.Green
                    : Color.Red;

                listView1.Items.Add(item);
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
