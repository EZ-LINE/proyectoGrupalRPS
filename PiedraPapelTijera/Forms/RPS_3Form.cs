using Forms.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class RPS_3Form : Form
    {
        string[] nombreJugadores;
        public int[,] resultados;
        int currentPlayer; 
        
        public RPS_3Form(string[] nombreJugadores, int[,] resultados)
        {
            this.nombreJugadores = nombreJugadores;
            this.resultados = resultados;
            currentPlayer = 0;

            InitializeComponent();
            PlayEndgameSequence();
           
        }

        private void PlayEndgameSequence() 
        {
            UpdatePlayerCounter(0);
            //Encontrar un archivo compatible wav es dolor. Esto va a crashear dado que este archivo no existe
            SoundPlayer sadHorn = new SoundPlayer("resources/sadHorn.wav");
            
            txtCongratulations.Text = "GAME: ...";
            System.Threading.Thread.Sleep(1000);
            txtCongratulations.Text = "GAME: COMPLETE";
            System.Threading.Thread.Sleep(200);
            sadHorn.Play();
            LoadPlayer(0);


        }

        private void UpdatePlayerCounter(int i) 
        {
            playerCounter.Text = i+"/" + nombreJugadores.Length;
        }

        public void LoadPlayer(int slot) 
        {
            int timer = 150;
            ClackAndWait(timer);
            txtPlayerName.Text = nombreJugadores[slot];
            txtPlayerName.Visible = true;
            ClackAndWait(timer);
            txtWin.Text = ""+resultados[slot, 0];
            txtWin.Visible = true;
            ClackAndWait(timer);
            txtLoss.Text = "" + resultados[slot, 1];
            txtLoss.Visible = true;
            ClackAndWait(timer);
            txtDraw.Text = "" + resultados[slot, 2];
            txtDraw.Visible= true;
            ClackAndWait(timer);
            txtScore.Text = "" + resultados[slot, 3];
            txtScore.Visible = true;    
        }

        //Esto podria ser incluso mas elegante si esta funcion recibiera el label entero con el texto a mostrar, 
        //de tal forma que la funcion anterior se reduce a 4 lineas
        private void ClackAndWait(int time) 
        {
            SoundPlayer clack = new SoundPlayer(Resources.click);
            clack.Play();
            System.Threading.Thread.Sleep(time);
        }

        private void GameCompleteText(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNextPlayer_Click(object sender, EventArgs e)
        {
            //try to load next player
            _ = currentPlayer < nombreJugadores.Length ? currentPlayer++ : currentPlayer = 0;
            /*if (currentPlayer > nombreJugadores.Length)
            {
                currentPlayer++;
   
            }
            else 
            {
                currentPlayer = 0;

            }*/
            LoadPlayer(currentPlayer);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPreviousPlayer_Click(object sender, EventArgs e)
        {
            //try to load previous player
            _ = currentPlayer > 0 ? currentPlayer-- : currentPlayer = nombreJugadores.Length;
        }

        private void playerLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

/*        static void MostrarEstadisticasIndividuales(string[] nombresJugadores, int[,] resultados)
        {
            StringBuilder estadisticasIndividuales = new StringBuilder();
            for (int i = 0; i < nombresJugadores.Length; i++)
            {
                estadisticasIndividuales.AppendLine($"Jugador: {nombresJugadores[i]}");
                estadisticasIndividuales.AppendLine($"Ganados: {resultados[i, 0]}");
                estadisticasIndividuales.AppendLine($"Empatados: {resultados[i, 1]}");
                estadisticasIndividuales.AppendLine($"Perdidos: {resultados[i, 2]}");
                estadisticasIndividuales.AppendLine($"Puntos: {resultados[i, 3]}");
                estadisticasIndividuales.AppendLine("\n");
            }
            Console.WriteLine(estadisticasIndividuales.ToString());
        }

        static int ObtenerIndiceGanador(int[,] resultados)
        {
            int indiceGanador = 0;
            int mayorPuntos = resultados[0, 3];

            for (int i = 1; i < resultados.GetLength(0); i++)
            {
                if (resultados[i, 3] > mayorPuntos)
                {
                    mayorPuntos = resultados[i, 3];
                    indiceGanador = i;
                }
            }
            return indiceGanador;
        }

        static void MostrarGanadorTorneo(string[] nombresJugadores, int[,] resultados)
        {
            int indiceGanador = ObtenerIndiceGanador(resultados);
            string ganador = nombresJugadores[indiceGanador];
            StringBuilder mostrarGanador = new StringBuilder();

            mostrarGanador.AppendLine("Estadísticas generales:");
            mostrarGanador.AppendLine($"El ganador del torneo es: {ganador}\n");
            Console.WriteLine(mostrarGanador.ToString());
        }

        static void MostrarTablaPosiciones(string[] nombresJugadores, int[,] resultados)
        {
            for (int i = 0; i < nombresJugadores.Length; i++)
            {
                for (int j = i + 1; j < nombresJugadores.Length; j++)
                {
                    if (resultados[j, 3] > resultados[i, 3])
                    {
                        int tempPuntos = resultados[i, 3];
                        resultados[i, 3] = resultados[j, 3];
                        resultados[j, 3] = tempPuntos;

                        int tempGanados = resultados[i, 0];
                        resultados[i, 0] = resultados[j, 0];
                        resultados[j, 0] = tempGanados;

                        int tempEmpatados = resultados[i, 1];
                        resultados[i, 1] = resultados[j, 1];
                        resultados[j, 1] = tempEmpatados;

                        int tempPerdidos = resultados[i, 2];
                        resultados[i, 2] = resultados[j, 2];
                        resultados[j, 2] = tempPerdidos;

                        string tempNombre = nombresJugadores[i];
                        nombresJugadores[i] = nombresJugadores[j];
                        nombresJugadores[j] = tempNombre;
                    }
                }
            }

            StringBuilder tablaPosiciones = new StringBuilder();

            tablaPosiciones.AppendLine("Tabla de Posiciones:");
            tablaPosiciones.AppendLine("-----------------------------------------");
            tablaPosiciones.AppendLine("Posición\tJugador\t\tPuntos");
            tablaPosiciones.AppendLine("-----------------------------------------");

            for (int i = 0; i < nombresJugadores.Length; i++)
            {
                tablaPosiciones.AppendLine($"{i + 1}\t\t{nombresJugadores[i]}\t\t{resultados[i, 3]}");
            }

            tablaPosiciones.AppendLine("-----------------------------------------\n");
            Console.WriteLine(tablaPosiciones.ToString());
        }
    }*/
