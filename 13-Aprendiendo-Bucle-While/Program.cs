using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Aprendiendo_Bucle_While
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 
             *
             *  Ciclo While: Este bucle es ideal cuando no sabemos la cantidad de elementos
             *  que vamos a recorrer como por ejemplo los registros de una tabla de una base de datos
             *  
             *  while (condicion){
             *    // Codigo
             *  }
             *
             */

            int temperatura;

            Console.WriteLine("Ingrese la temperatura ");
            temperatura = Convert.ToInt32(Console.ReadLine());

            while(temperatura > 20)
            {
                temperatura--;
                Console.WriteLine("La temperatura -> {0}", temperatura);
            }

            Console.WriteLine("La temperatura final");

            Console.ReadKey();
        }
    }
}
