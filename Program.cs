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
            int CartasJugador = 2;
            Console.WriteLine("Que comience el juego, tienes: " + CartasJugador + "  cartas en mano");
            return CartasJugador;

        }


        /// <summary>
        /// le dimos a elegir al jugador sobre si desea tener una nueva carta o no
        /// </summary>
        /// <returns>S para si, N para no</returns>

        // static string PedirCartas()
        //{

        // Console.WriteLine("¿Desea una nueva carta?");
        //Console.WriteLine("s = si"); // s para si 
        //Console.WriteLine("n = no"); //n para no 

        //string opcion = Convert.ToString(Console.ReadLine());
        //return opcion;
        // }
        /// <summary>
        /// haremos una condicional if, para ver si le damos una carta al jugador dependiendo de la opcion que eligio
        /// </summary>
        /// <param name="CartasJugador">conjunto con el que comenzó (0)</param>
        /// <param name="opcion">eleccion del jugador sobre si desea una carta nueva</param>
        /// <param name="cartaAleatoria">carta generada de manera aleatoria del 1 al 11</param>
        //static void EntregaDeCarta(int CartasJugador, string opcion, int cartaAleatoria)
        //{
        //   if (opcion == "s")
        // {
        //     Console.WriteLine("cartas en mano: " + cartaAleatoria);
        //}
        //else if (opcion == "n")
        //{
        //Console.WriteLine("cartas en mano: " + CartasJugador);
        //}
        //else
        //{
        //  Console.WriteLine("comando no valido, por favor, elija una de las siguientes opciones: S= si, N = no");
        //}
        //}
        /// <summary>
        /// sumatoria de puntos del jugador 
        /// </summary>
        /// <param name="CartaAleatoria">carta generada aleatoriamente</param>
        /// <param name="CartasJugador">cartas que tiene el jugador (0)</param>

        static void sumaPuntos(int CartasJugador, int cartaAleatoria, string opcion2)
        {




            int suma = cartaAleatoria + CartasJugador; //sumamos el numero de cartas del jugador con el puntaje de las cartas aleatorias
            Console.WriteLine("total de puntos: " + suma);



        }


        static int suma = 2;

        static void Main(string[] args)
        {
            int CartasJugador = NumeroCartas();



            // hacemos un ciclo while para que el jugador pueda pedir varias veces ua carta hasta llegar a 21 
            while (suma < 21)
            {
                Console.WriteLine("¿Desea una nueva carta?");
                Console.WriteLine("1) = si"); // s para si 
                Console.WriteLine("2) = no"); //n para no 
                int opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 1)
                {
                    Random rnd = new Random();
                    int aiCarta = rnd.Next(1, 12);



                    suma = aiCarta + suma; //sumamos el numero de cartas del jugador con el puntaje de las cartas aleatorias


                    Console.WriteLine("puntos de cartas: " + suma);
                } ///
                  ///Cuando el jugador se detenga, generar aleatoriamente un número entre el 17 y el 26 (incluyendo ambos números). Este será el valor de "la casa" contra el cual debe competir el número obtenido por las cartas del jugador.

                  ///
                else if (opcion == 2)
                {

                    Random rnd = new Random();
                    int lehouseAi = rnd.Next(17, 26);
                    Console.WriteLine("La casa tiene: " + lehouseAi);

                    // El jugador obtiene un 21 y la casa obtiene un número menor
                    if (suma == 21 && lehouseAi > 21) 
                    {
                        Console.WriteLine("Gano " + suma);
                    }
                    else if (suma > lehouseAi && suma < 21)
                    {
                        Console.WriteLine("Gano " + suma);
                    }
                    //La casa obtiene un número mayor a 21 y el jugador obtiene un número menor o igual que 21.
                    if (lehouseAi > 21 && suma <= 21)
                    {
                        Console.WriteLine("Gano " + suma);
                    }
                    //El jugador y la casa obtienen un número menor o igual a 21, pero el jugador obtiene un número más alto.
                    else if (suma > lehouseAi && suma < 21) // 9. (fix) Modificar el valor del as; tomarlo con valor de 11 cuando sea posible hacerlo sin que el número total del jugador sobrepase el límite de 21, o en caso contrario tomarlo con valor de 1.
                    {
                        Console.WriteLine("Gano  " + suma);
                    }
                    //La casa obtiene un número mayor a 21 y el jugador obtiene un número menor o igual que 21.
                    if (lehouseAi > 21 && suma <= 21)
                    {
                        Console.WriteLine("Ganó el jugador con " + suma);
                    }
                    Console.WriteLine(CartasJugador);
                    

                    // El jugador obtiene un 21 y la casa obtiene un numero menor
                     if (suma == 21 )
                    {
                            Console.WriteLine("Gano el jugador con " + suma);
                    }
                    if (suma > 21 )
                    {
                            Console.WriteLine("Gana la casa");
                    }


                
                   
                    
                   
                }
            }
        }












    }
}












