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
        

        
        

        static void Main(string[] args)
        {
            int opcionCarta = SelectOption();
            //Console.WriteLine("mano: " + opcionCarta);

         
         
            

            
            

        }
    }
}
        