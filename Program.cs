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
            Console.WriteLine("Que comience el juego, tienes: " + CartasJugador + "  cartas en mano");
            return CartasJugador;

        }


        /// <summary>
        /// le dimos a elegir al jugador sobre si desea tener una nueva carta o no
        /// </summary>
        /// <returns>S para si, N para no</returns>

        static string PedirCartas()
        {
            Console.WriteLine("¿Desea una nueva carta?");
            Console.WriteLine("s = si"); // s para si 
            Console.WriteLine("n = no"); //n para no 

            string opcion = Convert.ToString(Console.ReadLine());
            return opcion;
        }
        /// <summary>
        /// haremos una condicional if, para ver si le damos una carta al jugador dependiendo de la opcion que eligio
        /// </summary>
        /// <param name="CartasJugador">conjunto con el que comenzó (0)</param>
        /// <param name="opcion">eleccion del jugador sobre si desea una carta nueva</param>
        /// <param name="cartaAleatoria">carta generada de manera aleatoria del 1 al 11</param>
        static void EntregaDeCarta(int CartasJugador, string opcion, int cartaAleatoria)
        {
          if(opcion == "s")
          {
              Console.WriteLine("cartas en mano: " + cartaAleatoria);
          }
          else if(opcion == "n")
          {
              Console.WriteLine("cartas en mano: " + CartasJugador);
          }
          else
          {
              Console.WriteLine("comando no valido, por favor, elija una de las siguientes opciones: S= si, N = no");
          }
        }

        static void Main(string[] args)
        {

            int CartasJugador = NumeroCartas(); // el jugador tiene 0 cartas en mano
            string opcion = PedirCartas(); // se le dio al jugador la opcion de pedir mas cartas

            int cartaAleatoria = generarCartas();
            
            EntregaDeCarta(CartasJugador, opcion, cartaAleatoria);

        }









    }
}

