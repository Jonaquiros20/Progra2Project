namespace Progra2Project
{
    partial class Resultados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resultados));
            listView1 = new ListView();
            btnReiniciar = new Button();
            btnCerrar = new Button();
            lblPuntaje = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.ScrollBar;
            listView1.FullRowSelect = true;
            listView1.Location = new Point(50, 80);
            listView1.Name = "listView1";
            listView1.Size = new Size(700, 250);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = Color.Lime;
            btnReiniciar.Location = new Point(200, 360);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(100, 30);
            btnReiniciar.TabIndex = 1;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Red;
            btnCerrar.Location = new Point(500, 360);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(100, 30);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblPuntaje
            // 
            lblPuntaje.AutoSize = true;
            lblPuntaje.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPuntaje.Location = new Point(50, 30);
            lblPuntaje.Name = "lblPuntaje";
            lblPuntaje.Size = new Size(95, 21);
            lblPuntaje.TabIndex = 3;
            lblPuntaje.Text = "Tu puntaje:";
            // 
            // Resultados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(814, 418);
            Controls.Add(lblPuntaje);
            Controls.Add(btnCerrar);
            Controls.Add(btnReiniciar);
            Controls.Add(listView1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Resultados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resultados";
            Load += Resultados_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblPuntaje;
    }
}
