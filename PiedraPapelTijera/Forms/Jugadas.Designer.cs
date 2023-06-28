namespace Forms
{
    partial class Jugadas
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
            lblJugador = new Label();
            label3 = new Label();
            lblRonda = new Label();
            label5 = new Label();
            btnJugar = new Button();
            label6 = new Label();
            lbl = new Label();
            lbls = new Label();
            lblCPU = new Label();
            btnPiedra = new Button();
            btnPapel = new Button();
            btnTijera = new Button();
            label9 = new Label();
            label11 = new Label();
            lblResultado = new Label();
            lblPuntos = new Label();
            btnContinuar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(83, 28);
            label1.TabIndex = 0;
            label1.Text = "Jugador";
            label1.Click += label1_Click;
            // 
            // lblJugador
            // 
            lblJugador.AutoSize = true;
            lblJugador.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblJugador.Location = new Point(120, 9);
            lblJugador.Name = "lblJugador";
            lblJugador.Size = new Size(64, 28);
            lblJugador.TabIndex = 1;
            lblJugador.Text = "Name";
            lblJugador.Click += lblJugador_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(268, 41);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 2;
            label3.Text = "Ronda";
            // 
            // lblRonda
            // 
            lblRonda.AutoSize = true;
            lblRonda.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRonda.Location = new Point(371, 41);
            lblRonda.Name = "lblRonda";
            lblRonda.Size = new Size(0, 21);
            lblRonda.TabIndex = 3;
            lblRonda.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(2, 118);
            label5.Name = "label5";
            label5.Size = new Size(215, 28);
            label5.TabIndex = 4;
            label5.Text = "Ingrese su movimiento ";
            // 
            // btnJugar
            // 
            btnJugar.Location = new Point(411, 196);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(133, 35);
            btnJugar.TabIndex = 8;
            btnJugar.Text = "JUGAR";
            btnJugar.UseVisualStyleBackColor = true;
            btnJugar.Click += btnJugar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(32, 282);
            label6.Name = "label6";
            label6.Size = new Size(142, 25);
            label6.TabIndex = 9;
            label6.Text = "CPU ha elegido: ";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lbl.Location = new Point(32, 331);
            lbl.Name = "lbl";
            lbl.Size = new Size(94, 25);
            lbl.TabIndex = 10;
            lbl.Text = "Resultado:";
            lbl.Click += label7_Click;
            // 
            // lbls
            // 
            lbls.AutoSize = true;
            lbls.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lbls.Location = new Point(32, 375);
            lbls.Name = "lbls";
            lbls.Size = new Size(71, 25);
            lbls.TabIndex = 11;
            lbls.Text = "Puntos:";
            // 
            // lblCPU
            // 
            lblCPU.AutoSize = true;
            lblCPU.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblCPU.Location = new Point(202, 282);
            lblCPU.Name = "lblCPU";
            lblCPU.Size = new Size(0, 25);
            lblCPU.TabIndex = 12;
            lblCPU.Click += lblCPU_Click;
            // 
            // btnPiedra
            // 
            btnPiedra.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnPiedra.Location = new Point(249, 98);
            btnPiedra.Name = "btnPiedra";
            btnPiedra.Size = new Size(114, 76);
            btnPiedra.TabIndex = 13;
            btnPiedra.Text = "Piedra";
            btnPiedra.UseVisualStyleBackColor = true;
            btnPiedra.Click += btnPiedra_Click;
            // 
            // btnPapel
            // 
            btnPapel.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnPapel.Location = new Point(421, 98);
            btnPapel.Name = "btnPapel";
            btnPapel.Size = new Size(114, 76);
            btnPapel.TabIndex = 14;
            btnPapel.Text = "Papel";
            btnPapel.UseVisualStyleBackColor = true;
            btnPapel.Click += btnPapel_Click;
            // 
            // btnTijera
            // 
            btnTijera.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnTijera.Location = new Point(595, 98);
            btnTijera.Name = "btnTijera";
            btnTijera.Size = new Size(114, 76);
            btnTijera.TabIndex = 15;
            btnTijera.Text = "Tijera";
            btnTijera.UseVisualStyleBackColor = true;
            btnTijera.Click += btnTijera_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(268, 216);
            label9.Name = "label9";
            label9.Size = new Size(0, 25);
            label9.TabIndex = 16;
            label9.Click += label9_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(133, 216);
            label11.Name = "label11";
            label11.Size = new Size(106, 25);
            label11.TabIndex = 18;
            label11.Text = "Usted elige";
            label11.Click += label11_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(202, 331);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 25);
            lblResultado.TabIndex = 19;
            // 
            // lblPuntos
            // 
            lblPuntos.AutoSize = true;
            lblPuntos.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblPuntos.Location = new Point(202, 375);
            lblPuntos.Name = "lblPuntos";
            lblPuntos.Size = new Size(0, 25);
            lblPuntos.TabIndex = 20;
            lblPuntos.Click += label4_Click_1;
            // 
            // btnContinuar
            // 
            btnContinuar.Location = new Point(653, 358);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(75, 23);
            btnContinuar.TabIndex = 21;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = true;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // Jugadas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnContinuar);
            Controls.Add(lblPuntos);
            Controls.Add(lblResultado);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(btnTijera);
            Controls.Add(btnPapel);
            Controls.Add(btnPiedra);
            Controls.Add(lblCPU);
            Controls.Add(lbls);
            Controls.Add(lbl);
            Controls.Add(label6);
            Controls.Add(btnJugar);
            Controls.Add(label5);
            Controls.Add(lblRonda);
            Controls.Add(label3);
            Controls.Add(lblJugador);
            Controls.Add(label1);
            Name = "Jugadas";
            Text = "Jugadas";
            Load += Jugadas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblJugador;
        private Label label3;
        private Label lblRonda;
        private Label label5;
        private Button btnJugar;
        private Label label6;
        private Label lbl;
        private Label lbls;
        private Label lblCPU;
        private Button btnPiedra;
        private Button btnPapel;
        private Button btnTijera;
        private Label label9;
        private Label label11;
        private Label lblResultado;
        private Label lblPuntos;
        private Button btnContinuar;
    }
}