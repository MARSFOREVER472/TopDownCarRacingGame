using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopDownCarRacing
{
    public partial class Form1 : Form
    {
        // Variables a declarar.

        int roadSpeed; // Velocidad del circuito.
        int trafficSpeed; // Velocidad del tráfico de coches.
        int playerSpeed = 12; // La velocidad del jugador comienza de 12 km/h.
        int score; // Puntuación del juego.
        int carImage; // Cantidad de coches en enteros.

        Random rnd = new Random(); // Variable Aleatoria.
        Random carPos = new Random(); // La posición de los coches del circuito pueden variar.
        bool goLeft, goRight; // Dependerá de que los coches puedan moverse hacia la izquierda o hacia la derecha.
        public Form1()
        {
            InitializeComponent();
        }

        private void TeclaPresionada(object sender, KeyEventArgs e)
        {
            // EN INSTANTES...
        }

        private void TeclaSoltada(object sender, KeyEventArgs e)
        {
            // EN INSTANTES...
        }

        private void EventoTemporizadorJuego(object sender, EventArgs e)
        {
            // EN INSTANTES...
        }
    }
}
