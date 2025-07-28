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
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(50, 80);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(700, 250);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(200, 360);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(100, 30);
            this.btnReiniciar.TabIndex = 1;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(500, 360);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 30);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPuntaje.Location = new System.Drawing.Point(50, 30);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(90, 21);
            this.lblPuntaje.TabIndex = 3;
            this.lblPuntaje.Text = "Tu puntaje:";
            // 
            // Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Resultados";
            this.Text = "Resultados";
            this.Load += new System.EventHandler(this.Resultados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblPuntaje;
    }
}
