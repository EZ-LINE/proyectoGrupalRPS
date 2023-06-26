namespace Forms
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        string eleccionJugador = "R";
        string[] nombresJugadores = { "Alberto", "Juan", "pedro" };
        int ronda = 0;
        static int nroJugadores = 3;
        int[,] resultados = InicializarResultados(nroJugadores);
        int nroRondas = 3;
        
        int jugador = 0;

        public Form1()
        {
            InitializeComponent();
            btnContinuar.Enabled = false;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void lblCPU_Click(object sender, EventArgs e)
        {

        }
        static string MostrarEleccionCPU(int eleccionCPU)
        {
            string jugadaCPU;

            if (eleccionCPU == 1)
            {
                jugadaCPU = "Papel";
            }
            else if (eleccionCPU == 2)
            {
                jugadaCPU = "Piedra";
            }
            else
            {
                jugadaCPU = "Tijera";
            }
            return jugadaCPU;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblJugador.Text = $"{nombresJugadores[0]}";
            lblRonda.Text = "1";
        }


        void JugarTorneo(int ronda, string[] nombresJugadores, int[,] resultados)
        {
            if (jugador<nombresJugadores.Length)
            {
                
                btnContinuar.Enabled = false;
                lblJugador.Text = $"{nombresJugadores[jugador]}";
                //lblRonda.Text = (ronda+1 ).ToString();
                //La CPU elegirá, al azar, una opción de juego. Tendremos en cuenta las
                //siguientes referencias:
                //1 - Papel, 2 - Piedra, 3 - Tijera
                int eleccionCPU = random.Next(1, 4);

                lblCPU.Text = MostrarEleccionCPU(eleccionCPU);

                ActualizarResultados(eleccionJugador, eleccionCPU, jugador, resultados);

                btnJugar.Enabled = false;
                btnContinuar.Enabled = true;
                
            }

        }


        private void btnJugar_Click(object sender, EventArgs e)
        {
            if (ronda < nroRondas)
            {
                if (label9.Text == "Piedra")
                {
                    eleccionJugador = "R";

                }
                else if (label9.Text == "Papel")
                {
                    eleccionJugador = "P";

                }
                else if (label9.Text == "Tijera")
                {
                    eleccionJugador = "T";

                }

                JugarTorneo(ronda, nombresJugadores, resultados);
            }
            else
            {
                btnContinuar.Enabled = false;
                btnJugar.Enabled = false;
            }


        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            jugador++;
            btnJugar.Enabled = true;
            lblResultado.Text = "";
            lblPuntos.Text = "";
            lblCPU.Text = "";
            

            if (jugador < nombresJugadores.Length)
            {
                lblJugador.Text = $"{nombresJugadores[jugador]}";
            }
            else if (ronda < nroRondas)
            {
                
                ronda += 1;
                lblRonda.Text = (ronda+1).ToString();
                jugador = 0;
                   
                lblJugador.Text = $"{nombresJugadores[jugador]}";
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnPiedra_Click(object sender, EventArgs e)
        {
            label9.Text = "Piedra";
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {

            label9.Text = "Papel";
        }

        private void btnTijera_Click(object sender, EventArgs e)
        {

            label9.Text = "Tijera";
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarResultados(string eleccionJugador, int eleccionCPU, int jugador, int[,] resultados)
        {
            int resultado = CalcularResultado(eleccionJugador, eleccionCPU);
            resultados[jugador, resultado]++;

            int puntos = CalcularPuntos(resultado);
            resultados[jugador, 3] += puntos;

            lblResultado.Text = $"{ObtenerTextoResultado(resultado)}";
            lblPuntos.Text = $"{puntos}";

        }

        static int CalcularResultado(string movimientoJugador, int movimientoMaquina)
        {
            //(R - Piedra, P - Papel, T - Tijera)
            //1 - Papel, 2 - Piedra, 3 - Tijera
            int resultado = 0;
            if (movimientoJugador == "P" && movimientoMaquina == 2 || movimientoJugador == "R" && movimientoMaquina == 3
                || movimientoJugador == "T" && movimientoMaquina == 1)
            {
                resultado = 0;
            }
            else if (movimientoJugador == "P" && movimientoMaquina == 1 || movimientoJugador == "R" && movimientoMaquina == 2
                || movimientoJugador == "T" && movimientoMaquina == 3)
            {
                resultado = 1;
            }
            else
            {
                resultado = 2;
            }
            return resultado;
        }

        static int CalcularPuntos(int resultado)
        {
            int puntos = 0;

            if (resultado == 0) //Ganó el jugador
            {
                puntos = 2;
            }
            else if (resultado == 1) //Empate
            {
                puntos = 0;
            }
            else //Ganó la CPU
            {
                puntos = -1;
            }
            return puntos;
        }

        static string ObtenerTextoResultado(int resultado)
        {
            string infoResultado = "";

            if (resultado == 0)
            {
                infoResultado = "Ganaste!";
            }
            else if (resultado == 1)
            {
                infoResultado = "Empate";
            }
            else
            {
                infoResultado = "Perdiste";
            }
            return infoResultado;
        }

        static int[,] InicializarResultados(int cantidadJugadores)
        {
            //Se utiliza un arreglo bidimensional para guardar los resultados de los jugadores.
            //Las filas contendrán una longitud de acuerdo al número de jugadores, luego
            //se utilizarán las columnas para guardar los resultados generales de acuerdo al 
            //siguiente criterio:
            //[i, 0] -> ganados, [i, 1] -> empatados, [i, 2] -> perdidos, [i, 3] -> puntos
            int[,] resultados = new int[cantidadJugadores, 4];
            return resultados;
        }



        private void lblJugador_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }


    }
}