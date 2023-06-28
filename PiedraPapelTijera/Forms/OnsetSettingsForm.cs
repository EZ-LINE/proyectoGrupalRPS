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
        int nroJugadores;
        int nroRondas;


        public OnsetSettingsForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void OnsetSettingsForm_Load(object sender, EventArgs e)
        {
            labelNroJugadores.Visible = false;
            textNroJugadores.Visible = false;
            botonConfirmarJugadores.Visible = false;
            labelErrorJugadores.Visible = false;
            labelNroRondas.Visible = false;
            textNroRondas.Visible = false;
            botonConfirmarRondas.Visible = false;
            labelErrorRondas.Visible = false;
            botonPlay.Visible = false;
        }

        private void botonIniciar_Click(object sender, EventArgs e)
        {
            botonIniciar.Visible = false;
            IniciarJuego();
            Thread.Sleep(500);
            labelNroJugadores.Visible = true;
            textNroJugadores.Visible = true;
            textNroJugadores.Focus();
            botonConfirmarJugadores.Visible = true;
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

        private void textNroJugadores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                labelErrorJugadores.Visible = true;
                botonConfirmarJugadores.IconColor = Color.Red;
                botonConfirmarJugadores.FlatAppearance.BorderColor = Color.Red;
            }
            else
            {
                labelErrorJugadores.Visible = false;
                botonConfirmarJugadores.IconColor = Color.Green;
                botonConfirmarJugadores.FlatAppearance.BorderColor = Color.Green;
            }
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
    }
}
