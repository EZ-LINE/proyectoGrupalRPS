using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Forms
{
    public partial class OnsetSettingsForm : Form
    {
        MainForm mainForm;
        SoundPlayer startGame;
        int nroJugadores = 0;
        int nroRondas = 0;
        List<String> jugadores = new List<String>();
        

        public OnsetSettingsForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void OnsetSettingsForm_Load(object sender, EventArgs e)
        {
            lblNewPlayer.Visible = false;
            textnewPlayerInput.Visible = false;
            labelNroRondas.Visible = false;
            textNroRondas.Visible = false;
            botonConfirmarRondas.Visible = false;
            labelErrorRondas.Visible = false;
            botonPlay.Visible = false;
            playerInputError.Visible = false;
        }

        private void botonIniciar_Click(object sender, EventArgs e)
        {
            botonIniciar.Visible = false;
            IniciarJuego();
            Thread.Sleep(500);
            lblNewPlayer.Visible = true;
            textnewPlayerInput.Visible = true;
            textnewPlayerInput.Focus();
            labelNroRondas.Visible = true;
            textNroRondas.Visible = true;
            botonConfirmarRondas.Visible = true;
            botonPlay.Visible = true;
            botonPlay.Enabled = true;
        }

        private void botonPlay_Click(object sender, EventArgs e)
        {
            //necesito que le mandes la lista de jugadores y los resultados, por aca o por separado.
            //mainForm.OpenChildForms(new RPS_3Form());
            mainForm.OpenChildForms(new Jugadas(nroRondas, nroJugadores));

        }

        private void IniciarJuego()
        {
            startGame = new SoundPlayer(Properties.Resources.inicio);
            startGame.Play();
        }


        private void textNroRondas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                labelErrorRondas.Visible = true;
                botonConfirmarRondas.IconColor = Color.Red;
                botonConfirmarRondas.FlatAppearance.BorderColor = Color.Red;
            }
            else
            {
                labelErrorRondas.Visible = false;
                botonConfirmarRondas.IconColor = Color.Green;
                botonConfirmarRondas.FlatAppearance.BorderColor = Color.Green;
            }
        }

        private void labelNroJugadores_Click(object sender, EventArgs e)
        {

        }

        private void textnewPlayer_TextChanged(object sender, EventArgs e)
        {

        }

        private void addNewPlayerButton_Click(object sender, EventArgs e)
        {
            //add new player
            if (textnewPlayerInput.Text != "" && nroJugadores < 10) 
            {
                //field is not empty. Add new player
                playerInputError.Visible = false;
                nroJugadores++;
                jugadores.Add(textnewPlayerInput.Text);
                lblTotalPlayers.Text = "Jugadores activos: "+nroJugadores;
                textnewPlayerInput.Text = "";
            } else if (nroJugadores>= 10) 
            {
                playerInputError.Visible = true;
                playerInputError.Text = "ⓘError: Se supero la cantidad maxima de jugadores (10)";
            }else 
            {
                playerInputError.Visible = true;
                playerInputError.Text = "ⓘError: El nombre no puede estar vacio";
            }
        }
    }
    
    

}
