namespace Progra2Project
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btniniciarjuego = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 29);
            label1.Name = "label1";
            label1.Size = new Size(543, 46);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido a Dara's Quizz";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(218, 135);
            label2.Name = "label2";
            label2.Size = new Size(230, 19);
            label2.TabIndex = 1;
            label2.Text = "Quieres abrirte paso y ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(181, 178);
            label3.Name = "label3";
            label3.Size = new Size(312, 19);
            label3.TabIndex = 2;
            label3.Text = "probar tu suerte en este quizz?";
            // 
            // btniniciarjuego
            // 
            btniniciarjuego.Font = new Font("Stencil", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btniniciarjuego.Location = new Point(297, 268);
            btniniciarjuego.Name = "btniniciarjuego";
            btniniciarjuego.Size = new Size(75, 23);
            btniniciarjuego.TabIndex = 3;
            btniniciarjuego.Text = "Iniciar";
            btniniciarjuego.UseVisualStyleBackColor = true;
            btniniciarjuego.Click += btniniciarjuego_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 397);
            Controls.Add(btniniciarjuego);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btniniciarjuego;
    }
}
