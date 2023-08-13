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
            // Editaremos un algoritmo para incrementar la puntuación.

            lblScore.Text = "Score: " + score; // Score: 0 + 1 = 1.
            score++;

            // Con este evento hará que el jugador se mueva hacia la izquierda o hacia la derecha.

            if (goLeft == true && Player.Left > 5) // Si el jugador va hacia la izquierda.
            {
                Player.Left -= playerSpeed; // La velocidad del jugador desciende.
            }

            if (goRight == true && Player.Right < 422) // Si el jugador va hacia la derecha.
            {
                Player.Left += playerSpeed; // La velocidad del jugador aumenta.
            }

            // Con esto haremos que las pistas del circuito se mueva hacia abajo.

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

            // Los coches por la pista también se moverán automáticamente.

            AI1.Top += trafficSpeed; // La velocidad del tráfico para el coche 1 incrementa.
            AI2.Top += trafficSpeed; // La velocidad del tráfico para el coche 2 incrementa.

            if (AI1.Top > 330) // Para el coche 1 del lado izquierdo.
            {
                changeAICars(AI1); // Los coches pueden variar a su elección.
            }

            if (AI2.Top > 330) // Para el coche 2 del lado derecho.
            {
                changeAICars(AI2); // Los coches pueden variar a su elección.
            }

            // Luego, haremos que el vehículo principal pueda detectar colisiones con algunos coches o camiones de la pista.

            if (Player.Bounds.IntersectsWith(AI1.Bounds) || Player.Bounds.IntersectsWith(AI2.Bounds)) // Si choca con algunos coches o camiones de la pista.
            {
                gameOver(); // El juego se acaba llamando a la función ya creada anteriormente.
            }

            // Dependiendo de la puntuación obtenida, se obtendrán cualquier logro o medalla (bronce, plata y oro, respectivamente).

            if (score > 40 && score < 500) // Si la puntuación obtenida está entre 40 y 500.
            {
                logros.Image = Properties.Resources.bronze; // Obtiene un premio de bronce.
            }

            if (score > 500 && score < 2000) // Si la puntuación obtenida está entre 500 y 2000.
            {
                logros.Image = Properties.Resources.silver; // Obtiene un premio de plata.

                // Dependiendo de la velocidad de la pista y la de tráfico de vehículos, la dificultad puede aumentar.

                roadSpeed = 20; // La velocidad de la pista se iniciará en 20 km/h.
                trafficSpeed = 22; // La velocidad del tráfico de vehículos se iniciará en 22 km/h.
            }

            if (score > 2000) // Si la puntuación obtenida es mayor que 2000.
            {
                logros.Image = Properties.Resources.gold; // Obtiene un premio de oro.

                // Dependiendo de la velocidad de la pista y la de tráfico de vehículos, la dificultad puede aumentar.

                roadSpeed = 25; // La velocidad de la pista se iniciará en 25 km/h.
                trafficSpeed = 27; // La velocidad del tráfico de vehículos se iniciará en 27 km/h.
            }
        }

        // Nuevo método para los coches de la interfaz sabiendo que la posición de los coches pueden variar.

        private void changeAICars(PictureBox tempCar)
        {
            // Ahí se pueden cambiar cualquier vehículo según su posición en la que se encuentran las imágenes.

            carImage = rnd.Next(1, 8); // Se pueden elegir 8 vehículos distintos.

            switch (carImage)
            {
                case 1: // Para el vehículo 1.
                    tempCar.Image = Properties.Resources.ambulance;
                    break;

                case 2: // Para el vehículo 2.
                    tempCar.Image = Properties.Resources.carGreen;
                    break;

                case 3: // Para el vehículo 3.
                    tempCar.Image = Properties.Resources.carGrey;
                    break;

                case 4: // Para el vehículo 4.
                    tempCar.Image = Properties.Resources.carOrange;
                    break;

                case 5: // Para el vehículo 5.
                    tempCar.Image = Properties.Resources.carPink;
                    break;

                case 6: // Para el vehículo 6.
                    tempCar.Image = Properties.Resources.CarRed;
                    break;

                case 7: // Para el vehículo 7.
                    tempCar.Image = Properties.Resources.carYellow;
                    break;

                case 8: // Para el vehículo 8.
                    tempCar.Image = Properties.Resources.TruckBlue;
                    break;

                case 9: // Para el vehículo 9.
                    tempCar.Image = Properties.Resources.TruckWhite;
                    break;
            }

            tempCar.Top = carPos.Next(100, 400) * -1; // Posición en donde se encuentra cualquier coche.

            // Para aquellos vehículos que van desde ambos lados.

            if ((string)tempCar.Tag == "carLeft") // Para un vehículo que está en el lado izquierdo.
            {
                tempCar.Left = carPos.Next(5, 200);
            }

            if ((string)tempCar.Tag == "carRight") // Para un vehículo que está en el lado derecho.
            {
                tempCar.Left = carPos.Next(245, 422);
            }
        }

        // Nuevo método para terminar una partida.

        private void gameOver()
        {
            // Por último, para finalizar, le agregaremos retoques finales al finalizar el juego.

            playSound(); // Llamado del método anterior ya creado para probar efectos de audio al finalizar el juego.
            gameTimer.Stop(); // Paraliza el temporizador.
            explosion.Visible = true; // Al colisionar con un objeto, se creará un efecto explosivo.
            Player.Controls.Add(explosion); // Se agregarán controles a la explosión.
            explosion.Location = new Point(-8, 5); // Ubicación en donde se encuentra la explosión.
            explosion.BackColor = Color.Transparent; // El color de la explosión será transparente.

            logros.Visible = true; // Se verán los logros obtenidos al finalizar la partida.
            logros.BringToFront(); // Se tiene que ver hacia al frente los logros.

            botonInicio.Visible = true; // Se puede ver el botón de inicio al finalizar la partida.
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
