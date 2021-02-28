using System;

namespace Blackjack
{
    class Program
    {
      
        /// <summary>
        /// Entregar a usuario conjunto de cartas vacio, 
        ///  
        /// </summary>
        /// <returns>el usuario tiene 0 cartas</returns>

        static int conjuntoDeCartas()
        {
           // entregamos al jugador un conjunto de cartas vacio
            int cartasjugador = 0;

            Console.WriteLine("Empecemos, su mano tiene " + cartasjugador + " cartas");
           
            
            
            int opcionCarta = Convert.ToInt32(Console.ReadLine());
            return opcionCarta;
            

        }
        /// <summary>
        /// preguntar si el jugador desea una nueva carta
        /// </summary>
        /// <returns>1) pedira carta, 2) No quiero</returns>
        static int pedirNuevaCarta()
        {
            Console.WriteLine("Conjunto de cartas vacio, ¿Quieres una carta?");
            Console.WriteLine("1) Pedir carta");
            Console.WriteLine("2) No quiero");

            int nuevaCarta = Convert.ToInt32(Console.ReadLine());
            return nuevaCarta;
        }
        
         static int MostrarCartaRandom()
        {
            /// <summary>
            ///  Si el jugador solicita una carta, generar aleatoriamente una carta de una baraja y agregarla a las cartas que tiene el jugador.
            /// </summary>
            /// <returns>La carta random que genre el sistema del 1 al 12</returns>
            Random rnd = new Random();
            //numeros random del 1 al 11 tomamos as como 11
            int option = rnd.Next(1, 12);
            return option;
        }

        
        

        static void Main(string[] args)
        {
            int opcionCarta = conjuntoDeCartas();
            
            int nuevaCarta = pedirNuevaCarta();

             //TODO: Se entrega la carta random
            int aiOption = MostrarCartaRandom();
            Console.WriteLine("Mano: " + aiOption);
         

         
         
            

            
            

        }
    }
}
        