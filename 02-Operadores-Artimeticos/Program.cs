using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Operadores_Artimeticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Operadores Aritmeticos: Nos permiten ejecutar operaciones matematicas
             * como suma, resta, multiplciacion y division
             *  suma (+)
             *  resta (-)
             *  Multiplicacion (*)
             *  Division (/)
             */

            byte numero1 = 20;
            byte numero2 = 10;

           /* En C#, no puedes hacer la suma de dos byte sin conversión explícita porque el resultado de byte + byte se convierte automáticamente en int. */

            int suma = numero1 + numero2; 

            int resta = numero1 - numero2;

            int multiplicacion = numero1 * numero2;

            int division = numero1 / numero2;

            int residuo = numero1 % numero2;

            // Tambien podemos declarar variables de esta forma si son del mismo tipo de dato

            int numero4, numero5;

            numero4 = 30;
            numero5 = 50;


            Console.WriteLine("La suma de {0} y {1} es igual a = {2}", numero1, numero2, suma);
            Console.WriteLine("La resta de {0} y {1} es igual a = {2}", numero1, numero2, resta);
            Console.WriteLine("La multilicacion de {0} y {1} es igual a = {2}", numero1, numero2, multiplicacion);
            Console.WriteLine("La división de {0} y {1} es igual a = {2}", numero1, numero2, division);
            Console.WriteLine("El residuo de la división de {0} y {1} es igual a = {2}", numero1, numero2, residuo);
            Console.WriteLine("El número es {0}", numero4);
            Console.WriteLine("El número es {0}", numero5);
            Console.ReadLine();

        }
    }
}
