namespace Progra2Project
{
    partial class Juego
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            rb1 = new RadioButton();
            rb2 = new RadioButton();
            rb3 = new RadioButton();
            rb4 = new RadioButton();
            btnsiguiente = new Button();
            btnreiniciar = new Button();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(100, 30);
            label1.Name = "label1";
            label1.Size = new Size(165, 21);
            label1.TabIndex = 0;
            label1.Text = "Texto de la pregunta";
            label1.Click += label1_Click;
            // 
            // rb1
            // 
            rb1.AutoSize = true;
            rb1.Location = new Point(100, 80);
            rb1.Name = "rb1";
            rb1.Size = new Size(85, 19);
            rb1.TabIndex = 1;
            rb1.TabStop = true;
            rb1.Text = "Respuesta 1";
            rb1.UseVisualStyleBackColor = true;
            rb1.CheckedChanged += rb1_CheckedChanged;
            // 
            // rb2
            // 
            rb2.AutoSize = true;
            rb2.Location = new Point(100, 110);
            rb2.Name = "rb2";
            rb2.Size = new Size(85, 19);
            rb2.TabIndex = 2;
            rb2.TabStop = true;
            rb2.Text = "Respuesta 2";
            rb2.UseVisualStyleBackColor = true;
            rb2.CheckedChanged += rb2_CheckedChanged;
            // 
            // rb3
            // 
            rb3.AutoSize = true;
            rb3.Location = new Point(100, 140);
            rb3.Name = "rb3";
            rb3.Size = new Size(85, 19);
            rb3.TabIndex = 3;
            rb3.TabStop = true;
            rb3.Text = "Respuesta 3";
            rb3.UseVisualStyleBackColor = true;
            rb3.CheckedChanged += rb3_CheckedChanged;
            // 
            // rb4
            // 
            rb4.AutoSize = true;
            rb4.Location = new Point(100, 170);
            rb4.Name = "rb4";
            rb4.Size = new Size(85, 19);
            rb4.TabIndex = 4;
            rb4.TabStop = true;
            rb4.Text = "Respuesta 4";
            rb4.UseVisualStyleBackColor = true;
            rb4.CheckedChanged += rb4_CheckedChanged;
            // 
            // btnsiguiente
            // 
            btnsiguiente.Location = new Point(100, 210);
            btnsiguiente.Name = "btnsiguiente";
            btnsiguiente.Size = new Size(100, 30);
            btnsiguiente.TabIndex = 5;
            btnsiguiente.Text = "Siguiente";
            btnsiguiente.UseVisualStyleBackColor = true;
            btnsiguiente.Click += btnsiguiente_Click;
            // 
            // btnreiniciar
            // 
            btnreiniciar.Location = new Point(220, 210);
            btnreiniciar.Name = "btnreiniciar";
            btnreiniciar.Size = new Size(100, 30);
            btnreiniciar.TabIndex = 6;
            btnreiniciar.Text = "Reiniciar";
            btnreiniciar.UseVisualStyleBackColor = true;
            btnreiniciar.Click += btnreiniciar_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(100, 260);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(220, 23);
            progressBar1.TabIndex = 7;
            progressBar1.Click += progressBar1_Click;
            // 
            // Juego
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 350);
            Controls.Add(progressBar1);
            Controls.Add(btnreiniciar);
            Controls.Add(btnsiguiente);
            Controls.Add(rb4);
            Controls.Add(rb3);
            Controls.Add(rb2);
            Controls.Add(rb1);
            Controls.Add(label1);
            Name = "Juego";
            Text = "Juego";
            Load += Juego_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton rb1;
        private RadioButton rb2;
        private RadioButton rb3;
        private RadioButton rb4;
        private Button btnsiguiente;
        private Button btnreiniciar;
        private ProgressBar progressBar1;
    }
}
