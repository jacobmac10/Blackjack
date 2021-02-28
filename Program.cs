using System;

namespace Blackjack
{
    class Program
    {
      
        /// <summary>
        /// Entregar a usuario conjunto de cartas vacio, 
        ///  pedir a usuario que nos pida una carta
        /// </summary>
        /// <returns>selecciona 1 - pedir carta</returns>

        static int SelectOption()
        {
            //pedir al usuario que nos pida una carta para comenzar juego
            // 1: pedir carta
            
            Console.WriteLine("Conjunto de cartas vacio, ¿Quieres una carta?");
            Console.WriteLine("1) Pedir carta");
            Console.WriteLine("2) No");
            

            int opcionCarta = Convert.ToInt32(Console.ReadLine());
            return opcionCarta;
        }
        
         static int MostrarCartaRandom()
        {
            /// <summary>
            ///  Si el jugador solicita una carta, generar aleatoriamente una carta de una baraja y agregarla a las cartas que tiene el jugador.
            /// </summary>
            /// <returns>La carta random que genre el sistema del 1 al 11</returns>
            Random rnd = new Random();
            //numeros random del 1 al 11
            int option = rnd.Next(1, 11);
            return option;
        }

        
        

        static void Main(string[] args)
        {
            int opcionCarta = SelectOption();
            //Console.WriteLine("mano: " + opcionCarta);
             //TODO: Se entrega la carta random
            int aiOption = MostrarCartaRandom();
            Console.WriteLine("Mano: " + aiOption);

         
         
            

            
            

        }
    }
}
        