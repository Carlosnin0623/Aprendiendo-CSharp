using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Operadores_relacionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             
                 Operadores Relacionales

                 Se usan para expresar la relación que existe entre dos valores

                 Estas expresiones, al igual que las expresiones aritmeticas, tienen sus 
                 propios operadores.

                 La expresión será evaluada, pero el resultado de la evaluación tendrá
                 únicamente dos valores posibles: true o false Booleanos

                Signo Operador

                == igualdad
                != No igual - Diferente
                > Mayor que
                < Menor que
                >= Mayor o igual que
                <= Menor o igual que
            
             */

            int a = 5;
            int b = 7;
            int c = 5;
            int d = 4;
            bool resultado;


            resultado = a == c;

            Console.WriteLine(resultado);

            resultado = a == b;

            Console.WriteLine(resultado);

            resultado = a == (3 + 2);

            Console.WriteLine(resultado);

            resultado = (b - 2) == d;

            Console.WriteLine(resultado);

            resultado = a != 7;

            Console.WriteLine(resultado);

            resultado = a != c;

            Console.WriteLine(resultado);

            resultado = b > a;

            Console.WriteLine(resultado);

            resultado = (a + 2) <= b;

            Console.WriteLine(resultado);

            resultado = a > b;

            Console.WriteLine(resultado);

            resultado = b > b;

            Console.WriteLine(resultado);

            resultado = d < a;

            Console.WriteLine(resultado);

            resultado = d < (a - 3);

            Console.WriteLine(resultado);

            resultado = d < d;

            Console.WriteLine(resultado);

            resultado = b >= a;

            Console.WriteLine(resultado);

            resultado = b >=  (a + c);

            Console.WriteLine(resultado);

            Console.ReadKey();
 
        }
    }
}
