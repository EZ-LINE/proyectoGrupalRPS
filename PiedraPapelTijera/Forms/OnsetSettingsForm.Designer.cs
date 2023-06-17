namespace Forms
{
    partial class OnsetSettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            botonIniciar = new Customs.MyButtons();
            labelNroJugadores = new Label();
            labelNroRondas = new Label();
            textNroJugadores = new TextBox();
            textNroRondas = new TextBox();
            botonPlay = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // botonIniciar
            // 
            botonIniciar.BackColor = Color.HotPink;
            botonIniciar.BackgroundColor = Color.HotPink;
            botonIniciar.BorderColor = Color.Gold;
            botonIniciar.BorderRadius = 60;
            botonIniciar.BorderSize = 3;
            botonIniciar.Cursor = Cursors.Hand;
            botonIniciar.FlatAppearance.BorderSize = 0;
            botonIniciar.FlatAppearance.MouseOverBackColor = Color.Magenta;
            botonIniciar.FlatStyle = FlatStyle.Flat;
            botonIniciar.Font = new Font("Ravie", 9F, FontStyle.Regular, GraphicsUnit.Point);
            botonIniciar.ForeColor = Color.DarkTurquoise;
            botonIniciar.Location = new Point(365, 340);
            botonIniciar.Name = "botonIniciar";
            botonIniciar.Size = new Size(70, 70);
            botonIniciar.TabIndex = 0;
            botonIniciar.Text = "INICIA JUEGO";
            botonIniciar.TextColor = Color.DarkTurquoise;
            botonIniciar.UseVisualStyleBackColor = false;
            botonIniciar.Click += botonIniciar_Click;
            // 
            // labelNroJugadores
            // 
            labelNroJugadores.AutoSize = true;
            labelNroJugadores.BackColor = Color.White;
            labelNroJugadores.Font = new Font("Bauhaus 93", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelNroJugadores.Location = new Point(33, 360);
            labelNroJugadores.Name = "labelNroJugadores";
            labelNroJugadores.Size = new Size(230, 21);
            labelNroJugadores.TabIndex = 1;
            labelNroJugadores.Text = "Nro. Jugadores (máx. 10):";
            // 
            // labelNroRondas
            // 
            labelNroRondas.AutoSize = true;
            labelNroRondas.BackColor = Color.White;
            labelNroRondas.Font = new Font("Bauhaus 93", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelNroRondas.Location = new Point(386, 360);
            labelNroRondas.Name = "labelNroRondas";
            labelNroRondas.Size = new Size(207, 21);
            labelNroRondas.TabIndex = 2;
            labelNroRondas.Text = "Nro. Rondas (máx. 10):";
            // 
            // textNroJugadores
            // 
            textNroJugadores.Location = new Point(269, 358);
            textNroJugadores.Name = "textNroJugadores";
            textNroJugadores.Size = new Size(90, 23);
            textNroJugadores.TabIndex = 3;
            // 
            // textNroRondas
            // 
            textNroRondas.Location = new Point(599, 358);
            textNroRondas.Name = "textNroRondas";
            textNroRondas.Size = new Size(90, 23);
            textNroRondas.TabIndex = 4;
            // 
            // botonPlay
            // 
            botonPlay.BackColor = Color.LawnGreen;
            botonPlay.FlatAppearance.BorderColor = Color.Green;
            botonPlay.FlatAppearance.BorderSize = 2;
            botonPlay.FlatAppearance.MouseDownBackColor = Color.GreenYellow;
            botonPlay.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            botonPlay.FlatStyle = FlatStyle.Flat;
            botonPlay.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            botonPlay.IconChar = FontAwesome.Sharp.IconChar.Play;
            botonPlay.IconColor = Color.Black;
            botonPlay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            botonPlay.IconSize = 30;
            botonPlay.Location = new Point(726, 349);
            botonPlay.Name = "botonPlay";
            botonPlay.Size = new Size(40, 40);
            botonPlay.TabIndex = 5;
            botonPlay.UseVisualStyleBackColor = false;
            botonPlay.Click += botonPlay_Click;
            // 
            // OnsetSettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.piedraPapelTijera;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 416);
            Controls.Add(botonPlay);
            Controls.Add(textNroRondas);
            Controls.Add(textNroJugadores);
            Controls.Add(labelNroRondas);
            Controls.Add(labelNroJugadores);
            Controls.Add(botonIniciar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OnsetSettingsForm";
            Text = "OnsetForm";
            Load += OnsetSettingsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Customs.MyButtons botonIniciar;
        private Label labelNroJugadores;
        private Label labelNroRondas;
        private TextBox textNroJugadores;
        private TextBox textNroRondas;
        private FontAwesome.Sharp.IconButton botonPlay;
    }
}