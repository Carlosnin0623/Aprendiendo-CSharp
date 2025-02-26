using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Bidimencional_Suma_de_una_matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             *   Crea un programa que calcule la suma de de los números de una matriz 
             *   predefinidos e imprima el resultado en pantalla.
             */


            int[,] matriz =
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
             };



            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine(matriz[i, j]);
                }
            }

            Console.ReadKey();
        }
    }
}
