using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Estructura_de_control_Swich
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*  Estructura de control Switch: El Swich lo que nos va a permitir
             *  encontrar una serie de opciones que se pueden ejecutar dentro de la
             *  misma estructura selectiva.
             */

            float a, b, resultado;
            int opcion;


            // Mostrar el menu de opciones 

            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("Elije una de la opciones anterior: ");

            opcion = Convert.ToInt32(Console.ReadLine());

            // Pedir los números
            Console.WriteLine("Ingrese el primer número: ");
            a = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Ingrese el segundo número: ");
            b = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    resultado = a + b;
                    Console.WriteLine("La suma del número {0} y el número {1} es: {2}", a, b, resultado);
                    break;
                case 2:

                    resultado = a - b;
                    Console.WriteLine("La resta del número {0} y el número {1} es: {2}", a, b, resultado);

                    break;
                case 3:

                    resultado = a * b;
                    Console.WriteLine("La multiplicación del número {0} y el número {1} es: {2}", a, b, resultado);
                    break;

                case 4:

                    resultado = a / b;
                    Console.WriteLine("La diviión del número {0} y el número {1} es: {2}", a, b, resultado);
                    break;

                default:
                    Console.WriteLine("La elección seleccionada no es valida");
                    break;
            }

            Console.ReadKey();
        }
    }
}
