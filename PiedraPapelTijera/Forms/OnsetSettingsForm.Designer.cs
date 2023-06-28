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
            this.botonIniciar = new Forms.Customs.MyButtons();
            this.lblNewPlayer = new System.Windows.Forms.Label();
            this.labelNroRondas = new System.Windows.Forms.Label();
            this.textnewPlayerInput = new System.Windows.Forms.TextBox();
            this.textNroRondas = new System.Windows.Forms.TextBox();
            this.botonPlay = new FontAwesome.Sharp.IconButton();
            this.botonConfirmarRondas = new FontAwesome.Sharp.IconButton();
            this.labelErrorRondas = new System.Windows.Forms.Label();
            this.addNewPlayerButton = new FontAwesome.Sharp.IconButton();
            this.lblTotalPlayers = new System.Windows.Forms.Label();
            this.playerInputError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonIniciar
            // 
            this.botonIniciar.BackColor = System.Drawing.Color.HotPink;
            this.botonIniciar.BackgroundColor = System.Drawing.Color.HotPink;
            this.botonIniciar.BorderColor = System.Drawing.Color.Gold;
            this.botonIniciar.BorderRadius = 60;
            this.botonIniciar.BorderSize = 3;
            this.botonIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonIniciar.FlatAppearance.BorderSize = 0;
            this.botonIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.botonIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.botonIniciar.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.botonIniciar.Location = new System.Drawing.Point(365, 340);
            this.botonIniciar.Name = "botonIniciar";
            this.botonIniciar.Size = new System.Drawing.Size(70, 70);
            this.botonIniciar.TabIndex = 0;
            this.botonIniciar.Text = "INICIA JUEGO";
            this.botonIniciar.TextColor = System.Drawing.Color.DarkTurquoise;
            this.botonIniciar.UseVisualStyleBackColor = false;
            this.botonIniciar.Click += new System.EventHandler(this.botonIniciar_Click);
            // 
            // lblNewPlayer
            // 
            this.lblNewPlayer.AutoSize = true;
            this.lblNewPlayer.BackColor = System.Drawing.Color.White;
            this.lblNewPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewPlayer.Location = new System.Drawing.Point(41, 38);
            this.lblNewPlayer.Name = "lblNewPlayer";
            this.lblNewPlayer.Size = new System.Drawing.Size(140, 24);
            this.lblNewPlayer.TabIndex = 1;
            this.lblNewPlayer.Text = "Nuevo Jugador";
            this.lblNewPlayer.Click += new System.EventHandler(this.labelNroJugadores_Click);
            // 
            // labelNroRondas
            // 
            this.labelNroRondas.AutoSize = true;
            this.labelNroRondas.BackColor = System.Drawing.Color.White;
            this.labelNroRondas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNroRondas.Location = new System.Drawing.Point(386, 360);
            this.labelNroRondas.Name = "labelNroRondas";
            this.labelNroRondas.Size = new System.Drawing.Size(204, 24);
            this.labelNroRondas.TabIndex = 2;
            this.labelNroRondas.Text = "Nro. Rondas (máx. 10):";
            // 
            // textnewPlayerInput
            // 
            this.textnewPlayerInput.Location = new System.Drawing.Point(41, 82);
            this.textnewPlayerInput.Name = "textnewPlayerInput";
            this.textnewPlayerInput.Size = new System.Drawing.Size(199, 23);
            this.textnewPlayerInput.TabIndex = 3;
            this.textnewPlayerInput.TextChanged += new System.EventHandler(this.textnewPlayer_TextChanged);
            // 
            // textNroRondas
            // 
            this.textNroRondas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNroRondas.Location = new System.Drawing.Point(599, 358);
            this.textNroRondas.Name = "textNroRondas";
            this.textNroRondas.Size = new System.Drawing.Size(40, 23);
            this.textNroRondas.TabIndex = 4;
            this.textNroRondas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNroRondas_KeyPress);
            // 
            // botonPlay
            // 
            this.botonPlay.BackColor = System.Drawing.Color.LawnGreen;
            this.botonPlay.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.botonPlay.FlatAppearance.BorderSize = 2;
            this.botonPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.botonPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.botonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonPlay.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.botonPlay.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.botonPlay.IconColor = System.Drawing.Color.Black;
            this.botonPlay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.botonPlay.IconSize = 30;
            this.botonPlay.Location = new System.Drawing.Point(726, 349);
            this.botonPlay.Name = "botonPlay";
            this.botonPlay.Size = new System.Drawing.Size(40, 40);
            this.botonPlay.TabIndex = 5;
            this.botonPlay.TabStop = false;
            this.botonPlay.UseVisualStyleBackColor = false;
            this.botonPlay.Click += new System.EventHandler(this.botonPlay_Click);
            // 
            // botonConfirmarRondas
            // 
            this.botonConfirmarRondas.BackColor = System.Drawing.Color.Black;
            this.botonConfirmarRondas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.botonConfirmarRondas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonConfirmarRondas.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.botonConfirmarRondas.IconColor = System.Drawing.Color.White;
            this.botonConfirmarRondas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.botonConfirmarRondas.IconSize = 20;
            this.botonConfirmarRondas.Location = new System.Drawing.Point(645, 358);
            this.botonConfirmarRondas.Name = "botonConfirmarRondas";
            this.botonConfirmarRondas.Size = new System.Drawing.Size(23, 23);
            this.botonConfirmarRondas.TabIndex = 7;
            this.botonConfirmarRondas.TabStop = false;
            this.botonConfirmarRondas.UseVisualStyleBackColor = false;
            this.botonConfirmarRondas.Click += new System.EventHandler(this.botonConfirmarRondas_Click);
            // 
            // labelErrorRondas
            // 
            this.labelErrorRondas.AutoSize = true;
            this.labelErrorRondas.BackColor = System.Drawing.Color.White;
            this.labelErrorRondas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelErrorRondas.ForeColor = System.Drawing.Color.Red;
            this.labelErrorRondas.Location = new System.Drawing.Point(401, 384);
            this.labelErrorRondas.Name = "labelErrorRondas";
            this.labelErrorRondas.Size = new System.Drawing.Size(267, 13);
            this.labelErrorRondas.TabIndex = 9;
            this.labelErrorRondas.Text = "ⓘ ERROR. Solo ingrese números (mín. 1 - máx. 10)";
            // 
            // addNewPlayerButton
            // 
            this.addNewPlayerButton.BackColor = System.Drawing.Color.LawnGreen;
            this.addNewPlayerButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.addNewPlayerButton.FlatAppearance.BorderSize = 2;
            this.addNewPlayerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.addNewPlayerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.addNewPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewPlayerButton.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addNewPlayerButton.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.addNewPlayerButton.IconColor = System.Drawing.Color.Black;
            this.addNewPlayerButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addNewPlayerButton.IconSize = 30;
            this.addNewPlayerButton.Location = new System.Drawing.Point(246, 78);
            this.addNewPlayerButton.Name = "addNewPlayerButton";
            this.addNewPlayerButton.Size = new System.Drawing.Size(25, 23);
            this.addNewPlayerButton.TabIndex = 10;
            this.addNewPlayerButton.TabStop = false;
            this.addNewPlayerButton.UseVisualStyleBackColor = false;
            this.addNewPlayerButton.Click += new System.EventHandler(this.addNewPlayerButton_Click);
            // 
            // lblTotalPlayers
            // 
            this.lblTotalPlayers.AutoSize = true;
            this.lblTotalPlayers.BackColor = System.Drawing.Color.White;
            this.lblTotalPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalPlayers.Location = new System.Drawing.Point(41, 159);
            this.lblTotalPlayers.Name = "lblTotalPlayers";
            this.lblTotalPlayers.Size = new System.Drawing.Size(181, 24);
            this.lblTotalPlayers.TabIndex = 11;
            this.lblTotalPlayers.Text = "Jugadores activos: 0";
            // 
            // playerInputError
            // 
            this.playerInputError.AutoSize = true;
            this.playerInputError.BackColor = System.Drawing.Color.White;
            this.playerInputError.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playerInputError.ForeColor = System.Drawing.Color.Red;
            this.playerInputError.Location = new System.Drawing.Point(41, 113);
            this.playerInputError.Name = "playerInputError";
            this.playerInputError.Size = new System.Drawing.Size(52, 13);
            this.playerInputError.TabIndex = 12;
            this.playerInputError.Text = "ⓘERROR";
            // 
            // OnsetSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Forms.Properties.Resources.piedraPapelTijera;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 416);
            this.Controls.Add(this.playerInputError);
            this.Controls.Add(this.lblTotalPlayers);
            this.Controls.Add(this.addNewPlayerButton);
            this.Controls.Add(this.labelErrorRondas);
            this.Controls.Add(this.botonConfirmarRondas);
            this.Controls.Add(this.botonPlay);
            this.Controls.Add(this.textNroRondas);
            this.Controls.Add(this.textnewPlayerInput);
            this.Controls.Add(this.labelNroRondas);
            this.Controls.Add(this.lblNewPlayer);
            this.Controls.Add(this.botonIniciar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OnsetSettingsForm";
            this.Text = "OnsetForm";
            this.Load += new System.EventHandler(this.OnsetSettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Customs.MyButtons botonIniciar;
        private Label lblNewPlayer;
        private Label labelNroRondas;
        private TextBox textnewPlayerInput;
        private TextBox textNroRondas;
        private FontAwesome.Sharp.IconButton botonPlay;
        private FontAwesome.Sharp.IconButton botonConfirmarRondas;
        private Label labelErrorRondas;
        private FontAwesome.Sharp.IconButton addNewPlayerButton;
        private Label lblTotalPlayers;
        private Label playerInputError;
    }
}