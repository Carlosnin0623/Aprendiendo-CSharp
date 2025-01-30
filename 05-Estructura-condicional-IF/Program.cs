using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Estructura_condicional_IF
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 
              Las estrucuras de control no permiten controlar el flujo del sistemas, permitiendo
              que dependiendo de un resultado se ejecute una cosa u otra.
           
             */

             int n1, n2, n3;

            Console.WriteLine("########## Bienvenido ###########");
            Console.WriteLine("Este programa devolverá el mayor de 3 números");

            Console.WriteLine("Digite el primer número: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el segundo número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el tercer número: ");
            n3 = Convert.ToInt32(Console.ReadLine());


             if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("El primer número {0} es el mayor", n1);

            }else if(n2 > n3 && n2 > n1)
            {
                Console.WriteLine("El segundo número {0} es el mayor", n2);

            }else if(n3 > n1 && n3 > n2)
            {
                Console.WriteLine("El tercer número {0} es el mayor", n3);
            }else if ((n1 == n2) || (n1 == n3) && (n2 == n1) || (n2 == n3) && (n3 == n1) || (n3 == n2))
            {
                Console.WriteLine("Todos los números son iguales");
            }
            
            Console.ReadKey();

        }
    }
}
