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

namespace Forms
{
    public partial class OnsetSettingsForm : Form
    {
        MainForm mainForm;
        SoundPlayer startGame;

        public OnsetSettingsForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void OnsetSettingsForm_Load(object sender, EventArgs e)
        {
            labelNroJugadores.Visible = false;
            textNroJugadores.Visible = false;
            labelNroRondas.Visible = false;
            textNroRondas.Visible = false;
            botonPlay.Visible = false;
        }

        private void botonIniciar_Click(object sender, EventArgs e)
        {
            botonIniciar.Visible = false;
            IniciarJuego();
            Thread.Sleep(500);
            labelNroJugadores.Visible = true;
            textNroJugadores.Visible = true;
            labelNroRondas.Visible = true;
            textNroRondas.Visible = true;
            botonPlay.Visible = true;
        }

        private void botonPlay_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForms(new RPS_3Form());
        }

        private void IniciarJuego()
        {
            startGame = new SoundPlayer(Properties.Resources.inicio);
            startGame.Play();
        }
    }
}
