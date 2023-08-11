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
        int playerSpeed = 12; // La velocidad del jugador comienza en 12 km/h.
        int score; // Puntuación del juego.
        int carImage; // Cantidad de coches en enteros.

        Random rnd = new Random(); // Variable Aleatoria.
        Random carPos = new Random(); // La posición de los coches del circuito pueden variar.
        bool goLeft, goRight; // Dependerá de que los coches puedan moverse hacia la izquierda o hacia la derecha.

        // Clase de la interfaz.

        public Form1()
        {
            InitializeComponent(); // Método de inicialización de los componentes de la interfaz.
            resetGame(); // Llamado del método anterior para reiniciar el juego.
        }

        // Método de ejecución cuando presiona una tecla.

        private void TeclaPresionada(object sender, KeyEventArgs e)
        {
            // Esto ayudará de que la tecla presionada correctamente del teclado permita mover de izquierda a derecha.

            if (e.KeyCode == Keys.Left) // Si presiona la tecla izquierda del teclado.
            {
                goLeft = true; // Va hacia la izquierda.
            }

            if (e.KeyCode == Keys.Right) // Si presiona la tecla derecha del teclado.
            {
                goRight = true; // Va hacia la derecha.
            }
        }

        // Método de ejecución cuando suelta una tecla.

        private void TeclaSoltada(object sender, KeyEventArgs e)
        {
            // Esto ayudará a que la tecla suelta del teclado pueda mantener en su posición original (No se mueve de un lado a otro).

            if (e.KeyCode == Keys.Left) // Si suelta la tecla izquierda del teclado.
            {
                goLeft = false; // Se mantiene.
            }

            if (e.KeyCode == Keys.Right) // Si suelta la tecla derecha del teclado.
            {
                goRight = false; // Se mantiene.
            }
        }

        // Evento del temporizador del juego.

        private void EventoTemporizadorJuego(object sender, EventArgs e)
        {
            // Con este evento hará que el jugador se mueva hacia la izquierda o hacia la derecha.

            if (goLeft == true && Player.Left > 5) // Si el jugador va hacia la izquierda.
            {
                Player.Left -= playerSpeed; // La velocidad del jugador desciende.
            }

            if (goRight == true && Player.Right < 422) // Si el jugador va hacia la derecha.
            {
                Player.Left += playerSpeed; // La velocidad del jugador aumenta.
            }

            // Con esto haremos que la pista del circuito se mueva hacia abajo.

            pistaCircuito1.Top += roadSpeed; // Para la pista 1.
            pistaCircuito2.Top += roadSpeed; // Para la pista 2.

            if (pistaCircuito2.Top > 425) // Para la pista 2.
            {
                pistaCircuito2.Top = -425; // Con esta pista se va encajando hacia al panel.
            }

            if (pistaCircuito1.Top > 425) // Para la pista 1.
            {
                pistaCircuito1.Top = -425; // Se repite el mismo procedimiento pero con otra pista.
            }
        }

        // Nuevo método para los coches de la interfaz sabiendo que la posición de los coches pueden variar.

        private void changeAICars(PictureBox tempCar)
        {
            // EN INSTANTES...
        }

        // Nuevo método para terminar una partida.

        private void gameOver()
        {
            // EN INSTANTES...
        }

        // Nuevo método para reiniciar el juego.

        private void resetGame()
        {
            // Crearemos un procedimiento mucho más complejo.

            botonInicio.Enabled = false; // Por el momento, la función de este componente no está activada.
            explosion.Visible = false; // No se visualizará la explosión al generar un efecto especial cuando tropieza o colisiona con cualquier objeto.
            logros.Visible = false; // No se visualizarán los premios al alcanzar los objetivos.
            goLeft = false; // No se irá hacia el lado izquierdo del circuito.
            goRight = false; // No se irá hacia el lado derecho del circuito.
            score = 0; // La puntuación se inicializa en 0.
            logros.Image = Properties.Resources.bronze; // La imagen es obtener un premio de bronce.

            roadSpeed = 12; // La velocidad del circuito se inicializa en 12 km/h.
            trafficSpeed = 15; // La velocidad del tráfico entre los coches se inicializa en 15 km/h.

            // Para el coche 1:

            AI1.Top = carPos.Next(200, 500) * -1; // Hacia adelante o hacia atrás.
            AI1.Left = carPos.Next(5, 200); // Hacia los lados.

            // Para el coche 2:

            AI2.Top = carPos.Next(200, 500) * -1; // Hacia adelante o hacia atrás.
            AI2.Left = carPos.Next(245, 422); // Hacia los lados.

            gameTimer.Start(); // ¡¡¡¡QUE EMPIECE EL JUEGO!!!!.

        }

        // Nuevo método para reconocimiento de archivos multimedia.

        private void playSound()
        {
            // EN INSTANTES...
        }
    }
}
