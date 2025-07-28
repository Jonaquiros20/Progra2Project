namespace Progra2Project
{
    partial class Juego
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Juego));
            label1 = new Label();
            rb1 = new RadioButton();
            rb2 = new RadioButton();
            rb3 = new RadioButton();
            rb4 = new RadioButton();
            btnsiguiente = new Button();
            btnreiniciar = new Button();
            progressBar1 = new ProgressBar();
            btnhabilitarpreguntas = new Button();
            btnsalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 30);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 0;
            label1.Text = "Texto de la pregunta";
            // 
            // rb1
            // 
            rb1.Location = new Point(100, 60);
            rb1.Name = "rb1";
            rb1.Size = new Size(104, 24);
            rb1.TabIndex = 1;
            // 
            // rb2
            // 
            rb2.Location = new Point(100, 90);
            rb2.Name = "rb2";
            rb2.Size = new Size(104, 24);
            rb2.TabIndex = 2;
            // 
            // rb3
            // 
            rb3.Location = new Point(100, 120);
            rb3.Name = "rb3";
            rb3.Size = new Size(104, 24);
            rb3.TabIndex = 3;
            // 
            // rb4
            // 
            rb4.Location = new Point(100, 150);
            rb4.Name = "rb4";
            rb4.Size = new Size(104, 24);
            rb4.TabIndex = 4;
            // 
            // btnsiguiente
            // 
            btnsiguiente.Location = new Point(100, 190);
            btnsiguiente.Name = "btnsiguiente";
            btnsiguiente.Size = new Size(90, 30);
            btnsiguiente.TabIndex = 5;
            btnsiguiente.Text = "Siguiente";
            btnsiguiente.Click += btnsiguiente_Click;
            // 
            // btnreiniciar
            // 
            btnreiniciar.Location = new Point(200, 190);
            btnreiniciar.Name = "btnreiniciar";
            btnreiniciar.Size = new Size(90, 30);
            btnreiniciar.TabIndex = 6;
            btnreiniciar.Text = "Reiniciar";
            btnreiniciar.Click += btnreiniciar_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(100, 290);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(250, 20);
            progressBar1.TabIndex = 7;
            // 
            // btnhabilitarpreguntas
            // 
            btnhabilitarpreguntas.Location = new Point(100, 240);
            btnhabilitarpreguntas.Name = "btnhabilitarpreguntas";
            btnhabilitarpreguntas.Size = new Size(190, 30);
            btnhabilitarpreguntas.TabIndex = 8;
            btnhabilitarpreguntas.Text = "Habilitar Preguntas";
            btnhabilitarpreguntas.Click += btnhabilitarpreguntas_Click;
            // 
            // btnsalir
            // 
            btnsalir.BackColor = Color.Red;
            btnsalir.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsalir.ImageAlign = ContentAlignment.TopCenter;
            btnsalir.Location = new Point(424, 3);
            btnsalir.Name = "btnsalir";
            btnsalir.RightToLeft = RightToLeft.Yes;
            btnsalir.Size = new Size(75, 23);
            btnsalir.TabIndex = 9;
            btnsalir.Text = "X";
            btnsalir.TextAlign = ContentAlignment.TopCenter;
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // Juego
            // 
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(500, 350);
            Controls.Add(btnsalir);
            Controls.Add(label1);
            Controls.Add(rb1);
            Controls.Add(rb2);
            Controls.Add(rb3);
            Controls.Add(rb4);
            Controls.Add(btnsiguiente);
            Controls.Add(btnreiniciar);
            Controls.Add(progressBar1);
            Controls.Add(btnhabilitarpreguntas);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Juego";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Juego";
            Load += Juego_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private RadioButton rb1, rb2, rb3, rb4;
        private Button btnsiguiente, btnreiniciar, btnhabilitarpreguntas;
        private ProgressBar progressBar1;
        private Button btnsalir;
    }
}
