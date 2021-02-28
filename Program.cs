using System;

namespace Blackjack
{
    class Program
    {
        /// <summary>
        /// vamos a generar las cartas del juego y mostrarlas de manera aleatoria
        /// cartas del 1 al 11
        /// </summary>
        /// <returns>el valor aleatorio (aiCarta)</returns>
        static int generarCartas()
        {
            Random rnd = new Random();

            int aiCarta = rnd.Next(1, 12); // los numeros random generados seran del 1 al 11. tomando As como 11.
            return aiCarta;
        }

        /// <summary>
        /// El jugador comienza con un conjunto de cartas vacío
        /// </summary>
       
       /// <returns>el numero de cartas que tiene el jugador al comenzar el juego (0)</returns>
        static int NumeroCartas()
        {
            int CartasJugador = 0;
            Console.WriteLine("Que comience el juego, tienes: " + CartasJugador + "cartas en mano" );
            return CartasJugador;

        }

        static void Main(string[] args)
        {
            int aiCarta = generarCartas();
        }









    }
}

